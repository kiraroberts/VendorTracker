using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorTracker.Models;

namespace VendorTracker.Controllers
{
    public class VendorTrackerController : Controller
    {
        [HttpGet("/vendors")]
        public ActionResult Index()
        List<Vendor> allVendors =
        Vendor.GetAll();
        return View(allVendors);
    }
}