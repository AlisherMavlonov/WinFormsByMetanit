namespace WinFormsByMetanit
{
    partial class TablControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablControl));
            menuStrip1 = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Тип = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            clientNameBox1 = new TextBox();
            GlassTypeListBox3 = new ListBox();
            LayerGrassListBox2 = new ListBox();
            QuantityBox6 = new TextBox();
            HeigthBox4 = new TextBox();
            widthTextBox3 = new TextBox();
            clientLastnameBox2 = new TextBox();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1709, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(59, 24);
            менюToolStripMenuItem.Text = "Файл";
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(81, 24);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 30);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1709, 971);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(button6);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(clientNameBox1);
            tabPage1.Controls.Add(GlassTypeListBox3);
            tabPage1.Controls.Add(LayerGrassListBox2);
            tabPage1.Controls.Add(QuantityBox6);
            tabPage1.Controls.Add(HeigthBox4);
            tabPage1.Controls.Add(widthTextBox3);
            tabPage1.Controls.Add(clientLastnameBox2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(1701, 938);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Склад";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Тип, Column5, Column6 });
            dataGridView1.Location = new Point(23, 209);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1465, 689);
            dataGridView1.TabIndex = 14;
            // 
            // Column1
            // 
            Column1.HeaderText = "Имя";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 142;
            // 
            // Column2
            // 
            Column2.HeaderText = "Фамилия";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 142;
            // 
            // Column3
            // 
            Column3.HeaderText = "Слой";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 142;
            // 
            // Column4
            // 
            Column4.HeaderText = "количество";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 142;
            // 
            // Тип
            // 
            Тип.HeaderText = "Тип";
            Тип.MinimumWidth = 6;
            Тип.Name = "Тип";
            Тип.ReadOnly = true;
            Тип.Width = 142;
            // 
            // Column5
            // 
            Column5.HeaderText = "Шрина";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 142;
            // 
            // Column6
            // 
            Column6.HeaderText = "Высота";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 142;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.Red;
            button6.Location = new Point(1511, 784);
            button6.Name = "button6";
            button6.Size = new Size(141, 55);
            button6.TabIndex = 20;
            button6.Text = "Выход";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click_1;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkTurquoise;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.Transparent;
            button5.Location = new Point(1511, 683);
            button5.Name = "button5";
            button5.Size = new Size(141, 55);
            button5.TabIndex = 19;
            button5.Text = "Сохранить";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(1511, 571);
            button4.Name = "button4";
            button4.Size = new Size(141, 55);
            button4.TabIndex = 18;
            button4.Text = "Удалить";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkOrange;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1511, 472);
            button3.Name = "button3";
            button3.Size = new Size(141, 55);
            button3.TabIndex = 17;
            button3.Text = "Печать";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1511, 368);
            button2.Name = "button2";
            button2.Size = new Size(141, 55);
            button2.TabIndex = 16;
            button2.Text = "Сброс настроек";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.SpringGreen;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1511, 271);
            button1.Name = "button1";
            button1.Size = new Size(141, 55);
            button1.TabIndex = 15;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // clientNameBox1
            // 
            clientNameBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            clientNameBox1.Location = new Point(253, 68);
            clientNameBox1.MaxLength = 15;
            clientNameBox1.Multiline = true;
            clientNameBox1.Name = "clientNameBox1";
            clientNameBox1.PlaceholderText = "введите имя";
            clientNameBox1.Size = new Size(235, 47);
            clientNameBox1.TabIndex = 7;
            // 
            // GlassTypeListBox3
            // 
            GlassTypeListBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GlassTypeListBox3.FormattingEnabled = true;
            GlassTypeListBox3.ItemHeight = 28;
            GlassTypeListBox3.Items.AddRange(new object[] { "Простой", "Рефленный йодовый", "Рефленный сафед", "Йодовый простой", "Йодовый танировка", "Рефленный йодовый зеркало", "Рефленный сафед зеркало", "Зеркало зеркало" });
            GlassTypeListBox3.Location = new Point(791, 68);
            GlassTypeListBox3.Name = "GlassTypeListBox3";
            GlassTypeListBox3.Size = new Size(234, 116);
            GlassTypeListBox3.TabIndex = 11;
            // 
            // LayerGrassListBox2
            // 
            LayerGrassListBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LayerGrassListBox2.FormattingEnabled = true;
            LayerGrassListBox2.ItemHeight = 28;
            LayerGrassListBox2.Items.AddRange(new object[] { "Пакет", "Одинар" });
            LayerGrassListBox2.Location = new Point(520, 68);
            LayerGrassListBox2.Name = "LayerGrassListBox2";
            LayerGrassListBox2.Size = new Size(234, 60);
            LayerGrassListBox2.TabIndex = 9;
            // 
            // QuantityBox6
            // 
            QuantityBox6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            QuantityBox6.Location = new Point(520, 137);
            QuantityBox6.MaxLength = 20;
            QuantityBox6.Multiline = true;
            QuantityBox6.Name = "QuantityBox6";
            QuantityBox6.PlaceholderText = "количество";
            QuantityBox6.Size = new Size(234, 47);
            QuantityBox6.TabIndex = 10;
            // 
            // HeigthBox4
            // 
            HeigthBox4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            HeigthBox4.Location = new Point(1056, 137);
            HeigthBox4.Multiline = true;
            HeigthBox4.Name = "HeigthBox4";
            HeigthBox4.PlaceholderText = "высота";
            HeigthBox4.Size = new Size(235, 47);
            HeigthBox4.TabIndex = 13;
            // 
            // widthTextBox3
            // 
            widthTextBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            widthTextBox3.Location = new Point(1056, 68);
            widthTextBox3.Multiline = true;
            widthTextBox3.Name = "widthTextBox3";
            widthTextBox3.PlaceholderText = "шрина";
            widthTextBox3.Size = new Size(235, 48);
            widthTextBox3.TabIndex = 12;
            // 
            // clientLastnameBox2
            // 
            clientLastnameBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            clientLastnameBox2.Location = new Point(253, 137);
            clientLastnameBox2.MaxLength = 15;
            clientLastnameBox2.Multiline = true;
            clientLastnameBox2.Name = "clientLastnameBox2";
            clientLastnameBox2.PlaceholderText = "введите фамилия";
            clientLastnameBox2.Size = new Size(235, 47);
            clientLastnameBox2.TabIndex = 8;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(1701, 938);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Заказы";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(1701, 938);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Добавить Заказ";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(3, 4, 3, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 4, 3, 4);
            tabPage4.Size = new Size(1701, 938);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 29);
            tabPage5.Margin = new Padding(3, 4, 3, 4);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3, 4, 3, 4);
            tabPage5.Size = new Size(1701, 938);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 29);
            tabPage6.Margin = new Padding(3, 4, 3, 4);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3, 4, 3, 4);
            tabPage6.Size = new Size(1701, 938);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "tabPage6";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.Location = new Point(4, 29);
            tabPage7.Margin = new Padding(3, 4, 3, 4);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3, 4, 3, 4);
            tabPage7.Size = new Size(1701, 938);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "tabPage7";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // TablControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1709, 1001);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "TablControl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TablControl";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TextBox clientNameBox1;
        private ListBox GlassTypeListBox3;
        private ListBox LayerGrassListBox2;
        private TextBox QuantityBox6;
        private TextBox HeigthBox4;
        private TextBox widthTextBox3;
        private TextBox clientLastnameBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Тип;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}