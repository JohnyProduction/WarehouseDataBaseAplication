
namespace DataBaseAplication
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.login_button = new System.Windows.Forms.Button();
            this.server_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.database_name = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.login_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.login_button.FlatAppearance.BorderSize = 0;
            this.login_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.login_button.ForeColor = System.Drawing.Color.Black;
            this.login_button.Location = new System.Drawing.Point(152, 322);
            this.login_button.Margin = new System.Windows.Forms.Padding(0);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(100, 28);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "Zaloguj";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // server_name
            // 
            this.server_name.Location = new System.Drawing.Point(109, 95);
            this.server_name.Margin = new System.Windows.Forms.Padding(4);
            this.server_name.Name = "server_name";
            this.server_name.Size = new System.Drawing.Size(181, 22);
            this.server_name.TabIndex = 1;
            this.server_name.Text = "user-VirtualBox";
            this.server_name.TextChanged += new System.EventHandler(this.server_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(105, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nazwa serwera / IP serwera";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(109, 192);
            this.user.Margin = new System.Windows.Forms.Padding(4);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(181, 22);
            this.user.TabIndex = 3;
            this.user.Text = "sa";
            this.user.TextChanged += new System.EventHandler(this.user_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(105, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Użytkownik";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(109, 242);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(181, 22);
            this.password.TabIndex = 5;
            this.password.Text = "zaq1@WSX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(105, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hasło";
            // 
            // database_name
            // 
            this.database_name.FormattingEnabled = true;
            this.database_name.Items.AddRange(new object[] {
            "Hurtownia",
            "Pracownicy",
            "Northwind",
            "test",
            "sql11498704"});
            this.database_name.Location = new System.Drawing.Point(108, 143);
            this.database_name.Name = "database_name";
            this.database_name.Size = new System.Drawing.Size(181, 24);
            this.database_name.TabIndex = 7;
            this.database_name.Text = "Hurtownia";
            this.database_name.SelectedIndexChanged += new System.EventHandler(this.database_name_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(106, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nazwa bazy danych";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(395, 366);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.database_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.server_name);
            this.Controls.Add(this.login_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(413, 413);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(413, 413);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Hurtownia - Logowanie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox server_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.ComboBox database_name;
        private System.Windows.Forms.Label label4;
    }
}

