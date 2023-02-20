namespace Otopark_Otomasyon
{
    partial class FormMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCarEntry = new System.Windows.Forms.TabPage();
            this.groupBoxCarEntry = new System.Windows.Forms.GroupBox();
            this.comboBoxCarType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCarEntry = new System.Windows.Forms.Button();
            this.maskedTextBoxDate = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.textBoxEntryPlate = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.tabPageCarExit = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCarExit = new System.Windows.Forms.Button();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxCarExitPlate = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPageCarEntry.SuspendLayout();
            this.groupBoxCarEntry.SuspendLayout();
            this.tabPageCarExit.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCarEntry);
            this.tabControl1.Controls.Add(this.tabPageCarExit);
            this.tabControl1.Location = new System.Drawing.Point(26, 36);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(612, 277);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageCarEntry
            // 
            this.tabPageCarEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.tabPageCarEntry.Controls.Add(this.groupBoxCarEntry);
            this.tabPageCarEntry.Location = new System.Drawing.Point(4, 27);
            this.tabPageCarEntry.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCarEntry.Name = "tabPageCarEntry";
            this.tabPageCarEntry.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCarEntry.Size = new System.Drawing.Size(604, 246);
            this.tabPageCarEntry.TabIndex = 0;
            this.tabPageCarEntry.Text = "Araç Giriş";
            // 
            // groupBoxCarEntry
            // 
            this.groupBoxCarEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.groupBoxCarEntry.Controls.Add(this.comboBoxCarType);
            this.groupBoxCarEntry.Controls.Add(this.label5);
            this.groupBoxCarEntry.Controls.Add(this.label4);
            this.groupBoxCarEntry.Controls.Add(this.label3);
            this.groupBoxCarEntry.Controls.Add(this.label2);
            this.groupBoxCarEntry.Controls.Add(this.label1);
            this.groupBoxCarEntry.Controls.Add(this.buttonCarEntry);
            this.groupBoxCarEntry.Controls.Add(this.maskedTextBoxDate);
            this.groupBoxCarEntry.Controls.Add(this.maskedTextBoxTel);
            this.groupBoxCarEntry.Controls.Add(this.textBoxEntryPlate);
            this.groupBoxCarEntry.Controls.Add(this.textBoxName);
            this.groupBoxCarEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxCarEntry.ForeColor = System.Drawing.Color.Green;
            this.groupBoxCarEntry.Location = new System.Drawing.Point(17, 18);
            this.groupBoxCarEntry.Name = "groupBoxCarEntry";
            this.groupBoxCarEntry.Size = new System.Drawing.Size(569, 206);
            this.groupBoxCarEntry.TabIndex = 0;
            this.groupBoxCarEntry.TabStop = false;
            // 
            // comboBoxCarType
            // 
            this.comboBoxCarType.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBoxCarType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxCarType.ForeColor = System.Drawing.Color.White;
            this.comboBoxCarType.FormattingEnabled = true;
            this.comboBoxCarType.Items.AddRange(new object[] {
            "Otomobil",
            "Motosiklet",
            "Kamyon"});
            this.comboBoxCarType.Location = new System.Drawing.Point(387, 87);
            this.comboBoxCarType.Name = "comboBoxCarType";
            this.comboBoxCarType.Size = new System.Drawing.Size(121, 26);
            this.comboBoxCarType.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(251, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Araç Giriş Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(299, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Araç Tipi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(59, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(319, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Plaka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ad Soyad:";
            // 
            // buttonCarEntry
            // 
            this.buttonCarEntry.BackColor = System.Drawing.Color.Green;
            this.buttonCarEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCarEntry.ForeColor = System.Drawing.Color.Black;
            this.buttonCarEntry.Location = new System.Drawing.Point(108, 118);
            this.buttonCarEntry.Name = "buttonCarEntry";
            this.buttonCarEntry.Size = new System.Drawing.Size(116, 31);
            this.buttonCarEntry.TabIndex = 5;
            this.buttonCarEntry.Text = "Araç Giriş";
            this.buttonCarEntry.UseVisualStyleBackColor = false;
            this.buttonCarEntry.Click += new System.EventHandler(this.buttonCarEntry_Click);
            // 
            // maskedTextBoxDate
            // 
            this.maskedTextBoxDate.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.maskedTextBoxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxDate.ForeColor = System.Drawing.Color.White;
            this.maskedTextBoxDate.Location = new System.Drawing.Point(387, 125);
            this.maskedTextBoxDate.Mask = "00/00/0000 90:00";
            this.maskedTextBoxDate.Name = "maskedTextBoxDate";
            this.maskedTextBoxDate.Size = new System.Drawing.Size(122, 24);
            this.maskedTextBoxDate.TabIndex = 4;
            this.maskedTextBoxDate.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxTel
            // 
            this.maskedTextBoxTel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.maskedTextBoxTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxTel.ForeColor = System.Drawing.Color.White;
            this.maskedTextBoxTel.Location = new System.Drawing.Point(108, 85);
            this.maskedTextBoxTel.Mask = "(999) 000-0000";
            this.maskedTextBoxTel.Name = "maskedTextBoxTel";
            this.maskedTextBoxTel.Size = new System.Drawing.Size(116, 24);
            this.maskedTextBoxTel.TabIndex = 1;
            // 
            // textBoxEntryPlate
            // 
            this.textBoxEntryPlate.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxEntryPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxEntryPlate.ForeColor = System.Drawing.Color.White;
            this.textBoxEntryPlate.Location = new System.Drawing.Point(387, 51);
            this.textBoxEntryPlate.Name = "textBoxEntryPlate";
            this.textBoxEntryPlate.Size = new System.Drawing.Size(122, 24);
            this.textBoxEntryPlate.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxName.ForeColor = System.Drawing.Color.White;
            this.textBoxName.Location = new System.Drawing.Point(108, 51);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(116, 24);
            this.textBoxName.TabIndex = 0;
            // 
            // tabPageCarExit
            // 
            this.tabPageCarExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.tabPageCarExit.Controls.Add(this.groupBox1);
            this.tabPageCarExit.Location = new System.Drawing.Point(4, 27);
            this.tabPageCarExit.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCarExit.Name = "tabPageCarExit";
            this.tabPageCarExit.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCarExit.Size = new System.Drawing.Size(604, 246);
            this.tabPageCarExit.TabIndex = 1;
            this.tabPageCarExit.Text = "Araç Çıkış";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.buttonCarExit);
            this.groupBox1.Controls.Add(this.textBoxTotal);
            this.groupBox1.Controls.Add(this.textBoxCarExitPlate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(17, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(67, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ücret:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(67, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Plaka:";
            // 
            // buttonCarExit
            // 
            this.buttonCarExit.BackColor = System.Drawing.Color.Red;
            this.buttonCarExit.ForeColor = System.Drawing.Color.Black;
            this.buttonCarExit.Location = new System.Drawing.Point(322, 70);
            this.buttonCarExit.Name = "buttonCarExit";
            this.buttonCarExit.Size = new System.Drawing.Size(106, 52);
            this.buttonCarExit.TabIndex = 2;
            this.buttonCarExit.Text = "Araç Çıkış";
            this.buttonCarExit.UseVisualStyleBackColor = false;
            this.buttonCarExit.Click += new System.EventHandler(this.buttonCarExit_Click);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTotal.ForeColor = System.Drawing.Color.White;
            this.textBoxTotal.Location = new System.Drawing.Point(139, 101);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(122, 24);
            this.textBoxTotal.TabIndex = 1;
            // 
            // textBoxCarExitPlate
            // 
            this.textBoxCarExitPlate.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxCarExitPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxCarExitPlate.ForeColor = System.Drawing.Color.White;
            this.textBoxCarExitPlate.Location = new System.Drawing.Point(139, 70);
            this.textBoxCarExitPlate.Name = "textBoxCarExitPlate";
            this.textBoxCarExitPlate.Size = new System.Drawing.Size(122, 24);
            this.textBoxCarExitPlate.TabIndex = 0;
            this.textBoxCarExitPlate.TextChanged += new System.EventHandler(this.textBoxCarExitPlate_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışYapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(671, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(671, 343);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.tabControl1.ResumeLayout(false);
            this.tabPageCarEntry.ResumeLayout(false);
            this.groupBoxCarEntry.ResumeLayout(false);
            this.groupBoxCarEntry.PerformLayout();
            this.tabPageCarExit.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCarEntry;
        private System.Windows.Forms.GroupBox groupBoxCarEntry;
        private System.Windows.Forms.TabPage tabPageCarExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCarEntry;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDate;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTel;
        private System.Windows.Forms.TextBox textBoxEntryPlate;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCarExit;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxCarExitPlate;
        private System.Windows.Forms.ComboBox comboBoxCarType;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
    }
}