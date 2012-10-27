﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo_v2.Models;

namespace Demo_v2.Controllers
{
    public class LugaresController : Controller
    {
        SpotItEntities spotItDB = new SpotItEntities();


        //
        // GET: /Lugares/

        public ActionResult Index()
        {
            var categorias = spotItDB.Categoria.ToList();
            return View(categorias);
        }

        public ActionResult Browse(string categoria)
        {
            var aux = spotItDB.Categoria.Find(categoria);
            return View(aux);
        }

    }
}