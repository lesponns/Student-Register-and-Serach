using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_32_10_08_23_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int adet, IndexNo;
            string searchnumber;
            Console.Write("Kaç öğrenci kaydı yapılacak: ");
            adet = int.Parse(Console.ReadLine());

            //Array değişken kaydı
            string[] name = new string[adet];
            string[] snumber = new string[adet];
            string[] phone = new string[adet];

            //Öğrenci kaydı
            for (int i = 0; i < adet; i++) 
            {
                Console.Clear();
                Console.Write("{0}. Adı: ", (i + 1));
                name[i] = Console.ReadLine();
                Console.Write("{0}. Okul Numarası: ", (i + 1));
                snumber[i] = Console.ReadLine();
                Console.Write("{0}. Telefonu: ", (i + 1));
                phone[i] = Console.ReadLine();
            }

            //Kayıtları yazdırma
            Console.Write("\nYazdırmak için bir tuşa basınız.");
            Console.ReadKey();
            Console.Clear();
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write("Adı: {0}\nOkul Numarası: {1}\nTelefonu: {2}\n\n", name[i], snumber[i], phone[i]);
            }



            //Öğrenci kaydı arama
            do
            {
                Console.Write("Aramak için öğrenci no: ");
                searchnumber = Console.ReadLine(); 
                IndexNo = Array.IndexOf(snumber, searchnumber);
                if (IndexNo == -1)
                {
                    Console.Write("Öğrenci bulunamadı.");
                }
                else 
                {
                    Console.Write("Öğrenci Okul Bilgileri\n");
                    Console.Write("Adı: {0}\n", name[IndexNo]);
                    Console.Write("Okul No: {0}\n", snumber[IndexNo]);
                    Console.Write("Telefon: {0}\n", phone[IndexNo]);
                }
            }
            while (IndexNo == -1);
            Console.ReadKey();
        }
    }
}
