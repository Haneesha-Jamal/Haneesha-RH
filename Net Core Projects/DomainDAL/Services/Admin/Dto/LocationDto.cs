﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainDAL.Services.Admin.Dto
{
    public class LocationDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string Discription { get; set; } = null!;
    }
}
