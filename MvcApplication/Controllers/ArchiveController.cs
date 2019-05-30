using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication.Controllers
{
    public class ArchiveController : Controller
    {
       
            public string Entry(DateTime entryDate)
            {
                return "You requested the entry from " + entryDate.ToString();
            }
        
    }
}