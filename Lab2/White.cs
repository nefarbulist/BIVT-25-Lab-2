namespace Lab2
{
    public class White
    {
        const double E = 0.0001;

        public int Task1(int n)
        {
            int answer = 0;
            for (int i = 1; i <= n; i++)
            {
                answer += 3 * i - 1;
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
            int answer = 0;
            long product = 1;
            int n = 1;
            while (product <= L)
            {
                product *= n;
                n += 3;
            }
            answer = n - 3;
            return answer;
        }

        public double Task6(double x)
        {
            double answer = 1.0;
            double term = x * x;
            while (term >= E)
            {
                answer += term;
                term *= x * x;
            }
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
            const double R = 6371.0;
            double h = Math.Sqrt(L * L + R * R) - R;
            int answer = (int)Math.Ceiling(h / v);
            return answer;
        }
    }
}
