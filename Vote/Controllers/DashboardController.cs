using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vote.Models;
using Vote.Data_Adapter;
using System.Drawing;

namespace Vote.Controllers
{
    public class DashboardController : Controller, IController
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            return View();            
        }       
        
        public ActionResult Dashboard()
        {            
            DashboardViewModelHolder holder = new DashboardViewModelHolder(); 
            DataAdapter discoveryService = new DataAdapter(); 
            Image_Adapter image_Adapter = new Image_Adapter(); 
            holder.national_Elected_Officials = new List<National_Elected_Officials_Model>(); 
            National_Elected_Officials_Model n;
            State_Elected_Officials_Model s = new State_Elected_Officials_Model();
            Local_Elected_Officials_Model l = new Local_Elected_Officials_Model(); 
            //Data_Adapter data_Adapter = new Data_Adapter();
            //data_Adapter.consume_Dashboard_Controller_Data(holder, n, s, l); 
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
                    
                    //Image picture = image_Adapter.byteArrayToImage(pictureByteArray);
                    //RedirectToAction("Image", pictureByteArray);
                    

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

        //public FileContentResult Image(int electedOfficialId)
        //{
        //    byte[] picture = GetPicture(electedOfficialId);
        //    return new FileContentResult(picture, "image/jpeg");
        //}

        public FileContentResult Image(byte[] pictureByteArray)
        {            
            return new FileContentResult(pictureByteArray, "image/jpeg");
        }

    }
}
