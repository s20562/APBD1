using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBD2
{
    public class Ship
    {
        public string Nazwa { get; private set; }
        public decimal MaxPredkosc { get; private set; }
        public int MaxLiczbaKontenerow { get; private set; }
        public decimal MaxWagaKontenerow { get; private set; }
        public List<Container> Kontenery { get; private set; }

        public Ship(string nazwa, decimal maxPredkosc, int maxLiczbaKontenerow, decimal maxWagaKontenerow)
        {
            Nazwa = nazwa;
            MaxPredkosc = maxPredkosc;
            MaxLiczbaKontenerow = maxLiczbaKontenerow;
            MaxWagaKontenerow = maxWagaKontenerow;
            Kontenery = new List<Container>();
        }

        public void DodajKontener(Container kontener)
        {
            if (Kontenery.Count < MaxLiczbaKontenerow)
            {
                Kontenery.Add(kontener);
            }
            else
            {
                throw new Exception("Nie można dodać więcej kontenerów, osiągnięto maksymalną liczbę.");
            }
        }

        public void UsunKontener(string numerSeryjny)
        {
            var kontener = Kontenery.Find(c => c.NumerSeryjny == numerSeryjny);
            if (kontener != null)
            {
                Kontenery.Remove(kontener);
            }
            else
            {
                throw new Exception("Nie znaleziono kontenera o podanym numerze seryjnym.");
            }
        }

        public void ZaładujKontenery(List<Container> kontenery)
        {
            foreach (var kontener in kontenery)
            {
                DodajKontener(kontener);
            }
        }

        public void RozładujKontener(string numerSeryjny)
        {
            UsunKontener(numerSeryjny);
        }

        public void ZastapKontener(string numerSeryjny, Container nowyKontener)
        {
            UsunKontener(numerSeryjny);
            DodajKontener(nowyKontener);
        }

        public void WypiszInformacje()
        {
            Console.WriteLine($"Nazwa statku: {Nazwa}");
            Console.WriteLine($"Maksymalna prędkość: {MaxPredkosc}");
            Console.WriteLine($"Maksymalna liczba kontenerów: {MaxLiczbaKontenerow}");
            Console.WriteLine($"Maksymalna waga kontenerów: {MaxWagaKontenerow}");
            Console.WriteLine("Lista kontenerów:");
            foreach (var kontener in Kontenery)
            {
                Console.WriteLine($"Numer seryjny: {kontener.NumerSeryjny}, Typ: {kontener.Typ}, Masa ładunku: {kontener.MasaLadunku}");
            }
        }
    }
}
