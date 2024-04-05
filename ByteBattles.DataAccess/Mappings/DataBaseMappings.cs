using AutoMapper;
using ByteBattles.Core.Models;
using ByteBattles.DataAccess.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBattles.DataAccess.Mappings
{
    public class DataBaseMappings : Profile
    {
        public DataBaseMappings()
        {
            CreateMap<UserEntity, User>();
        }
    }
}
