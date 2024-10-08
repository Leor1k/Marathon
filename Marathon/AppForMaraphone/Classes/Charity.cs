using System;
using System.Windows.Media.Imaging;

namespace AppForMaraphone.Classes
{
    public class Charity
    {
        public int CharId { get; set; } = 0;
        public string CharityName { get; } = null;
        public string Description { get; } = null;
        public string PictureName { get; } = null;
        public Charity(int id,string name, string discription, string imageName) 
        {
            CharId = id;
            CharityName = name;
            Description = discription;
            PictureName = imageName;  
        }
    }
}
