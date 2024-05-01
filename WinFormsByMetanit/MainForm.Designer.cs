using WinFormsByMetanit.Domain.Entity;

namespace WinFormsByMetanit
{
    partial class MainForm
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
            materialBindingSource = new BindingSource(components);
            materialRepositoryBindingSource = new BindingSource(components);
            windowDbContextBindingSource = new BindingSource(components);
            userRepositoryBindingSource = new BindingSource(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            Users = new Button();
            Ckients = new Button();
            AddMaterial = new Button();
            GetMaterials = new Button();
            GetOrders = new Button();
            AddOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)materialBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)materialRepositoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)windowDbContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userRepositoryBindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // materialBindingSource
            // 
            materialBindingSource.DataSource = typeof(Material);
            // 
            // materialRepositoryBindingSource
            // 
            materialRepositoryBindingSource.DataSource = typeof(Dal.Repositories.MaterialRepository);
            // 
            // windowDbContextBindingSource
            // 
            windowDbContextBindingSource.DataSource = typeof(Dal.WindowDbContext);
            // 
            // userRepositoryBindingSource
            // 
            userRepositoryBindingSource.DataSource = typeof(Dal.Repositories.UserRepository);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(Users, 2, 1);
            tableLayoutPanel1.Controls.Add(Ckients, 1, 1);
            tableLayoutPanel1.Controls.Add(AddMaterial, 0, 1);
            tableLayoutPanel1.Controls.Add(GetMaterials, 2, 0);
            tableLayoutPanel1.Controls.Add(GetOrders, 1, 0);
            tableLayoutPanel1.Controls.Add(AddOrder, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0000076F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(661, 421);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.UseWaitCursor = true;
            // 
            // Users
            // 
            Users.Dock = DockStyle.Fill;
            Users.Location = new Point(443, 213);
            Users.Name = "Users";
            Users.Size = new Size(215, 204);
            Users.TabIndex = 5;
            Users.Text = "Пользователь";
            Users.UseVisualStyleBackColor = true;
            Users.UseWaitCursor = true;
            // 
            // Ckients
            // 
            Ckients.Dock = DockStyle.Fill;
            Ckients.Location = new Point(223, 213);
            Ckients.Name = "Ckients";
            Ckients.Size = new Size(214, 204);
            Ckients.TabIndex = 4;
            Ckients.Text = "Клиенты";
            Ckients.UseVisualStyleBackColor = true;
            Ckients.UseWaitCursor = true;
            // 
            // AddMaterial
            // 
            AddMaterial.Dock = DockStyle.Fill;
            AddMaterial.Location = new Point(3, 213);
            AddMaterial.Name = "AddMaterial";
            AddMaterial.Size = new Size(214, 204);
            AddMaterial.TabIndex = 3;
            AddMaterial.Text = "Приход материал";
            AddMaterial.UseVisualStyleBackColor = true;
            AddMaterial.UseWaitCursor = true;
            AddMaterial.Click += AddMaterial_Click;
            // 
            // GetMaterials
            // 
            GetMaterials.Dock = DockStyle.Fill;
            GetMaterials.Location = new Point(443, 3);
            GetMaterials.Name = "GetMaterials";
            GetMaterials.Size = new Size(215, 204);
            GetMaterials.TabIndex = 2;
            GetMaterials.Text = "Остаток материалов";
            GetMaterials.UseVisualStyleBackColor = true;
            GetMaterials.UseWaitCursor = true;
            // 
            // GetOrders
            // 
            GetOrders.Dock = DockStyle.Fill;
            GetOrders.Location = new Point(223, 3);
            GetOrders.Name = "GetOrders";
            GetOrders.Size = new Size(214, 204);
            GetOrders.TabIndex = 1;
            GetOrders.Text = "Смотреть заказы";
            GetOrders.UseVisualStyleBackColor = true;
            GetOrders.UseWaitCursor = true;
            // 
            // AddOrder
            // 
            AddOrder.Dock = DockStyle.Fill;
            AddOrder.Location = new Point(3, 3);
            AddOrder.Name = "AddOrder";
            AddOrder.Size = new Size(214, 204);
            AddOrder.TabIndex = 0;
            AddOrder.Text = "Добавить заказ";
            AddOrder.UseVisualStyleBackColor = true;
            AddOrder.UseWaitCursor = true;
            AddOrder.Click += AddOrder_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new Size(661, 421);
            Controls.Add(tableLayoutPanel1);
            HelpButton = true;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главный";
            TopMost = true;
            UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)materialBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)materialRepositoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)windowDbContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)userRepositoryBindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private BindingSource windowDbContextBindingSource;
        private BindingSource userRepositoryBindingSource;
        private BindingSource materialRepositoryBindingSource;
        private BindingSource materialBindingSource;
        private TableLayoutPanel tableLayoutPanel1;
        private Button Users;
        private Button Ckients;
        private Button AddMaterial;
        private Button GetMaterials;
        private Button GetOrders;
        private Button AddOrder;
    }
}