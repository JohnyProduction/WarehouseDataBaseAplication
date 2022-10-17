
namespace DataBaseAplication
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.IDSale = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IDCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IDCommodity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Payment = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IDSale
            // 
            this.IDSale.Location = new System.Drawing.Point(13, 108);
            this.IDSale.Name = "IDSale";
            this.IDSale.Size = new System.Drawing.Size(139, 22);
            this.IDSale.TabIndex = 0;
            this.IDSale.TextChanged += new System.EventHandler(this.IDSale_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(13, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Sprzedaży";
            // 
            // IDCustomer
            // 
            this.IDCustomer.Location = new System.Drawing.Point(158, 108);
            this.IDCustomer.Name = "IDCustomer";
            this.IDCustomer.Size = new System.Drawing.Size(140, 22);
            this.IDCustomer.TabIndex = 2;
            this.IDCustomer.TextChanged += new System.EventHandler(this.IDCustomer_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(159, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID Odbiorcy";
            // 
            // IDCommodity
            // 
            this.IDCommodity.Location = new System.Drawing.Point(304, 108);
            this.IDCommodity.Name = "IDCommodity";
            this.IDCommodity.Size = new System.Drawing.Size(139, 22);
            this.IDCommodity.TabIndex = 4;
            this.IDCommodity.TextChanged += new System.EventHandler(this.IDCommodity_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(305, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID Towaru";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(450, 108);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(139, 22);
            this.priceBox.TabIndex = 8;
            this.priceBox.TextChanged += new System.EventHandler(this.priceBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(450, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Wartość Sprzedaży";
            // 
            // Payment
            // 
            this.Payment.FormattingEnabled = true;
            this.Payment.Items.AddRange(new object[] {
            "Tak",
            "Nie"});
            this.Payment.Location = new System.Drawing.Point(595, 106);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(139, 24);
            this.Payment.TabIndex = 10;
            this.Payment.SelectedIndexChanged += new System.EventHandler(this.Payment_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(595, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Zapłacono";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(759, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1043, 232);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDCommodity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDSale);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Dodaj Sprzedaż";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDSale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDCommodity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Payment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox IDCustomer;
    }
}