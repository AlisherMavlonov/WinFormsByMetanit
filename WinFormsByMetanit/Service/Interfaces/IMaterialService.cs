using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsByMetanit.Domain.Entity;
using WinFormsByMetanit.Domain.Response;
using WinFormsByMetanit.Domain.ViewModels.MaterialViewModel;

namespace WinFormsByMetanit.Service.Interfaces
{
    public interface IMaterialService
    {
        Task<IBaseResponse<Material>> AddMaterial(PrihodMaterial prihodMaterial);
        Task<IBaseResponse<Material>> DeleteMaterial(RashodiMaterial rashodi);
        Task<IBaseResponse<IEnumerable<Material>>> GetMaterial();
    }
}
