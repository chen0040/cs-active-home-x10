namespace ActiveHomeX10
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLampAddress = new System.Windows.Forms.TextBox();
            this.btnTurnOnLamp = new System.Windows.Forms.Button();
            this.btnTurnOffLamp = new System.Windows.Forms.Button();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.rdoPLC = new System.Windows.Forms.RadioButton();
            this.rdoRF = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCheckStatus = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lamp Address:";
            // 
            // txtLampAddress
            // 
            this.txtLampAddress.Location = new System.Drawing.Point(95, 15);
            this.txtLampAddress.Name = "txtLampAddress";
            this.txtLampAddress.Size = new System.Drawing.Size(100, 20);
            this.txtLampAddress.TabIndex = 1;
            this.txtLampAddress.Text = "A1";
            // 
            // btnTurnOnLamp
            // 
            this.btnTurnOnLamp.Location = new System.Drawing.Point(213, 15);
            this.btnTurnOnLamp.Name = "btnTurnOnLamp";
            this.btnTurnOnLamp.Size = new System.Drawing.Size(75, 23);
            this.btnTurnOnLamp.TabIndex = 2;
            this.btnTurnOnLamp.Text = "ON";
            this.btnTurnOnLamp.UseVisualStyleBackColor = true;
            this.btnTurnOnLamp.Click += new System.EventHandler(this.btnTurnOnLamp_Click);
            // 
            // btnTurnOffLamp
            // 
            this.btnTurnOffLamp.Location = new System.Drawing.Point(294, 15);
            this.btnTurnOffLamp.Name = "btnTurnOffLamp";
            this.btnTurnOffLamp.Size = new System.Drawing.Size(75, 23);
            this.btnTurnOffLamp.TabIndex = 2;
            this.btnTurnOffLamp.Text = "OFF";
            this.btnTurnOffLamp.UseVisualStyleBackColor = true;
            this.btnTurnOffLamp.Click += new System.EventHandler(this.btnTurnOffLamp_Click);
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Location = new System.Drawing.Point(15, 233);
            this.StatusTextBox.Multiline = true;
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StatusTextBox.Size = new System.Drawing.Size(562, 79);
            this.StatusTextBox.TabIndex = 3;
            // 
            // rdoPLC
            // 
            this.rdoPLC.AutoSize = true;
            this.rdoPLC.Checked = true;
            this.rdoPLC.Location = new System.Drawing.Point(19, 31);
            this.rdoPLC.Name = "rdoPLC";
            this.rdoPLC.Size = new System.Drawing.Size(96, 17);
            this.rdoPLC.TabIndex = 4;
            this.rdoPLC.TabStop = true;
            this.rdoPLC.Text = "Via Power Line";
            this.rdoPLC.UseVisualStyleBackColor = true;
            // 
            // rdoRF
            // 
            this.rdoRF.AutoSize = true;
            this.rdoRF.Location = new System.Drawing.Point(19, 54);
            this.rdoRF.Name = "rdoRF";
            this.rdoRF.Size = new System.Drawing.Size(124, 17);
            this.rdoRF.TabIndex = 4;
            this.rdoRF.Text = "Via Radio Frequency";
            this.rdoRF.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoPLC);
            this.groupBox1.Controls.Add(this.rdoRF);
            this.groupBox1.Location = new System.Drawing.Point(15, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Channel";
            // 
            // btnCheckStatus
            // 
            this.btnCheckStatus.Location = new System.Drawing.Point(15, 195);
            this.btnCheckStatus.Name = "btnCheckStatus";
            this.btnCheckStatus.Size = new System.Drawing.Size(75, 23);
            this.btnCheckStatus.TabIndex = 2;
            this.btnCheckStatus.Text = "Check Status";
            this.btnCheckStatus.UseVisualStyleBackColor = true;
            this.btnCheckStatus.Click += new System.EventHandler(this.btnCheckStatus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 324);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(this.btnTurnOffLamp);
            this.Controls.Add(this.btnCheckStatus);
            this.Controls.Add(this.btnTurnOnLamp);
            this.Controls.Add(this.txtLampAddress);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLampAddress;
        private System.Windows.Forms.Button btnTurnOnLamp;
        private System.Windows.Forms.Button btnTurnOffLamp;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.RadioButton rdoPLC;
        private System.Windows.Forms.RadioButton rdoRF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCheckStatus;
    }
}

