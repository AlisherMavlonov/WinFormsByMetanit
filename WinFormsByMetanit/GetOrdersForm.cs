using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsByMetanit.Dal;
using WinFormsByMetanit.Dal.Interfaces;
using WinFormsByMetanit.Domain.Entity;
using WinFormsByMetanit.Domain.Enum;
using WinFormsByMetanit.Service.Interfaces;

namespace WinFormsByMetanit
{
    public partial class GetOrdersForm : Form
    {
        private readonly IOrderService _orderService;
        private readonly IClientService _clientService;
        private readonly IMaterialService _materialService;
        private readonly IUserService _userService;

        public GetOrdersForm(IOrderService orderService,
                             IClientService clientService,
                             IMaterialService materialService,
                             IUserService userService)
        {
            InitializeComponent();
            _orderService = orderService;
            _clientService = clientService;
            _materialService = materialService;
            _userService = userService;
        }

        private async void GetOrdersForm_Load(object sender, EventArgs e)
        {
            var response = await _orderService.GetOrders();
            var response1 = await _clientService.GetAllClients();
            var materials = await _materialService.GetMaterial();
            var users = await _userService.GetAllUser();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://metanit.com");
        }
    }
}
