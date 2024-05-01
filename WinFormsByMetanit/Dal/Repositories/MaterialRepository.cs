using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsByMetanit.Dal.Interfaces;
using WinFormsByMetanit.Domain.Entity;
using WinFormsByMetanit.Domain.ViewModels.MaterialViewModel;

namespace WinFormsByMetanit.Dal.Repositories
{
    public class MaterialRepository : IMaterialRepository
    {
        private readonly WindowDbContext db;

        public MaterialRepository(WindowDbContext context)
        {
            db = context;
        }

        public async Task AddMaterial(PrihodMaterial prihodMaterial)
        {
            var octatocMaterial = db.Materials.FirstOrDefault(x => x.Id.Equals(1));
            if (octatocMaterial == null)
            {
                octatocMaterial = new Material()
                {
                    Gel = prihodMaterial.Gel,
                    Germetik = prihodMaterial.Germetik,
                    Ramka = prihodMaterial.Ramka,
                    Ugolok = prihodMaterial.Ugolok,
                    Prostoy = prihodMaterial.Prostoy,
                    RefSaf = prihodMaterial.RefSaf,
                    RefYod = prihodMaterial.RefYod,
                    YodProstoy = prihodMaterial.YodProstoy,
                    YodTanirovka = prihodMaterial.YodTanirovka,
                    Zerkalo = prihodMaterial.Zerkalo
                };
                await db.Materials.AddAsync(octatocMaterial);
                await db.SaveChangesAsync();
            }
            else
            {
                octatocMaterial.Ugolok += prihodMaterial.Ugolok;
                octatocMaterial.Ramka += prihodMaterial.Ramka;
                octatocMaterial.Germetik += prihodMaterial.Germetik;
                octatocMaterial.Gel += prihodMaterial.Gel;
                octatocMaterial.Prostoy += prihodMaterial.Prostoy;
                octatocMaterial.RefYod += prihodMaterial.RefSaf;
                octatocMaterial.Zerkalo += prihodMaterial.Zerkalo;
                octatocMaterial.RefSaf += prihodMaterial.RefSaf;
                octatocMaterial.YodProstoy += prihodMaterial.YodProstoy;
                octatocMaterial.YodTanirovka += prihodMaterial.YodTanirovka;

                await db.SaveChangesAsync();
            }

        }
        public async Task RemoveMaterial(RashodiMaterial rashodi)
        {
            var octatocMaterial = await db.Materials.FirstOrDefaultAsync(x=>x.Id == 1);

            octatocMaterial.Ugolok -= rashodi.Ugolok;
            octatocMaterial.Ramka -= rashodi.Ramka;
            octatocMaterial.Germetik -= rashodi.Germetik;
            octatocMaterial.Gel -= rashodi.Gel;
            octatocMaterial.Prostoy -= rashodi.Prostoy;
            octatocMaterial.RefYod -= rashodi.RefYod;
            octatocMaterial.Zerkalo -= rashodi.Zerkalo;
            octatocMaterial.RefSaf -= rashodi.RefSaf;
            octatocMaterial.YodProstoy -= rashodi.YodProstoy;
            octatocMaterial.YodTanirovka -= rashodi.YodTanirovka;

            await db.SaveChangesAsync();

        }
        public IQueryable<Material> GetAll()
        {
            return db.Materials;
        }

        public Task Create(Material entity)
        {
            throw new NotImplementedException();
        }

        public Task CreateAll(List<Material> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }



        public Task<Material> Update(Material entity)
        {
            throw new NotImplementedException();
        }
    }
}
