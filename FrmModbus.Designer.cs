namespace NModbusTest
{
    partial class FrmModbus
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
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReadRegister = new System.Windows.Forms.Button();
            this.txtReadRegisterValue = new System.Windows.Forms.TextBox();
            this.textReadModbusAddress = new System.Windows.Forms.TextBox();
            this.txtReadModbusCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnWriteRegister = new System.Windows.Forms.Button();
            this.textWriteModbusAddress = new System.Windows.Forms.TextBox();
            this.txtWriteRegisterValue = new System.Windows.Forms.TextBox();
            this.txtWriteModbusAddress = new System.Windows.Forms.Label();
            this.txtWriteModbusValue = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnWriteCoil = new System.Windows.Forms.Button();
            this.textWriteCoilAddress = new System.Windows.Forms.TextBox();
            this.txtWriteCoilValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnReadCoil = new System.Windows.Forms.Button();
            this.txtReadCoilValue = new System.Windows.Forms.TextBox();
            this.textReadCoilAddress = new System.Windows.Forms.TextBox();
            this.txtReadCoilCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTrackNumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtStatusCheck = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(78, 37);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(107, 20);
            this.txtIPAddress.TabIndex = 1;
            this.txtIPAddress.Text = "172.16.1.161";
            this.txtIPAddress.TextChanged += new System.EventHandler(this.txtIPAddress_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReadRegister);
            this.groupBox1.Controls.Add(this.txtReadRegisterValue);
            this.groupBox1.Controls.Add(this.textReadModbusAddress);
            this.groupBox1.Controls.Add(this.txtReadModbusCount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 119);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Read Holding Register";
            // 
            // btnReadRegister
            // 
            this.btnReadRegister.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReadRegister.Location = new System.Drawing.Point(21, 71);
            this.btnReadRegister.Name = "btnReadRegister";
            this.btnReadRegister.Size = new System.Drawing.Size(88, 28);
            this.btnReadRegister.TabIndex = 5;
            this.btnReadRegister.Text = "Read";
            this.btnReadRegister.UseVisualStyleBackColor = false;
            this.btnReadRegister.Click += new System.EventHandler(this.btnReadRegister_Click);
            // 
            // txtReadRegisterValue
            // 
            this.txtReadRegisterValue.Location = new System.Drawing.Point(126, 71);
            this.txtReadRegisterValue.Multiline = true;
            this.txtReadRegisterValue.Name = "txtReadRegisterValue";
            this.txtReadRegisterValue.ReadOnly = true;
            this.txtReadRegisterValue.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReadRegisterValue.Size = new System.Drawing.Size(202, 42);
            this.txtReadRegisterValue.TabIndex = 4;
            this.txtReadRegisterValue.TextChanged += new System.EventHandler(this.txtReadRegisterValue_TextChanged);
            // 
            // textReadModbusAddress
            // 
            this.textReadModbusAddress.Location = new System.Drawing.Point(223, 34);
            this.textReadModbusAddress.Name = "textReadModbusAddress";
            this.textReadModbusAddress.Size = new System.Drawing.Size(104, 20);
            this.textReadModbusAddress.TabIndex = 3;
            this.textReadModbusAddress.Text = "0";
            this.textReadModbusAddress.TextChanged += new System.EventHandler(this.textReadModbusAddress_TextChanged);
            // 
            // txtReadModbusCount
            // 
            this.txtReadModbusCount.Location = new System.Drawing.Point(59, 34);
            this.txtReadModbusCount.Name = "txtReadModbusCount";
            this.txtReadModbusCount.Size = new System.Drawing.Size(111, 20);
            this.txtReadModbusCount.TabIndex = 2;
            this.txtReadModbusCount.Tag = "";
            this.txtReadModbusCount.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Qty";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnWriteRegister);
            this.groupBox2.Controls.Add(this.textWriteModbusAddress);
            this.groupBox2.Controls.Add(this.txtWriteRegisterValue);
            this.groupBox2.Controls.Add(this.txtWriteModbusAddress);
            this.groupBox2.Controls.Add(this.txtWriteModbusValue);
            this.groupBox2.Location = new System.Drawing.Point(373, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 119);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Write Holding Register";
            // 
            // btnWriteRegister
            // 
            this.btnWriteRegister.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnWriteRegister.Location = new System.Drawing.Point(14, 63);
            this.btnWriteRegister.Name = "btnWriteRegister";
            this.btnWriteRegister.Size = new System.Drawing.Size(138, 28);
            this.btnWriteRegister.TabIndex = 11;
            this.btnWriteRegister.Text = "Write";
            this.btnWriteRegister.UseVisualStyleBackColor = false;
            this.btnWriteRegister.Click += new System.EventHandler(this.btnWriteRegister_Click);
            // 
            // textWriteModbusAddress
            // 
            this.textWriteModbusAddress.Location = new System.Drawing.Point(121, 31);
            this.textWriteModbusAddress.Name = "textWriteModbusAddress";
            this.textWriteModbusAddress.Size = new System.Drawing.Size(31, 20);
            this.textWriteModbusAddress.TabIndex = 9;
            this.textWriteModbusAddress.Text = "512";
            this.textWriteModbusAddress.TextChanged += new System.EventHandler(this.textWriteModbusAddress_TextChanged);
            // 
            // txtWriteRegisterValue
            // 
            this.txtWriteRegisterValue.Location = new System.Drawing.Point(52, 31);
            this.txtWriteRegisterValue.Name = "txtWriteRegisterValue";
            this.txtWriteRegisterValue.Size = new System.Drawing.Size(15, 20);
            this.txtWriteRegisterValue.TabIndex = 8;
            this.txtWriteRegisterValue.Text = "1";
            this.txtWriteRegisterValue.TextChanged += new System.EventHandler(this.txtWriteRegisterValue_TextChanged);
            // 
            // txtWriteModbusAddress
            // 
            this.txtWriteModbusAddress.AutoSize = true;
            this.txtWriteModbusAddress.Location = new System.Drawing.Point(73, 34);
            this.txtWriteModbusAddress.Name = "txtWriteModbusAddress";
            this.txtWriteModbusAddress.Size = new System.Drawing.Size(45, 13);
            this.txtWriteModbusAddress.TabIndex = 7;
            this.txtWriteModbusAddress.Text = "Address";
            // 
            // txtWriteModbusValue
            // 
            this.txtWriteModbusValue.AutoSize = true;
            this.txtWriteModbusValue.Location = new System.Drawing.Point(12, 34);
            this.txtWriteModbusValue.Name = "txtWriteModbusValue";
            this.txtWriteModbusValue.Size = new System.Drawing.Size(34, 13);
            this.txtWriteModbusValue.TabIndex = 6;
            this.txtWriteModbusValue.Text = "Value";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnWriteCoil);
            this.groupBox3.Controls.Add(this.textWriteCoilAddress);
            this.groupBox3.Controls.Add(this.txtWriteCoilValue);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(373, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 119);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Write Coil";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnWriteCoil
            // 
            this.btnWriteCoil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnWriteCoil.Location = new System.Drawing.Point(15, 63);
            this.btnWriteCoil.Name = "btnWriteCoil";
            this.btnWriteCoil.Size = new System.Drawing.Size(137, 28);
            this.btnWriteCoil.TabIndex = 11;
            this.btnWriteCoil.Text = "Write";
            this.btnWriteCoil.UseVisualStyleBackColor = false;
            this.btnWriteCoil.Click += new System.EventHandler(this.btnWriteCoil_Click);
            // 
            // textWriteCoilAddress
            // 
            this.textWriteCoilAddress.Location = new System.Drawing.Point(121, 28);
            this.textWriteCoilAddress.Name = "textWriteCoilAddress";
            this.textWriteCoilAddress.Size = new System.Drawing.Size(31, 20);
            this.textWriteCoilAddress.TabIndex = 9;
            this.textWriteCoilAddress.Text = "512";
            this.textWriteCoilAddress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtWriteCoilValue
            // 
            this.txtWriteCoilValue.Location = new System.Drawing.Point(49, 31);
            this.txtWriteCoilValue.Name = "txtWriteCoilValue";
            this.txtWriteCoilValue.Size = new System.Drawing.Size(18, 20);
            this.txtWriteCoilValue.TabIndex = 8;
            this.txtWriteCoilValue.Text = "1";
            this.txtWriteCoilValue.TextChanged += new System.EventHandler(this.txtWriteCoilValue_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Value";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnReadCoil);
            this.groupBox4.Controls.Add(this.txtReadCoilValue);
            this.groupBox4.Controls.Add(this.textReadCoilAddress);
            this.groupBox4.Controls.Add(this.txtReadCoilCount);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(15, 188);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(342, 119);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Read Coil";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btnReadCoil
            // 
            this.btnReadCoil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReadCoil.Location = new System.Drawing.Point(18, 71);
            this.btnReadCoil.Name = "btnReadCoil";
            this.btnReadCoil.Size = new System.Drawing.Size(88, 28);
            this.btnReadCoil.TabIndex = 5;
            this.btnReadCoil.Text = "Read";
            this.btnReadCoil.UseVisualStyleBackColor = false;
            this.btnReadCoil.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtReadCoilValue
            // 
            this.txtReadCoilValue.Location = new System.Drawing.Point(126, 71);
            this.txtReadCoilValue.Multiline = true;
            this.txtReadCoilValue.Name = "txtReadCoilValue";
            this.txtReadCoilValue.ReadOnly = true;
            this.txtReadCoilValue.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReadCoilValue.Size = new System.Drawing.Size(202, 41);
            this.txtReadCoilValue.TabIndex = 4;
            this.txtReadCoilValue.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textReadCoilAddress
            // 
            this.textReadCoilAddress.Location = new System.Drawing.Point(224, 34);
            this.textReadCoilAddress.Name = "textReadCoilAddress";
            this.textReadCoilAddress.Size = new System.Drawing.Size(104, 20);
            this.textReadCoilAddress.TabIndex = 3;
            this.textReadCoilAddress.Text = "0";
            // 
            // txtReadCoilCount
            // 
            this.txtReadCoilCount.Location = new System.Drawing.Point(56, 34);
            this.txtReadCoilCount.Name = "txtReadCoilCount";
            this.txtReadCoilCount.Size = new System.Drawing.Size(111, 20);
            this.txtReadCoilCount.TabIndex = 2;
            this.txtReadCoilCount.Text = "1";
            this.txtReadCoilCount.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Address";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Qty";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtStatusCheck);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.txtTrackNumber);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(539, 63);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(162, 70);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Status Check";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Track Number";
            // 
            // txtTrackNumber
            // 
            this.txtTrackNumber.Location = new System.Drawing.Point(87, 13);
            this.txtTrackNumber.Name = "txtTrackNumber";
            this.txtTrackNumber.Size = new System.Drawing.Size(17, 20);
            this.txtTrackNumber.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(9, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtStatusCheck
            // 
            this.txtStatusCheck.Location = new System.Drawing.Point(87, 43);
            this.txtStatusCheck.Name = "txtStatusCheck";
            this.txtStatusCheck.ReadOnly = true;
            this.txtStatusCheck.Size = new System.Drawing.Size(37, 20);
            this.txtStatusCheck.TabIndex = 3;
            // 
            // FrmModbus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(744, 327);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.label1);
            this.Name = "FrmModbus";
            this.Text = "GTCS Simulator";
            this.Load += new System.EventHandler(this.FrmModbus_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReadRegister;
        private System.Windows.Forms.TextBox txtReadRegisterValue;
        private System.Windows.Forms.TextBox textReadModbusAddress;
        private System.Windows.Forms.TextBox txtReadModbusCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnWriteRegister;
        private System.Windows.Forms.TextBox textWriteModbusAddress;
        private System.Windows.Forms.TextBox txtWriteRegisterValue;
        private System.Windows.Forms.Label txtWriteModbusAddress;
        private System.Windows.Forms.Label txtWriteModbusValue;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnWriteCoil;
        private System.Windows.Forms.TextBox textWriteCoilAddress;
        private System.Windows.Forms.TextBox txtWriteCoilValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnReadCoil;
        private System.Windows.Forms.TextBox txtReadCoilValue;
        private System.Windows.Forms.TextBox textReadCoilAddress;
        private System.Windows.Forms.TextBox txtReadCoilCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtTrackNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStatusCheck;
        private System.Windows.Forms.Button button1;
    }
}

