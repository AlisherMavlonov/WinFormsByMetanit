namespace WinFormsByMetanit
{
    partial class DataGridView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGridView));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            menuStrip1 = new MenuStrip();
            файлыToolStripMenuItem = new ToolStripMenuItem();
            добавитьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            печатьToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            редоктироватьToolStripMenuItem = new ToolStripMenuItem();
            сбросНастроекToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            Zafecserbutton = new Button();
            clientNameBox1 = new TextBox();
            AddOrderdataGridView = new System.Windows.Forms.DataGridView();
            nameColumn = new DataGridViewTextBoxColumn();
            lastNameColumn = new DataGridViewTextBoxColumn();
            layerColumn = new DataGridViewTextBoxColumn();
            quantityColumn = new DataGridViewTextBoxColumn();
            typeColumn = new DataGridViewTextBoxColumn();
            widthColumn = new DataGridViewTextBoxColumn();
            heightColumn = new DataGridViewTextBoxColumn();
            ExetButton = new Button();
            SaveButton = new Button();
            DeleteButton = new Button();
            PrintButton = new Button();
            CleanButton = new Button();
            Addbutton = new Button();
            GlassTypeListBox3 = new ListBox();
            LayerGrassListBox2 = new ListBox();
            QuantityBox6 = new TextBox();
            HeigthBox4 = new TextBox();
            widthTextBox3 = new TextBox();
            clientLastnameBox2 = new TextBox();
            tabPage2 = new TabPage();
            button8 = new Button();
            ugoloklabel12 = new Label();
            germetiklabel11 = new Label();
            gellabel10 = new Label();
            prostoylabel9 = new Label();
            refYodlabel8 = new Label();
            zerkalolabel7 = new Label();
            refSaflabel6 = new Label();
            yodProstoylabel5 = new Label();
            YodTanirovkalabel4 = new Label();
            ramkalabel3 = new Label();
            textBox12 = new TextBox();
            textBox11 = new TextBox();
            textBox10 = new TextBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            tabPage3 = new TabPage();
            dataGridView2 = new System.Windows.Forms.DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ramkaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ugolokDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            germetikDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            prostoyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            refYodDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            zerkaloDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            refSafDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yodProstoyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yodTanirovkaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            materialBindingSource = new BindingSource(components);
            tabPage4 = new TabPage();
            button7 = new Button();
            dataGridView3 = new System.Windows.Forms.DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clientBindingSource = new BindingSource(components);
            tabPage5 = new TabPage();
            dataGridView4 = new System.Windows.Forms.DataGridView();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            orderServiceBindingSource = new BindingSource(components);
            materialBindingSource1 = new BindingSource(components);
            clientServiceBindingSource = new BindingSource(components);
            orderBindingSource1 = new BindingSource(components);
            orderBindingSource = new BindingSource(components);
            materialRepositoryBindingSource = new BindingSource(components);
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            orderBindingSource2 = new BindingSource(components);
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AddOrderdataGridView).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)materialBindingSource).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderServiceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)materialBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientServiceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)materialRepositoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            resources.ApplyResources(printPreviewDialog1, "printPreviewDialog1");
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Name = "printPreviewDialog1";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлыToolStripMenuItem, редоктироватьToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            // 
            // файлыToolStripMenuItem
            // 
            файлыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem, сохранитьToolStripMenuItem, печатьToolStripMenuItem, выходToolStripMenuItem });
            файлыToolStripMenuItem.Name = "файлыToolStripMenuItem";
            resources.ApplyResources(файлыToolStripMenuItem, "файлыToolStripMenuItem");
            // 
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            resources.ApplyResources(добавитьToolStripMenuItem, "добавитьToolStripMenuItem");
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            resources.ApplyResources(сохранитьToolStripMenuItem, "сохранитьToolStripMenuItem");
            // 
            // печатьToolStripMenuItem
            // 
            печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            resources.ApplyResources(печатьToolStripMenuItem, "печатьToolStripMenuItem");
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            resources.ApplyResources(выходToolStripMenuItem, "выходToolStripMenuItem");
            // 
            // редоктироватьToolStripMenuItem
            // 
            редоктироватьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { сбросНастроекToolStripMenuItem, удалитьToolStripMenuItem });
            редоктироватьToolStripMenuItem.Name = "редоктироватьToolStripMenuItem";
            resources.ApplyResources(редоктироватьToolStripMenuItem, "редоктироватьToolStripMenuItem");
            // 
            // сбросНастроекToolStripMenuItem
            // 
            сбросНастроекToolStripMenuItem.Name = "сбросНастроекToolStripMenuItem";
            resources.ApplyResources(сбросНастроекToolStripMenuItem, "сбросНастроекToolStripMenuItem");
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            resources.ApplyResources(удалитьToolStripMenuItem, "удалитьToolStripMenuItem");
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            resources.ApplyResources(tabPage1, "tabPage1");
            tabPage1.Controls.Add(Zafecserbutton);
            tabPage1.Controls.Add(clientNameBox1);
            tabPage1.Controls.Add(AddOrderdataGridView);
            tabPage1.Controls.Add(ExetButton);
            tabPage1.Controls.Add(SaveButton);
            tabPage1.Controls.Add(DeleteButton);
            tabPage1.Controls.Add(PrintButton);
            tabPage1.Controls.Add(CleanButton);
            tabPage1.Controls.Add(Addbutton);
            tabPage1.Controls.Add(GlassTypeListBox3);
            tabPage1.Controls.Add(LayerGrassListBox2);
            tabPage1.Controls.Add(QuantityBox6);
            tabPage1.Controls.Add(HeigthBox4);
            tabPage1.Controls.Add(widthTextBox3);
            tabPage1.Controls.Add(clientLastnameBox2);
            tabPage1.Name = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Zafecserbutton
            // 
            resources.ApplyResources(Zafecserbutton, "Zafecserbutton");
            Zafecserbutton.BackColor = Color.Lime;
            Zafecserbutton.Name = "Zafecserbutton";
            Zafecserbutton.UseVisualStyleBackColor = false;
            Zafecserbutton.Click += Zafecserbutton_Click;
            // 
            // clientNameBox1
            // 
            clientNameBox1.AutoCompleteCustomSource.AddRange(new string[] { resources.GetString("clientNameBox1.AutoCompleteCustomSource"), resources.GetString("clientNameBox1.AutoCompleteCustomSource1"), resources.GetString("clientNameBox1.AutoCompleteCustomSource2") });
            clientNameBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            clientNameBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            resources.ApplyResources(clientNameBox1, "clientNameBox1");
            clientNameBox1.Name = "clientNameBox1";
            // 
            // AddOrderdataGridView
            // 
            AddOrderdataGridView.AllowUserToAddRows = false;
            resources.ApplyResources(AddOrderdataGridView, "AddOrderdataGridView");
            AddOrderdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AddOrderdataGridView.BackgroundColor = SystemColors.ActiveCaption;
            AddOrderdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AddOrderdataGridView.Columns.AddRange(new DataGridViewColumn[] { nameColumn, lastNameColumn, layerColumn, quantityColumn, typeColumn, widthColumn, heightColumn });
            AddOrderdataGridView.Name = "AddOrderdataGridView";
            AddOrderdataGridView.RowTemplate.Height = 29;
            // 
            // nameColumn
            // 
            nameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(nameColumn, "nameColumn");
            nameColumn.Name = "nameColumn";
            nameColumn.ReadOnly = true;
            // 
            // lastNameColumn
            // 
            lastNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(lastNameColumn, "lastNameColumn");
            lastNameColumn.Name = "lastNameColumn";
            lastNameColumn.ReadOnly = true;
            // 
            // layerColumn
            // 
            layerColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(layerColumn, "layerColumn");
            layerColumn.Name = "layerColumn";
            layerColumn.ReadOnly = true;
            // 
            // quantityColumn
            // 
            quantityColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(quantityColumn, "quantityColumn");
            quantityColumn.Name = "quantityColumn";
            quantityColumn.ReadOnly = true;
            // 
            // typeColumn
            // 
            typeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(typeColumn, "typeColumn");
            typeColumn.Name = "typeColumn";
            typeColumn.ReadOnly = true;
            // 
            // widthColumn
            // 
            widthColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(widthColumn, "widthColumn");
            widthColumn.Name = "widthColumn";
            widthColumn.ReadOnly = true;
            // 
            // heightColumn
            // 
            heightColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(heightColumn, "heightColumn");
            heightColumn.Name = "heightColumn";
            heightColumn.ReadOnly = true;
            // 
            // ExetButton
            // 
            resources.ApplyResources(ExetButton, "ExetButton");
            ExetButton.ForeColor = Color.Red;
            ExetButton.Name = "ExetButton";
            ExetButton.UseVisualStyleBackColor = true;
            ExetButton.Click += ExetButton_Click_1;
            // 
            // SaveButton
            // 
            resources.ApplyResources(SaveButton, "SaveButton");
            SaveButton.BackColor = Color.DarkTurquoise;
            SaveButton.ForeColor = Color.Transparent;
            SaveButton.Name = "SaveButton";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click_1;
            // 
            // DeleteButton
            // 
            resources.ApplyResources(DeleteButton, "DeleteButton");
            DeleteButton.BackColor = Color.Red;
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Name = "DeleteButton";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click_1;
            // 
            // PrintButton
            // 
            resources.ApplyResources(PrintButton, "PrintButton");
            PrintButton.BackColor = Color.DarkOrange;
            PrintButton.ForeColor = Color.White;
            PrintButton.Name = "PrintButton";
            PrintButton.UseVisualStyleBackColor = false;
            PrintButton.Click += PrintButton_Click_1;
            // 
            // CleanButton
            // 
            resources.ApplyResources(CleanButton, "CleanButton");
            CleanButton.BackColor = SystemColors.ActiveCaption;
            CleanButton.ForeColor = Color.White;
            CleanButton.Name = "CleanButton";
            CleanButton.UseVisualStyleBackColor = false;
            CleanButton.Click += CleanButton_Click_1;
            // 
            // Addbutton
            // 
            resources.ApplyResources(Addbutton, "Addbutton");
            Addbutton.BackColor = Color.SpringGreen;
            Addbutton.ForeColor = Color.White;
            Addbutton.Name = "Addbutton";
            Addbutton.UseVisualStyleBackColor = false;
            Addbutton.Click += Addbutton_Click_1;
            // 
            // GlassTypeListBox3
            // 
            resources.ApplyResources(GlassTypeListBox3, "GlassTypeListBox3");
            GlassTypeListBox3.FormattingEnabled = true;
            GlassTypeListBox3.Items.AddRange(new object[] { resources.GetString("GlassTypeListBox3.Items") });
            GlassTypeListBox3.Name = "GlassTypeListBox3";
            GlassTypeListBox3.Validating += GlassTypeListBox3_Validating;
            // 
            // LayerGrassListBox2
            // 
            resources.ApplyResources(LayerGrassListBox2, "LayerGrassListBox2");
            LayerGrassListBox2.FormattingEnabled = true;
            LayerGrassListBox2.Items.AddRange(new object[] { resources.GetString("LayerGrassListBox2.Items"), resources.GetString("LayerGrassListBox2.Items1") });
            LayerGrassListBox2.Name = "LayerGrassListBox2";
            LayerGrassListBox2.SelectedIndexChanged += LayerGrassListBox2_SelectedIndexChanged;
            // 
            // QuantityBox6
            // 
            resources.ApplyResources(QuantityBox6, "QuantityBox6");
            QuantityBox6.Name = "QuantityBox6";
            QuantityBox6.Validating += QuantityBox6_Validating;
            // 
            // HeigthBox4
            // 
            resources.ApplyResources(HeigthBox4, "HeigthBox4");
            HeigthBox4.Name = "HeigthBox4";
            // 
            // widthTextBox3
            // 
            resources.ApplyResources(widthTextBox3, "widthTextBox3");
            widthTextBox3.ForeColor = SystemColors.WindowText;
            widthTextBox3.Name = "widthTextBox3";
            widthTextBox3.Validating += widthTextBox3_Validating;
            // 
            // clientLastnameBox2
            // 
            resources.ApplyResources(clientLastnameBox2, "clientLastnameBox2");
            clientLastnameBox2.Name = "clientLastnameBox2";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.DarkGray;
            tabPage2.Controls.Add(button8);
            tabPage2.Controls.Add(ugoloklabel12);
            tabPage2.Controls.Add(germetiklabel11);
            tabPage2.Controls.Add(gellabel10);
            tabPage2.Controls.Add(prostoylabel9);
            tabPage2.Controls.Add(refYodlabel8);
            tabPage2.Controls.Add(zerkalolabel7);
            tabPage2.Controls.Add(refSaflabel6);
            tabPage2.Controls.Add(yodProstoylabel5);
            tabPage2.Controls.Add(YodTanirovkalabel4);
            tabPage2.Controls.Add(ramkalabel3);
            tabPage2.Controls.Add(textBox12);
            tabPage2.Controls.Add(textBox11);
            tabPage2.Controls.Add(textBox10);
            tabPage2.Controls.Add(textBox9);
            tabPage2.Controls.Add(textBox8);
            tabPage2.Controls.Add(textBox7);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(textBox3);
            resources.ApplyResources(tabPage2, "tabPage2");
            tabPage2.Name = "tabPage2";
            // 
            // button8
            // 
            resources.ApplyResources(button8, "button8");
            button8.BackColor = Color.MediumSeaGreen;
            button8.ForeColor = Color.White;
            button8.Name = "button8";
            button8.UseVisualStyleBackColor = false;
            // 
            // ugoloklabel12
            // 
            resources.ApplyResources(ugoloklabel12, "ugoloklabel12");
            ugoloklabel12.ForeColor = Color.Black;
            ugoloklabel12.Name = "ugoloklabel12";
            // 
            // germetiklabel11
            // 
            resources.ApplyResources(germetiklabel11, "germetiklabel11");
            germetiklabel11.ForeColor = Color.Black;
            germetiklabel11.Name = "germetiklabel11";
            // 
            // gellabel10
            // 
            resources.ApplyResources(gellabel10, "gellabel10");
            gellabel10.ForeColor = Color.Black;
            gellabel10.Name = "gellabel10";
            // 
            // prostoylabel9
            // 
            resources.ApplyResources(prostoylabel9, "prostoylabel9");
            prostoylabel9.ForeColor = Color.Black;
            prostoylabel9.Name = "prostoylabel9";
            // 
            // refYodlabel8
            // 
            resources.ApplyResources(refYodlabel8, "refYodlabel8");
            refYodlabel8.ForeColor = Color.Black;
            refYodlabel8.Name = "refYodlabel8";
            // 
            // zerkalolabel7
            // 
            resources.ApplyResources(zerkalolabel7, "zerkalolabel7");
            zerkalolabel7.ForeColor = Color.Black;
            zerkalolabel7.Name = "zerkalolabel7";
            // 
            // refSaflabel6
            // 
            resources.ApplyResources(refSaflabel6, "refSaflabel6");
            refSaflabel6.ForeColor = Color.Black;
            refSaflabel6.Name = "refSaflabel6";
            // 
            // yodProstoylabel5
            // 
            resources.ApplyResources(yodProstoylabel5, "yodProstoylabel5");
            yodProstoylabel5.ForeColor = Color.Black;
            yodProstoylabel5.Name = "yodProstoylabel5";
            // 
            // YodTanirovkalabel4
            // 
            resources.ApplyResources(YodTanirovkalabel4, "YodTanirovkalabel4");
            YodTanirovkalabel4.ForeColor = Color.Black;
            YodTanirovkalabel4.Name = "YodTanirovkalabel4";
            // 
            // ramkalabel3
            // 
            resources.ApplyResources(ramkalabel3, "ramkalabel3");
            ramkalabel3.ForeColor = Color.Black;
            ramkalabel3.Name = "ramkalabel3";
            // 
            // textBox12
            // 
            resources.ApplyResources(textBox12, "textBox12");
            textBox12.Name = "textBox12";
            // 
            // textBox11
            // 
            resources.ApplyResources(textBox11, "textBox11");
            textBox11.Name = "textBox11";
            // 
            // textBox10
            // 
            resources.ApplyResources(textBox10, "textBox10");
            textBox10.Name = "textBox10";
            // 
            // textBox9
            // 
            resources.ApplyResources(textBox9, "textBox9");
            textBox9.Name = "textBox9";
            // 
            // textBox8
            // 
            resources.ApplyResources(textBox8, "textBox8");
            textBox8.Name = "textBox8";
            // 
            // textBox7
            // 
            resources.ApplyResources(textBox7, "textBox7");
            textBox7.Name = "textBox7";
            // 
            // textBox6
            // 
            resources.ApplyResources(textBox6, "textBox6");
            textBox6.Name = "textBox6";
            // 
            // textBox5
            // 
            resources.ApplyResources(textBox5, "textBox5");
            textBox5.Name = "textBox5";
            // 
            // textBox4
            // 
            resources.ApplyResources(textBox4, "textBox4");
            textBox4.Name = "textBox4";
            // 
            // textBox3
            // 
            resources.ApplyResources(textBox3, "textBox3");
            textBox3.Name = "textBox3";
            textBox3.UseSystemPasswordChar = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView2);
            resources.ApplyResources(tabPage3, "tabPage3");
            tabPage3.Name = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            resources.ApplyResources(dataGridView2, "dataGridView2");
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, ramkaDataGridViewTextBoxColumn, ugolokDataGridViewTextBoxColumn, germetikDataGridViewTextBoxColumn, gelDataGridViewTextBoxColumn, prostoyDataGridViewTextBoxColumn, refYodDataGridViewTextBoxColumn, zerkaloDataGridViewTextBoxColumn, refSafDataGridViewTextBoxColumn, yodProstoyDataGridViewTextBoxColumn, yodTanirovkaDataGridViewTextBoxColumn });
            dataGridView2.DataSource = materialBindingSource;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 29;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            dataGridViewCellStyle1.BackColor = Color.White;
            idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(idDataGridViewTextBoxColumn, "idDataGridViewTextBoxColumn");
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ramkaDataGridViewTextBoxColumn
            // 
            ramkaDataGridViewTextBoxColumn.DataPropertyName = "Ramka";
            resources.ApplyResources(ramkaDataGridViewTextBoxColumn, "ramkaDataGridViewTextBoxColumn");
            ramkaDataGridViewTextBoxColumn.Name = "ramkaDataGridViewTextBoxColumn";
            ramkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ugolokDataGridViewTextBoxColumn
            // 
            ugolokDataGridViewTextBoxColumn.DataPropertyName = "Ugolok";
            resources.ApplyResources(ugolokDataGridViewTextBoxColumn, "ugolokDataGridViewTextBoxColumn");
            ugolokDataGridViewTextBoxColumn.Name = "ugolokDataGridViewTextBoxColumn";
            ugolokDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // germetikDataGridViewTextBoxColumn
            // 
            germetikDataGridViewTextBoxColumn.DataPropertyName = "Germetik";
            resources.ApplyResources(germetikDataGridViewTextBoxColumn, "germetikDataGridViewTextBoxColumn");
            germetikDataGridViewTextBoxColumn.Name = "germetikDataGridViewTextBoxColumn";
            germetikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gelDataGridViewTextBoxColumn
            // 
            gelDataGridViewTextBoxColumn.DataPropertyName = "Gel";
            resources.ApplyResources(gelDataGridViewTextBoxColumn, "gelDataGridViewTextBoxColumn");
            gelDataGridViewTextBoxColumn.Name = "gelDataGridViewTextBoxColumn";
            gelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prostoyDataGridViewTextBoxColumn
            // 
            prostoyDataGridViewTextBoxColumn.DataPropertyName = "Prostoy";
            resources.ApplyResources(prostoyDataGridViewTextBoxColumn, "prostoyDataGridViewTextBoxColumn");
            prostoyDataGridViewTextBoxColumn.Name = "prostoyDataGridViewTextBoxColumn";
            prostoyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // refYodDataGridViewTextBoxColumn
            // 
            refYodDataGridViewTextBoxColumn.DataPropertyName = "RefYod";
            resources.ApplyResources(refYodDataGridViewTextBoxColumn, "refYodDataGridViewTextBoxColumn");
            refYodDataGridViewTextBoxColumn.Name = "refYodDataGridViewTextBoxColumn";
            refYodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zerkaloDataGridViewTextBoxColumn
            // 
            zerkaloDataGridViewTextBoxColumn.DataPropertyName = "Zerkalo";
            resources.ApplyResources(zerkaloDataGridViewTextBoxColumn, "zerkaloDataGridViewTextBoxColumn");
            zerkaloDataGridViewTextBoxColumn.Name = "zerkaloDataGridViewTextBoxColumn";
            zerkaloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // refSafDataGridViewTextBoxColumn
            // 
            refSafDataGridViewTextBoxColumn.DataPropertyName = "RefSaf";
            resources.ApplyResources(refSafDataGridViewTextBoxColumn, "refSafDataGridViewTextBoxColumn");
            refSafDataGridViewTextBoxColumn.Name = "refSafDataGridViewTextBoxColumn";
            refSafDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yodProstoyDataGridViewTextBoxColumn
            // 
            yodProstoyDataGridViewTextBoxColumn.DataPropertyName = "YodProstoy";
            resources.ApplyResources(yodProstoyDataGridViewTextBoxColumn, "yodProstoyDataGridViewTextBoxColumn");
            yodProstoyDataGridViewTextBoxColumn.Name = "yodProstoyDataGridViewTextBoxColumn";
            yodProstoyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yodTanirovkaDataGridViewTextBoxColumn
            // 
            yodTanirovkaDataGridViewTextBoxColumn.DataPropertyName = "YodTanirovka";
            resources.ApplyResources(yodTanirovkaDataGridViewTextBoxColumn, "yodTanirovkaDataGridViewTextBoxColumn");
            yodTanirovkaDataGridViewTextBoxColumn.Name = "yodTanirovkaDataGridViewTextBoxColumn";
            yodTanirovkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materialBindingSource
            // 
            materialBindingSource.DataSource = typeof(Domain.Entity.Material);
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button7);
            tabPage4.Controls.Add(dataGridView3);
            resources.ApplyResources(tabPage4, "tabPage4");
            tabPage4.Name = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.BackColor = Color.SeaGreen;
            resources.ApplyResources(button7, "button7");
            button7.ForeColor = Color.White;
            button7.Name = "button7";
            button7.UseVisualStyleBackColor = false;
            // 
            // dataGridView3
            // 
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, Name, lastNameDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn });
            dataGridView3.DataSource = clientBindingSource;
            resources.ApplyResources(dataGridView3, "dataGridView3");
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 29;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            resources.ApplyResources(idDataGridViewTextBoxColumn1, "idDataGridViewTextBoxColumn1");
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // Name
            // 
            Name.DataPropertyName = "Name";
            resources.ApplyResources(Name, "Name");
            Name.Name = "Name";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            resources.ApplyResources(lastNameDataGridViewTextBoxColumn, "lastNameDataGridViewTextBoxColumn");
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            resources.ApplyResources(phoneNumberDataGridViewTextBoxColumn, "phoneNumberDataGridViewTextBoxColumn");
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // clientBindingSource
            // 
            clientBindingSource.DataSource = typeof(Domain.Entity.Client);
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(dataGridView4);
            resources.ApplyResources(tabPage5, "tabPage5");
            tabPage5.Name = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToOrderColumns = true;
            dataGridView4.AutoGenerateColumns = false;
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { Column7, Column8, Column9 });
            dataGridView4.DataSource = orderServiceBindingSource;
            resources.ApplyResources(dataGridView4, "dataGridView4");
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowTemplate.Height = 29;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "Id";
            resources.ApplyResources(Column7, "Column7");
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.DataPropertyName = "Name";
            resources.ApplyResources(Column8, "Column8");
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.DataPropertyName = "Status";
            resources.ApplyResources(Column9, "Column9");
            Column9.Name = "Column9";
            // 
            // orderServiceBindingSource
            // 
            orderServiceBindingSource.DataSource = typeof(Service.Implementations.OrderService);
            // 
            // materialBindingSource1
            // 
            materialBindingSource1.DataSource = typeof(Domain.Entity.Material);
            // 
            // clientServiceBindingSource
            // 
            clientServiceBindingSource.DataSource = typeof(Service.Implementations.ClientService);
            // 
            // orderBindingSource1
            // 
            orderBindingSource1.DataSource = typeof(Domain.Entity.Order);
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Domain.Entity.Order);
            // 
            // materialRepositoryBindingSource
            // 
            materialRepositoryBindingSource.DataSource = typeof(Dal.Repositories.MaterialRepository);
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // orderBindingSource2
            // 
            orderBindingSource2.DataSource = typeof(Domain.Entity.Order);
            // 
            // DataGridView
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            resources.ApplyResources(this, "$this");
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            SizeGripStyle = SizeGripStyle.Show;
            Load += DataGridView_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AddOrderdataGridView).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)materialBindingSource).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).EndInit();
            tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderServiceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)materialBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientServiceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)materialRepositoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлыToolStripMenuItem;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem печатьToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem редоктироватьToolStripMenuItem;
        private ToolStripMenuItem сбросНастроекToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox clientNameBox1;
        private System.Windows.Forms.DataGridView AddOrderdataGridView;
        private Button ExetButton;
        private Button SaveButton;
        private Button DeleteButton;
        private Button PrintButton;
        private Button CleanButton;
        private Button Addbutton;
        private ListBox GlassTypeListBox3;
        private ListBox LayerGrassListBox2;
        private TextBox QuantityBox6;
        private TextBox HeigthBox4;
        private TextBox widthTextBox3;
        private TextBox clientLastnameBox2;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private BindingSource materialRepositoryBindingSource;
        private BindingSource materialBindingSource;
        private TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private BindingSource clientBindingSource;
        private Button button7;
        private TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridView4;
        private BindingSource orderBindingSource;
        private BindingSource orderBindingSource1;
        private BindingSource clientServiceBindingSource;
        private BindingSource orderServiceBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private Button button8;
        private Label ugoloklabel12;
        private Label germetiklabel11;
        private Label gellabel10;
        private Label prostoylabel9;
        private Label refYodlabel8;
        private Label zerkalolabel7;
        private Label refSaflabel6;
        private Label yodProstoylabel5;
        private Label YodTanirovkalabel4;
        private Label ramkalabel3;
        private TextBox textBox12;
        private TextBox textBox11;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ramkaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ugolokDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn germetikDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn prostoyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn refYodDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn zerkaloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn refSafDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yodProstoyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yodTanirovkaDataGridViewTextBoxColumn;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private BindingSource materialBindingSource1;
        private Button Zafecserbutton;
        private BindingSource orderBindingSource2;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn lastNameColumn;
        private DataGridViewTextBoxColumn layerColumn;
        private DataGridViewTextBoxColumn quantityColumn;
        private DataGridViewTextBoxColumn typeColumn;
        private DataGridViewTextBoxColumn widthColumn;
        private DataGridViewTextBoxColumn heightColumn;
    }
}