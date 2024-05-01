using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsByMetanit.Dal.Interfaces;
using WinFormsByMetanit.Domain;
using WinFormsByMetanit.Domain.Entity;
using WinFormsByMetanit.Domain.Enum;
using WinFormsByMetanit.Domain.Extensions;
using WinFormsByMetanit.Domain.ViewModels.MaterialViewModel;
using WinFormsByMetanit.Service.Interfaces;

namespace WinFormsByMetanit
{
    public partial class AddOrderForm : Form
    {
        private readonly IOrderService _orderService;
        private readonly IClientService _clientService;
        private readonly IMaterialService _materialService;
        private readonly List<OrderDetails> _orderDetailsList;
        public AddOrderForm(IOrderService orderService, IClientService clientService, IMaterialService materialService)
        {
            InitializeComponent();
            _orderService = orderService;
            _clientService = clientService;
            _materialService = materialService;
            _orderDetailsList = new();

        }
        //        Простой
        //Рефленный йодовый
        //Рефленный сафед
        //Йодовый простой
        //Йодовый танировка
        //Рефленный йодовый зеркало
        //        Рефленный сафед зеркало
        //        Зеркало зеркало

        private async void button1_Click(object sender, EventArgs e)
        {
            //var materials = new PrihodMaterial()
            //{
            //    Gel = 10000,
            //    Germetik = 10000,
            //    Ramka = 500,
            //    Ugolok = 500,
            //    Prostoy = 1000,
            //    RefSaf = 1000,
            //    RefYod = 1000,
            //    YodProstoy = 1000,
            //    YodTanirovka = 1000,
            //    Zerkalo = 1000,
            //};

            //await _materialService.AddMaterial(materials);
            //var client1 = new Client()
            //{
            //    LastName = "Mavlonov",
            //    Name = "Alisher",
            //    PhoneNumber = "928957799",

            //};
            //await _clientService.AddClient(client1);

            var clientName = clientNameBox1.Text;
            var lastName = clientLastnameBox2.Text;
            var client = await _clientService.GetClient(clientName, lastName);
            if (client.StatusCode != StatusCode.Ok)
            {
                textBox3.Text = client.Description;
            }
            else
            {
                var order = new Order()
                {
                    StatusOrder = StatusOrder.notReady,
                    Client = client.Data,
                    ClientId = client.Data.Id

                };

                LayerGrass layerGrass = Enum.GetValues(typeof(LayerGrass))
                .Cast<LayerGrass>()
                .FirstOrDefault(c => c.GetType()
                    .GetMember(c.ToString())[0]
                    .GetCustomAttribute<DisplayAttribute>()
                    ?.Name == LayerGrassListBox2.Text);

                GlassTypePaket typeGlassPaket = Enum.GetValues(typeof(GlassTypePaket))
                .Cast<GlassTypePaket>()
                .FirstOrDefault(c => c.GetType()
                    .GetMember(c.ToString())[0]
                    .GetCustomAttribute<DisplayAttribute>()
                    ?.Name == GlassTypeListBox3.Text);

                GlassTypeOdinar typeGlassOdinar = Enum.GetValues(typeof(GlassTypeOdinar))
                .Cast<GlassTypeOdinar>()
                .FirstOrDefault(c => c.GetType()
                    .GetMember(c.ToString())[0]
                    .GetCustomAttribute<DisplayAttribute>()
                    ?.Name == GlassTypeListBox3.Text);


                var orderDetail = new OrderDetails()
                {

                    GlassTypeOdinar = typeGlassOdinar,
                    GlassTypePaket = typeGlassPaket,
                    Width = Convert.ToInt32(widthTextBox3.Text),
                    Heigth = Convert.ToInt32(HeigthBox4.Text),
                    Quantity = Convert.ToInt32(QuantityBox6.Text),

                };


                //order.OrderDetails.Add(orderDetail);
                order.OrderDetails.AddRange(_orderDetailsList);
                //orderDetail.Order = order;

                if (orderDetail.LayerGrass == LayerGrass.TwoLayer)
                {
                    var response = await _orderService.CreateOrderPaket(order);

                    if (response.StatusCode == StatusCode.Ok)
                    {
                        textBox3.Text = $"{response.Data.Ramka} Ramka, {response.Data.Ugolok} Ugolok, {response.Data.Gel} Gel, " +
                            $"{response.Data.Germetik} Germetic, {response.Data.Prostoy} Prostoy, {response.Data.RefYod} RefYod ";
                    }

                    else
                    {
                        textBox3.Text = response.Description;
                    }
                }

                if (orderDetail.LayerGrass == LayerGrass.Single)
                {
                    var response = await _orderService.CreateOrderOdinar(order);

                    if (response.StatusCode == StatusCode.Ok)
                    {
                        textBox3.Text = $"{response.Data.Ramka} Ramka, {response.Data.Ugolok} Ugolok, {response.Data.Gel} Gel, " +
                            $"{response.Data.Germetik} Germetic ";
                    }

                    else
                    {
                        textBox3.Text = response.Description;
                    }
                }
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var clientName = clientNameBox1.Text;
            var lastName = clientLastnameBox2.Text;
            var client = await _clientService.GetClient(clientName, lastName);

            if (client.StatusCode != StatusCode.Ok)
            {
                textBox3.Text = client.Description;
            }
            else
            {
                LayerGrass layerGrass = Enum.GetValues(typeof(LayerGrass))
                .Cast<LayerGrass>()
                .FirstOrDefault(c => c.GetType()
                    .GetMember(c.ToString())[0]
                    .GetCustomAttribute<DisplayAttribute>()
                    ?.Name == LayerGrassListBox2.Text);

                if (layerGrass == LayerGrass.Single)
                {
                    GlassTypeOdinar typeGlassOdinar1 = Enum.GetValues(typeof(GlassTypeOdinar))
                .Cast<GlassTypeOdinar>()
                .FirstOrDefault(c => c.GetType()
                    .GetMember(c.ToString())[0]
                    .GetCustomAttribute<DisplayAttribute>()
                    ?.Name == GlassTypeListBox3.Text);


                    var orderDetail1 = new OrderDetails()
                    {

                        GlassTypeOdinar = typeGlassOdinar1,
                        GlassTypePaket = null,
                        Width = Convert.ToInt32(widthTextBox3.Text),
                        Heigth = Convert.ToInt32(HeigthBox4.Text),
                        Quantity = Convert.ToInt32(QuantityBox6.Text),
                        LayerGrass = layerGrass,

                    };

                    _orderDetailsList.Add(orderDetail1);
                    textBox3.Text = $"Заказ добавлен в корзину! В корзине {_orderDetailsList.Count} заказов";
                }
                else
                {

                    GlassTypePaket typeGlassPaket = Enum.GetValues(typeof(GlassTypePaket))
                    .Cast<GlassTypePaket>()
                    .FirstOrDefault(c => c.GetType()
                        .GetMember(c.ToString())[0]
                        .GetCustomAttribute<DisplayAttribute>()
                        ?.Name == GlassTypeListBox3.Text);

                    var orderDetail = new OrderDetails()
                    {

                        GlassTypePaket = typeGlassPaket,
                        GlassTypeOdinar = null,
                        Width = Convert.ToInt32(widthTextBox3.Text),
                        Heigth = Convert.ToInt32(HeigthBox4.Text),
                        Quantity = Convert.ToInt32(QuantityBox6.Text),
                        LayerGrass = layerGrass,

                    };

                    _orderDetailsList.Add(orderDetail);

                    textBox3.Text = $"Заказ добавлен в корзину! В корзине {_orderDetailsList.Count} заказов";
                }
            }
        }

        private void listBox1_DataSourceChanged(object sender, EventArgs e)
        {
            var d = new OrderDetails()
            {
                Heigth = 1,
                Width = 2,
                GlassTypePaket = GlassTypePaket.Prostoy

            };
            _orderDetailsList.Add(d);
        }
    }
}
