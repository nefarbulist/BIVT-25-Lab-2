namespace Lab2
{
    public class White
    {
        const double E = 0.0001;

        public int Task1(int n)
        {
            int answer = 0;
            for (int i = 0; i < n; i++)
            {
                answer += 2 + 3 * i;
            }
            return answer;
        }

        public double Task2(int n)
        {
            double answer = 0;
            for (int i = 1; i <= n; i++)
            {
                answer += 1.0 / i;
            }
            return answer;
        }

        public long Task3(int n)
        {
            long answer = 1;
            for (int i = 2; i <= n; i++)
            {
                answer *= i;
            }
            return answer;
        }

        public long Task4(int a, int b)
        {
            if (a == 0 && b == 0) return 0;
            if (b == 0) return 1;

            long answer = 1;
            for (int i = 0; i < b; i++)
            {
                answer *= a;
            }
            return answer;
        }

        public int Task5(int L)
        {
            long product = 1;
            int n = 1;

            while (product <= L)
            {
                product *= n;
                n += 3;
            }

            return n - 3;
        }

        public double Task6(double x)
        {
            double answer = 1.0;
            double term;
            int power = 2;
            do
            {
                term = Math.Pow(x, power);
                answer += term;
                power += 2;
            } while (term >= E);
            return answer;
        }

        public int Task7(int n)
        {
            int answer = 0;
            int sum = 0;
            while (sum < n)
            {
                answer++;
                sum += answer;
            }
            return answer;
        }

        public int Task8(double L, double v)
        {
            int t = 0;
            const double R = 6371.0;
            while (true)
            {
                double h = v * t;
                double d = Math.Sqrt((R + h) * (R + h) - R * R);
                if (d > L)
                    break;
                t++;
            }
            return t;
        }
    }
}
