using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WinFormsByMetanit.Dal.Interfaces;
using WinFormsByMetanit.Domain.Entity;
using WinFormsByMetanit.Domain.Response;
using WinFormsByMetanit.Service.Interfaces;

namespace WinFormsByMetanit.Service.Implementations
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<IBaseResponse<Client>> AddClient(Client newClient)
        {
            try
            {

                var client = await _clientRepository.GetAll().FirstOrDefaultAsync(x => x.Name == newClient.Name
                && x.LastName == newClient.LastName && x.PhoneNumber == newClient.PhoneNumber);

                if (client != null)
                {
                    return new BaseResponse<Client>()
                    {
                        Description = $"В Базе уже есть клиент с таким данных",
                        StatusCode = Domain.Enum.StatusCode.ClientAlreadyExists
                    };
                }
                client = new Client()
                {
                    LastName = newClient.LastName,
                    Name = newClient.Name,
                    PhoneNumber = newClient.PhoneNumber,
                };

                await _clientRepository.Create(client);

                return new BaseResponse<Client>()
                {
                    Data = client,
                    Description = $"{client.Name} успешно довален в БД",
                    StatusCode = Domain.Enum.StatusCode.Ok
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<Client>()
                {
                    Description = ex.Message,
                    StatusCode = Domain.Enum.StatusCode.InternalServerError
                };
            }
        }

        public Task<IBaseResponse<Client>> DeleteClient(int id)
        {
            throw new NotImplementedException();
        }

        public async Task <IBaseResponse<IEnumerable<Client>>> GetAllClients()
        {
            try
            {
                var clients = _clientRepository.GetAll();
                if (clients == null)
                {
                    return new BaseResponse<IEnumerable<Client>>()
                    {
                        Description = $"В БД 0 Элементов",
                        StatusCode = Domain.Enum.StatusCode.ClientNotFaund
                    };
                }

                return new BaseResponse<IEnumerable<Client>>()
                {
                    Data = clients,
                    StatusCode = Domain.Enum.StatusCode.Ok
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<Client>>()
                {
                    Description = ex.Message,
                    StatusCode = Domain.Enum.StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<Client>> GetClient(string Name, string LastName)
        {
            try
            {
                var client = _clientRepository.GetAll().FirstOrDefault(x=>x.Name == Name
                && x.LastName == LastName);

                if (client == null)
                {
                    return new BaseResponse<Client>()
                    {
                        Description = $"В БД нет клиент с таким данным",
                        StatusCode = Domain.Enum.StatusCode.ClientNotFaund
                    };
                }
                return new BaseResponse<Client>()
                {
                    Data = client,
                    StatusCode = Domain.Enum.StatusCode.Ok
                };

            }
            catch (Exception ex)
            {
                return new BaseResponse<Client>()
                {
                    Description = ex.Message,
                    StatusCode = Domain.Enum.StatusCode.InternalServerError
                };
            }
        }

        public Task<IBaseResponse<Client>> UpdateClient(Client updateClient)
        {
            throw new NotImplementedException();
        }
    }
}
