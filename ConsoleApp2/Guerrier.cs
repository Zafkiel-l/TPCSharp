using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    
    public class Guerrier : Personnages , IEpee
    {
        public Guerrier(string name):base(name)
        {
            pv = 8;
            atck = 3;
        }
        
        public void Epee()
        {
            throw new NotImplementedException();
        }
        public override void Deplacement()
        {

        }

    }
    
     
}
