using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsByMetanit.Domain.Entity;
using WinFormsByMetanit.Domain.ViewModels.User;

namespace WinFormsByMetanit.Domain.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<User, UserViewModel>();
    //        this.CreateMap<DataGridViewRow, Order>()
    //            .ForMember(dest=>dest.StatusOrder,
    //opt => opt.MapFrom(src => src.Cells["nameColumn"].Value))
    //            .ForMember(dest=>dest.Client, opt=>opt.MapFrom());

        }
    }
}
