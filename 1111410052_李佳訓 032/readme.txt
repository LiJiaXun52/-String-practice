羅馬數字以七個不同的符號表示 ：I、V、X、L、C和D。M

符號       值
Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000


例如， 2寫成II 羅馬數字，只是兩個一相加。12寫成 XII，簡單地說就是X + II。該數27寫為XXVII，即XX + V + II。
→分別宣告一個字串陣列 symbols 和一個整數陣列 values，分別存儲羅馬數字的符號和對應的數值

羅馬數字通常從左到右從最大到最小書寫。然而，四的數字不是IIII。相反，數字四寫為IV。因為一在五之前，所以我們減去它，得到四。同樣的原理也適用於數字九，寫成IX。有六種使用減法的情況：

I可以放在V(5)和X(10)之前，得到4 (IV) 和9 (IX)。 
X可以放在L(50) 和C(100) 之前，得到 40(XL) 和 90 (XC)。 
C可以放在D(500) 和M(1000) 之前，得到 400 (CD_ 和 900 (CM)。
給定一個整數，將其轉換為羅馬數字。


→使用羅馬數字的表示規則，從最大的羅馬數字開始遍歷，逐步構建出對應的羅馬數字表示。
從最大的羅馬數字 M 開始，遍歷所有的羅馬數字符號。
在每一步中，檢查整數中包含多少個當前羅馬數字的數值。
根據羅馬數字的規則，將相應數量的羅馬數字符號添加到結果中。
繼續遍歷其他羅馬數字，直到整數為0。

namespace _1111410052_李佳訓_032
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            // 請用戶輸入一個數字
            Console.WriteLine("請輸入一個數字:");
            // 讀取用戶輸入的字串並轉換為整數
            string input = Console.ReadLine();
            num = int.Parse(input);

            // 將整數轉換為羅馬數字
            string romanNumeral = IntToRoman(num);

            // 輸出結果，顯示轉換後的羅馬數字
            Console.WriteLine($"羅馬數字表示為：{romanNumeral}");
        }

        // 將整數轉換為羅馬數字的靜態
        public static string IntToRoman(int num)
        {
            string res = String.Empty;
            // 宣告羅馬數字的數值和對應的符號
            List<int> val = new List<int> { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            List<string> str = new List<string> { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            // 遍歷羅馬數字的數值和對應的符號
            for (int i = 0; i < val.Count; ++i)
            {
                // 將整數轉換為羅馬數字
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