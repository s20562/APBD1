using APBD2;
using System;
using System.Collections.Generic;

// Tworzenie kontenerów
var liquidContainer = new LiquidContainer("KON-L-1", 1000);
var gasContainer = new Container("KON-G-1", ContainerType.Gas, 1, 2, 3, 4, 2000);
var refrigeratedContainer = new Container("KON-C-1", ContainerType.Refrigerated, 5, 6, 7, 8, 1500);


// Tworzenie statku
var ship = new Ship("Statek 1", 20, 100, 40000);

// Dodanie kontenerów na statek
ship.DodajKontener(liquidContainer);
ship.DodajKontener(gasContainer);
ship.DodajKontener(refrigeratedContainer);

// Wypisanie informacji o statku i jego ładunku
ship.WypiszInformacje();

// Przykładowe operacje na kontenerach
try
{
    liquidContainer.SprawdzPrzekroczenieLadownosci(800);
    gasContainer.SprawdzPrzekroczenieLadownosci(1800); // Spodziewany błąd OverfillException
}
catch (OverfillException ex)
{
    Console.WriteLine("Błąd: " + ex.Message);
}

// Rozładunek kontenera
ship.RozładujKontener("KON-C-1");

// Wypisanie zaktualizowanej informacji o statku i jego ładunku
ship.WypiszInformacje();
    