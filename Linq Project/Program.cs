using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nAşağıdaki kodlardan birini seçiniz\n");
            Console.WriteLine("1- Integer ve string değerleri olan bir array listesindeki stringleri gösteren program\n");
            Console.WriteLine("2- Bir string array içerisinde yazılı olan numaraları sıralayan program\n");
            string selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                    firstQuestion();
                    break;
              
                case "2":
                    secondQuestion();
                    break;
      
                default:
                    Console.WriteLine("Lütfen yalnızca 1 ya da 2 sayılarını giriniz\n");
                    Main(args);
                    break;
            }
            Console.WriteLine("\nTekrar denemek isterseniz 'Y' tuşuna basınız.");
            string selection2 = Console.ReadLine();
            if(selection2 == "Y" || selection2 == "y")
            {
                Main(args);
            } 


        }

        static void firstQuestion()
        {
            //rastgele sayı ve string değerleriyle bir arraylist oluşturulması
            ArrayList arrList = new ArrayList() 
            {
            17, "Hello", 35, 445, "World", "!", 43, 55, "Have a great day!", 27, "4 apples"
            };

            //LINQ kullanarak stringlerin bulunması
            IEnumerable<string> stringValues = arrList.OfType<string>();
            Console.WriteLine("İlk programın cevabı:");

            foreach (var str in stringValues)
            {
                Console.WriteLine(str);
            }
        }

        static void secondQuestion()
        {
            var arrList = new ArrayList()
            {
                "10", "5", "20", "3", "15", "27", "84", "-100"
            };

            // Array list ögesini string dizine dönüştürüp LINQ komutlarıyla sıralama 
            var sortedNumbers = arrList.Cast<string>().OrderBy(item => int.Parse(item));
             Console.WriteLine("İkinci programın cevabı:");
            
            foreach (var number in sortedNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
