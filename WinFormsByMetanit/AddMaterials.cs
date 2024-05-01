using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsByMetanit.Domain.ViewModels.MaterialViewModel;
using WinFormsByMetanit.Service.Interfaces;

namespace WinFormsByMetanit
{
    public partial class AddMaterials : Form
    {
        private readonly IMaterialService _materialService;

        private Rectangle buttonOriginalRectanle;
        private Size originalFormSize;
        public AddMaterials(IMaterialService materialService)
        {
            InitializeComponent();
            _materialService = materialService;
            this.Resize += AddMaterial_Resize;
            originalFormSize = this.Size;
            buttonOriginalRectanle = new Rectangle(button1.Location, button1.Size);
        }
        private void AddMaterial_Resize(object sender, EventArgs e)
        {
            resizeControl(button1, buttonOriginalRectanle);
        }
        private void resizeControl(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(originalFormSize.Height);

            int newX = (int)(r.Width * xRatio);
            int newY = (int)(r.Height * yRatio);

            int newWidth = (int)(r.X * xRatio);
            int newHeight = (int)(r.Y * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var materials = new PrihodMaterial()
            {
                Gel = 10000,
                Germetik = 10000,
                Ramka = 500,
                Ugolok = 500,
                Prostoy = 1000,
                RefSaf = 1000,
                RefYod = 1000,
                YodProstoy = 1000,
                YodTanirovka = 1000,
                Zerkalo = 1000,
            };

            await _materialService.AddMaterial(materials);

        }
    }
}
