using System;

namespace _3_Overflowing
{
    class Program
    {
        static void Main(string[] args)
        {
          
            
            byte number = 254;
            number = (byte)(number + 1);
            Console.WriteLine(number);
            float totalPrice = 12.95f;
            bool isTrue = true;
            var totalCount = 14.85;
            char karakter = 'A';
            Console.WriteLine(Char.IsLower(karakter));
            string ad = "ibrAHim";
            Console.WriteLine(Char.IsLower(ad,4));
            string s = "1";
            int i = Convert.ToInt32(s);
            int j = int.Parse(s);
            Console.WriteLine("{0} , {1}",i,j);
            
            try
            {
                var digit = "1234";
                byte b = Convert.ToByte(digit);
                Console.WriteLine("b nin değeri hesaplanamaz" + b);
            }
            catch (Exception)
            {

                Console.WriteLine("Numara byte değerine çevrilemiyor");
            }
           





        }
    }
}
