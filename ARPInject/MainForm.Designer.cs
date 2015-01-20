namespace ARPReply
{
    partial class ArpReplyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nextHopMacCombo = new System.Windows.Forms.ComboBox();
            this.sendersIPCombo = new System.Windows.Forms.ComboBox();
            this.arpInjectButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.myMacCombo = new System.Windows.Forms.ComboBox();
            this.myIPCombo = new System.Windows.Forms.ComboBox();
            this.packetsCountCombo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nextHopMacCombo
            // 
            this.nextHopMacCombo.FormattingEnabled = true;
            this.nextHopMacCombo.Items.AddRange(new object[] {
            "6c:50:4d:81:ab:c4"});
            this.nextHopMacCombo.Location = new System.Drawing.Point(359, 89);
            this.nextHopMacCombo.Name = "nextHopMacCombo";
            this.nextHopMacCombo.Size = new System.Drawing.Size(182, 21);
            this.nextHopMacCombo.TabIndex = 0;
            this.nextHopMacCombo.Text = "6c:50:4d:81:ab:c4";
            // 
            // sendersIPCombo
            // 
            this.sendersIPCombo.FormattingEnabled = true;
            this.sendersIPCombo.Items.AddRange(new object[] {
            "10.224.0.1"});
            this.sendersIPCombo.Location = new System.Drawing.Point(359, 148);
            this.sendersIPCombo.Name = "sendersIPCombo";
            this.sendersIPCombo.Size = new System.Drawing.Size(182, 21);
            this.sendersIPCombo.TabIndex = 3;
            this.sendersIPCombo.Text = "10.224.0.1";
            // 
            // arpInjectButton
            // 
            this.arpInjectButton.Location = new System.Drawing.Point(359, 204);
            this.arpInjectButton.Name = "arpInjectButton";
            this.arpInjectButton.Size = new System.Drawing.Size(182, 23);
            this.arpInjectButton.TabIndex = 5;
            this.arpInjectButton.Text = "Start";
            this.arpInjectButton.UseVisualStyleBackColor = true;
            this.arpInjectButton.Click += new System.EventHandler(this.arpInjectButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sender\'s MAC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sender\'s IP";
            // 
            // myMacCombo
            // 
            this.myMacCombo.FormattingEnabled = true;
            this.myMacCombo.Items.AddRange(new object[] {
            "10:78:d2:95:84:56"});
            this.myMacCombo.Location = new System.Drawing.Point(45, 89);
            this.myMacCombo.Name = "myMacCombo";
            this.myMacCombo.Size = new System.Drawing.Size(233, 21);
            this.myMacCombo.TabIndex = 1;
            this.myMacCombo.Text = "10:78:d2:95:84:56";
            // 
            // myIPCombo
            // 
            this.myIPCombo.FormattingEnabled = true;
            this.myIPCombo.Items.AddRange(new object[] {
            "192.168.17.51"});
            this.myIPCombo.Location = new System.Drawing.Point(45, 148);
            this.myIPCombo.Name = "myIPCombo";
            this.myIPCombo.Size = new System.Drawing.Size(233, 21);
            this.myIPCombo.TabIndex = 2;
            this.myIPCombo.Text = "192.168.17.51";
            // 
            // packetsCountCombo
            // 
            this.packetsCountCombo.Location = new System.Drawing.Point(45, 204);
            this.packetsCountCombo.Name = "packetsCountCombo";
            this.packetsCountCombo.Size = new System.Drawing.Size(100, 20);
            this.packetsCountCombo.TabIndex = 4;
            this.packetsCountCombo.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "My MAC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "My IP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "No of ARP replies to send";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(434, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "The Sender\'s IP is the one who\'s MAC was asked for (in a prior ARP Request, for e" +
    "xample)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "ARP Reply packets will be sent to My MAC. ";
            // 
            // ArpReplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 325);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arpInjectButton);
            this.Controls.Add(this.packetsCountCombo);
            this.Controls.Add(this.sendersIPCombo);
            this.Controls.Add(this.myIPCombo);
            this.Controls.Add(this.myMacCombo);
            this.Controls.Add(this.nextHopMacCombo);
            this.Name = "ArpReplyForm";
            this.Text = "ArpReply";
            this.Load += new System.EventHandler(this.ArpReplyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox nextHopMacCombo;
        private System.Windows.Forms.ComboBox sendersIPCombo;
        private System.Windows.Forms.Button arpInjectButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox myMacCombo;
        private System.Windows.Forms.ComboBox myIPCombo;
        private System.Windows.Forms.TextBox packetsCountCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}