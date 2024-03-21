Console.WriteLine(Penjumlahan.JumlahTigaAngka<double>(13, 02, 22));
SimpleDataBase<double> sdb = new SimpleDataBase<double>();
sdb.AddNewData(13);
sdb.AddNewData(02);
sdb.AddNewData(22);
sdb.PrintAllData();

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

class SimpleDataBase<T>
{
    List<T> storedData;
    List<DateTime> inputDates;

    public SimpleDataBase()
    {
        this.storedData = new List<T> { };
        this.inputDates = new List<DateTime> { };
    }

    public void AddNewData(T data)
    {
        this.storedData.Add(data);
        this.inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        int i = 0;
        this.storedData.ForEach(data =>
        {
            i++;
            Console.WriteLine("Data " + i + " berisi: " + data + ", yang disimpan pada waktu UTC: " + this.inputDates[this.storedData.IndexOf(data)]);
        });
    }
}