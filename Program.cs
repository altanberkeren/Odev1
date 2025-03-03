class Program
{
    static void Main()
    {
        // Arabaları oluşturuyoruz
        Car[] cars = { new BMW(), new Porsche(), new Mercedes(), new Togg(), new Audi(), new Toyota() };

        // Arabaların bilgilerini ekrana yazdırıyoruz
        foreach (var car in cars)
        {
            car.PrintFun();
        }
    }
}