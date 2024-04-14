namespace _1111410052_李佳訓031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words;
            char x;

            Console.WriteLine("請輸入一個字串陣列（以半形逗號分隔）:");
            words = Console.ReadLine().Split(',');

            Console.WriteLine("您要尋找的字元:");
            x = Console.ReadKey().KeyChar;
            Console.WriteLine();

            List<int> indices = new List<int>();

            for (int i = 0; i < words.Length; i++)
            {

                if (words[i].IndexOf(x) != -1)
                {
                    indices.Add(i);
                }
                else
                {
                    Console.WriteLine();
                }
            }

            foreach (int index in indices)
            {
                Console.Write(index + " ");
            }
            
        }
    }
}