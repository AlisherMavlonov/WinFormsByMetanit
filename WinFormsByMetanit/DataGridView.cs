using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WinFormsByMetanit.Domain.Entity;
using WinFormsByMetanit.Domain.Enum;
using WinFormsByMetanit.Domain.Extensions;
using WinFormsByMetanit.Domain.ViewModels.MaterialViewModel;
using WinFormsByMetanit.Service.Interfaces;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsByMetanit
{
    public partial class DataGridView : Form
    {
        private readonly IMaterialService _materialService;
        private readonly IClientService _clientService;
        private readonly IOrderService _orderService;
        private List<Order> orders;
        
        public DataGridView(IMaterialService materialService, IClientService clientService, IOrderService orderService)
        {
            InitializeComponent();
            _materialService = materialService;
            _clientService = clientService;
            _orderService = orderService;
            orders = new List<Order>();
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        private async void ExetButton_Click_1(object sender, EventArgs e)
        {
            MeExit();
        }

        private void MeExit()
        {
            DialogResult iExet;

            iExet = MessageBox.Show("Подтвердите, усли вы хотите", "Сохранить Таблицу",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (iExet == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private async void Addbutton_Click_1(object sender, EventArgs e)
        {

            if (AddOrderdataGridView.Rows.Count > 0)
            {
                var orderDatails = new List<OrderDetails>();
                var newOrder = new Order();

                for (int i = 0; i < AddOrderdataGridView.Rows.Count + 1; i++)
                {
                    var row = AddOrderdataGridView.Rows[i];

                    var name = row.Cells["nameColumn"].Value.ToString();
                    var lastName = row.Cells["lastNameColumn"].Value.ToString();
                    var client = await _clientService.GetClient(name, lastName);
                    var layerGrass = (row.Cells["layerColumn"].ToString()).GetEnumValueByDisplayName();
                    var typeGlass = (row.Cells["typeColumn"].ToString()).GetEnumValueByDisplayName().ToString();

                    var datail = new OrderDetails()
                    {
                        Width = Convert.ToInt32(row.Cells["widthColumn"].Value.ToString()),
                        Heigth = Convert.ToInt32(row.Cells["heightColumn"].Value.ToString()),
                        Quantity = Convert.ToInt32(row.Cells["quantityColumn"].Value.ToString()),
                        LayerGrass = layerGrass,
                        //GlassTypeOdinar = ,
                        //GlassTypePaket = typeGlass,

                    };
                    if (datail.LayerGrass == LayerGrass.TwoLayer)
                    {
                        datail.GlassTypeOdinar = null;
                    }
                    orderDatails.Add(datail);
                    newOrder.StatusOrder = StatusOrder.notReady;
                    newOrder.OrderDetails = orderDatails;
                    newOrder.Client = client.Data;


                };

            }
            else
            {
                MessageBox.Show("Сначало зафексируйте заказ!!!");
            }
        }
        private void DeleteButton_Click_1(object sender, EventArgs e)
        {
            iDelete();
        }
        private void iDelete()
        {
            foreach (DataGridViewRow item in this.AddOrderdataGridView.SelectedRows)
            {
                AddOrderdataGridView.Rows.RemoveAt(item.Index);
            }

        }
        private void CleanButton_Click_1(object sender, EventArgs e)
        {
            iReset();
        }
        private void iReset()
        {
            //========================================Clears the Textbox=============================
            foreach (TabPage tabPage in tabControl1.Controls)
            {
                foreach (var c in tabPage.Controls)
                {

                    if (c is System.Windows.Forms.TextBox)
                    {
                        ((System.Windows.Forms.TextBox)c).Text = string.Empty;
                    }
                }
            }


            //========================================Clears the DataGridView========================
            int numRows = AddOrderdataGridView.Rows.Count;

            for (int i = 0; i < numRows; i++)
            {

                try
                {
                    int max = AddOrderdataGridView.Rows.Count - 1;
                    AddOrderdataGridView.Rows.Remove(AddOrderdataGridView.Rows[max]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Все строки должны быть удалены" + ex, "DataGridView Delete",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        Bitmap bitmap;
        private void PrintButton_Click_1(object sender, EventArgs e)
        {
            int height = AddOrderdataGridView.Height;
            AddOrderdataGridView.Height = AddOrderdataGridView.RowCount * AddOrderdataGridView.RowTemplate.Height * 2;
            bitmap = new Bitmap(AddOrderdataGridView.Width, AddOrderdataGridView.Height);
            AddOrderdataGridView.DrawToBitmap(bitmap, new Rectangle(0, 0, AddOrderdataGridView.Width, AddOrderdataGridView.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            AddOrderdataGridView.Height = height;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            ISave();
        }

        private void ISave()
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            app.Visible = true;
            worksheet = workbook.Sheets["Лист1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Exported from gridView";

            for (int i = 1; i < AddOrderdataGridView.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = AddOrderdataGridView.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < AddOrderdataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < AddOrderdataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = AddOrderdataGridView.Rows[i].Cells[j].Value.ToString();
                }

            }
        }
        private async void DataGridView_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            if (LayerGrassListBox2.Text == "")
            {
                GlassTypeListBox3.ForeColor = Color.Red;
                GlassTypeListBox3.Items.Add("Укажите Слой Стекло");

            }

            var materials = await _materialService.GetMaterial();
            dataGridView2.DataSource = materials.Data.ToList();

            var clients = await _clientService.GetAllClients();
            dataGridView3.DataSource = clients.Data.ToList();

            var orders = await _orderService.GetOrders();
            var ordersView = orders.Data.Select(x => new
            {
                Id = x.Id,
                Name = x.Client.Name,
                Status = x.StatusOrder.GetDisplayName(),
            });
            dataGridView4.DataSource = ordersView.ToList();
        }

        private void widthTextBox3_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(widthTextBox3.Text))
            {
                e.Cancel = true;
                widthTextBox3.Focus();
                errorProvider1.SetError(widthTextBox3, "Поле обязательно для заполнения.");
            }
            else if (!isNumeric(widthTextBox3.Text))
            {
                e.Cancel = true;
                widthTextBox3.Focus();
                errorProvider1.SetError(widthTextBox3, "В поле должен быть только положительные цифры.");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(widthTextBox3, "");
            }
        }
        private void QuantityBox6_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider2 = new ErrorProvider();
            if (string.IsNullOrEmpty(QuantityBox6.Text))
            {
                e.Cancel = true;
                QuantityBox6.Focus();
                errorProvider2.SetError(QuantityBox6, "Поле обязательно для заполнения.");
            }
            else if (!isNumeric(QuantityBox6.Text))
            {
                e.Cancel = true;
                QuantityBox6.Focus();
                errorProvider2.SetError(QuantityBox6, "В поле должен быть только положительные цифры.");
            }

            else
            {
                e.Cancel = false;
                errorProvider2.SetError(QuantityBox6, "");
            }
        }
        private bool isNumeric(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private async void Zafecserbutton_Click(object sender, EventArgs e)
        {
            if (GlassTypeListBox3.Text != "" && LayerGrassListBox2.Text != ""
                && widthTextBox3.Text != "" && HeigthBox4.Text != "" && QuantityBox6.Text != "")
            {

                var clientName = clientNameBox1.Text;
                var lastName = clientLastnameBox2.Text;
                var response = await _clientService.GetClient(clientName, lastName);
                if (response.StatusCode != StatusCode.Ok)
                {
                    DialogResult iExet;

                    iExet = MessageBox.Show("Нет Клиент с таким Данным В БД!!! Для добавление клиента нажмите OK", "Сохранить клиента",
                                            MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (iExet == DialogResult.OK)
                    {
                        var client1 = new Client()
                        {
                            LastName = lastName,
                            Name = clientName,

                        };
                        await _clientService.AddClient(client1);
                    }
                }
                else
                {
                    AddOrderdataGridView.Rows.Add(clientNameBox1.Text, clientLastnameBox2.Text, LayerGrassListBox2.Text,
                                            QuantityBox6.Text, GlassTypeListBox3.Text, widthTextBox3.Text, HeigthBox4.Text);
                }

            }

            else
            {
                MessageBox.Show("Вся поля должен быть заполнен");
            }
        }

        private void LayerGrassListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var paketTypeGlass = new List<string>()
            {
               "Простой", "Рефленный йодовый", "Рефленный сафед", "Йодовый простой", "Йодовый танировка",
               "Рефленный йодовый зеркало", "Рефленный сафед зеркало", "Зеркало зеркало"
            };
            var odinarTypeGlass = new List<string>()
            {
               "Простой", "Рефленный сафед", "Йодовый простой",
               "Рефленный йодовый", "Рефленный сафед", "Зеркало"
            };

            if (LayerGrassListBox2.Text == "Пакет")
            {
                GlassTypeListBox3.ForeColor = Color.Black;
                GlassTypeListBox3.Items.Clear();
                foreach (var item in paketTypeGlass)
                {
                    GlassTypeListBox3.Items.Add(item);
                }

            }
            if (LayerGrassListBox2.Text == "Одинар")
            {
                GlassTypeListBox3.ForeColor = Color.Black;
                GlassTypeListBox3.Items.Clear();
                foreach (var item in odinarTypeGlass)
                {
                    GlassTypeListBox3.Items.Add(item);
                }
            }
            if (LayerGrassListBox2.Text == "")
            {
                GlassTypeListBox3.ForeColor = Color.Red;

                GlassTypeListBox3.Items.Clear();
                GlassTypeListBox3.Items.Add("Укажите Слой Стекло");
            }
        }

        private void GlassTypeListBox3_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider errorProvider1 = new ErrorProvider();
            if (string.IsNullOrEmpty(GlassTypeListBox3.Text))
            {
                e.Cancel = true;
                GlassTypeListBox3.Focus();
                errorProvider1.SetError(GlassTypeListBox3, "Поле обязательно для заполнения.");
            }

        }
    }
}
