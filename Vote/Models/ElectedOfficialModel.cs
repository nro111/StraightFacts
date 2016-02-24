using System.Drawing;

namespace Vote.Models
{    
    public abstract class Elected_Officials_Model
    {
        public int ElectedOfficialID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] Picture { get; set; }
        public string Position { get; set; }
        public string Party { get; set; }
        public string Bio { get; set; }
        public int YearsOfService { get; set; }
        public int Terms { get; set; }
        public string PictureAsString { get; set; }

        //public string Views { get; set; }        
    }

    public class National_Elected_Officials_Model : Elected_Officials_Model
    {
        public string Branch { get; set; }
    }

    public class State_Elected_Officials_Model : Elected_Officials_Model
    {
        public string Branch { get; set; }
        public string District { get; set; }
        public string Zip { get; set; }
    }

    public class Local_Elected_Officials_Model : Elected_Officials_Model
    {
        public string City { get; set; }
        public string Township { get; set; }
        public string County { get; set; }
        public string Municipality { get; set; }     
    }
}