//Задание 1
//Console.WriteLine("Введите количество покупок");
//int A = int.Parse(Console.ReadLine());
//List<string> Shoping = new List<string>();
//InputList(Shoping, A);

//PrintList(Shoping);

//static void PrintList(List<string> L)
//{
//    Console.WriteLine("Список данных:");
//    foreach (string N in L)
//        Console.WriteLine(N);
//    Console.WriteLine($"Длина списка {L.Count} ");
//}

//static void InputList(List<string> L, int C)
//{
//    Console.WriteLine("Введите список товар");
//    for (int i = 0; i < C; i++)
//    {
//        L.Add(Console.ReadLine());
//    }

//    Задание 2
//    Console.WriteLine("Ввод Строки");
//    string line = Console.ReadLine();
//    Console.WriteLine("Ввод числа");
//    int islo = int.Parse(Console.ReadLine());
//    string[] mas = line.Split(" # ");
//    string line1 = "";
//    foreach (string s in mas)
//    {
//        if (s.Length > 3 && s.Length % 3 == 0)
//            line1 += $"{s.ToUpper()}, ";
//    }
//    Console.WriteLine(line1.Substring(0, line1.Length - 2));
//}

//Задание 3
Console.WriteLine("Ввод Строки");
string line = Console.ReadLine();
Console.WriteLine("Ввод числа");
int islo = int.Parse(Console.ReadLine());
