給你一個0 索引的字串陣列words和一個字元x。
→創建一個字串陣列和字元x，可讓使用者輸入。
傳回表示包含字元 的單字的索引陣列x。
→使用for迴圈檢查陣列裡是否有字元x。
請注意，傳回的數組可以是任何順序
→使用if，如果字串裡有字元x則返回索引值。
檢查字串中是否包含指定的字元，而不是從特定的索引位置開始檢查，不需要使用 Array.IndexOf 方法，直接使用字串的 IndexOf 方法。
課本5-12頁有類似題型可參考
備註:在寫時有出現錯誤有請chatgpt修正


namespace _11410052_李佳訓031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //宣告字串和字元
            string[] words;
            char x;

            //讓輸入者輸入陣列，以半形逗號隔開字串區分
            Console.WriteLine("請輸入一個字串陣列（以半形逗號分隔）:");
            words = Console.ReadLine().Split(',');

            //讓輸入者輸入要尋找的字元
            Console.WriteLine("您要尋找的字元:");
            x = Console.ReadKey().KeyChar;
            Console.WriteLine();

            // 創建一個空的索引列表，用於存儲包含字元的單字的索引
            List<int> indices = new List<int>();

            // 檢查每個字串是否包含指定的字元，並將其索引添加到索引列表中
            for (int i = 0; i < words.Length; i++)
            {
                //找出所有包含指定字元的字串，並將它們的索引保存在 indices 中
                if (words[i].IndexOf(x) != -1)
                {
                    indices.Add(i);
                }
                else
                {
                    Console.WriteLine();
                }
            }

            // 輸出結果
            Console.WriteLine("包含字元的單字的索引陣列:");
            foreach (int index in indices)
            {
                Console.Write(index + " ");
            }
        }
    }
}





