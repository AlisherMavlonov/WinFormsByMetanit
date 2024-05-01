using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsByMetanit.Domain.Entity;
using WinFormsByMetanit.Domain.Response;
using WinFormsByMetanit.Domain.ViewModels.MaterialViewModel;

namespace WinFormsByMetanit.Service.Interfaces
{
    public interface IOrderService
    {
        Task<IBaseResponse<RashodiMaterial>> CreateOrderPaket(Order order);
        Task<IBaseResponse<RashodiMaterial>> CreateOrderOdinar(Order order);
        Task<IBaseResponse<IEnumerable<Order>>> GetOrders();
        Task<IBaseResponse<bool>> DeleteOrder(int id);

        Task<IBaseResponse<Order>> UpdateOrder(Order order);
        Task<IBaseResponse<DataTable>> GetOrderDb();
    }
}
