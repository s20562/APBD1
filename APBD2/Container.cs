using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD2
{
    public class Container
    {
        public string NumerSeryjny { get; private set; }
        public ContainerType Typ { get; private set; }
        public decimal MasaLadunku { get; private set; }
        public decimal Wysokosc { get; private set; }
        public decimal WagaWlasna { get; private set; }
        public decimal Glebokosc { get; private set; }
        public decimal MaxLadownosc { get; private set; }

        public Container(string numerSeryjny, ContainerType typ, decimal masaLadunku, decimal wysokosc, decimal wagaWlasna, decimal glebokosc, decimal maxLadownosc)
        {
            NumerSeryjny = numerSeryjny;
            Typ = typ;
            MasaLadunku = masaLadunku;
            Wysokosc = wysokosc;
            WagaWlasna = wagaWlasna;
            Glebokosc = glebokosc;
            MaxLadownosc = maxLadownosc;
        }

        public void ZaładujLadunek(decimal masa)
        {
            if (masa > MaxLadownosc)
                throw new OverfillException("Masa ładunku przekracza maksymalną ładowność kontenera.");
            MasaLadunku = masa;
        }

        public void OpróżnijLadunek()
        {
            MasaLadunku = 0;
        }

        public void SprawdzPrzekroczenieLadownosci(decimal masa)
        {
            if (masa > MaxLadownosc)
                throw new OverfillException("Masa ładunku przekracza maksymalną ładowność kontenera.");
        }
    }
}