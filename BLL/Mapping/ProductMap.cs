﻿using AutoMapper;
using BLL.DTO;
using ClassLibrary1.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mapping
{
    public class ProductMap : Profile
    {
        public ProductMap()
        {
            CreateMap<Product, ProductDTO>();
        }
    }
}
