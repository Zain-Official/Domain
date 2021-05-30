using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Domain.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
     public string Name(int id,string nam)
        {
            return "Name : "+nam+" ID : "+id;
        }
    }
}