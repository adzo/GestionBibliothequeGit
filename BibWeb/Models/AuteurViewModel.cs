using BibDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibWeb.Models
{
    public class AuteurViewModel
    {
        public int AuteurCode { get; set; }
        public int CIN { get; set; }
        public string Adresse { get; set; }
        public NomComplet NomComplet { get; set; }
    }
}