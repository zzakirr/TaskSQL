using MenuCs.Data;
using MenuCs.Models;
using System;
namespace MenuCs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu \n1.Stadion Elave Et : \n2.Staiona bax : \n3. ID-e uygun stadiona bax \n4. Stadion Sil");
            int answer = int.Parse(Console.ReadLine());

            bool check = true;
            while (check)
            {
                switch (answer)
                {
                    case 1:
                        Console.WriteLine("Stationun bilgilerini yazin : Name , HourPrice , Capacity");
                        string name = Console.ReadLine();
                        int hourPrice = int.Parse(Console.ReadLine());
                        int Capacity = int.Parse(Console.ReadLine());

                        Stadium stadium = new Stadium() { Capacity = Capacity, HourPrice = hourPrice, Name = name };

                        StadiumData stadiumData = new StadiumData();
                        stadiumData.ADD(stadium);
                        check = false;
                        break;
                    case 2:
                        StadiumData stadiumData2 = new StadiumData();
                        var ss = stadiumData2.Select();
                        foreach (var item in ss)
                        {
                            Console.WriteLine(item.Capacity + item.Name);
                        }
                        check = false;

                        break;
                    default:
                        break;
                }
            }


        }
    }
}