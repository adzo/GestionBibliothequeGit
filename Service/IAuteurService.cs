﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibDomain.Entities;
using ServicePattern;

namespace Service
{
    public interface IAuteurService:IService<Auteur>
    {
    }
}
