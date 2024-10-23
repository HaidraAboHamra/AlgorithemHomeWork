using System;

class Program
{
    static void Main(string[] args)
    {
        int[] frequency = new int[76]; // مصفوفة لتخزين التكرارات (0-75)

        Console.WriteLine("أدخل الأعداد بين 25 و75 (اكتب 'exit' للخروج):");

        while (true)
        {
            string input = Console.ReadLine();

            // تحقق مما إذا أراد المستخدم الخروج
            if (input.ToLower() == "exit")
            {
                break;
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
        }

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
}
