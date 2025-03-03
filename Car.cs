using System;

class Car
{
    public string Brand { get; set; }
    public string GearType { get; set; }
    public int MaxSpeed { get; set; }
    public double Price { get; set; }
    public string Color { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public void PrintFun() // Sürekli Console.WriteLine yazmamak için bir fonksiyon oluşturdum
    {

        Console.WriteLine($"{Brand} → {GearType}");
        Console.WriteLine($"Model: {Model}, Yil: {Year}, Renk: {Color}, Maksimum Hiz: {MaxSpeed} km/h, Fiyat: {Price} TL");

    }
}

