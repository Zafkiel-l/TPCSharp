using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{

    public class Chasseur : Personnages
    {
        public Chasseur(string name) : base(name)
        {
            pv = 6;
            atck = 4;
        }

       
        public override void Deplacement()
        {

        }

    }


}
