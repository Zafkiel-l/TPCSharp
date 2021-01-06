using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{

    
    public class Personnages

    {
       public int pv { get; set; }
       public int atck { get; set; }
       public string name { get; }


        public Personnages()
        {
            name = "perso";
        }

        public Personnages(string name)
        {
            this.name = name;
        }

 
        public virtual void Deplacement()
        {
         
        }
     

    }


   
}
