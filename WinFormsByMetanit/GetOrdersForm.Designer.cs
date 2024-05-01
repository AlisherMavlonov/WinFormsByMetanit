namespace WinFormsByMetanit
{
    partial class GetOrdersForm
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
            LinkLabel linkLabel1;
            orderBindingSource = new BindingSource(components);
            orderServiceBindingSource1 = new BindingSource(components);
            windowDbContextBindingSource = new BindingSource(components);
            orderServiceBindingSource = new BindingSource(components);
            windowDbContextBindingSource1 = new BindingSource(components);
            windowDbContextBindingSource2 = new BindingSource(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderServiceBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)windowDbContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderServiceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)windowDbContextBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)windowDbContextBindingSource2).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)clientsDataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ostatokSkladaDataGridView1).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(975, 422);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(203, 20);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "AlisherMavlonov@gmail.com";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Domain.Entity.Order);
            // 
            // orderServiceBindingSource1
            // 
            orderServiceBindingSource1.DataSource = typeof(Service.Implementations.OrderService);
            // 
            // windowDbContextBindingSource
            // 
            windowDbContextBindingSource.DataSource = typeof(Dal.WindowDbContext);
            // 
            // orderServiceBindingSource
            // 
            orderServiceBindingSource.DataSource = typeof(Service.Implementations.OrderService);
            // 
            // windowDbContextBindingSource1
            // 
            windowDbContextBindingSource1.DataSource = typeof(Dal.WindowDbContext);
            // 
            // windowDbContextBindingSource2
            // 
            windowDbContextBindingSource2.DataSource = typeof(Dal.WindowDbContext);
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1186, 480);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(linkLabel1);
            tabPage1.Controls.Add(ordersDataGridView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1178, 447);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Заказы";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ordersDataGridView1
            // 
            ordersDataGridView1.Dock = DockStyle.Fill;
            ordersDataGridView1.Location = new Point(3, 3);
            ordersDataGridView1.Name = "ordersDataGridView1";
            ordersDataGridView1.Size = new Size(1172, 441);
            ordersDataGridView1.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(clientsDataGridView2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1178, 447);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Клиенты";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // clientsDataGridView2
            // 
            clientsDataGridView2.Dock = DockStyle.Fill;
            clientsDataGridView2.Location = new Point(3, 3);
            clientsDataGridView2.Name = "clientsDataGridView2";
            clientsDataGridView2.Size = new Size(1172, 441);
            clientsDataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(ostatokSkladaDataGridView1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1178, 447);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Остаток Склада";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // ostatokSkladaDataGridView1
            // 
            ostatokSkladaDataGridView1.Dock = DockStyle.Fill;
            ostatokSkladaDataGridView1.Location = new Point(3, 3);
            ostatokSkladaDataGridView1.Name = "ostatokSkladaDataGridView1";
            ostatokSkladaDataGridView1.Size = new Size(1172, 441);
            ostatokSkladaDataGridView1.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dataGridView1);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1178, 447);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Пользователи";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1172, 441);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1178, 447);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // GetOrdersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 480);
            Controls.Add(tabControl1);
            Load += GetOrdersForm_Load;
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderServiceBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)windowDbContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderServiceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)windowDbContextBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)windowDbContextBindingSource2).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)clientsDataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ostatokSkladaDataGridView1).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ordersDataGridView1;
        private DataGridView clientsDataGridView2;
        private BindingSource orderServiceBindingSource;
        private BindingSource windowDbContextBindingSource;
        private BindingSource orderBindingSource;
        private ComboBox comboBox1;
        private BindingSource orderServiceBindingSource1;
        private BindingSource windowDbContextBindingSource1;
        private BindingSource windowDbContextBindingSource2;
        private DataGridViewTextBoxColumn IdClient;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewComboBoxColumn OrdersId;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DataGridView ostatokSkladaDataGridView1;
        private DataGridView dataGridView1;
        private TabPage tabPage5;
    }
}