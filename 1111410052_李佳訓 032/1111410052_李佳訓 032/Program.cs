
namespace _1111410052_李佳訓_032
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("請輸入一個數字:");
            string input = Console.ReadLine();
            num = int.Parse(input);
            string romanNumeral = IntToRoman(num);

            Console.WriteLine($"羅馬數字表示為：{romanNumeral}");
        }

        public static string IntToRoman(int num)
        {
            string res = String.Empty;
            List<int> val = new List<int> { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            List<string> str = new List<string> { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            for (int i = 0; i < val.Count; ++i)
            {
                while (num >= val[i])
                {
                    num -= val[i];
                    res += str[i];
                }
            }
            return res;
        }
    }
}