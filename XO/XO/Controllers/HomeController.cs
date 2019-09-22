using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XO.Controllers
{
    public class HomeController : Controller
    {
         string[,] s = new string[3,3];
        public ActionResult Index()
        {
           return View();
        }
        [HttpPost]
        public  string Winner(string s1, string s2, string s3, string s4, string s5, string s6, string s7, string s8, string s9)
        {
            s[0, 0] = s1;
            s[0, 1] = s2;
            s[0, 2] = s3;
            s[1, 0] = s4;
            s[1, 1] = s5;
            s[1, 2] = s6;
            s[2, 0] = s7;
            s[2, 1] = s8;
            s[2, 2] = s9;

            for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (s[i, 0] == s[i, 1] && s[i, 1] == s[i, 2] && s[i, 0] != "" && s[i, 1] != "" && s[i, 2] != "")
                        {
                            string str = s[i, 0];
                            s = null;
                            s = new string[3, 3];
                            return "Winner: " + str;
                        }
                        else if (s[0, i] == s[1, i] && s[1, i] == s[2, i] && s[0, i] != "" && s[1, i] != "" && s[2, i] != "")
                        {
                            string str = s[0, i];
                            s = null;
                            s = new string[3, 3];
                            return "Winner: " + str;
                        }
                        else if (s[0, 0] == s[1, 1] && s[1, 1] == s[2, 2] && s[0, 0] != "" && s[1, 1] != "" && s[2, 2] != "")
                        {
                            string str = s[0, 0];
                            s = null;
                            s = new string[3, 3];
                            return "Winner: " + str;
                        }
                        else if (s[0, 2] == s[1, 1] && s[1, 1] == s[2, 0] && s[0, 2] != "" && s[1, 1] != "" && s[2, 0] != "")
                        {
                            string str = s[0, 2];
                            s = null;
                            s = new string[3, 3];
                            return "Winner: " + str;
                        }
                    }
                }
                return "";
        }
    }
}