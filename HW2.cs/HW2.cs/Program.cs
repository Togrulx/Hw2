using System;

namespace HW2.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 2

            // Gonderilmis ededin reqemlerinin cemini qaytaran metod 
            //-misalcun bu metodu call ederken arqument olaraq 451 gondersek 
            //metoddan geriye 10 qayitmalidir


            /*    int number;
                bool check;

                Console.WriteLine("Eded daxil edin : ");
                while (true)
                {
                    check = int.TryParse(Console.ReadLine(), out number);
                    if (check && number>=0)
                   {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Warning!!! Xahiw edirik duzgun daxil edin :");
                    }

                }

                Console.WriteLine($"{number} ededinin reqemlerinin cemi - {SumOfNumber(number)} edir");
               */

            #endregion

            #region task3
            //Supermarketdə belə bir aksiya keçirilir: “İstənilən iki mal alana üçüncüsü pulsuz verilir,
            //    ancaq seçilmiş 3 maldan iki ən bahalısının qiyməti ödənilir”.Alınacaq 3 məhsulun qiyməti verilmişdirsə ödəniləcək 
            //    məbləği hesbalayan metod yazin -yəni metodunuz 3 doubel parameter qebul edib en boyuk ikisinin cemini hesablayib 
            //    qaytarmalidir

            /* double priceOne=0, priceTwo=0, priceThree=0;
            int count = 3;
            bool check = true;
            Console.WriteLine("3 eded daxil edin.\n Birinci regemi daxil edin:  ");
            while (check || count!=0)
            {
                if (count == 3)
                {

                    check = double.TryParse(Console.ReadLine(), out priceOne);
                     if (!check)
                    {
                        Console.WriteLine("Warning!!! Birinci regemi duzgun daxil edin!");
                    }
                    else if (check)
                    {
                        Console.WriteLine("Ikinci regemi daxil edin: ");
                        count--;
                        continue;
                    }
                   }else if (count == 2)
                {
                    check = double.TryParse(Console.ReadLine(), out priceTwo);
                    if (!check)
                    {
                   Console.WriteLine("Warning!!! ikinci regemi duzgun daxil edin!");
                    }
                    else if (check)
                    {
                        Console.WriteLine("Ucuncu regemi daxil edin: ");
                        count--;
                        continue;
                    }
                }else if( count == 1)
                {
                    check = double.TryParse(Console.ReadLine(), out priceThree);
                    if (!check)
                    {
                       Console.WriteLine("Warning!!! Ucuncu regemi duzgun daxil edin!");
                    }
                    else if (check)
                    {
                        break; 
                    }
                }
            }

            Console.WriteLine($"Odeyeceyiniz mebleg = {ProductsPrice(priceOne,priceTwo,priceThree)}");

            */

            #endregion
            #region task 2

            // Gonderilmis ededin reqemlerinin cemini qaytaran metod 
            //-misalcun bu metodu call ederken arqument olaraq 451 gondersek 
            //metoddan geriye 10 qayitmalidir


            /*    int number;
                bool check;

                Console.WriteLine("Eded daxil edin : ");
                while (true)
                {
                    check = int.TryParse(Console.ReadLine(), out number);
                    if (check && number>=0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Warning!!! Xahiw edirik duzgun daxil edin :");
                    }

                }
    Console.WriteLine($"{number} ededinin reqemlerinin cemi - {SumOfNumber(number)} edir");
             
              */
            #endregion

            #region task3
            //Supermarketdə belə bir aksiya keçirilir: “İstənilən iki mal alana üçüncüsü pulsuz verilir,
            //    ancaq seçilmiş 3 maldan iki ən bahalısının qiyməti ödənilir”.Alınacaq 3 məhsulun qiyməti verilmişdirsə ödəniləcək 
            //    məbləği hesbalayan metod yazin -yəni metodunuz 3 doubel parameter qebul edib en boyuk ikisinin cemini hesablayib 
            //    qaytarmalidir

            /* double priceOne=0, priceTwo=0, priceThree=0;
            int count = 3;
            bool check = true;
            Console.WriteLine("3 eded daxil edin.\n Birinci regemi daxil edin:  ");
            while (check || count!=0)
            {
                if (count == 3)
                {

                    check = double.TryParse(Console.ReadLine(), out priceOne);
                    if (!check)
                    {
                        Console.WriteLine("Warning!!! Birinci regemi duzgun daxil edin!");
                     }
                   else if (check)
                    {
                        Console.WriteLine("Ikinci regemi daxil edin: ");
                       count--;
                        continue;
                    }
                }else if (count == 2)
                {
                    check = double.TryParse(Console.ReadLine(), out priceTwo);
                    if (!check)
                    {
                        Console.WriteLine("Warning!!! ikinci regemi duzgun daxil edin!");
                    }
                    else if (check)
                    {
                        Console.WriteLine("Ucuncu regemi daxil edin: ");
                        count--;
                        continue;
                    }
                }else if( count == 1)
                {
                    check = double.TryParse(Console.ReadLine(), out priceThree);
                    if (!check)
                    {
                        Console.WriteLine("Warning!!! Ucuncu regemi duzgun daxil edin!");
                    }
                    else if (check)
                    {
                        break;
                    }
               }
            }

            Console.WriteLine($"Odeyeceyiniz mebleg = {ProductsPrice(priceOne,priceTwo,priceThree)}");

            */

            #endregion




        }

        /* static int SumOfNumber(int number)
        {
            int sum = 0;
            int temp;
            while (number != 0)
            {
                temp = number % 10;
                number /= 10;
                sum += temp;
            }

            return sum;
        } */

       /* static double ProductsPrice(double priceOne, double priceTwo, double priceThree)
        {
            double sum;
            double maxPrice = priceOne > priceTwo ? (priceOne > priceThree ? priceOne : priceThree) : (priceTwo > priceThree ? priceTwo : priceThree);
            if (maxPrice == priceOne)
            {
                return sum = maxPrice + (priceTwo > priceThree ? priceTwo : priceThree);
            }
            else if (maxPrice == priceTwo)
            {
                return sum = maxPrice + (priceOne > priceThree ? priceOne : priceThree);
            }
            else
            {
                return sum = maxPrice + (priceOne > priceTwo ? priceOne : priceTwo);
            }



        } */

        /* static int CompareInt(params int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }
        */
    }
}
