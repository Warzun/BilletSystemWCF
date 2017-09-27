using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{

    //<summary>
    //Min bil klasse arver fra Vehicle udover det har den selv 3 properties
    //</summary>
    public class Bill : Vehicle
    {
        public override string Nummerplade { get; set; }
        public override bool Brobizz { get; set; }

        public int bilpriserikr = 410;


        

        
        public Bill(string nummerplade, bool brobizz, DateTime Dato, bool turøresund, bool turstorebælt): base(nummerplade,brobizz,Dato,turøresund,turstorebælt)
        {
            this.Nummerplade = nummerplade;

        }

       
        public override string VehicleType()
        {
            return "Bil";
        }

        public override int Pris()
        {
            return 240;
        }


   
        public override string ToString()
        {
            return this.Brobizz.ToString() + Nummerplade.ToString();
        }

        
        public int WeekendRabat { get; set; }
        public int WeekendRabatter()
        {
        
            return 0;

        }
    }
}

