using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public class MC : Vehicle
    {
        public override string Nummerplade { get; set; }
        public override bool Brobizz { get; set; }
        public int McPriseriKr = 210;

        public MC(string nummerplade, bool brobizz, DateTime Dato, bool turøresund, bool turstorebælt) : base(nummerplade, brobizz, Dato, turøresund, turstorebælt)
        {
            this.Nummerplade = nummerplade;
        }

        public override int PrisStorebælt()
        {
            if (Brobizz)
            {
                
                Console.WriteLine("Du har brobizz så prisen er 73 for Motorcykler");
                return 73;

            }
            return McPriseriKr;
        }

        public override string VehicleType()
        {
            return "Øresund MC";
        }

        public override int Pris()
        {
            throw new NotImplementedException();
        }
    }
}

   
