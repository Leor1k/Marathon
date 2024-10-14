using System;

namespace AppForMaraphone.Classes
{
    public class Registration
    {
        public int RanerId { get; } = 0;
        public DateTime DateRegestration{ get; }
        public int RaceKitOption { get; } = 0;
        public int Cost { get; } = 0;
        public Charity SelectedCharity { get; } = null;  
        public Registration (int runer, DateTime dateTimeReg, int selectedKit, int costs, Charity selectedCharity)
        {
            RanerId = runer;
            DateRegestration = dateTimeReg;
            RaceKitOption = selectedKit;
            Cost = costs;
            SelectedCharity = selectedCharity;  
        }
    }
}
