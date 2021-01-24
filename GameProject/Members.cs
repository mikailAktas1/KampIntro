using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class Members
    { 


        public void Add (Members GameMembers)
        {
            Console.WriteLine("Gamers is Add." + " " + GameMembers.AdiSoyadi);
        }

        public void Remove(Members GameMembers)
        {
            Console.WriteLine("Gamers is removed." + " " + GameMembers.AdiSoyadi);
        }
        public void Update(Members GameMembers)
        {
            Console.WriteLine("Gamers is update." + " " + GameMembers.AdiSoyadi);

        }

        


        public string AdiSoyadi { get; set; }
        public int TcNo { get; set; }
        public int DogumYili { get; set; }

    }
}
