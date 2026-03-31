
public class SimpleDataBase<T> {
    private List<T> storedData;
    private List<DateTime> inputDates;


    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T d) {
        storedData.Add(d);
        DateTime currentTime = DateTime.Now;
        inputDates.Add(currentTime);
    }
    public void printAlldata() {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Data  {i+1} berisi: {storedData[i]}, yang disimpan pada waktu UTC: { inputDates[i]}");
        }
    }
}

public class Progress {
    public static void Main(string[] args)
    {
        SimpleDataBase<int> data = new SimpleDataBase<int>();
        data.AddNewData(10);
        data.AddNewData(30);
        data.AddNewData(00);
        data.printAlldata();
    }
}