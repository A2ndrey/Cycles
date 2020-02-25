using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            // for 

            // BeeGeek(19);
            // EvenNumber();
            // divider();
            // reversesequence();
            // squares();
            // divider2();
            // summnumber();
            // summcondition();
            // countnumberendzero();
            // zeroes();
            // myfactorial();
            // multiplicationofnumbers();
            // multiplicationofnumberslast7();
            // multiplicationofevennumbers();



            // while

            // countdividethree();
            // stepentwo();
            // binarylogaripthm();
            // nod();
            //countfour();
            // greatdigit();
            //reversenumber();
            // reversebinary();
            // countonebinary();
            // evennumbernonthree();
            // subtractingPpositiAndNegative();
            // average();
            // countmorethenpreviouse();
            // countsignchange();
            // threedividers();
            // countseven();
            // maxsumdigit();
            // decompositiontosimpledigits();
            // maxdivider();
            // numbersfrom10to100();
            // multiplymumber();
            stringnumber();
        }


        static void stringnumber()
        {
  
            string s = Console.ReadLine();
            int i = 1;

            while (true)
            {
                string s2 = Console.ReadLine();

                if (s == s2)
                {
                    Console.WriteLine(i);
                    break;
                }

                i++;

            }

            Console.ReadKey();


        }
        static void multiplymumber()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int j = 0;
            bool succes = false;

            for (int i = 1; i < n; i++)
            {
                if ((i % c == 0) && (i % d != 0))
                {
                    j = i;
                    succes = true;
                    break;
                }
            }

            if (succes)
            {
                Console.WriteLine(j);

            }

            Console.ReadKey();
        }


        static void numbersfrom10to100()
        {

            while (true)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                if (n < 10)
                {
                    continue;
                }
                else if (n > 100)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(n);
                }

            }

        }

        static void maxdivider()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = (n - 1); i > 1; i--)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

            Console.ReadKey();
        }

        static void decompositiontosimpledigits()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            int j = n;

            while (j > 1)
            {
                if ((j % i) == 0)
                {
                    Console.Write(i + " ");
                    j = j / i;
                }
                else
                {
                    while ((j % i) != 0)
                    {
                        i++;
                    }
                }
            }

            Console.ReadKey();

        }

        static void maxsumdigit()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int max_sum = 0;
            int max_i = 1;

            for (int i = 1; i <= N; i++)
            {
                int n = i;
                int cur_summ = 0;
                while (n > 0)
                {
                    int digit = n % 10;

                    cur_summ += digit;
                    n /= 10;

                }
                if (cur_summ >= max_sum)
                {
                    max_sum = cur_summ;
                    max_i = i;
                }


            }

            Console.WriteLine(max_i + " " + max_sum);


            Console.ReadKey();
        }
        static void countseven()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int n = 0;
            for (int i = 0; i <= N; i++)
            {
                n = i;
                while (n > 0)
                {
                    int digit = n % 10;
                    if (digit == 7)
                    {
                        count++;
                    }
                    n /= 10;
                }
            }

            Console.WriteLine(count);

            Console.ReadKey();

        }


        static void threedividers()
        {

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());

            int i, j, count;

            for (i = a; i <= b; i++)
            {
                count = 0;

                for (j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }

                if (count >= k)
                {
                    Console.Write(i + " ");
                }


            }

            Console.ReadKey();
        }
        static void countsignchange()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int prev, count;
            prev = 0;
            count = 0;


            while (n != 0)
            {
                if ((n > 0) && (prev < 0) || (n < 0) && (prev > 0))
                {
                    count++;
                }

                prev = n;
                n = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine(count);

            Console.ReadKey();
            return;
        }

        static void countmorethenpreviouse()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int prev = 0;
            int count = 0;

            while (n != 0)
            {
                if ((n > prev) && (prev != 0))
                {
                    count++;
                }

                prev = n;
                n = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine(count);

            Console.ReadKey();
            return;
        }

        static void average()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int count = 0;

            while (n != 0)
            {
                sum += n;
                count++;

                n = Convert.ToInt32(Console.ReadLine());
            }

            double avrg = (double)sum / count;
            Console.WriteLine(avrg);

            Console.ReadKey();
            return;
        }

        static void subtractingPpositiAndNegative()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int countP = 0;
            int countN = 0;
            while (n != 0)
            {
                if (n > 0)
                {
                    countP++;
                }
                else
                {
                    countN++;
                }

                n = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(countP - countN);

            Console.ReadKey();
            return;

        }
        static void evennumbernonthree()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (n != 0)
            {
                if ((n % 2 == 0) && (n % 3 != 0))
                {
                    sum += n;
                }

                n = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine(sum);

            Console.ReadKey();

            return;
        }


        static void countonebinary()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            while (n != 0)
            {
                int digit = n % 2;
                if (digit == 1)
                {
                    count++;
                }
                n /= 2;
            }

            Console.WriteLine(count);

            Console.ReadKey();
            return;
        }
        static void reversebinary()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string revbin = "";
            while (n != 0)
            {
                int digit = n % 2;
                revbin += digit;

                n /= 2;


            }

            Console.WriteLine(revbin);

            Console.ReadKey();
            return;

        }
        static void reversenumber()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string reversen = "";

            while (n > 0)
            {
                int digit = n % 10;
                reversen += digit;

                n /= 10;
            }



            Console.WriteLine(reversen);

            Console.ReadKey();
            return;


        }

        static void greatdigit()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int n2 = n;

            while (n > 0)
            {
                int digit = n % 10;
                sum += digit;
                n /= 10;
            }

            if ((n2 % sum) == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            Console.ReadKey();
            return;

        }
        static void countfour()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            while (n > 0)
            {
                int digit = n % 10;
                if (digit == 4)
                {
                    count++;
                }
                n /= 10;
            }
            Console.WriteLine(count);


            Console.ReadKey();
            return;
        }

        static void nod()
        {

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a;

            int i = 1;

            if (a < b)
            {
                a = b;
                b = c;
            }

            while (i <= b)
            {
                if (((a % i) == 0) && (b % i) == 0)
                {
                    c = i;
                }

                i++;

            }

            Console.WriteLine(c);

            Console.ReadKey();
            return;
        }

        static void binarylogaripthm()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int count = 0;

            while (i < n)
            {
                i *= 2;
                count++;
            }

            Console.WriteLine(count);

            Console.ReadKey();
            return;

        }

        static void stepentwo()
        {

            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 1;

            while (sum <= n)
            {
                Console.WriteLine(sum);
                sum *= 2;

            }

            Console.ReadKey();

            return;
        }
        static void countdividethree()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while ((a % 3) == 0)
            {
                count += 1;
                a = a / 3;

            }

            Console.WriteLine(count);

            Console.ReadKey();

            return;

        }
        static void multiplicationofevennumbers()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = 1;

            for (int i = 1; i <= n; i++)
            {
                if ((i % 2) == 0)
                {
                    m *= i;
                }

            }

            Console.WriteLine(m);

            Console.ReadKey();

            return;

        }


        static void multiplicationofnumberslast7()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int m = 1;

            for (int i = a; i <= b; i++)
            {
                if ((i % 10) == 7)
                {
                    m *= i;
                }


            }

            Console.WriteLine(m);

            Console.ReadKey();

            return;
        }

        static void multiplicationofnumbers()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int m = 1;

            for (int i = a; i <= b; i++)
            {
                m *= i;

            }

            Console.WriteLine(m);

            Console.ReadKey();

            return;
        }

        static void myfactorial()
        {

            int n = Convert.ToInt32(Console.ReadLine());
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
            }
            Console.WriteLine(f);

            Console.ReadKey();

            return;
        }


        static void zeroes()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string answ = "NO";

            for (int i = 0; i < n; i++)

            {
                int x = Convert.ToInt32(Console.ReadLine());

                if (x == 0)
                {
                    answ = "YES";
                    break;
                }

            }

            Console.WriteLine(answ);

            Console.ReadKey();

            return;
        }

        static void countnumberendzero()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());

                if (x % 10 == 0)
                {
                    count++;
                }


            }

            Console.WriteLine(count);

            Console.ReadKey();

            return;
        }

        static void summcondition()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());

                if ((x % 2 == 0) && (x % 3 != 0))
                {
                    sum += x;
                }


            }

            Console.WriteLine(sum);

            Console.ReadKey();

            return;
        }


        static void summnumber()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());

                sum += x;

            }

            Console.WriteLine(sum);

            Console.ReadKey();

            return;
        }


        static void divider2()
        {

            int x = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <= x; i++)
            {

                if (x % i == 0) { count++; }

            }

            Console.WriteLine(count);
            Console.ReadKey();

            return;
        }

        static void squares()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(Math.Pow(i, 2));
            }

            Console.ReadKey();
            return;
        }
        static void reversesequence()
        {

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            for (int i = b; i >= a; i--)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();

            return;
        }
        static void divider()
        {
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    Console.WriteLine(i);
                }

            }

            Console.ReadKey();

            return;
        }

        static void EvenNumber()
        {

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            for (int i = a; i < b; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }


            }

            Console.ReadKey();

            return;

        }

        static void BeeGeek(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Hello, BeeGeek!");
            }

            Console.ReadKey();
            return;
        }
    }



}
