using AutoMapper;
using OefeningPersonsMVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OefeningPersonsMVC.ViewModels
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PersonCreateViewModel, Person>();
        }

    }
}
