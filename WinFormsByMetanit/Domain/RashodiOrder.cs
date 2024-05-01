using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsByMetanit.Domain.Entity;
using WinFormsByMetanit.Domain.Enum;
using WinFormsByMetanit.Domain.ViewModels.MaterialViewModel;

namespace WinFormsByMetanit.Domain
{
    public static class RashodiOrder
    {
        
        const int Square = 1;
        const int Ramka = 4;
        const int Germetic = 120;
        const int Gel = 100;
        const int Ugalok = 4;

        public static RashodiMaterial Paket(List<OrderDetails> orderDetails)
        {
            RashodiMaterial rashodi = new RashodiMaterial();
            foreach (var orderDetail in orderDetails)
            {
                var squareOrder = (orderDetail.Heigth * orderDetail.Width) * orderDetail.Quantity;

                switch (orderDetail.GlassTypePaket)
                {
                    case GlassTypePaket.Prostoy: rashodi.Prostoy += squareOrder * 2;
                        break;

                    case GlassTypePaket.RefYod: rashodi.Prostoy += squareOrder; rashodi.RefYod += squareOrder;
                        break;

                    case GlassTypePaket.RefYodZerkalo: rashodi.RefYod += squareOrder; rashodi.Zerkalo += squareOrder;
                        break;

                    case GlassTypePaket.RefSaf: rashodi.Prostoy += squareOrder; rashodi.RefSaf += squareOrder;
                        break;

                    case GlassTypePaket.RefSafZerkalo: rashodi.RefSaf += squareOrder; rashodi.Zerkalo += squareOrder;
                        break;

                    case GlassTypePaket.YodProstoy: rashodi.Prostoy += squareOrder; rashodi.YodProstoy += squareOrder;
                        break;

                    case GlassTypePaket.YodTanirovka: rashodi.Prostoy += squareOrder; rashodi.YodTanirovka += squareOrder;
                        break;

                    case GlassTypePaket.ZerkaloZerkalo: rashodi.Zerkalo += squareOrder * 2;
                        break;

                    default:
                        break;
                }

                rashodi.Ramka += Ramka * orderDetail.Quantity;
                rashodi.Germetik += Germetic * squareOrder;
                rashodi.Gel += Gel * squareOrder;
                rashodi.Ugolok += Ugalok * orderDetail.Quantity;
            }
            return rashodi;
        }
        public static RashodiMaterial Odinar(List<OrderDetails> orderDetails)
        {
            RashodiMaterial rashodi = new RashodiMaterial();
            foreach (var orderDetail in orderDetails)
            {
                var squareOrder = (orderDetail.Heigth * orderDetail.Width) * orderDetail.Quantity;
                switch (orderDetail.GlassTypeOdinar)
                {
                    case Enum.GlassTypeOdinar.Prostoy:
                        rashodi.Prostoy += squareOrder;
                        break;

                    case Enum.GlassTypeOdinar.RefYod:
                        rashodi.RefYod += squareOrder;
                        break;

                    case Enum.GlassTypeOdinar.RefSaf:
                        rashodi.RefSaf += squareOrder;
                        break;

                    case Enum.GlassTypeOdinar.YodProstoy:
                        rashodi.YodProstoy += squareOrder;
                        break;

                    case Enum.GlassTypeOdinar.YodTanirovka:
                        rashodi.YodTanirovka += squareOrder;
                        break;

                    case Enum.GlassTypeOdinar.Zerkalo:
                        rashodi.Zerkalo += squareOrder;
                        break;

                    default:
                        break;
                }
            }
            return rashodi;
        }
    }
}
