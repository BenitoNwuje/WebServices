using AutoMapper;
using HelloCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloCore.ViewModels
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<RestaurantCreateViewModel, Restaurant>();
        }
    }
}
