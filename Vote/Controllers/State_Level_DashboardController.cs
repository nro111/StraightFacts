using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vote.Data_Adapter;
using Vote.Models;

namespace Vote.Controllers
{
    public class State_Level_OfficialsController : Controller
    {
        // GET: State_Level_Dashboard
        
        public ActionResult Executive_Dashboard()
        {
            DashboardViewModelHolder holder = new DashboardViewModelHolder();
            DataAdapter discoveryService = new DataAdapter();
            Image_Adapter image_Adapter = new Image_Adapter();
            holder.state_Elected_Officials = new List<State_Elected_Officials_Model>();
            State_Elected_Officials_Model s;

            foreach (List<object> official in discoveryService.retrieve_State_Executive_Officials())
            {
                s = new State_Elected_Officials_Model();
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

                    s.ElectedOfficialID = id;
                    s.FirstName = fname;
                    s.LastName = lname;
                    s.Picture = pictureByteArray;
                    s.Position = position;
                    s.Party = party;
                    s.Bio = bio;
                    s.YearsOfService = yearsOfService;
                    s.Terms = terms;
                    s.Branch = branch;
                    s.PictureAsString = System.Convert.ToBase64String(pictureByteArray);
                }
                holder.state_Elected_Officials.Add(s);
            }
            return View(holder);
        }

        public ActionResult Legislative_Dashboard()
        {
            DashboardViewModelHolder holder = new DashboardViewModelHolder();
            DataAdapter discoveryService = new DataAdapter();
            Image_Adapter image_Adapter = new Image_Adapter();
            holder.state_Elected_Officials = new List<State_Elected_Officials_Model>();
            State_Elected_Officials_Model s;
            List<object> legislativeMembers = new List<object>();
            legislativeMembers.AddRange(discoveryService.retrieve_State_House_Officials());
            legislativeMembers.AddRange(discoveryService.retrieve_State_Senate_Officials());

            foreach (List<object> official in legislativeMembers)
            {
                s = new State_Elected_Officials_Model();
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

                    s.ElectedOfficialID = id;
                    s.FirstName = fname;
                    s.LastName = lname;
                    s.Picture = pictureByteArray;
                    s.Position = position;
                    s.Party = party;
                    s.Bio = bio;
                    s.YearsOfService = yearsOfService;
                    s.Terms = terms;
                    s.Branch = branch;
                    s.PictureAsString = System.Convert.ToBase64String(pictureByteArray);
                }
                holder.state_Elected_Officials.Add(s);
            }
            return View(holder);
        }

        public ActionResult Judicial_Dashboard()
        {
            DashboardViewModelHolder holder = new DashboardViewModelHolder();
            DataAdapter discoveryService = new DataAdapter();
            Image_Adapter image_Adapter = new Image_Adapter();
            holder.state_Elected_Officials = new List<State_Elected_Officials_Model>();
            State_Elected_Officials_Model s;

            foreach (List<object> official in discoveryService.retrieve_National_Judicial_Officials())
            {
                s = new State_Elected_Officials_Model();
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

                    s.ElectedOfficialID = id;
                    s.FirstName = fname;
                    s.LastName = lname;
                    s.Picture = pictureByteArray;
                    s.Position = position;
                    s.Party = party;
                    s.Bio = bio;
                    s.YearsOfService = yearsOfService;
                    s.Terms = terms;
                    s.Branch = branch;
                    s.PictureAsString = System.Convert.ToBase64String(pictureByteArray);
                }
                holder.state_Elected_Officials.Add(s);
            }
            return View(holder);
        }
    }
}