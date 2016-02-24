using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vote.Data_Adapter
{
    public class Data_Adapter_Test : IAdapter
    {
        public void consume_Dashboard_Controller_Data(List<List<object>> holder, List<object> n, List<object> s, List<object> l)
        {
            DataAdapter discoveryService = new DataAdapter();
            Image_Adapter image_Adapter = new Image_Adapter();

            foreach (List<object> official in discoveryService.retrieve_National_Executive_Officials())
            {
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
                    Image picture = image_Adapter.byteArrayToImage(pictureByteArray);

                    //n.ElectedOfficialID = id;
                    //n.FirstName = fname;
                    //n.LastName = lname;
                    //n.Picture = picture;
                    //n.Position = position;
                    //n.Party = party;
                    //n.Bio = bio;
                    //n.YearsOfService = yearsOfService;
                    //n.Terms = terms;
                    //n.Branch = branch;

                }
                //holder.national_Elected_Officials.Add(n);
            }
        }
    }
}
