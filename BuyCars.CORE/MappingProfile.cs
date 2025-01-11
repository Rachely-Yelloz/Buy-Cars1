using AutoMapper;
using BuyCars.CORE.DTOs;
using BuyCars.CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyCars.CORE
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Order,OrderDTO>().ReverseMap();
        }
    }
}
