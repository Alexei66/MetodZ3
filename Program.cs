namespace NewAppMetodZ3
{
    internal class Program
    {
        static string InString()
        {
            string str = Console.ReadLine();

            return str;
        }
        /// <summary>
        /// Удаляет одинаковые рядом стоящие символы 
        /// </summary>
        /// <param name="chars"> Строка с исходными символами </param>
        /// <param name="Res"> Строка в которую сохраняем результат </param>
        /// <returns></returns>
        static string DeleteSame (string chars, string Res)
        {
            
            for (int i = 1; i < chars.Length; i++)
            {
                if (chars[i] != Res[Res.Length-1])
                {
                    Res += chars[i].ToString();
                }
            }
            return Res;
        }
        /// <summary>
        /// Вывод строки в консоль
        /// </summary>
        /// <param name="str"></param>
        static void Print (string str)
        { 
            Console.WriteLine (str);
        }

        static void Main(string[] args)
        {

            // Задание 3. Создать метод, принимающий текст. 
            // Результатом работы метода должен быть новый текст, в котором
            // удалены все кратные рядом стоящие символы, оставив по одному 
            // Пример: ПППОООГГГООООДДДААА >>> ПОГОДА
            // Пример: Ххххоооорррооошшшиий деееннннь >>> хороший день

            Console.WriteLine("Введи строку с символами ");
            string input = InString();            
            string ResStr = input[0].ToString();
            var Res = DeleteSame(input, ResStr);
            Print(Res);
                               


        }
    }
}