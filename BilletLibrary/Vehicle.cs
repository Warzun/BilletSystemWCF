using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public abstract class Vehicle
    {
        /// <summary>
        /// Her har jeg sat alle mine properties
        /// </summary>
        public abstract string Nummerplade { get; set; }
        public abstract bool Brobizz { get; set; }
        public DateTime Dato;
        public bool TurØresund;
        public bool TurStorebælt;

        protected Vehicle(string nummerplade, bool brobizz, DateTime dato, bool turøresund, bool turstorebælt)
        {
            this.TurØresund = turøresund;
            this.TurStorebælt = turstorebælt;
            this.Dato = dato;
            this.Brobizz = brobizz;
            if (Brobizz)
            {
                Console.WriteLine("Dette køretøj har Brobizz! ");
            }
            else
            {
                Console.WriteLine("Dette køretøj har ikke Brobizz");
            }
            this.Nummerplade = nummerplade;
            if (Nummerplade.Length > 7)
            {
                throw new ArgumentException("Nummerpladen indenholder for mange tegn! ");
            }
        }


        /// <summary>
        /// Min metode der håndterer prisen over storebælt
        /// </summary>
        public virtual int PrisStorebælt()
        {
            if (VehicleType().Contains("Bil"))
            {
                Console.WriteLine("Bil Storebælt");
                return 240;
            }
            if (VehicleType().Contains("Bil") && Brobizz)
            {
                Console.WriteLine("Bil med Brobizz Storebælt");
                return 230;
            }
            if (VehicleType().Contains("MC") && Brobizz)
            {
                Console.WriteLine("MC med Brobizz StoreBælt");
                return 120;

            }
            Console.WriteLine("MC Storebælt");
            return 125;

        }

        //<summary>
        // Øresunds taksten
        //</summary>
        public virtual int PrisØresundsbroen()
        {
            if (VehicleType().Contains("Bil"))
            {
                Console.WriteLine("Øresund Bil");
                return 410;
            }
            if (VehicleType().Contains("Bil") && Brobizz)
            {
                Console.WriteLine("Øresund Bil med Brobizz");
                return 161;
            }
            if (VehicleType().Contains("MC") && Brobizz)
            {
                Console.WriteLine("Øresund MC med Brobizz");
                return 73;

            }
            Console.WriteLine("Øresund MC");
            return 210;
        }

        //<summary>
        // returnerer mit base vehicle
        //</summary>
        public virtual string VehicleType()
        {
            return "Base Vehicle";
        }

        
        public abstract int Pris();
    }
}
