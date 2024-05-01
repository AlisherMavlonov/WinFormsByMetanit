using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsByMetanit.Domain.Entity;
using WinFormsByMetanit.Domain.ViewModels.MaterialViewModel;

namespace WinFormsByMetanit.Dal.Interfaces
{
    public interface IMaterialRepository : IBaseRepository<Material>
    {
        Task AddMaterial(PrihodMaterial prihodMaterial);
        Task RemoveMaterial(RashodiMaterial rashodi);
    }
}
