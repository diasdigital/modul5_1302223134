Console.WriteLine(Penjumlahan.JumlahTigaAngka<double>(13, 02, 22));
class Penjumlahan
{
    public static dynamic JumlahTigaAngka<T>(T a, T b, T c)
    {
        dynamic bebas1 = a;
        dynamic bebas2 = b;
        dynamic bebas3 = c;
        return bebas1 + bebas2 + bebas3;
    }
}