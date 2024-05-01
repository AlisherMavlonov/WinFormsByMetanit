using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsByMetanit.Dal.Interfaces;
using WinFormsByMetanit.Domain;
using WinFormsByMetanit.Domain.Entity;
using WinFormsByMetanit.Domain.Enum;
using WinFormsByMetanit.Domain.Extensions;
using WinFormsByMetanit.Domain.Response;
using WinFormsByMetanit.Domain.ViewModels.MaterialViewModel;
using WinFormsByMetanit.Service.Interfaces;

namespace WinFormsByMetanit.Service.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderDatailsRepository _orderDatailRepository;
        private readonly IClientService _clientService;
        private readonly IMaterialService _materialService;

        public OrderService(IOrderRepository orderRepository,
                            IOrderDatailsRepository orderDatailRepository, 
                            IClientService clientService,
                            IMaterialService materialService)
        {
            _orderRepository = orderRepository;
            _orderDatailRepository = orderDatailRepository;
            _clientService = clientService;
            _materialService = materialService;
        }

        public async Task<IBaseResponse<RashodiMaterial>> CreateOrderOdinar(Order order)
        {
            try
            {
                await _orderRepository.Create(order);

                var rashodi = RashodiOrder.Odinar(order.OrderDetails);

                await _materialService.DeleteMaterial(rashodi);

                return new BaseResponse<RashodiMaterial>()
                {
                    Data = rashodi,
                    StatusCode = Domain.Enum.StatusCode.Ok
                };

            }
            catch (Exception ex)
            {
                return new BaseResponse<RashodiMaterial>()
                {
                    Description = ex.Message,
                    StatusCode = Domain.Enum.StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<RashodiMaterial>> CreateOrderPaket(Order order)
        {
            try
            {
                await _orderRepository.Create(order);

                    var rashodi = RashodiOrder.Paket(order.OrderDetails);

                    await _materialService.DeleteMaterial(rashodi);

                    return new BaseResponse<RashodiMaterial>()
                    {
                        Data = rashodi,
                        StatusCode = Domain.Enum.StatusCode.Ok
                    };

            }
            catch (Exception ex)
            {
                return new BaseResponse<RashodiMaterial>()
                {
                    Description = ex.Message,
                    StatusCode = Domain.Enum.StatusCode.InternalServerError
                };
            }
        }

        public Task<IBaseResponse<bool>> DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IBaseResponse<DataTable>> GetOrderDb()
        {
            throw new NotImplementedException();
        }

        public async Task<IBaseResponse<IEnumerable<Order>>> GetOrders()
        {
            try
            {
                var orders = _orderRepository.GetAll().Include(x=>x.Client);

                return new BaseResponse<IEnumerable<Order>>()
                {
                    Data = orders,
                    StatusCode = Domain.Enum.StatusCode.Ok
                };
            }

            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<Order>>()
                {
                    Description = ex.Message,
                    StatusCode = Domain.Enum.StatusCode.InternalServerError
                };
            }

        }

        public Task<IBaseResponse<Order>> UpdateOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
