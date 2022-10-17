
namespace DataBaseAplication
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.IDCustomer = new System.Windows.Forms.TextBox();
            this.NameCustomer = new System.Windows.Forms.TextBox();
            this.CityCustomer = new System.Windows.Forms.TextBox();
            this.SurnameCustomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addCustomerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IDCustomer
            // 
            this.IDCustomer.Location = new System.Drawing.Point(12, 102);
            this.IDCustomer.Name = "IDCustomer";
            this.IDCustomer.Size = new System.Drawing.Size(232, 22);
            this.IDCustomer.TabIndex = 0;
            this.IDCustomer.TextChanged += new System.EventHandler(this.IDCustomer_TextChanged);
            // 
            // NameCustomer
            // 
            this.NameCustomer.Location = new System.Drawing.Point(538, 102);
            this.NameCustomer.Name = "NameCustomer";
            this.NameCustomer.Size = new System.Drawing.Size(232, 22);
            this.NameCustomer.TabIndex = 1;
            this.NameCustomer.TextChanged += new System.EventHandler(this.NameCustomer_TextChanged);
            // 
            // CityCustomer
            // 
            this.CityCustomer.Location = new System.Drawing.Point(795, 102);
            this.CityCustomer.Name = "CityCustomer";
            this.CityCustomer.Size = new System.Drawing.Size(232, 22);
            this.CityCustomer.TabIndex = 2;
            this.CityCustomer.TextChanged += new System.EventHandler(this.CityCustomer_TextChanged);
            // 
            // SurnameCustomer
            // 
            this.SurnameCustomer.Location = new System.Drawing.Point(276, 102);
            this.SurnameCustomer.Name = "SurnameCustomer";
            this.SurnameCustomer.Size = new System.Drawing.Size(232, 22);
            this.SurnameCustomer.TabIndex = 3;
            this.SurnameCustomer.TextChanged += new System.EventHandler(this.SurnameCustomer_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID-Odbiorcy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(276, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(538, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Imię";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(795, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Miasto";
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.Location = new System.Drawing.Point(926, 179);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(75, 29);
            this.addCustomerBtn.TabIndex = 8;
            this.addCustomerBtn.Text = "Dodaj";
            this.addCustomerBtn.UseVisualStyleBackColor = true;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1043, 232);
            this.Controls.Add(this.addCustomerBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SurnameCustomer);
            this.Controls.Add(this.CityCustomer);
            this.Controls.Add(this.NameCustomer);
            this.Controls.Add(this.IDCustomer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Dodaj Odbiorce";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDCustomer;
        private System.Windows.Forms.TextBox NameCustomer;
        private System.Windows.Forms.TextBox CityCustomer;
        private System.Windows.Forms.TextBox SurnameCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addCustomerBtn;
    }
}