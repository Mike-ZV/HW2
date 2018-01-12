using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HW2
{

    class Program
    {
        static Random rn = new Random();

        static void Task1(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Task2(int[] arr)
        {
            int z = 0;
            while (true)
            {
                if (arr[z] == arr.Max())
                {
                    Console.WriteLine(z);
                    break;
                }
                z++;

            }
        }

        static void Task3(int[] arr)
        {
            int y = -1;
            for (int i = 0; i < 10; i++)
            {
                if (arr[i] % 2 == 0 && y < arr[i])
                {
                    y = arr[i];
                }
            }
            int z = 0;
            while (true)
            {
                if (arr[z] == y)
                {
                    Console.WriteLine(z);
                    break;
                }
                z++;
            }
        }

        static void Task4(ref int[] arr, string s)
        {
            for (int i = Int32.Parse(s); i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            Array.Resize(ref arr, arr.Length - 1);
            Task1(arr);
        }

        static void Task5(ref int[] arr, string s) 
        {
            int z = 0;
            foreach (int item in arr)
            {
                if (Int32.Parse(s) == item)
                {
                    z++;
                }
            }
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == Int32.Parse(s))
                    for (int j = i; j < arr.Length - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
            }
            Array.Resize(ref arr, arr.Length - z);
            Task1(arr);
        }

        static void Task5(ref int[] arr, int n)
        {
            int z = 0;
            foreach (int item in arr)
            {
                if (n == item)
                {
                    z++;
                }
            }
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == n)
                    for (int j = i; j < arr.Length - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
            }
            Array.Resize(ref arr, arr.Length - z);
            Task1(arr);
        }

        static void Task6(ref int[] arr, string s, int n)
        {
            Array.Resize(ref arr, arr.Length + 1);
            for (int i = arr.Length-1; i > Int32.Parse(s); i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[Int32.Parse(s)]  = n;
            Task1(arr);
        }

        static void Task7(ref int[] arr)
        {
            int z = 0, y = 0, x;
            while (y < arr.Length)
            {
                x = arr[y];
                foreach (int item in arr)
                {
                    if (x == item)
                    {
                        z++;
                    }
                }
                if (z == 2)
                {
                    Task5(ref arr, x);
                    z = 0;
                }
                else { y++; z = 0; }
            }
            Task1(arr);
        }

        static void Task8(ref string s)
        {

            Console.WriteLine(s);
            int x, y;
            for (int i = 0; i < s.Length; i++)
                if (s[i] == 'a')
                {
                    x = 0;
                    for (int j = i - 1; j >= 0; j--)
                        if (s[j] == ' ')
                        {
                            x = j;
                            j = 0;
                        }
                    y = s.Length;
                    for (int j = i + 1; j < s.Length; j++)
                        if (s[j] == ' ')
                        {
                            y = j;
                            j = s.Length;
                        }
                    s = s.Remove(x, y - x);
                    i = x;
                }
            s = s.Trim();
            Console.WriteLine(s);
        }

        static void Task9(ref string s)
        {

            Console.WriteLine(s);
            int x, y, n = 0;
            char z;
            for (int i = s.Length - 1; s[i] != ' '; i--) { n++; }
           
            for (int k = s.Length - 1; s[k] != ' '; k--)
            {
                z = s[k];
                for (int i = 0; i < s.Length-n; i++)
                    if (s[i] == z)
                    {
                        x = 0;
                        for (int j = i - 1; j >= 0; j--)
                            if (s[j] == ' ')
                            {
                                x = j;
                                j = 0;
                            }
                        y = s.Length;
                        for (int j = i + 1; j < s.Length-n; j++)
                            if (s[j] == ' ')
                            {
                                y = j;
                                j = s.Length;
                            }
                        s = s.Remove(x, y - x);
                        i = x;
                        k = k - (y - x);
                    }
                 
            }
            s = s.Trim();
            Console.WriteLine(s);
        }

        static void Task10(ref string s)
        {
            Console.WriteLine(s);
            int x, y, n = 0;
            char z = s[0];

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ' && i != 0)
                {
                    if (s[i - 1] == z)
                    {
                        x = 0;
                        for (int j = i - 1; j >= 0; j--)
                            if (s[j] == ' ')
                            {
                                x = j+1;
                                break;
                            }
                        s = s.Insert(i, "]");
                        s = s.Insert(x, "[");
                        i += 2;
                        
                    }
                    if (i + 1 != s.Length)
                        z = s[i + 1];
                }
                
            }
            Console.WriteLine(s);
        }

        static void ShowDArr(int[,] darr)
        {
            int a = darr.GetUpperBound(0) + 1, b = darr.GetUpperBound(1) + 1;
            Console.WriteLine("/--------/");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(darr[i, j]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        static void ShowDArr(float[,] darr)
        {
            int a = darr.GetUpperBound(0) + 1, b = darr.GetUpperBound(1) + 1;
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(darr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void FillDArr_10(ref int[,] darr)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    darr[i, j] = rn.Next(10);
                }
            }
        }

        static void FillDArr_100(ref int[,] darr)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    darr[i, j] = rn.Next(10, 99);
                }
            }
        }

        static void Task11(ref int[,] darr)
        {
            int a = darr.GetUpperBound(0) + 1, b = darr.GetUpperBound(1) + 1;
            ShowDArr(darr);
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (i == j && darr[i, j] % 2 == 0)
                    {
                        for (int s = 0; s < b; s++)
                            darr[i, s] = 0;
                        break;
                    }
                }
            }
            ShowDArr(darr);
        }

        static void Task12(ref int[,] darr)
        {
            int a = darr.GetUpperBound(0) + 1, b = darr.GetUpperBound(1) + 1;
            ShowDArr(darr);
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (i == j && darr[j, i] % 2 == 0)
                    {
                        for (int s = 0; s < b; s++)
                            darr[s, i] = 0;
                        break;
                    }
                }
            }
            ShowDArr(darr);
        }

        static void Task13(ref int[,] darr)
        {
            int a = darr.GetUpperBound(0) + 1, b = darr.GetUpperBound(1) + 1;
            ShowDArr(darr);
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    for (int z = i + 1; z < a; z++)
                    {
                        if (darr[i, j] == darr[z, j])
                        {
                            for (int i1 = 0; i1 < a; i1++)
                            {
                                for (int j1 = j; j1 < b - 1; j1++)
                                {
                                    darr[i1, j1] = darr[i1, j1 + 1];
                                }
                            }
                            b--;
                            j--;
                            break;
                        }
                    }
                }
            }
            int[,] newArray = new int[a, b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    newArray[i, j] = darr[i, j];
                }
            }
            darr = newArray;
            ShowDArr(darr);
        }

        static void Task14()
        {
            char s = '0';
            int n = 0;
            while (s != '.')
            {
                s = Console.ReadKey().KeyChar;
                if (s == ' ')
                    n++;
            }
            Console.WriteLine();
            Console.WriteLine("Space count = {0}", n);
        }

        static void Task15()
        {
            Console.Write("Enter 6 digits: ");
            string n = Console.ReadLine();
            int d;
            while (n.Length > 6 || n.Length < 6 || Int32.TryParse(n, out d) == false)
            {
                Console.Write("Try again: ");
                n = Console.ReadLine();
            }
            Int32.TryParse(n, out d);
            if (d / 100000 + (d % 100000) / 10000 + (d % 10000) / 1000 == (d % 1000) / 100 + (d % 100) / 10 + d % 10)
            {
                Console.WriteLine("It is lucky ticket!");
            }
            else Console.WriteLine("It is regular ticket.");
        }

        static void Task16()
        {
            char s = Console.ReadKey().KeyChar;
            StringBuilder sb = new StringBuilder();
            while (Convert.ToInt32(s) > 96 && Convert.ToInt32(s) < 123 || Convert.ToInt32(s) > 64 && Convert.ToInt32(s) < 91)
            {
                if (Convert.ToInt32(s) > 96 && Convert.ToInt32(s) < 123)
                    s = Convert.ToChar(Convert.ToInt32(s) - 32);
                else if (Convert.ToInt32(s) > 64 && Convert.ToInt32(s) < 91)
                    s = Convert.ToChar(Convert.ToInt32(s) + 32);
                sb.Append(s, 1);
                s = Console.ReadKey().KeyChar;
            }
            string st = sb.ToString();
            Console.WriteLine();
            Console.WriteLine(st);
        }

        static void Task17()
        {
            Console.WriteLine("Enter two digits (A < B): ");
            int A, B;
            Int32.TryParse(Console.ReadLine(), out A);
            Int32.TryParse(Console.ReadLine(), out B);
            while (A >= B)
            {
                Console.WriteLine("A > B! Try again: ");
                Int32.TryParse(Console.ReadLine(), out A);
                Int32.TryParse(Console.ReadLine(), out B);
            }
            for (int i = A; i <= B; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                    Console.Write(' ');
                } 
                Console.WriteLine();
            }
        }

        static void Task18()
        {
            Console.WriteLine("Enter any number: ");
            string s = Console.ReadLine();
            int n;
            while (Int32.TryParse(s, out n) != true)
            {
                Console.WriteLine("Enter any number: ");
                s = Console.ReadLine();
            }
            Console.WriteLine(s.Reverse().ToArray());
        }

        static void Task19()
        {
            int [] A = new int[5];
            float[,] B = new float[3, 4];
            for (int i = 0; i < 5; i++)
                Int32.TryParse(Console.ReadLine(), out A[i]);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = Convert.ToSingle(rn.Next(1, 99))/10;
                }
            }
            Task1(A);
            Console.WriteLine();
            ShowDArr(B);
            int n = 0; 
            float f = 0, max = B[0, 0], min = B[0, 0];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                {
                    if (max > B[i, j]) max = B[i, j];
                    if (min < B[i, j]) min = B[i, j];
                }
            if (A.Max() == max) Console.WriteLine(max);
            else Console.WriteLine("No common max element.");
            if (A.Min() == min) Console.WriteLine(min);
            else Console.WriteLine("No common min element.");
            foreach (int item in A)
                f += item;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    f += B[i, j];
            Console.WriteLine("Common summ = {0}", f);
            f = 1;
            foreach (int item in A)
                f *= item;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    f *= B[i, j];
            Console.WriteLine("Common product = {0}", f);
            foreach (int item in A)
                if (item % 2 == 0) n += item;
            Console.WriteLine("Even elements summ of array A = {0}", n);
            f = 0;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    if (j % 2 != 0) f += B[i, j];
            Console.WriteLine("Odd columns summ of array B = {0}", f);
        }

        static void Task20()
        {
            int M = rn.Next(1,15), N = rn.Next(1,15);
            int[] arr1 = new int [M], arr2 = new int [N], arr3 = {};
            for (int i = 0; i < M; i++)
                arr1[i] = rn.Next(15);
            for (int i = 0; i < N; i++)
                arr2[i] = rn.Next(15);
            for (int i = 0; i < M; i++)
                for(int j = 0; j< N; j++)
                    if (arr1[i] == arr2[j])
                    {
                        bool b = true;
                        foreach(int item in arr3)
                            if (item == arr2[j])
                            {
                                b = false;
                                break;
                            }
                        if (b == true)
                        {
                            Array.Resize(ref arr3, arr3.Length + 1);
                            arr3[arr3.Length - 1] = arr2[j];
                        }                
                    }
            Task1(arr1);
            Task1(arr2);
            Task1(arr3);
        }

        static void Task21()
        {
            int[,] darr = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    darr[i, j] = rn.Next(-100, 100);
                }
            }
            int min = darr[0,0], max = darr[0,0], sum = 0, counter = 0;
            bool b = false;
             for (int i = 0; i < 5; i++)
                 for (int j = 0; j < 5; j++) {
                     if (min > darr[i, j])
                         min = darr[i, j];
                     if (max < darr[i, j])
                         max = darr[i, j];
                    }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (b == true && darr[i, j] == min || b == true && darr[i, j] == max){
                        b = false;
                        counter++;
                        break;
                    }
                    if (b == true)
                        sum += darr[i, j];

                    if (b == false && darr[i, j] == min || b == false && darr[i, j] == max)
                    {
                        b = true;
                    }
                    
                }
                if (counter != 0)
                    break;
            }
            ShowDArr(darr);
            Console.WriteLine();
            Console.WriteLine(sum);
        }

        static void Task22()
        {
            string s = Console.ReadLine();
            bool t = true;
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(s.ToUpper());
            for (int i = 0, j = sb.Length - 1; i < sb.Length / 2 && j > i; i++, j--)
            {
                while (sb[i] == ' ' || sb[i] == ',' || sb[i] == '.' || sb[i] == '!' || sb[i] == '?' || sb[i] == ';' || sb[i] == ':' || sb[i] == '\'' || sb[i] == '"')
                    i++;
                while (sb[j] == ' ' || sb[j] == ',' || sb[j] == '.' || sb[j] == '!' || sb[j] == '?' || sb[j] == ';' || sb[j] == ':' || sb[j] == '\'' || sb[j] == '"')
                    j--;
                if (i > j)
                    break;
                if (sb[i] != sb[j])
                {
                    t = false;
                    break;
                }
            }
            if (t == true)
                Console.WriteLine("Палиндром.");
            else Console.WriteLine("Не палиндром.");
        }

        static void Task23()
        {
            int N;
            string s;
            StringBuilder sb = new StringBuilder();
            Int32.TryParse(Console.ReadLine(), out N);
            for (int i = 0; i < N; i++)
                sb.Append('*');
            s = sb.ToString();
            Console.WriteLine(s);
        }

        static void Task24()
        {
            string s = Console.ReadLine();
            StringBuilder sb = new StringBuilder(s);
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == '\\' || sb[i] == '/')
                {
                    sb.Remove(i, 1);
                    i--;
                }
            }
            s = sb.ToString();
            Console.WriteLine(s);
        }

        static void Task25()
        {
            StringBuilder sb = new StringBuilder("класс");
            sb.Replace("сс","1");
            Console.WriteLine(sb);
        }

        static void Task26()
        {
            string s = Console.ReadLine();
            int n = 0;
            for (int i = 0; i < s.Length; i++)
                if (s[i] >= '0' && s[i] <= '9')
                    n++;
            Console.WriteLine(n);
        }

        static void Task27()
        {
            string s = Console.ReadLine();
            if (s.IndexOf("one") != -1 || s.IndexOf("One") != -1)
                Console.WriteLine("yes");
            else Console.WriteLine("no");
        }

        static void Task28()
        {
            string s = Console.ReadLine();
            char[] c = new Char[128];
            int x = 0;
            bool b = false;
            for (char i = 'a'; i <= 'z'; i++)
            {
                c[x] = i;
                x++;
            }
            for (char i = 'A'; i <= 'Z'; i++)
            {
                c[x] = i;
                x++;
            }
            for (char i = '0'; i <= '9'; i++)
            {
                c[x] = i;
                x++;
            }
            for (char i = 'а'; i <= 'я'; i++)
            {
                c[x] = i;
                x++;
            }
            for (char i = 'А'; i <= 'Я'; i++)
            {
                c[x] = i;
                x++;
            }
            for (int i = 0; i < s.Length; i++)
            {
                foreach(char item in c){
                    if (item == s[i])
                    {
                        b = true;
                        break;
                    }
                }
                if (b == false)
                {
                    Console.WriteLine("Contains");
                    return;
                }
                else b = false;
            }
            Console.WriteLine("no");
        }

        static void Task29()
        {
            string s = Console.ReadLine();
            char[] c = new Char[1];
            int[] n = new Int32[1];
            int x = 0;
            bool b = false;
            c[0] = s.ToUpper()[0];
            n[0] = 1;
            while (true)
            {
                x = s.IndexOf(' ', x) + 1;
                if (x == 0)
                    break;
                else
                {
                    for (int i = 0; i < c.Length; i++)
                        if (s.ToUpper()[x] == c[i])
                        {
                            n[i]++;
                            b = true;
                            break;
                        }
                    if (b == false)
                    {
                        Array.Resize(ref c, c.Length + 1);
                        Array.Resize(ref n, n.Length + 1);
                        c[c.Length - 1] = s.ToUpper()[x];
                        n[n.Length - 1] = 1;
                    }
                    else b = false;
                }
            }
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == n.Max())
                    Console.WriteLine(c[i]);
            }
        }

        static void Task30()
        {
            string s = Console.ReadLine();
            int n = 0, x = 0;
            while (true)
            {
                x = s.IndexOf('P', x) + 1;
                if (x == 0)
                    break;
                else n++;
            }
            while (true)
            {
                x = s.IndexOf('p', x) + 1;
                if (x == 0)
                    break;
                else n++;
            }
            Console.WriteLine(n);
        }

        static void Task31()
        {
            string s = Console.ReadLine();
            int n = 0, x = 0;
            if (String.IsNullOrEmpty(s))
            {
                Console.WriteLine(n);
                return;
            }
            else n++;
            while (true)
            {
                x = s.IndexOf(' ', x) + 1;
                if (x == 0)
                    break;
                else n++;
            }
            Console.WriteLine(n);
            while (true)
            {
                if (s.IndexOf(' ', x) > 0)
                    Console.WriteLine(s.Substring(x, s.IndexOf(' ', x) - x));
                else Console.WriteLine(s.Substring(x, s.Length - x));
                x = s.IndexOf(' ', x) + 1;
                if (x == 0)
                    break;
            }
        }

        static void Task32()
        {
            string s = Console.ReadLine();
            int n = 0, x = 0;
            if (String.IsNullOrEmpty(s))
            {
                Console.WriteLine(n);
                return;
            }
            while (true)
            {
                if (s.IndexOf(' ', x) > 0)
                {
                    if (s[x] == s[s.IndexOf(' ', x) - 1])
                        n++;
                }
                else
                    if (s[x] == s[s.Length - 1])
                        n++;
                x = s.IndexOf(' ', x) + 1;
                if (x == 0)
                    break;
            }
            Console.WriteLine(n);
        }

        static void Task33()
        {
            string s = Console.ReadLine();
            int n = 0, x = 0;
            if (String.IsNullOrEmpty(s))
            {
                Console.WriteLine(n);
                return;
            }
            while (true)
            {
                if (s.IndexOf(' ', x) > 0)
                {
                    if (s[s.IndexOf(' ', x) - 1] == '3' || s[s.IndexOf(' ', x) - 1] == '4')
                        n += Int32.Parse(s.Substring(x, s.IndexOf(' ', x) - x));
                }
                else
                    if (s[s.Length - 1] == '3' || s[s.Length - 1] == '4')
                        n += Int32.Parse(s.Substring(x, s.Length - x));
                x = s.IndexOf(' ', x) + 1;
                if (x == 0)
                    break;
            }
            Console.WriteLine(n);
        }

        //----------------------------------------------------------------//

        static void Main(string[] args)
        {

            //task 1
            
            /*int[] arr0 = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arr0[i] = rn.Next(10);
            }
            Task1(arr0);

            //task 2
            Console.WriteLine();
            Task2(arr0);
            
            //task 3
            Console.WriteLine();
            Task3(arr0);

            //task 4
            Console.WriteLine();
            string s = Console.ReadLine();
            Task4(ref arr0, s);

            //task 5
            Console.WriteLine();
            s = Console.ReadLine();
            Task5(ref arr0, s);

            //task 6
            Console.WriteLine();
            s = Console.ReadLine();
            int n = Int32.Parse(Console.ReadLine());
            Task6(ref arr0, s, n);

            //task 7
            Task7(ref arr0);
            Console.ReadKey();*/

            //task 8
            /*string st = "lol Invadors must die, lol really";
            Task8(ref st);*/

            //task 9
            //Task9(ref st);
            
            //task10
            //Task10(ref st);

            //task11
            /*int[,] darr = new int [10, 10];
            FillDArr_10(ref darr);
            Task11(ref darr);*/
            
            //task12
            /*FillDArr_10(ref darr);
            Task12(ref darr);
            */
            //task13
            /*FillDArr_100(ref darr);
            Task13(ref darr);*/

            //task14
            //Task14();

            //task15
            //Task15();

            //task16
            //Task16();

            //task17
            //Task17();

            //task18
            //Task18();

            //task19
            //Task19();

            //task20
            //Task20();

            //task21
            //Task21();

            //task22
            //Task22();

            //task23
            //Task23();

            //task24
            //Task24();

            //task25
            //Task25();

            //task26
            //Task26();

            //task27
            //Task27();

            //task28
            //Task28();

            //task29
            //Task29();

            //task30
            //Task30();

            //task31
            //Task31();

            //task32
            //Task32();

            //task33
            Task33();
            Console.ReadKey();
        }

    }
}
