
namespace DataBaseAplication
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.server = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kwerendyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produktyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.księgowośćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pracownicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wypłatyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajOdbiorcęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajTowarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajSprzedażToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pobierzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sprzedażToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doZapłatyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTable = new System.Windows.Forms.Button();
            this.showSql = new System.Windows.Forms.Button();
            this.sqlCommand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1311, 361);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tableName
            // 
            this.tableName.FormattingEnabled = true;
            this.tableName.Location = new System.Drawing.Point(1182, 244);
            this.tableName.Name = "tableName";
            this.tableName.Size = new System.Drawing.Size(141, 24);
            this.tableName.TabIndex = 3;
            this.tableName.SelectedIndexChanged += new System.EventHandler(this.tableName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(1179, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wyświelenie tabeli";
            // 
            // server
            // 
            this.server.AutoSize = true;
            this.server.ForeColor = System.Drawing.SystemColors.Control;
            this.server.Location = new System.Drawing.Point(12, 38);
            this.server.Name = "server";
            this.server.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.server.Size = new System.Drawing.Size(56, 17);
            this.server.TabIndex = 5;
            this.server.Text = "label2";
            this.server.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.ForeColor = System.Drawing.SystemColors.Control;
            this.user.Location = new System.Drawing.Point(11, 61);
            this.user.Name = "user";
            this.user.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.user.Size = new System.Drawing.Size(56, 17);
            this.user.TabIndex = 6;
            this.user.Text = "label3";
            this.user.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kwerendyToolStripMenuItem,
            this.księgowośćToolStripMenuItem,
            this.edycjaToolStripMenuItem,
            this.pobierzToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1335, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kwerendyToolStripMenuItem
            // 
            this.kwerendyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produktyToolStripMenuItem});
            this.kwerendyToolStripMenuItem.Name = "kwerendyToolStripMenuItem";
            this.kwerendyToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.kwerendyToolStripMenuItem.Text = "Informacje";
            this.kwerendyToolStripMenuItem.Click += new System.EventHandler(this.kwerendyToolStripMenuItem_Click);
            // 
            // produktyToolStripMenuItem
            // 
            this.produktyToolStripMenuItem.Name = "produktyToolStripMenuItem";
            this.produktyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.produktyToolStripMenuItem.Text = "Produkty";
            this.produktyToolStripMenuItem.Click += new System.EventHandler(this.produktyToolStripMenuItem_Click);
            // 
            // księgowośćToolStripMenuItem
            // 
            this.księgowośćToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pracownicyToolStripMenuItem,
            this.wypłatyToolStripMenuItem});
            this.księgowośćToolStripMenuItem.Name = "księgowośćToolStripMenuItem";
            this.księgowośćToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.księgowośćToolStripMenuItem.Text = "Księgowość";
            this.księgowośćToolStripMenuItem.Click += new System.EventHandler(this.księgowośćToolStripMenuItem_Click);
            // 
            // pracownicyToolStripMenuItem
            // 
            this.pracownicyToolStripMenuItem.Name = "pracownicyToolStripMenuItem";
            this.pracownicyToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.pracownicyToolStripMenuItem.Text = "Pracownicy";
            this.pracownicyToolStripMenuItem.Click += new System.EventHandler(this.pracownicyToolStripMenuItem_Click);
            // 
            // wypłatyToolStripMenuItem
            // 
            this.wypłatyToolStripMenuItem.Name = "wypłatyToolStripMenuItem";
            this.wypłatyToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.wypłatyToolStripMenuItem.Text = "Wypłaty";
            this.wypłatyToolStripMenuItem.Click += new System.EventHandler(this.wypłatyToolStripMenuItem_Click);
            // 
            // edycjaToolStripMenuItem
            // 
            this.edycjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajOdbiorcęToolStripMenuItem,
            this.dodajTowarToolStripMenuItem,
            this.dodajSprzedażToolStripMenuItem});
            this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.edycjaToolStripMenuItem.Text = "Edycja";
            // 
            // dodajOdbiorcęToolStripMenuItem
            // 
            this.dodajOdbiorcęToolStripMenuItem.Name = "dodajOdbiorcęToolStripMenuItem";
            this.dodajOdbiorcęToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.dodajOdbiorcęToolStripMenuItem.Text = "Dodaj odbiorcę";
            this.dodajOdbiorcęToolStripMenuItem.Click += new System.EventHandler(this.dodajOdbiorcęToolStripMenuItem_Click);
            // 
            // dodajTowarToolStripMenuItem
            // 
            this.dodajTowarToolStripMenuItem.Name = "dodajTowarToolStripMenuItem";
            this.dodajTowarToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.dodajTowarToolStripMenuItem.Text = "Dodaj towar";
            this.dodajTowarToolStripMenuItem.Click += new System.EventHandler(this.dodajTowarToolStripMenuItem_Click);
            // 
            // dodajSprzedażToolStripMenuItem
            // 
            this.dodajSprzedażToolStripMenuItem.Name = "dodajSprzedażToolStripMenuItem";
            this.dodajSprzedażToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.dodajSprzedażToolStripMenuItem.Text = "Dodaj sprzedaż";
            this.dodajSprzedażToolStripMenuItem.Click += new System.EventHandler(this.dodajSprzedażToolStripMenuItem_Click);
            // 
            // pobierzToolStripMenuItem
            // 
            this.pobierzToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sprzedażToolStripMenuItem,
            this.doZapłatyToolStripMenuItem});
            this.pobierzToolStripMenuItem.Name = "pobierzToolStripMenuItem";
            this.pobierzToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.pobierzToolStripMenuItem.Text = "Pobierz";
            // 
            // sprzedażToolStripMenuItem
            // 
            this.sprzedażToolStripMenuItem.Name = "sprzedażToolStripMenuItem";
            this.sprzedażToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.sprzedażToolStripMenuItem.Text = "Sprzedaż";
            this.sprzedażToolStripMenuItem.Click += new System.EventHandler(this.sprzedażToolStripMenuItem_Click);
            // 
            // doZapłatyToolStripMenuItem
            // 
            this.doZapłatyToolStripMenuItem.Name = "doZapłatyToolStripMenuItem";
            this.doZapłatyToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.doZapłatyToolStripMenuItem.Text = "Do zapłaty";
            this.doZapłatyToolStripMenuItem.Click += new System.EventHandler(this.doZapłatyToolStripMenuItem_Click);
            // 
            // showTable
            // 
            this.showTable.Location = new System.Drawing.Point(1182, 275);
            this.showTable.Name = "showTable";
            this.showTable.Size = new System.Drawing.Size(141, 27);
            this.showTable.TabIndex = 8;
            this.showTable.Text = "Wyświetl";
            this.showTable.UseVisualStyleBackColor = true;
            this.showTable.Click += new System.EventHandler(this.showTable_Click);
            // 
            // showSql
            // 
            this.showSql.Location = new System.Drawing.Point(1182, 84);
            this.showSql.Name = "showSql";
            this.showSql.Size = new System.Drawing.Size(141, 27);
            this.showSql.TabIndex = 9;
            this.showSql.Text = "Wykonaj";
            this.showSql.UseVisualStyleBackColor = true;
            this.showSql.Click += new System.EventHandler(this.showSql_Click);
            // 
            // sqlCommand
            // 
            this.sqlCommand.Location = new System.Drawing.Point(976, 56);
            this.sqlCommand.Name = "sqlCommand";
            this.sqlCommand.Size = new System.Drawing.Size(347, 22);
            this.sqlCommand.TabIndex = 10;
            this.sqlCommand.TextChanged += new System.EventHandler(this.sqlCommand_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(976, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Własne zapytanie SQL";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1335, 688);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sqlCommand);
            this.Controls.Add(this.showSql);
            this.Controls.Add(this.showTable);
            this.Controls.Add(this.user);
            this.Controls.Add(this.server);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Hurtownia - Panel";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox tableName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label server;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kwerendyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produktyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem księgowośćToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pracownicyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wypłatyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajOdbiorcęToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajTowarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajSprzedażToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pobierzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sprzedażToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doZapłatyToolStripMenuItem;
        private System.Windows.Forms.Button showTable;
        private System.Windows.Forms.Button showSql;
        private System.Windows.Forms.TextBox sqlCommand;
        private System.Windows.Forms.Label label2;
    }
}