using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tp3.Models;

namespace Tp3.Controllers
{
    public class ProduitController : Controller
    {
        // GET: Produit
        public ActionResult Index()
        {
            ViewBag.Message = "Hello to the home page of TP3";

            return View();
        }

        public ActionResult DisplayOneProduct()
        {
            Produit produit = new Produit()
            {
                Id = 1,
                Name = "Produit 1",
                Prix = 10
            };
            ViewBag.Produit = produit;

            return View();  
        }

        public ActionResult DisplayManyproducts()
        {
            List<Produit> produits = new List<Produit>
            {
                new Produit { Id = 1, Name = "Produit 1", Prix = 10 },
                new Produit { Id = 2, Name = "Produit 2", Prix = 20 },
                new Produit { Id = 3, Name = "Produit 3", Prix = 30 }
            };

            ViewBag.Produits = produits;


            return View();
        }

    }
}