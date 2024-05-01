using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsByMetanit
{
    public partial class TablControl : Form
    {
        public TablControl()
        {
            InitializeComponent();
        }

        //private void button6_Click(object sender, EventArgs e)
        //{
        //    MeExit();
        //}

        //private void MeExit()
        //{
        //    DialogResult iExet;

        //    iExet = MessageBox.Show("Подтвердите, усли вы хотите", "Сохранить Таблицу",
        //                            MessageBoxButtons.YesNo, MessageBoxIcon.Information);

        //    if (iExet == DialogResult.Yes)
        //    {
        //        Application.Exit();
        //    }
        //}

        //private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    MeExit();
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    dataGridView1.Rows.Add(clientNameBox1.Text, clientLastnameBox2.Text, LayerGrassListBox2.Text,
        //                            QuantityBox6.Text, GlassTypeListBox3.Text, widthTextBox3.Text, HeigthBox4.Text);


        //}

        //private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    dataGridView1.Rows.Add(clientNameBox1.Text, clientLastnameBox2.Text, LayerGrassListBox2.Text,
        //                            QuantityBox6.Text, GlassTypeListBox3.Text, widthTextBox3.Text, HeigthBox4.Text);
        //    int a = dataGridView1.Rows.Count;
        //}
        //private void iDelete()
        //{
        //    foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
        //    {
        //        dataGridView1.Rows.RemoveAt(item.Index);
        //    }

        //}
        //private void button4_Click(object sender, EventArgs e)
        //{
        //    iDelete();
        //}

        //private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    iDelete();
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    iReset();
        //}
        //private void iReset()
        //{
        //    //========================================Clears the Textbox=============================
        //    foreach (var c in this.Controls)
        //    {
        //        if (c is TextBox)
        //        {
        //            ((TextBox)c).Text = string.Empty;
        //        }

        //    }


        //    //========================================Clears the DataGridView========================
        //    int numRows = dataGridView1.Rows.Count;

        //    for (int i = 0; i < numRows; i++)
        //    {

        //        try
        //        {
        //            int max = dataGridView1.Rows.Count - 1;
        //            dataGridView1.Rows.Remove(dataGridView1.Rows[max]);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Все строки должны быть удалены" + ex, "DataGridView Delete",
        //                MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //}

        //private void сбросНастроекToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    iReset();
        //}

        //Bitmap bitmap;
        //private void button3_Click(object sender, EventArgs e)
        //{
        //    int height = dataGridView1.Height;
        //    dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
        //    bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
        //    dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
        //    printPreviewDialog1.PrintPreviewControl.Zoom = 1;
        //    printPreviewDialog1.ShowDialog();
        //    dataGridView1.Height = height;
        //}

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        //private void button5_Click(object sender, EventArgs e)
        //{
        //    ISave();
        //}

        //private void ISave()
        //{
        //    Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
        //    Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
        //    Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

        //    app.Visible = true;
        //    worksheet = workbook.Sheets["Лист1"];
        //    worksheet = workbook.ActiveSheet;
        //    worksheet.Name = "Exported from gridView";

        //    for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
        //    {
        //        worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
        //    }

        //    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
        //    {
        //        for (int j = 0; j < dataGridView1.Columns.Count; j++)
        //        {
        //            worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
        //        }

        //    }


        //}

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ISave();
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            dataGridView1.Height = height;
        }

        private void DataGridView_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(clientNameBox1.Text, clientLastnameBox2.Text, LayerGrassListBox2.Text,
                                   QuantityBox6.Text, GlassTypeListBox3.Text, widthTextBox3.Text, HeigthBox4.Text);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            iReset();
        }
        private void iReset()
        {
            //========================================Clears the Textbox=============================
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }

            }


            //========================================Clears the DataGridView========================
            int numRows = dataGridView1.Rows.Count;

            for (int i = 0; i < numRows; i++)
            {

                try
                {
                    int max = dataGridView1.Rows.Count - 1;
                    dataGridView1.Rows.Remove(dataGridView1.Rows[max]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Все строки должны быть удалены" + ex, "DataGridView Delete",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        Bitmap bitmap;
        private void button3_Click_1(object sender, EventArgs e)
        {
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            dataGridView1.Height = height;
        }
        private void iDelete()
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }

        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            iDelete();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iDelete();
        }

        private void button5_Click_1(object sender, EventArgs e)
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

            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }

            }


        }

        private void button6_Click_1(object sender, EventArgs e)
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
    }
}
