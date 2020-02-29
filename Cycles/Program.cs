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
            // stringnumber();
            // EnumerableQubicEquation();
            // multiplydigits();
            //threedigitanalys();
            //interestingdigits();
            // perfectnumber();
            // difficultqubicequations();
            // simlemin();
            // simplemax();
            // extremum_sub();
            // speedfromcamera();
            // secondmax();
            // countzero();
            // ispolindrom();
            // digitwithout5and7();
            // digipow();
            // mincount();
            // digitalroot();
            //biggestdigiteven7();
            // friendlydigit(); // time limited
            amorphousdigit();

        }

        private static void amorphousdigit()
        {
            long k = Convert.ToInt64(Console.ReadLine());

            for (long i = 0; i <= k; i++)
            {
                if (i == 0) { Console.Write($"{i} "); continue; }

                long square = i * i;

                if (square == i)
                {
                    Console.Write($"{i} ");
                }
                else
                {
                    int position = 0;
                    double digit = 0;
                    while (square > 0)
                    {
                        digit += (square % 10) * Math.Pow(10, position);
                        if ((digit == i) && (square != 1))
                        {
                            Console.Write($"{i} ");
                            break;
                        }

                        position++;
                        square /= 10;
                    }
                }
            }
            Console.ReadKey();

        }

        private static void friendlydigit()
        {
            int k = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < k; i++)
            {
                int sum_i = 1;

                // sum i divider
                // int sum_i = 0;
                if ((i == 1) || (i == 2)) { sum_i = i; }
                else
                {

                    double sqrt = Math.Sqrt(i);
                    for (int d = 2; d <= sqrt; d++)
                    {

                        if (i % d == 0)
                        {
                            if (d != (i / d))
                            {
                                sum_i = sum_i + d + (i / d);
                            }
                            else
                            {
                                sum_i = sum_i + d;
                            }
                        }
                    }
                }
                //for (int m = 1; m < i; m++)
                //{
                //    if (i % m == 0)
                //    {
                //        sum_i += m;
                //    }

                //}

                for (int j = i + 1; j < k; j++)
                {
                    int sum_j = 1;

                    // sum j divider
                    // int sum_j = 0;
                    //for (int m = 1; m < j; m++)
                    //{
                    //    if (j % m == 0)
                    //    {
                    //        sum_j += m;
                    //    }

                    //}
                    if ((j == 1) || (j == 2)) { sum_j = j; }
                    else
                    {

                        double sqrtj = Math.Sqrt(j);
                        for (int d = 2; d <= sqrtj; d++)
                        {

                            if (j % d == 0)
                            {
                                if (d != (j / d))
                                {
                                    sum_j = sum_j + d + (j / d);
                                }
                                else
                                {
                                    sum_j = sum_j + d;
                                }
                            }
                        }
                    }
                    if ((sum_i == j) && (sum_j == i))
                    {
                        Console.WriteLine($"{i} {j}");
                    }

                }

            }
            Console.ReadKey();
        }

        private static void biggestdigiteven7()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int maxdigit = -1000;
            const int seven = 7;

            for (int i = a; i <= b; i++)
            {
                if (i % seven == 0)
                {
                    if (i > maxdigit)
                    {
                        maxdigit = i;
                    }
                }
            }

            if (maxdigit == -1000) { Console.WriteLine("NO"); }
            else { Console.WriteLine(maxdigit); }

            Console.ReadKey();
        }

        private static void digitalroot()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int a = n;

            while (n / 10 != 0)
            {
                while (n > 0)
                {
                    sum += n % 10;

                    n /= 10;
                }

                n = sum;
                sum = 0;

            }


            Console.WriteLine(n);

            Console.ReadKey();

        }

        private static void mincount()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int min = 0;
            int count = 0;
            //5

            //13        //1
            //12        //1

            //10        //2
            //31        //2
            //10        //2

            for (int i = 0; i < n; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());

                if (i == 0) { min = a; count++; }

                if (a < min)
                {
                    min = a;
                    count = 1;
                }
                else if ((a == min) && (i != 0)) { count++; }
            }

            Console.WriteLine($"min count: {count}");

            Console.ReadKey();
        }

        private static void digipow()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int result = 1;

            while (n > 0)
            {
                result *= a;
                n--;
            }

            Console.WriteLine(result);

            Console.ReadKey();
        }

        private static void digitwithout5and7()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int pos = 0;
            double newdigit = 0;

            while (n > 0)
            {
                int a = n % 10;
                if ((a != 5) && (a != 7))
                {
                    newdigit += a * Math.Pow(10, pos);
                    pos++;
                }
                n /= 10;

            }

            Console.WriteLine(newdigit);

            Console.ReadKey();
        }

        private static void ispolindrom()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int position = 0;
            double newdigit = 0;
            string result = "";

            int n_copy = n;

            while (n_copy / 10 > 0)
            {
                position++;
                n_copy /= 10;
            }

            n_copy = n;
            while (n_copy / 10 > 0)
            {
                a = n_copy % 10;
                n_copy = n_copy / 10;

                newdigit += a * Math.Pow(10, position);

                position--;

            }

            a = n_copy % 10;
            newdigit += a * Math.Pow(10, position);

            if (n == newdigit) { result = "YES"; } else { result = "NO"; }
            Console.WriteLine(result);

            Console.ReadKey();

        }

        private static void countzero()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());

                if (a == 0)
                {
                    count++;
                }

            }

            Console.WriteLine(count);
            Console.ReadKey();

        }

        private static void secondmax()
        {

            int max1 = 0;
            int max2 = 0;

            while (true)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                if (n == 0) { break; }

                if (n > max1)
                {
                    max2 = max1;
                    max1 = n;

                }
                else if (n > max2)
                {
                    max2 = n;
                }
            }


            Console.WriteLine(max2);

            Console.ReadLine();
        }

        private static void speedfromcamera()
        {
            const int LIMIT = 30;
            bool print_yes = false;

            int n = Convert.ToInt32(Console.ReadLine());
            int max = 0;

            for (int i = 0; i < n; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                if (a > max)
                {
                    max = a;
                }

                if (a < LIMIT) { print_yes = true; }
            }

            string keyword = print_yes ? "YES" : "NO";

            Console.WriteLine($"{max} {keyword}");

            Console.ReadKey();
        }

        private static void extremum_sub()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int a = Convert.ToInt32(Console.ReadLine());

            int min = a;
            int max = a;

            for (int i = 1; i < n; i++)
            {
                a = Convert.ToInt32(Console.ReadLine());

                if (a > max)
                {
                    max = a;
                }

                if (a < min)
                {
                    min = a;
                }

            }

            Console.WriteLine(max - min);

            Console.ReadKey();
        }

        private static void simplemax()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int max = 0;

            for (int i = 0; i < n; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());

                if ((i == 0) || (a > max))
                {
                    max = a;
                }
            }

            Console.WriteLine(max);

            Console.ReadKey();
        }

        static void simlemin()
        {

            int n = Convert.ToInt32(Console.ReadLine());
            int min = 0;

            for (int i = 0; i < n; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());

                if (i == 0) { min = a; }

                if (a < min)
                {
                    min = a;
                }
            }

            Console.WriteLine(min);

            Console.ReadKey();

        }

        private static void difficultqubicequations()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());
            double leftpart = 0;
            double rightpart = 0;
            int count = 0;

            for (int i = 0; i <= 1000; i++)
            {
                leftpart = (a * Math.Pow(i, 3) + b * Math.Pow(i, 2) + c * i + d);
                rightpart = i - e;
                if ((rightpart != 0) && (leftpart / rightpart) == 0)
                {
                    count++;
                }

            }

            Console.WriteLine(count);

            Console.ReadKey();
        }



        private static void perfectnumber()
        {
            int count_perfect = 0;
            for (int digit = 1; digit <= 10000; digit++)
            {
                int sum = 0;

                for (int i = 1; i < digit; i++)
                {
                    if ((digit % i) == 0)
                    {
                        sum += i;
                    }
                }

                if (digit == sum)
                {
                    Console.WriteLine($"Perfect digit: {digit}");
                    count_perfect++;
                }

                if (count_perfect == 3)
                {
                    break;
                }

            }

            Console.ReadKey();
        }

        private static void interestingdigits()
        {
            for (int i = 10; i < 100; i++)
            {
                if ((i % 10) * (i / 10) * 2 == i)
                {
                    Console.WriteLine($"Interesting digit: {i}");
                }
            }
            Console.ReadKey();

        }

        static void threedigitanalys()
        {

            int count = 0;

            for (int n = 100; n <= 999; n++)
            {
                if ((n / 100 + (n / 10) % 10 + n % 10) == 8)
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество элементов: {count}");
            Console.ReadKey();
        }
        static void multiplydigits()
        {

            int n = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if ((i % c == 0) && (i % d != 0))
                {
                    Console.WriteLine(i);
                }

            }

            Console.ReadKey();

        }

        static void EnumerableQubicEquation()
        {

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());

            for (int x = 0; x <= 1000; x++)
            {

                if (((a * Math.Pow(x, 3)) + b * Math.Pow(x, 2) + c * x + d) == 0)
                {
                    Console.Write(x + " ");
                }
            }
            Console.ReadKey();
        }
        static void stringnumber()
        {

            string s = Console.ReadLine();
            int i = 1;

            while (true)
            {
                string newstring = Console.ReadLine();

                if (s == newstring)
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
