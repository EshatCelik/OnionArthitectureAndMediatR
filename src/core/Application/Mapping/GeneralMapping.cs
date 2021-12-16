﻿using Application.Dto;
using Application.Features.Commands;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapping
{
    public  class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<Product,ProductDTO>().ReverseMap();
            CreateMap<Product, CreateProductCommand>().ReverseMap();

        }
    }
}
