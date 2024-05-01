using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsByMetanit.Service.Implementations;
using WinFormsByMetanit.Service.Interfaces;

namespace WinFormsByMetanit
{
    public partial class MainForm : Form
    {
        private readonly IOrderService _orderService;
        private readonly IClientService _clientService;
        private readonly IMaterialService _materialService;
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddOrder_Click(object sender, EventArgs e)
        {
            AddOrderForm addOrderForm = new AddOrderForm(_orderService, _clientService, _materialService);
            addOrderForm.Show();
        }

        private void AddMaterial_Click(object sender, EventArgs e)
        {
            AddMaterials addMaterial = new AddMaterials(_materialService);
            addMaterial.Show();
        }
    }
}
