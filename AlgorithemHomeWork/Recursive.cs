using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithemHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //مصفوفة للاعداد
            int[] frequency = new int[76];

            Console.WriteLine("أدخل الأعداد بين 25 و75 (اكتب 'exit' للخروج):");
            CalculateFrequency(frequency);

            // طباعة النتائج
            Console.WriteLine("\nعدد مرات تكرار كل قيمة:");
            for (int i = 25; i <= 75; i++)
            {
                if (frequency[i] > 0)
                {
                    Console.WriteLine($"الرقم {i} تكرر {frequency[i]} مرات.");
                }
            }
        }

        static void CalculateFrequency(int[] frequency)
        {
            string input = Console.ReadLine();

            // تحقق مما إذا أراد المستخدم الخروج
            if (input.ToLower() == "exit")
            {
                return; // إنهاء الدالة
            }

            // محاولة تحويل المدخل إلى عدد صحيح
            if (int.TryParse(input, out int number))
            {
                // التحقق من النطاق
                if (number >= 25 && number <= 75)
                {
                    frequency[number]++;
                    Console.WriteLine($"تم تسجيل الرقم {number} بنجاح.");
                }
                else
                {
                    Console.WriteLine($"خطأ: الرقم {number} خارج النطاق المسموح به (25-75).");
                }
            }
            else
            {
                Console.WriteLine("خطأ: يُرجى إدخال عدد صحيح أو 'exit' للخروج.");
            }

            // الاستدعاء العودي للمتابعة
            CalculateFrequency(frequency);
        }
    }
}
