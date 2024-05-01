using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsByMetanit.Dal.Interfaces;
using WinFormsByMetanit.Domain.Entity;
using WinFormsByMetanit.Domain.Response;
using WinFormsByMetanit.Domain.ViewModels.MaterialViewModel;
using WinFormsByMetanit.Service.Interfaces;

namespace WinFormsByMetanit.Service.Implementations
{
    public class MaterialService : IMaterialService
    {
        private readonly IMaterialRepository _materialRepository;
        public MaterialService(IMaterialRepository materialRepository)
        {
            _materialRepository = materialRepository;
        }

        public async Task<IBaseResponse<Material>> AddMaterial(PrihodMaterial prihodMaterial)
        {
            try
            {
                var addMaterial =  _materialRepository.AddMaterial(prihodMaterial);

                return new BaseResponse<Material>()
                {
                    Description = $"Успешно добавлен в БД",
                    StatusCode = Domain.Enum.StatusCode.Ok
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<Material>()
                {
                    Description = ex.Message,
                    StatusCode = Domain.Enum.StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<Material>> DeleteMaterial(RashodiMaterial rashodi)
        {
            try
            {
                await _materialRepository.RemoveMaterial(rashodi);

                return new BaseResponse<Material>()
                {
                    Description = $"Успешно удалено из БД",
                    StatusCode = Domain.Enum.StatusCode.Ok
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<Material>()
                {
                    Description = ex.Message,
                    StatusCode = Domain.Enum.StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<IEnumerable<Material>>> GetMaterial()
        {
            try
            {
                var materials = _materialRepository.GetAll();
                return new BaseResponse<IEnumerable<Material>>()
                {
                    Data = materials,
                    StatusCode = Domain.Enum.StatusCode.Ok,
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<Material>>()
                {
                    Description = ex.Message,
                    StatusCode = Domain.Enum.StatusCode.InternalServerError
                };
            }
        }
    }
}
