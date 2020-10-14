using System.IO;
using System;
namespace masha
{
    public class mas_dz
    {
        private static void Main()
        {
            Console.WriteLine();
        
    }   
        public static int Series15(int K)
        {
            K = 120;
            int[] a = new int[] { 6, 4, 90, 21, 1, 800, 0 };
            for(int i=0;i<a.Length;i++)
            {
                if (a[i] > K)
                    return a[i];
                if (a[i] == 0)
                    break;
            }
            return 0;
        }
        public static double[] Series17(int B)
        {
             B = 120;
            int N = 5, minIndex=0;
            double[] a = new double[] { 2.3, 4.5, 11, 20, 32.1,};
            double[] newA = new double[N + 1];
            for(int i=0;i<newA.Length;i++)
            {
                if (a[i] > B)
                    minIndex = i;
            }
            for(int i=0;i<=minIndex;i++)
            {
                if (i == minIndex)
                    newA[i] = B;
                else
                    newA[i] = a[i];
            }
            for (int i = minIndex; i <= newA.Length; i++)
            {
                    newA[i] = a[i-1];
            }
            return newA;

        }
        public static void Series18(int N)
        {
             N = 5;
            int[] A = new int[] { 1, 3, 7, 7, 9 };
            for(int i=0; i<N; i++)
            {
                if (A[i] != A[i]+1 )
                    Console.WriteLine(A[i]);

            }

        }
        public static int[] Series19(int N, int K)
        {
            N = 9;  K=0;
            int[] a = new int[] { 1, 3, 12, 3, 4, 6, 23, 34, 90 };
            int[] rez = new int[N];
            for(int i=1;i<=N;i++)
            {
                if (a[i] < a[i - 1])
                {
                    rez[K] = a[i];
                    K++;
                }
            }
            return rez;
        }

        private static void series13()
        {
            int N = 5;
            int K = 0;
            int[] A = new int[5] { 1, 2, 3, 4, 6 };
            for (int i = 0; i < N; i++)
            {
                if (A[i] % 2 != 0)
                {
                    A[i] *= 2;
                    K += A[i];
                }
            }
            Console.WriteLine(K);
        }

        private static bool Series21()
        {
            int N = 10, i=0;
            int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 2 };
            bool flag = true;
            while(flag && i<N)
            {
                if (a[i] > a[i + 1])
                    flag = false;
                i++;
            }
            return flag;
        }

        private static void Series22()
        {
            int N = 6, counter=0;
            int[] a = new int[] { 65,54,43,32,21,1};
            
           for(int i=0; i<N;)
            {
                if (a[i] < a[i + 1])
                    Console.WriteLine(a[i]);
                counter++;
                i++;
                break;
                
            }
            if (counter == 0)
                Console.WriteLine(counter);
        }

        private static int Series25()
        {
            int N = 10;
            int x=0, y=0, sum=0;
            int[] a = new int[] {2,3,0,4,34,5,766,0,89 };
            for(int i=0;i<N;i++)
            {
                if(a[i]==0)
                {
                    x = i;
                    break;
                }
            }
            for (int i = N; i>0; i--)
            {
                if (a[i] == 0)
                {
                    y = i;
                    break;
                }
            }
            for(int i=x;i<y;i++)
                sum += 0;
            return sum;
        }
        
    }
}




