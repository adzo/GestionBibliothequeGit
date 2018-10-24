using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BibDomain.Entities;
using BibWeb.Models;
using Service;

namespace BibWeb.Controllers
{
    public class AuteurController : Controller
    {
        AuteurService AS = new AuteurService();

        // GET: Auteur
        public ActionResult Index()
        {
            List<AuteurViewModel> list = new List<AuteurViewModel>();
            foreach (var item in AS.GetAll())
            {
                AuteurViewModel a = new AuteurViewModel()
                {
                    AuteurCode = item.AuteurCode,
                    CIN = item.CIN,
                    Adresse = item.Adresse,
                    NomComplet = new Models.NomComplet()
                    {
                        Nom = item.nomComplet.Nom,
                        Prenom = item.nomComplet.Prenom
                    }
                };
                list.Add(a);

            }

            return View(list);
        }

        [HttpPost]
        public ActionResult Index(string recherche)
        {
            List<AuteurViewModel> list = new List<AuteurViewModel>();
            foreach (var item in AS.GetAll())
            {
                AuteurViewModel a = new AuteurViewModel()
                {
                    AuteurCode = item.AuteurCode,
                    CIN = item.CIN,
                    Adresse = item.Adresse,
                    NomComplet = new Models.NomComplet()
                    {
                        Nom = item.nomComplet.Nom,
                        Prenom = item.nomComplet.Prenom
                    }
                };
                list.Add(a);

            }

            if (recherche != null)
            {
                list = list.Where(t => t.NomComplet.Nom.Contains(recherche)).ToList();
            }
            return View(list);
        }

        //// GET: Auteur/Details/5
        public ActionResult Details(int id)
        {
            Auteur item = AS.GetAll().FirstOrDefault(t => t.AuteurCode == id);
            if (item != null)
            {
                AuteurViewModel a = new AuteurViewModel()
                {
                    AuteurCode = item.AuteurCode,
                    CIN = item.CIN,
                    Adresse = item.Adresse,
                    NomComplet = new Models.NomComplet()
                    {
                        Nom = item.nomComplet.Nom,
                        Prenom = item.nomComplet.Prenom
                    }
                };
                return View(a);
            }
            return RedirectToAction("Index");
        }

        // GET: Auteur/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Auteur/Create
        [HttpPost]
        public ActionResult Create(AuteurViewModel AVM)
        {
            try
            {
                Auteur a = new Auteur()
                {
                    AuteurCode = AVM.AuteurCode,
                    nomComplet = new BibDomain.Entities.NomComplet()
                    {
                        Nom  = AVM.NomComplet.Nom,
                        Prenom = AVM.NomComplet.Prenom
                    },
                    Adresse = AVM.Adresse,
                    CIN = AVM.CIN
                };
                AS.Add(a);
                AS.Commit();

                
                //Generated automatically
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Auteur/Edit/5
        public ActionResult Edit(int id)
        {
            
            Auteur item = AS.GetAll().FirstOrDefault(t => t.AuteurCode == id);
            if (item != null)
            {
                AuteurViewModel a = new AuteurViewModel()
                {
                    AuteurCode = item.AuteurCode,
                    CIN = item.CIN,
                    Adresse = item.Adresse,
                    NomComplet = new Models.NomComplet()
                    {
                        Nom = item.nomComplet.Nom,
                        Prenom = item.nomComplet.Prenom
                    }
                };
                return View(a);
            }

            return RedirectToAction("Index");
        }

        //// POST: Auteur/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, AuteurViewModel AVM)
        {
            try
            {
                // TODO: Add update logic here
                Auteur a = new Auteur()
                {
                    AuteurCode = AVM.AuteurCode,
                    nomComplet = new BibDomain.Entities.NomComplet()
                    {
                        Nom = AVM.NomComplet.Nom,
                        Prenom = AVM.NomComplet.Prenom
                    },
                    Adresse = AVM.Adresse,
                    CIN = AVM.CIN
                };
                //AS.GetById(a.AuteurCode).nomComplet = a.nomComplet;
                //AS.GetById(a.AuteurCode).Adresse = a.Adresse;
                //AS.GetById(a.AuteurCode).CIN = a.CIN;
                AS.Update(a);
                AS.Commit();



                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //// GET: Auteur/Delete/5
        public ActionResult Delete(int id)
        {
            Auteur item = AS.GetAll().FirstOrDefault(t => t.AuteurCode == id);
            if (item != null)
            {
                AuteurViewModel a = new AuteurViewModel()
                {
                    AuteurCode = item.AuteurCode,
                    CIN = item.CIN,
                    Adresse = item.Adresse,
                    NomComplet = new Models.NomComplet()
                    {
                        Nom = item.nomComplet.Nom,
                        Prenom = item.nomComplet.Prenom
                    }
                };
                return View(a);
            }
            return RedirectToAction("Index");
        }

        //// POST: Auteur/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Auteur a = AS.GetAll().FirstOrDefault(t => t.AuteurCode == id);
                if (a != null)
                {
                    AS.Delete(a);
                    AS.Commit();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
