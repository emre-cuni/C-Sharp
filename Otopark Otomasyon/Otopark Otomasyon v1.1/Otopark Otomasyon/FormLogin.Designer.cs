namespace Otopark_Otomasyon
{
    partial class FormLogin
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.textBoxLoginAdmin = new System.Windows.Forms.TextBox();
            this.labelLoginPassword = new System.Windows.Forms.Label();
            this.labelLoginAdmin = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLogin = new System.Windows.Forms.TabPage();
            this.tabPageRegister = new System.Windows.Forms.TabPage();
            this.labelRegisterPassword = new System.Windows.Forms.Label();
            this.labelRegisterAdmin = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxRegisterPassword = new System.Windows.Forms.TextBox();
            this.textBoxRegisterAdmin = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPageLogin.SuspendLayout();
            this.tabPageRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Green;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonLogin.Location = new System.Drawing.Point(99, 91);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(148, 37);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Giriş Yap";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxLoginPassword
            // 
            this.textBoxLoginPassword.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxLoginPassword.ForeColor = System.Drawing.Color.White;
            this.textBoxLoginPassword.Location = new System.Drawing.Point(99, 59);
            this.textBoxLoginPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLoginPassword.Name = "textBoxLoginPassword";
            this.textBoxLoginPassword.Size = new System.Drawing.Size(148, 24);
            this.textBoxLoginPassword.TabIndex = 1;
            // 
            // textBoxLoginAdmin
            // 
            this.textBoxLoginAdmin.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxLoginAdmin.ForeColor = System.Drawing.Color.White;
            this.textBoxLoginAdmin.Location = new System.Drawing.Point(99, 22);
            this.textBoxLoginAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLoginAdmin.Name = "textBoxLoginAdmin";
            this.textBoxLoginAdmin.Size = new System.Drawing.Size(148, 24);
            this.textBoxLoginAdmin.TabIndex = 0;
            // 
            // labelLoginPassword
            // 
            this.labelLoginPassword.AutoSize = true;
            this.labelLoginPassword.ForeColor = System.Drawing.Color.White;
            this.labelLoginPassword.Location = new System.Drawing.Point(26, 65);
            this.labelLoginPassword.Name = "labelLoginPassword";
            this.labelLoginPassword.Size = new System.Drawing.Size(55, 18);
            this.labelLoginPassword.TabIndex = 4;
            this.labelLoginPassword.Text = "Parola:";
            // 
            // labelLoginAdmin
            // 
            this.labelLoginAdmin.AutoSize = true;
            this.labelLoginAdmin.ForeColor = System.Drawing.Color.White;
            this.labelLoginAdmin.Location = new System.Drawing.Point(17, 28);
            this.labelLoginAdmin.Name = "labelLoginAdmin";
            this.labelLoginAdmin.Size = new System.Drawing.Size(64, 18);
            this.labelLoginAdmin.TabIndex = 3;
            this.labelLoginAdmin.Text = "Yönetici:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageLogin);
            this.tabControl1.Controls.Add(this.tabPageRegister);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(283, 204);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPageLogin
            // 
            this.tabPageLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.tabPageLogin.Controls.Add(this.labelLoginAdmin);
            this.tabPageLogin.Controls.Add(this.textBoxLoginPassword);
            this.tabPageLogin.Controls.Add(this.labelLoginPassword);
            this.tabPageLogin.Controls.Add(this.buttonLogin);
            this.tabPageLogin.Controls.Add(this.textBoxLoginAdmin);
            this.tabPageLogin.Location = new System.Drawing.Point(4, 27);
            this.tabPageLogin.Name = "tabPageLogin";
            this.tabPageLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogin.Size = new System.Drawing.Size(275, 173);
            this.tabPageLogin.TabIndex = 0;
            this.tabPageLogin.Text = "Giriş Yap";
            // 
            // tabPageRegister
            // 
            this.tabPageRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tabPageRegister.Controls.Add(this.labelRegisterPassword);
            this.tabPageRegister.Controls.Add(this.labelRegisterAdmin);
            this.tabPageRegister.Controls.Add(this.buttonRegister);
            this.tabPageRegister.Controls.Add(this.textBoxRegisterPassword);
            this.tabPageRegister.Controls.Add(this.textBoxRegisterAdmin);
            this.tabPageRegister.Location = new System.Drawing.Point(4, 27);
            this.tabPageRegister.Name = "tabPageRegister";
            this.tabPageRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegister.Size = new System.Drawing.Size(275, 173);
            this.tabPageRegister.TabIndex = 1;
            this.tabPageRegister.Text = "Kayıt Ol";
            // 
            // labelRegisterPassword
            // 
            this.labelRegisterPassword.AutoSize = true;
            this.labelRegisterPassword.ForeColor = System.Drawing.Color.White;
            this.labelRegisterPassword.Location = new System.Drawing.Point(26, 65);
            this.labelRegisterPassword.Name = "labelRegisterPassword";
            this.labelRegisterPassword.Size = new System.Drawing.Size(55, 18);
            this.labelRegisterPassword.TabIndex = 4;
            this.labelRegisterPassword.Text = "Parola:";
            // 
            // labelRegisterAdmin
            // 
            this.labelRegisterAdmin.AutoSize = true;
            this.labelRegisterAdmin.ForeColor = System.Drawing.Color.White;
            this.labelRegisterAdmin.Location = new System.Drawing.Point(17, 28);
            this.labelRegisterAdmin.Name = "labelRegisterAdmin";
            this.labelRegisterAdmin.Size = new System.Drawing.Size(64, 18);
            this.labelRegisterAdmin.TabIndex = 3;
            this.labelRegisterAdmin.Text = "Yönetici:";
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.Maroon;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRegister.Location = new System.Drawing.Point(99, 91);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(148, 37);
            this.buttonRegister.TabIndex = 2;
            this.buttonRegister.Text = "Kayıt Ol";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // textBoxRegisterPassword
            // 
            this.textBoxRegisterPassword.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxRegisterPassword.Location = new System.Drawing.Point(99, 59);
            this.textBoxRegisterPassword.Name = "textBoxRegisterPassword";
            this.textBoxRegisterPassword.Size = new System.Drawing.Size(148, 24);
            this.textBoxRegisterPassword.TabIndex = 1;
            // 
            // textBoxRegisterAdmin
            // 
            this.textBoxRegisterAdmin.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxRegisterAdmin.Location = new System.Drawing.Point(99, 22);
            this.textBoxRegisterAdmin.Name = "textBoxRegisterAdmin";
            this.textBoxRegisterAdmin.Size = new System.Drawing.Size(148, 24);
            this.textBoxRegisterAdmin.TabIndex = 0;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(308, 232);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageLogin.ResumeLayout(false);
            this.tabPageLogin.PerformLayout();
            this.tabPageRegister.ResumeLayout(false);
            this.tabPageRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxLoginPassword;
        private System.Windows.Forms.TextBox textBoxLoginAdmin;
        private System.Windows.Forms.Label labelLoginPassword;
        private System.Windows.Forms.Label labelLoginAdmin;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLogin;
        private System.Windows.Forms.TabPage tabPageRegister;
        private System.Windows.Forms.Label labelRegisterPassword;
        private System.Windows.Forms.Label labelRegisterAdmin;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxRegisterPassword;
        private System.Windows.Forms.TextBox textBoxRegisterAdmin;
    }
}

