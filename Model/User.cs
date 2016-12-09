using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Model
{
    class User
    {
        public string name { get; set; }
        public string email { get; set; }
        public DateTime DOB { get; set; }
        public SEX sex { get; set; }
        public COUNTING ct { get; set; }

        public User()
        {
            ct = COUNTING.ONE;
        }
    }

    public enum COUNTING
    {
        ONE =1,
        TWO,
        THREE,
        FOUR,
        FIVE,
        SIX,
        SEVEN,
        EIGHT,
        NINE,
        TEN,
        HUNDRED=100,
        THOUSAND=1000
    }

    public struct SEX
    {
        public const string MALE = "male";
        public const string FEMALE = "female";
    }
}
