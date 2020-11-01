﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FabricaDelicias.Models;

namespace FabricaDelicias.UI.Web.Controllers
{
    public class ClienteController : Controller
    {
        public ActionResult Incluir()
        {
            var cli = new Cliente();

            return View(cli);
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}