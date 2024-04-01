using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD2
{
    public class LiquidContainer : Container, IHazardNotifier
    {
        public LiquidContainer(string numerSeryjny, decimal maxLadownosc)
            : base(numerSeryjny, ContainerType.Liquid, 0, 0, 0, 0, maxLadownosc)
        {
        }

        public void Notify(string numerSeryjny)
        {
            Console.WriteLine($"Kontener o numerze seryjnym {numerSeryjny} przechowuje niebezpieczny ładunek.");
        }
    }
}