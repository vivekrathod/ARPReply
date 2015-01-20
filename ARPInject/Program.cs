using PcapDotNet.Core;
using PcapDotNet.Packets.Ethernet;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using PcapDotNet.Packets;
using PcapDotNet.Packets.Arp;
using System.Threading;
using System.Windows.Forms;
using System.Globalization;

namespace ARPReply
{
    /// <summary>
    /// Generates fake ARP replies using the Pcap.Net library.
    /// </summary>
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ArpReplyForm());
        }
        
        public static void Start(string[] args)
        {
            // Retrieve the device list from the local machine
            IList<LivePacketDevice> allDevices = LivePacketDevice.AllLocalMachine;

            if (allDevices.Count == 0)
            {
                throw new Exception("No interfaces found! Make sure WinPcap is installed.");
            }

            // Print the list
            for (int i = 0; i != allDevices.Count; ++i)
            {
                LivePacketDevice device = allDevices[i];
                Console.Write((i + 1) + ". " + device.Name);
                if (device.Description != null)
                    Console.WriteLine(" (" + device.Description + ")");
                else
                    Console.WriteLine(" (No description available)");
            }

            // choose any adapter that is no Loopback
            LivePacketDevice selectedDevice = allDevices.Where(e => e.Attributes != DeviceAttributes.Loopback).First();

            // Open the output device
            using (PacketCommunicator communicator = selectedDevice.Open(100, // name of the device
                                                                         PacketDeviceOpenAttributes.Promiscuous, // promiscuous mode
                                                                         1000)) // read timeout
            {
                int packetsCount = Convert.ToInt32(args[4]);
                for (int i = 0; i < packetsCount; i++)
                {
                    communicator.SendPacket(BuildArpPacket(args[0], args[1], args[2], args[3], i));
                    Thread.Sleep(10);
                }
            }
        }

        private static Packet BuildArpPacket(string myMac, string myIP, string nextHopMac, string sendersIP, int i)
        {
            EthernetLayer ethernetLayer =
                new EthernetLayer
                {
                    Source = new MacAddress(nextHopMac), // mac address of next hop on way to senders IP
                    Destination = new MacAddress(myMac), // my mac address
                    EtherType = EthernetType.None, // Will be filled automatically.
                };
            byte[] myMacByteArray = myMac.Split(':').Select(e=>HexToByte(e)).ToArray();
            byte[] nextHopMacByteArray = nextHopMac.Split(':').Select(e=>HexToByte(e)).ToArray();
            byte[] sendersIPByteArray = sendersIP.Split('.').Select(e => byte.Parse(e)).ToArray();
            byte[] myIPByteArray = myIP.Split('.').Select(e => byte.Parse(e)).ToArray();
            ArpLayer arpLayer =
                new ArpLayer
                {
                    ProtocolType = EthernetType.IpV4,
                    Operation = ArpOperation.Reply,

                    SenderHardwareAddress = Array.AsReadOnly(nextHopMacByteArray), // mac address of next hop on way to reach the senders IP
                    SenderProtocolAddress = Array.AsReadOnly(sendersIPByteArray), // IP of the sender
                    TargetHardwareAddress = Array.AsReadOnly(myMacByteArray), // my mac address
                    TargetProtocolAddress = Array.AsReadOnly(myIPByteArray) // my ip
                };

            PacketBuilder builder = new PacketBuilder(ethernetLayer, arpLayer);

            return builder.Build(DateTime.Now);
        }

        private static byte HexToByte(string hex)
        {
            return byte.Parse(hex, NumberStyles.HexNumber);
        }
    }
}
