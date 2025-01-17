using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LAB4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            task3_8();
        }
        static void task1_3()
        {
            int[,] a = new int[4, 4] {{1,2,3,4},
                                      {5,6,7,8},
                                      {4,3,5,1},
                                      {2,1,3,4}};
            int n = 4, m = 4;
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                s += a[i, i];
                s += a[i, n - i - 1];
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(s);

        }
        static void task1_6()
        {
            int[,] a = new int[4, 7] {{1,2,3,4,5,6,7 },
                                      {7,8,9,10,11,12,13},
                                      {14,15,16,1,2,3,4},
                                      {-1,4,3,6,2,8,-3}};
            int[] b = new int[4];
            int n = 4, m = 7;
            for (int i = 0; i < n; i++)
            {
                int amin = a[i, 0];
                int imin = 0;
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] < amin)
                    {
                        amin = a[i, j];
                        imin = j;
                    }
                }
                b[i] = imin;
            }
            foreach (int i in b)
            {
                Console.Write(i);
                Console.Write(" ");
            }
        }
        static void task1_12()
        {
            int[,] a = new int[6, 7] {{1,2,3,4,5,6,7 },
                                      {7,8,9,10,11,12,13},
                                      {14,15,16,1,2,3,4},
                                      {-1,4,3,6,2,8,-3},
                                      {14,-15,-16,1,-2,3,4},
                                      {-1,4,3,-6,2,8,-3}};
            int n = 6, m = 7;
            int maxelem = 0, maxindex1 = 0, maxindex2 = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (maxelem < a[i, j])
                    {
                        maxelem = a[i, j];
                        maxindex1 = i;
                        maxindex2 = j;
                    }
                }
            }
            int k = 0, l = 0;
            int[,] b = new int[5, 6];
            for (int i = 0; i < n; i++)
            {
                if (i != maxindex1)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (j != maxindex2)
                        {
                            b[l, k] = a[i, j];
                            k++;
                        }
                    }
                }
                else
                    l--;
                l++;
                k = 0;
            }
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    Console.Write(b[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
        static void task1_13()
        {
            int[,] a = new int[5, 5] {{1,2,3,4,-1 },
                                      {7,19,-9,10,11},
                                      {14,16,15,1,2},
                                      {14,-15,-16,1,-2},
                                      {-1,4,3,-6,2}};
            int n = 5, m = 5;
            int maxelem = 0, index = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i, i] > maxelem)
                {
                    maxelem = a[i, i];
                    index = i;
                }
            }
            int ii = 3;
            int p = 0;
            for (int i = 0; i < 5; i++)
            {
                p = a[i, index];
                a[i, index] = a[i, ii];
                a[i, ii] = p;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void task1_17()
        {
            int[,] a = new int[5, 5] {{1,2,3,4,5 },
                                      {7,19,9,10,11},
                                      {14,16,15,1,2},
                                      {14,-15,-16,1,-2},
                                      {-1,4,3,-6,2}};
            int[] b = new int[5];
            int[] c = new int[5];
            int index = 0;
            int n = 5, m = 5;
            for (int i = 0; i < n; i++)
            {
                int minelem = 10000000;
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] < minelem)
                    {
                        minelem = a[i, j];
                        index = j;
                    }
                }
                c[i] = minelem;
                b[i] = index;
            }
            Array.Reverse(b);
            int p = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = b[p]; j > 0; j--)
                {
                    a[i, j] = a[i, j - 1];
                }
                p++;
            }
            for (int i = 0; i < n; i++)
            {
                a[i, 0] = c[i];
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void task1_29()
        {
            int[,] a = new int[5, 7] {{1,2,3,4,5,6,7 },
                                      {7,8,-9,2,-11,4,12},
                                      {14,15,16,1,2,3,4},
                                      {-1,4,3,6,2,8,-3},
                                      {14,-15,-16,1,-2,3,4}};
            int minelem = 1000000, index = 0;
            int n = 5, m = 7;
            for (int j = 0; j < m; j++)
            {
                if (minelem > Math.Abs(a[1, j]))
                {
                    minelem = Math.Abs(a[1, j]);
                    index = j;
                }
            }
            int[,] b = new int[5, 6];
            for (int i = 0;i < n;i++)
            {
                for (int j = 0;j <= index;j++)
                {
                    b[i, j] = a[i, j];
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = index + 1; j < m - 1; j++)
                {
                    b[i, j] = a[i, j + 1];
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    Console.Write(b[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
        static void task1_31()
        {
            int[,] a = new int[5, 8] {{1,2,3,4,5,6,7,0 },
                                      {7,8,-9,12,-11,4,12,0},
                                      {14,15,16,1,2,3,4,0},
                                      {-1,4,3,6,2,8,-3,0},
                                      {14,-15,-16,1,-2,3,4,0}};
            int[] b = new int[5] { 1, 2, 3, 4, 5 };
            int minelem = 100000, index = 0;
            int n = 5, m = 8;
            for (int j = 0; j < m - 1; j++)
            {
                if (minelem > a[4, j])
                {
                    minelem = a[4, j];
                    index = j;
                }
            }
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = m - 1; j > index; j--)
                {
                    a[i, j] = a[i, j - 1];
                }
            }
            for (int i = 0; i < n; i++)
            {
                a[i, index + 1] = b[i];
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
        static void task2_7()
        {
            int[,] a = new int[6, 6] {{1,2,3,4,5,6 },
                                      {7,19,9,10,11,12},
                                      {14,16,15,1,2,3},
                                      {14,-15,-16,1,-2,-5},
                                      {-1,4,3,-6,20,14},
                                      {1,2,3,4,5,6 } };
            int n = 6, m = 6;
            int maxelem = -10000000, index1 = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i, i] > maxelem)
                {
                    maxelem = a[i, i];
                    index1 = i;
                }
            }
            for (int i = index1 - 1; i >= 0; i--)
            {
                for (int j = m - 1; j > i; j--)
                {
                    a[i, j] = 0;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void task2_8()
        {
            int[,] a = new int[6, 6] {{1,2,3,4,5,6 },
                                      {7,19,9,10,11,12},
                                      {14,16,15,1,2,3},
                                      {14,-15,-16,1,-2,-5},
                                      {-1,4,3,-6,20,14},
                                      {1,2,3,4,5,6 } };
            int n = 6, m = 6;
            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {
                int maxelem = -1000000;
                int index = 0;
                for (int j = 0; j < m; j++)
                {
                    if (maxelem < a[i, j])
                    {
                        maxelem = a[i, j];
                        index = j;
                    }
                }
                b[i] = index;
            }
            int p = 0;
            for (int i = 0; i < n; i++)
            {
                int help = a[i, b[p]];
                a[i, b[p]] = a[i + 1, b[p + 1]];
                a[i + 1, b[p + 1]] = help;
                i++; ;
                p += 2;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void task2_9()
        {
            int[,] a = new int[6, 7] {{1,2,3,4,5,6,7},
                                      {7,19,9,10,11,12,13},
                                      {14,16,15,1,2,3,4},
                                      {14,-15,-16,1,-2,-5,6},
                                      {-1,4,3,-6,20,14,15},
                                      {1,2,3,4,5,6 ,16} };
            int n = 6, m = 7;
            m--;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m / 2; j++)
                {
                    int help = a[i, j];
                    a[i, j] = a[i, m - j];
                    a[i, m - j] = help;
                }
            }
            m++;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void task3_1()
        {
            int[,] a = new int[7, 5] {{1,2,3,4,5},
                                      {7,19,9,10,11},
                                      {-14,16,15,1,2},
                                      {14,-15,-16,1,-2},
                                      {-1,4,3,-6,20},
                                      {1,2,3,-4,5},
                                      {2,6,4,1,-3} };
            int n = 7,m = 5;
            int[,] c = new int[n, 2];
            double[,] b = new double[n, m];
            for (int i = 0; i < n; i++)
            {
                int mn = a[i, 0];
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] < mn)
                    {
                        mn = a[i, j];
                    }
                }
                c[i, 0] = i;
                c[i, 1] = mn;
            }
            int index;
            int zn;
            for (int k = 0; k < n - 1; k++)
            {
                for (int i = k + 1; i < n; i++)
                {
                    if (c[i, 1] > c[k, 1])
                    {
                        zn = c[k, 1];
                        index = c[k, 0];
                        c[k, 1] = c[i, 1];
                        c[k, 0] = c[i, 0];
                        c[i, 1] = zn;
                        c[i, 0] = index;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    b[i, j] = a[c[i, 0], j];
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(b[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
        static void task3_2()
        {
            int[,] a = new int[6, 6] {{1,2,3,4,5,6 },
                                      {7,19,9,10,11,12},
                                      {14,16,15,1,2,3},
                                      {14,-15,-16,1,-2,-5},
                                      {-1,4,3,-6,20,14},
                                      {1,2,3,4,5,6 } };
            int n = 6, m = 6;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == 0 || i == n - 1)
                    {
                        a[i, j] = 0;
                    }
                    a[i, 0] = 0;
                    a[i, m - 1] = 0;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void task3_3()
        {
            int[,] a = new int[6, 6] {{1,2,3,4,5,6 },
                                      {7,19,9,10,11,12},
                                      {14,16,15,1,2,3},
                                      {14,-15,-16,1,-2,-5},
                                      {-1,4,3,-6,20,14},
                                      {1,2,3,4,5,6 } };
            //int[,] a = new int[4, 4] { { 1, 2, 3, 4 },
            //                           { 1, 2, 3, 4 },
            //                           { 1, 2, 3, 4 },
            //                           { 1, 2, 3, 4 }};
            int n = 6;
            int[] b = new int[2 * n - 1];
            int p = 0;
            for (int i = n - 1; i != 0; i--)
            {
                int s = 0;
                for (int j = 0;j + i != n; j++)
                {
                    s += a[i + j, j];
                }
                b[p] = s;
                p++;
            }
            for (int i = n - 1; i != -1; i--)
            {
                int s = 0;
                for (int j = 0; j + i != n; j++)
                {
                    s += a[j, j + i];
                }
                b[p] = s;
                p++;
            }
            int sum = 0;
            foreach(int i in b)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
        static void task3_4()
        {
            //int[,] a = new int[5, 5] {{1,2,3,4,5},
            //                          {7,19,9,10,11},
            //                          {14,16,15,6,2},
            //                          {14,-15,-16,3,-2},
            //                          {-1,4,3,-6,20}};
            int[,] a = new int[6, 6] {{1,2,3,4,5,6 },
                                      {7,19,9,10,11,12},
                                      {14,16,15,6,2,3},
                                      {14,-15,-16,1,-2,-5},
                                      {-1,4,3,-6,20,14},
                                      {1,2,3,4,5,6 } };
            int n = 6;
            for (int i = n - 1; i >= n / 2;i--)
            {
                for (int j = i;j >= 0;j--)
                {
                    a[i, j] = 1;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void task3_8()
        {
            int[,] a = new int[7, 5] {{1,2,-3,4,5},
                                      {7,19,9,10,11},
                                      {14,-16,-15,1,2},
                                      {14,-15,16,1,-2},
                                      {-1,-4,-3,-6,-20},
                                      {1,2,3,-4,5},
                                      {-2,-6,-4,1,-3} };
            int n = 7, m = 5;
            int[,] c = new int[n, 2];
            double[,] b = new double[n, m];
            for (int i = 0; i < n; i++)
            {
                int count = 0;
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] > 0)
                    {
                        count++;
                    }
                }
                c[i, 0] = i;
                c[i, 1] = count;
            }
            int index;
            int zn;
            for (int k = 0; k < n - 1; k++)
            {
                for (int i = k + 1; i < n; i++)
                {
                    if (c[i, 1] > c[k, 1])
                    {
                        zn = c[k, 1];
                        index = c[k, 0];
                        c[k, 1] = c[i, 1];
                        c[k, 0] = c[i, 0];
                        c[i, 1] = zn;
                        c[i, 0] = index;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    b[i, j] = a[c[i, 0], j];
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(b[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void task3_10()
        {
            int[,] a = new int[7, 5] {{1,2,-3,4,5},
                                      {7,19,9,10,11},
                                      {14,-16,-15,1,2},
                                      {14,-15,16,1,-2},
                                      {-1,-4,-3,-6,-20},
                                      {1,2,3,-4,5},
                                      {-2,-6,-4,1,-3} };
            int n = 7, m = 5;
            int znach = 0;
            for (int k = 0; k < n * m; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m - 1; j++)
                    {
                        if (i % 2 != 0)
                        {
                            if (a[i, j] > a[i, j + 1])
                            {
                                znach = a[i, j + 1];
                                a[i, j + 1] = a[i, j];
                                a[i, j] = znach;
                            }
                        }
                        else
                        {
                            if (a[i, j] < a[i, j + 1])
                            {
                                znach = a[i, j + 1];
                                a[i, j + 1] = a[i, j];
                                a[i, j] = znach;
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void task3_11()
        {
            int[,] a = new int[7, 5] {{1,2,-3,4,0},
                                      {7,19,0,10,11},
                                      {14,-16,-15,0,2},
                                      {14,-15,16,0,-2},
                                      {-1,0,-3,-6,-20},
                                      {1,2,0,-4,5},
                                      {-2,-6,-4,0,-3} };
            int n = 7, m = 5,k = 0;
            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i, j] == 0)
                    {
                        b[i] = 1;
                        k++;
                        break;
                    }
                }
            }
            int p = 0;
            int[,] c = new int[k + 1, m];
            for (int i = 0; i < n; i++)
            {
                if(b[i] == 0)
                {
                    for (int j = 0; j < m; j++)
                    {
                        c[p, j] = a[i,j];
                    }
                    p++;
                }
            }
            if (k != n)
            {
                for (int i = 0; i < k + 1; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write(c[i, j]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("All strings contain 0");
            }
        }

    }
}
