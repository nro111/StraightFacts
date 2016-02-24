using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vote.Data_Adapter;
using Vote.Models;

namespace Vote.Controllers
{
    public class National_Level_OfficialsController : Controller
    {
        // GET: National_Level_Dashboard       
        public ActionResult Executive_Dashboard()
        {
            DashboardViewModelHolder holder = new DashboardViewModelHolder();
            DataAdapter discoveryService = new DataAdapter();
            Image_Adapter image_Adapter = new Image_Adapter();
            holder.national_Elected_Officials = new List<National_Elected_Officials_Model>();
            National_Elected_Officials_Model n;
            
            foreach (List<object> official in discoveryService.retrieve_National_Executive_Officials())
            {
                n = new National_Elected_Officials_Model();
                for (int i = 0; i <= official.Count; i++)
                {
                    int id = int.Parse(official.ElementAt(0).ToString());
                    string fname = official.ElementAt(1).ToString();
                    string lname = official.ElementAt(2).ToString();
                    byte[] pictureByteArray = (byte[])official.ElementAt(3);
                    string position = official.ElementAt(4).ToString();
                    string party = official.ElementAt(5).ToString();
                    string bio = official.ElementAt(6).ToString();
                    int yearsOfService = int.Parse(official.ElementAt(7).ToString());
                    int terms = int.Parse(official.ElementAt(8).ToString());
                    string branch = official.ElementAt(9).ToString();

                    n.ElectedOfficialID = id;
                    n.FirstName = fname;
                    n.LastName = lname;
                    n.Picture = pictureByteArray;
                    n.Position = position;
                    n.Party = party;
                    n.Bio = bio;
                    n.YearsOfService = yearsOfService;
                    n.Terms = terms;
                    n.Branch = branch;
                    n.PictureAsString = System.Convert.ToBase64String(pictureByteArray);
                }
                holder.national_Elected_Officials.Add(n);
            }
            return View(holder);
        }

        public ActionResult Legislative_Dashboard()
        {
            DashboardViewModelHolder holder = new DashboardViewModelHolder();
            DataAdapter discoveryService = new DataAdapter();
            Image_Adapter image_Adapter = new Image_Adapter();
            holder.national_Elected_Officials = new List<National_Elected_Officials_Model>();
            National_Elected_Officials_Model n;
            List<object> legislativeMembers = new List<object>();
            legislativeMembers.AddRange(discoveryService.retrieve_National_House_Officials());
            legislativeMembers.AddRange(discoveryService.retrieve_National_Senate_Officials());

            foreach (List<object> official in legislativeMembers)
            {
                n = new National_Elected_Officials_Model();
                for (int i = 0; i <= official.Count; i++)
                {
                    int id = int.Parse(official.ElementAt(0).ToString());
                    string fname = official.ElementAt(1).ToString();
                    string lname = official.ElementAt(2).ToString();
                    byte[] pictureByteArray = (byte[])official.ElementAt(3);
                    string position = official.ElementAt(4).ToString();
                    string party = official.ElementAt(5).ToString();
                    string bio = official.ElementAt(6).ToString();
                    int yearsOfService = int.Parse(official.ElementAt(7).ToString());
                    int terms = int.Parse(official.ElementAt(8).ToString());
                    string branch = official.ElementAt(9).ToString();

                    n.ElectedOfficialID = id;
                    n.FirstName = fname;
                    n.LastName = lname;
                    n.Picture = pictureByteArray;
                    n.Position = position;
                    n.Party = party;
                    n.Bio = bio;
                    n.YearsOfService = yearsOfService;
                    n.Terms = terms;
                    n.Branch = branch;
                    n.PictureAsString = System.Convert.ToBase64String(pictureByteArray);
                }
                holder.national_Elected_Officials.Add(n);
            }
            return View(holder);
        }

        public ActionResult Judicial_Dashboard()
        {
            DashboardViewModelHolder holder = new DashboardViewModelHolder();
            DataAdapter discoveryService = new DataAdapter();
            Image_Adapter image_Adapter = new Image_Adapter();
            holder.national_Elected_Officials = new List<National_Elected_Officials_Model>();
            National_Elected_Officials_Model n;
            
            foreach (List<object> official in discoveryService.retrieve_National_Judicial_Officials())
            {
                n = new National_Elected_Officials_Model();
                for (int i = 0; i <= official.Count; i++)
                {
                    int id = int.Parse(official.ElementAt(0).ToString());
                    string fname = official.ElementAt(1).ToString();
                    string lname = official.ElementAt(2).ToString();
                    byte[] pictureByteArray = (byte[])official.ElementAt(3);
                    string position = official.ElementAt(4).ToString();
                    string party = official.ElementAt(5).ToString();
                    string bio = official.ElementAt(6).ToString();
                    int yearsOfService = int.Parse(official.ElementAt(7).ToString());
                    int terms = int.Parse(official.ElementAt(8).ToString());
                    string branch = official.ElementAt(9).ToString();

                    n.ElectedOfficialID = id;
                    n.FirstName = fname;
                    n.LastName = lname;
                    n.Picture = pictureByteArray;
                    n.Position = position;
                    n.Party = party;
                    n.Bio = bio;
                    n.YearsOfService = yearsOfService;
                    n.Terms = terms;
                    n.Branch = branch;
                    n.PictureAsString = System.Convert.ToBase64String(pictureByteArray);
                }
                holder.national_Elected_Officials.Add(n);
            }
            return View(holder);
        }
    }
}