namespace WinFormsByMetanit
{
    partial class AddOrderForm
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
            components = new System.ComponentModel.Container();
            clientNameBox1 = new TextBox();
            clientLastnameBox2 = new TextBox();
            widthTextBox3 = new TextBox();
            HeigthBox4 = new TextBox();
            QuantityBox6 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            label7 = new Label();
            textBox3 = new TextBox();
            materialRepositoryBindingSource = new BindingSource(components);
            orderDetailsBindingSource = new BindingSource(components);
            LayerGrassListBox2 = new ListBox();
            GlassTypeListBox3 = new ListBox();
            button2 = new Button();
            orderDetailsBindingSource1 = new BindingSource(components);
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)materialRepositoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailsBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // clientNameBox1
            // 
            clientNameBox1.AccessibleRole = AccessibleRole.OutlineButton;
            clientNameBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clientNameBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            clientNameBox1.Location = new Point(165, 13);
            clientNameBox1.MaxLength = 20;
            clientNameBox1.Multiline = true;
            clientNameBox1.Name = "clientNameBox1";
            clientNameBox1.PlaceholderText = "введите имя ";
            clientNameBox1.Size = new Size(235, 59);
            clientNameBox1.TabIndex = 0;
            // 
            // clientLastnameBox2
            // 
            clientLastnameBox2.Location = new Point(164, 64);
            clientLastnameBox2.Multiline = true;
            clientLastnameBox2.Name = "clientLastnameBox2";
            clientLastnameBox2.PlaceholderText = "введите фамилия";
            clientLastnameBox2.Size = new Size(235, 28);
            clientLastnameBox2.TabIndex = 1;
            // 
            // widthTextBox3
            // 
            widthTextBox3.Location = new Point(166, 280);
            widthTextBox3.Multiline = true;
            widthTextBox3.Name = "widthTextBox3";
            widthTextBox3.PlaceholderText = "шрина";
            widthTextBox3.Size = new Size(235, 44);
            widthTextBox3.TabIndex = 2;
            // 
            // HeigthBox4
            // 
            HeigthBox4.Location = new Point(165, 343);
            HeigthBox4.Multiline = true;
            HeigthBox4.Name = "HeigthBox4";
            HeigthBox4.PlaceholderText = "высота";
            HeigthBox4.Size = new Size(235, 44);
            HeigthBox4.TabIndex = 3;
            // 
            // QuantityBox6
            // 
            QuantityBox6.Location = new Point(165, 409);
            QuantityBox6.Multiline = true;
            QuantityBox6.Name = "QuantityBox6";
            QuantityBox6.PlaceholderText = "количество";
            QuantityBox6.Size = new Size(235, 44);
            QuantityBox6.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 22);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 8;
            label1.Text = "Имя Клиента";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 64);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 9;
            label2.Text = "Фамилия клиента";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(11, 296);
            label.Name = "label";
            label.Size = new Size(58, 20);
            label.TabIndex = 10;
            label.Text = "Шрина";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 359);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 11;
            label3.Text = "Высота";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 123);
            label4.Name = "label4";
            label4.Size = new Size(137, 20);
            label4.TabIndex = 12;
            label4.Text = "Пакет или Одинар";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 425);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 13;
            label5.Text = "Количество";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 216);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 14;
            label6.Text = "Тип Стекло";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InfoText;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(492, 459);
            button1.Name = "button1";
            button1.Size = new Size(211, 64);
            button1.TabIndex = 15;
            button1.Text = "добавить в БД";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(450, 367);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 16;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(790, 459);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.ScrollBars = ScrollBars.Both;
            textBox3.Size = new Size(246, 34);
            textBox3.TabIndex = 17;
            textBox3.Text = "ответ опирации:";
            // 
            // materialRepositoryBindingSource
            // 
            materialRepositoryBindingSource.DataSource = typeof(Dal.Repositories.MaterialRepository);
            // 
            // orderDetailsBindingSource
            // 
            orderDetailsBindingSource.DataSource = typeof(Domain.Entity.OrderDetails);
            // 
            // LayerGrassListBox2
            // 
            LayerGrassListBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LayerGrassListBox2.FormattingEnabled = true;
            LayerGrassListBox2.ItemHeight = 28;
            LayerGrassListBox2.Items.AddRange(new object[] { "Пакет", "Одинар" });
            LayerGrassListBox2.Location = new Point(165, 109);
            LayerGrassListBox2.Name = "LayerGrassListBox2";
            LayerGrassListBox2.Size = new Size(234, 60);
            LayerGrassListBox2.TabIndex = 19;
            // 
            // GlassTypeListBox3
            // 
            GlassTypeListBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GlassTypeListBox3.FormattingEnabled = true;
            GlassTypeListBox3.ItemHeight = 28;
            GlassTypeListBox3.Items.AddRange(new object[] { "Простой", "Рефленный йодовый", "Рефленный сафед", "Йодовый простой", "Йодовый танировка", "Рефленный йодовый зеркало", "Рефленный сафед зеркало", "Зеркало зеркало" });
            GlassTypeListBox3.Location = new Point(165, 186);
            GlassTypeListBox3.Name = "GlassTypeListBox3";
            GlassTypeListBox3.Size = new Size(234, 88);
            GlassTypeListBox3.TabIndex = 20;
            // 
            // button2
            // 
            button2.BackColor = Color.LimeGreen;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(228, 459);
            button2.Name = "button2";
            button2.Size = new Size(222, 64);
            button2.TabIndex = 22;
            button2.Text = "добавить в карзину";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // orderDetailsBindingSource1
            // 
            orderDetailsBindingSource1.DataSource = typeof(Domain.Entity.OrderDetails);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(419, 13);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(646, 432);
            dataGridView1.TabIndex = 23;
            // 
            // Column1
            // 
            Column1.HeaderText = "Имя";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Пакет или Одинар";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Тип";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Шрина";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Высота";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Количество";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // AddOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 535);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(GlassTypeListBox3);
            Controls.Add(LayerGrassListBox2);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(QuantityBox6);
            Controls.Add(HeigthBox4);
            Controls.Add(widthTextBox3);
            Controls.Add(clientLastnameBox2);
            Controls.Add(clientNameBox1);
            Name = "AddOrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddOrderForm";
            ((System.ComponentModel.ISupportInitialize)materialRepositoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailsBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox widthTextBox3;
        private TextBox textBox4;
        private TextBox QuantityBox6;
        private Label label1;
        private Label label2;
        private Label label;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private TextBox clientNameBox1;
        private TextBox clientLastnameBox2;
        private TextBox HeigthBox4;
        private Label label7;
        private TextBox textBox3;
        private ListBox LayerGrassListBox2;
        private ListBox GlassTypeListBox3;
        private Button button2;
        private BindingSource orderDetailsBindingSource;
        private BindingSource materialRepositoryBindingSource;
        private BindingSource orderDetailsBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}