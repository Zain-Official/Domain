using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Domain.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
       public string Name(string name)
        {
            
            return "Wel Come to "+name;
        }

        public string FullName(string fname =null,string lname =null)
        {
            string F_NAME = string.Empty;
            if(fname !=null && lname !=null)
            {
                F_NAME = "Your First Name Is : " + fname + " And Last Name Is : " + lname;
            }
            else if (fname !=null && lname == null)
            {
                F_NAME = "Your First Name Is : " + fname;
            }
            else if (fname ==null && lname !=null)
            {
                F_NAME = "Your Last Name Is : " + lname;
            }
            else if(fname ==null && lname ==null)
            {
                F_NAME = "Please Enter Your Name ";
            }


            return F_NAME;

        }
    }
}