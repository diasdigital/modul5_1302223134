SimpleDataBase<double> sdb = new SimpleDataBase<double>();
sdb.AddNewData(13);
sdb.AddNewData(02);
sdb.AddNewData(22);
sdb.PrintAllData();

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