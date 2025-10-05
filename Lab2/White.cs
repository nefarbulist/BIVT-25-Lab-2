namespace Lab2
{
    public class White
    {
        const double E = 0.0001;

        public int Task1(int n)
        {
            int sum = 0;
            // code here
            for (int i = 1; i <= n; i++)
            {
                sum += 3 * i - 1;
            }
            // end
            return sum;
        }

        public double Task2(int n)
        {
            double sum = 0;
            // code here
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
            }
            // end
            return sum;
        }

        public long Task3(int n)
        {
            if (n == 0) return 1;
            long fact = 1;
            // code here
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            // end
            return fact;
        }

        public long Task4(int a, int b)
        {
            if (b == 0) return 1;
            if (a == 0) return 0;
            long res = 1;
            // code here
            for (int i = 0; i < b; i++)
            {
                res *= a;
            }
            // end
            return res;
        }

        public int Task5(int L)
        {
            long prod = 1;
            int n = 1;
            // code here
            while (prod <= L)
            {
                prod *= n;
                n += 3;
            }
            // end
            return n - 3;
        }

        public double Task6(double x)
        {
            double sum = 1.0;
            double term = x * x;
            // code here
            while (term > E)
            {
                sum += term;
                term *= x * x;
            }
            // end
            return sum;
        }

        public int Task7(int n)
        {
            int sum = 0;
            int k = 0;
            // code here
            while (sum < n)
            {
                sum += k;
                k++;
            }
            // end
            return k - 1;
        }

        public int Task8(double L, double v)
        {
            int res;
            // code here
            res = (int)(L / v + 0.5);
            // end
            return res;
        }
    }
}
