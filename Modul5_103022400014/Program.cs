
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
public class main { 
       public static void Main(String[] args)
    {
        //NIM: 103022400014
        pemrosesData.DapatkanNilaiTerbesar<double>(10, 30, 22);
    }
}
