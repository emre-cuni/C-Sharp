namespace MessageSender
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxIP = new MetroSet_UI.Controls.MetroSetTextBox();
            this.textBoxPort = new MetroSet_UI.Controls.MetroSetTextBox();
            this.textBoxMessage = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroGridSend = new MetroFramework.Controls.MetroGrid();
            this.buttonSend = new MetroSet_UI.Controls.MetroSetButton();
            this.buttonSave = new MetroSet_UI.Controls.MetroSetButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelPort = new MetroSet_UI.Controls.MetroSetLabel();
            this.textBoxName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.labelIP = new MetroSet_UI.Controls.MetroSetLabel();
            this.labelMessage = new MetroSet_UI.Controls.MetroSetLabel();
            this.labelName = new MetroSet_UI.Controls.MetroSetLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ColumnSend = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnToAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnToPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridSend)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxIP
            // 
            this.textBoxIP.AutoCompleteCustomSource = null;
            this.textBoxIP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxIP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxIP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.textBoxIP.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textBoxIP.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.textBoxIP.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.textBoxIP.Font = new System.Drawing.Font("Consolas", 11F);
            this.textBoxIP.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.textBoxIP.Image = null;
            this.textBoxIP.IsDerivedStyle = true;
            this.textBoxIP.Lines = null;
            this.textBoxIP.Location = new System.Drawing.Point(403, 33);
            this.textBoxIP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIP.MaxLength = 32767;
            this.textBoxIP.Multiline = false;
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.ReadOnly = false;
            this.textBoxIP.Size = new System.Drawing.Size(311, 26);
            this.textBoxIP.Style = MetroSet_UI.Enums.Style.Light;
            this.textBoxIP.StyleManager = null;
            this.textBoxIP.TabIndex = 1;
            this.textBoxIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxIP.ThemeAuthor = "Narwin";
            this.textBoxIP.ThemeName = "MetroLite";
            this.textBoxIP.UseSystemPasswordChar = false;
            this.textBoxIP.WatermarkText = "";
            // 
            // textBoxPort
            // 
            this.textBoxPort.AutoCompleteCustomSource = null;
            this.textBoxPort.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxPort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxPort.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.textBoxPort.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textBoxPort.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.textBoxPort.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.textBoxPort.Font = new System.Drawing.Font("Consolas", 11F);
            this.textBoxPort.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.textBoxPort.Image = null;
            this.textBoxPort.IsDerivedStyle = true;
            this.textBoxPort.Lines = null;
            this.textBoxPort.Location = new System.Drawing.Point(807, 33);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPort.MaxLength = 32767;
            this.textBoxPort.Multiline = false;
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.ReadOnly = false;
            this.textBoxPort.Size = new System.Drawing.Size(178, 26);
            this.textBoxPort.Style = MetroSet_UI.Enums.Style.Light;
            this.textBoxPort.StyleManager = null;
            this.textBoxPort.TabIndex = 2;
            this.textBoxPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxPort.ThemeAuthor = "Narwin";
            this.textBoxPort.ThemeName = "MetroLite";
            this.textBoxPort.UseSystemPasswordChar = false;
            this.textBoxPort.WatermarkText = "";
            this.textBoxPort.TextChanged += new System.EventHandler(this.textBoxPort_TextChanged);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.AutoCompleteCustomSource = null;
            this.textBoxMessage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxMessage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxMessage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.textBoxMessage.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textBoxMessage.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.textBoxMessage.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.textBoxMessage.Font = new System.Drawing.Font("Consolas", 11F);
            this.textBoxMessage.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.textBoxMessage.Image = null;
            this.textBoxMessage.IsDerivedStyle = true;
            this.textBoxMessage.Lines = null;
            this.textBoxMessage.Location = new System.Drawing.Point(113, 80);
            this.textBoxMessage.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMessage.MaxLength = 32767;
            this.textBoxMessage.Multiline = false;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.ReadOnly = false;
            this.textBoxMessage.Size = new System.Drawing.Size(1109, 26);
            this.textBoxMessage.Style = MetroSet_UI.Enums.Style.Light;
            this.textBoxMessage.StyleManager = null;
            this.textBoxMessage.TabIndex = 3;
            this.textBoxMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxMessage.ThemeAuthor = "Narwin";
            this.textBoxMessage.ThemeName = "MetroLite";
            this.textBoxMessage.UseSystemPasswordChar = false;
            this.textBoxMessage.WatermarkText = "";
            // 
            // metroGridSend
            // 
            this.metroGridSend.AllowUserToAddRows = false;
            this.metroGridSend.AllowUserToResizeRows = false;
            this.metroGridSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGridSend.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.metroGridSend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridSend.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridSend.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Consolas", 11F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridSend.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.metroGridSend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridSend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSend,
            this.ColumnName,
            this.ColumnToAddress,
            this.ColumnToPort,
            this.ColumnMessage});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Consolas", 11F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridSend.DefaultCellStyle = dataGridViewCellStyle8;
            this.metroGridSend.EnableHeadersVisualStyles = false;
            this.metroGridSend.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridSend.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.metroGridSend.Location = new System.Drawing.Point(12, 25);
            this.metroGridSend.Margin = new System.Windows.Forms.Padding(4);
            this.metroGridSend.Name = "metroGridSend";
            this.metroGridSend.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Consolas", 11F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridSend.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.metroGridSend.RowHeadersVisible = false;
            this.metroGridSend.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridSend.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridSend.Size = new System.Drawing.Size(1216, 247);
            this.metroGridSend.TabIndex = 4;
            this.metroGridSend.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridSend_CellContentClick);
            // 
            // buttonSend
            // 
            this.buttonSend.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.buttonSend.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.buttonSend.DisabledForeColor = System.Drawing.Color.Gray;
            this.buttonSend.Font = new System.Drawing.Font("Consolas", 11F);
            this.buttonSend.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.buttonSend.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.buttonSend.HoverTextColor = System.Drawing.Color.White;
            this.buttonSend.IsDerivedStyle = true;
            this.buttonSend.Location = new System.Drawing.Point(1008, 33);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.buttonSend.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.buttonSend.NormalTextColor = System.Drawing.Color.White;
            this.buttonSend.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.buttonSend.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.buttonSend.PressTextColor = System.Drawing.Color.White;
            this.buttonSend.Size = new System.Drawing.Size(89, 26);
            this.buttonSend.Style = MetroSet_UI.Enums.Style.Dark;
            this.buttonSend.StyleManager = null;
            this.buttonSend.TabIndex = 4;
            this.buttonSend.Text = "Gönder";
            this.buttonSend.ThemeAuthor = "Narwin";
            this.buttonSend.ThemeName = "MetroDark";
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.buttonSave.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.buttonSave.DisabledForeColor = System.Drawing.Color.Gray;
            this.buttonSave.Font = new System.Drawing.Font("Consolas", 11F);
            this.buttonSave.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.buttonSave.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.buttonSave.HoverTextColor = System.Drawing.Color.White;
            this.buttonSave.IsDerivedStyle = true;
            this.buttonSave.Location = new System.Drawing.Point(1133, 33);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.buttonSave.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.buttonSave.NormalTextColor = System.Drawing.Color.White;
            this.buttonSave.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.buttonSave.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.buttonSave.PressTextColor = System.Drawing.Color.White;
            this.buttonSave.Size = new System.Drawing.Size(89, 26);
            this.buttonSave.Style = MetroSet_UI.Enums.Style.Dark;
            this.buttonSave.StyleManager = null;
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Kaydet";
            this.buttonSave.ThemeAuthor = "Narwin";
            this.buttonSave.ThemeName = "MetroDark";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.groupBox1.Controls.Add(this.labelPort);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.buttonSend);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.textBoxMessage);
            this.groupBox1.Controls.Add(this.labelIP);
            this.groupBox1.Controls.Add(this.textBoxIP);
            this.groupBox1.Controls.Add(this.labelMessage);
            this.groupBox1.Controls.Add(this.textBoxPort);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 11F);
            this.groupBox1.Location = new System.Drawing.Point(16, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1234, 130);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // labelPort
            // 
            this.labelPort.Font = new System.Drawing.Font("Consolas", 11F);
            this.labelPort.IsDerivedStyle = true;
            this.labelPort.Location = new System.Drawing.Point(746, 36);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(54, 23);
            this.labelPort.Style = MetroSet_UI.Enums.Style.Light;
            this.labelPort.StyleManager = null;
            this.labelPort.TabIndex = 10;
            this.labelPort.Text = "Port";
            this.labelPort.ThemeAuthor = "Narwin";
            this.labelPort.ThemeName = "MetroLite";
            // 
            // textBoxName
            // 
            this.textBoxName.AutoCompleteCustomSource = null;
            this.textBoxName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.textBoxName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textBoxName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.textBoxName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.textBoxName.Font = new System.Drawing.Font("Consolas", 11F);
            this.textBoxName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.textBoxName.Image = null;
            this.textBoxName.IsDerivedStyle = true;
            this.textBoxName.Lines = null;
            this.textBoxName.Location = new System.Drawing.Point(113, 33);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.MaxLength = 32767;
            this.textBoxName.Multiline = false;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = false;
            this.textBoxName.Size = new System.Drawing.Size(213, 26);
            this.textBoxName.Style = MetroSet_UI.Enums.Style.Light;
            this.textBoxName.StyleManager = null;
            this.textBoxName.TabIndex = 0;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxName.ThemeAuthor = "Narwin";
            this.textBoxName.ThemeName = "MetroLite";
            this.textBoxName.UseSystemPasswordChar = false;
            this.textBoxName.WatermarkText = "";
            // 
            // labelIP
            // 
            this.labelIP.Font = new System.Drawing.Font("Consolas", 11F);
            this.labelIP.IsDerivedStyle = true;
            this.labelIP.Location = new System.Drawing.Point(360, 36);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(36, 23);
            this.labelIP.Style = MetroSet_UI.Enums.Style.Dark;
            this.labelIP.StyleManager = null;
            this.labelIP.TabIndex = 9;
            this.labelIP.Text = "IP";
            this.labelIP.ThemeAuthor = "Narwin";
            this.labelIP.ThemeName = "MetroDark";
            // 
            // labelMessage
            // 
            this.labelMessage.Font = new System.Drawing.Font("Consolas", 11F);
            this.labelMessage.IsDerivedStyle = true;
            this.labelMessage.Location = new System.Drawing.Point(26, 83);
            this.labelMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(79, 23);
            this.labelMessage.Style = MetroSet_UI.Enums.Style.Dark;
            this.labelMessage.StyleManager = null;
            this.labelMessage.TabIndex = 8;
            this.labelMessage.Text = "Mesaj";
            this.labelMessage.ThemeAuthor = "Narwin";
            this.labelMessage.ThemeName = "MetroDark";
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Consolas", 11F);
            this.labelName.IsDerivedStyle = true;
            this.labelName.Location = new System.Drawing.Point(26, 36);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(79, 23);
            this.labelName.Style = MetroSet_UI.Enums.Style.Dark;
            this.labelName.StyleManager = null;
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Ad";
            this.labelName.ThemeAuthor = "Narwin";
            this.labelName.ThemeName = "MetroDark";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.metroGridSend);
            this.groupBox2.Location = new System.Drawing.Point(15, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1237, 285);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // ColumnSend
            // 
            this.ColumnSend.HeaderText = "Send";
            this.ColumnSend.Name = "ColumnSend";
            this.ColumnSend.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnSend.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 150;
            // 
            // ColumnToAddress
            // 
            this.ColumnToAddress.HeaderText = "To Address";
            this.ColumnToAddress.Name = "ColumnToAddress";
            this.ColumnToAddress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnToAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnToAddress.Width = 150;
            // 
            // ColumnToPort
            // 
            this.ColumnToPort.HeaderText = "To Port";
            this.ColumnToPort.Name = "ColumnToPort";
            // 
            // ColumnMessage
            // 
            this.ColumnMessage.HeaderText = "Message";
            this.ColumnMessage.Name = "ColumnMessage";
            this.ColumnMessage.Width = 715;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1264, 457);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Packet Sender";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridSend)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetTextBox textBoxIP;
        private MetroSet_UI.Controls.MetroSetTextBox textBoxPort;
        private MetroSet_UI.Controls.MetroSetTextBox textBoxMessage;
        private MetroFramework.Controls.MetroGrid metroGridSend;
        private MetroSet_UI.Controls.MetroSetButton buttonSend;
        private MetroSet_UI.Controls.MetroSetButton buttonSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroSet_UI.Controls.MetroSetTextBox textBoxName;
        private MetroSet_UI.Controls.MetroSetLabel labelPort;
        private MetroSet_UI.Controls.MetroSetLabel labelIP;
        private MetroSet_UI.Controls.MetroSetLabel labelMessage;
        private MetroSet_UI.Controls.MetroSetLabel labelName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnSend;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnToAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnToPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMessage;
    }
}

