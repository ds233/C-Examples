//Собрать строку с числами от а до б, а <= б
//Способ через цикл
// string NumbersFor(int a, int b)
// {
//     string result = string.Empty;
//     for (int i = a; i <= b; i++) result += $"{i} ";
//     return result;
// }
// //Способ через Рекурсию
// string NumbersRec(int a, int b)
// {
//     if (a <= b) return $"{a} " + NumbersRec(a + 1, b);    //чтобы отсортировать от 10 9 8 7 ... нужно код местами поменять: NumbersRec(a+1, b) + $"{a} "
//     else return String.Empty;
// }

// Console.WriteLine(NumbersFor(1, 10));
// Console.WriteLine(NumbersRec(1, 10));

//Сумма чисел от 1 до н через Рекурсию
// int SumRec(int n)
// {
//     if (n == 0) return 0;
//     else return n + SumRec(n - 1);
// }
// Console.WriteLine(SumRec(10));

//Вычислить a^n
// int PowerFor(int a, int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result *= a;
//     return result;
// }

// int PowerRec(int a, int n)
// {
//     //if (n == 0) return 1;
//     //else return PowerRec(a, n - 1) * a;
//     return n == 0 ? 1 : PowerRec(a, n - 1) * a;     //тернарный оператор, запись условия иначе
// }

// int PowerRecMath(int a, int n)                      //Этот способ уменьшает количество вычислительных операций с 27 до 6 (математика;)
// {
//     if (n == 0) return 1;
//     else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
//     else return PowerRecMath(a, n - 1) * a;

// }

// Console.WriteLine(PowerFor(2, 10));
// Console.WriteLine(PowerRec(2, 10));
// Console.WriteLine(PowerRecMath(2, 10));



//Перебор слов. В некотором машинном алфавите имеются 4 буквы: а,и,с,в. Покажите все слова, состоящие из Т букв, которые можно построить из букв этого алфавита.
//Решение через цикл For
// char[] s={'а','и','с','в'};
// int count=s.Length;
// int n=1;
// for(int i=0;i<count;i++)
// {
//     for(int j=0;j<count;j++)
//     {
//         for(int k=0;k<count;k++)
//         {
//             for(int l =0;l<count;l++)
//             {
//                 for(int m=0;m<count;m++)
//                 {
//                     Console.WriteLine($"{n++,-5} {s[i]} {s[j]} {s[k]} {s[l]} {s[m]}");
//                 }
//             }
//         }
//     }
// }

// //Решение через Рекурсию
// int n=1;
// void FindWords(string alphabet, char[] word, int length = 0)
// {
//     if (length == word.Length)
//     {
//         Console.WriteLine($"{n++} {new String(word)}"); return;
//     }
//     for (int i = 0; i < alphabet.Length; i++)
//     {
//         word[length] = alphabet[i];
//         FindWords(alphabet, word, length + 1);
//     }
// }

// FindWords("аисв", new char[5]);


//Программа с помощью Рекурсии просматривает папки и файлы по указанному пути
// void CatalogInfo(string path, string indent = "")
// {
//     DirectoryInfo catalog = new DirectoryInfo(path);

//     DirectoryInfo[] catalogs = catalog.GetDirectories();
//     for (int i = 0; i < catalogs.Length; i++)
//     {
//         Console.WriteLine($"{indent}{catalogs[i].Name}");
//         CatalogInfo(catalogs[i].FullName, indent + " ");
//     }

//     FileInfo[] files = catalog.GetFiles();

//     for (int i = 0; i < files.Length; i++)
//     {
//         Console.WriteLine($"{indent}{files[i].Name}");
//     }
// }

// string path = @"D:\YandexDisk\Программирование\_Code\Example002_HelloUser";
// CatalogInfo(path);



// //Сравнение скорости работы Рекурсии и обычного цикла
// decimal fRec = 0;
// decimal fIte = 0;

// decimal FibonacciRec(int n)
// {
//     fRec++;
//     return n==0 || n==1 ? 1 : FibonacciRec(n-1) + FibonacciRec(n-2);
// }

// decimal FibonacciIte(int n)
// {
//     fIte++;
//     decimal result = 1;
//     decimal f0 = 1;
//     decimal f1=1;
//     for (int i=2;i<=n;i++)
//     {
//         result=f0+f1;
//         f0=f1;
//         f1=result;
//         fIte++;
//     }
//     return result;
// }

// Console.ReadLine();
// DateTime dt = DateTime.Now;

// for(int n=10;n<40;n++)
// {
//     Console.WriteLine($"FibonacciIte({n}) = {FibonacciIte(n)} fIte = {fIte.ToString("### ### ###"), -15}");
//     fIte=0;
// }
// System.Console.WriteLine((DateTime.Now-dt).TotalMilliseconds);

// Console.WriteLine();
// Console.ReadLine();
// dt = DateTime.Now;

// for(int n=10;n<40;n++)
// {
//     Console.WriteLine($"FibonacciRec({n}) = {FibonacciRec(n)} fRec = {fRec.ToString("### ### ###"), -15}");
//     fRec=0;
// }
// System.Console.WriteLine((DateTime.Now-dt).TotalMilliseconds);
// Console.ReadLine();


