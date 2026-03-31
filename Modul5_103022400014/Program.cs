
public class pemrosesData
{
        public static T DapatkanNilaiTerbesar <T> (T x, T y, T z){

        dynamic x1 = (dynamic)x;
        dynamic y1 = (dynamic)y;
        dynamic z1 = (dynamic)z;

        dynamic temp = (dynamic)x1;

        if (temp < y1)
        {
            temp = y1;
        }

        if (temp < z1) { 
            temp = z1;
        }


        return temp;
    }
}
﻿public class SimpleDataBase<T> {
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
        pemrosesData.DapatkanNilaiTerbesar<double>(10, 30, 00);
        //103022400014
        SimpleDataBase<int> data = new SimpleDataBase<int>();
        data.AddNewData(10);
        data.AddNewData(30);
        data.AddNewData(00);
        data.printAlldata();
    }
}

