using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibData.Infrastructure;
using BibDomain.Entities;
using ServicePattern;

namespace Service
{
    public class AuteurService:Service<Auteur>
    {
        private static IDatabaseFactory databaseFactory = new DatabaseFactory();
        private static IUnitOfWork unit = new UnitOfWork(databaseFactory);

        public AuteurService():base(unit)
        {
            
        }
    }
}
