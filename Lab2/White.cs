namespace Lab2
{
    public class White
    {
        const double E = 0.0001;

        public int Task1(int n)
        {
            int answer = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                answer += 2 + 3 * i;
            }
            // end

            return answer;
        }

        public double Task2(int n)
        {
            double answer = 0;

            // code here
            for (int i = 1; i <= n; i++)
            {
                answer += 1.0 / i;
            }
            // end

            return answer;
        }

        public long Task3(int n)
        {
            long answer = 1;

            // code here
            for (int i = 2; i <= n; i++)
            {
                answer *= i;
            }
            // end

            return answer;
        }

        public long Task4(int a, int b)
        {
            if (a == 0 && b == 0) return 0;
            if (b == 0) return 1;

            long answer = 1;

            // code here
            for (int i = 0; i < b; i++)
            {
                answer *= a;
            }
            // end

            return answer;
        }

        public int Task5(int L)
        {
            int answer = 0;

            // code here
            long p = 1;
            int n = 1;
            while (p <= L)
            {
                p *= n;
                n += 3;
            }
            answer = n - 3;
            // end

            return answer;
        }

        public double Task6(double x)
        {
            double answer = 1.0;

            // code here
            double term;
            int power = 2;
            do
            {
                term = Math.Pow(x, power);
                answer += term;
                power += 2;
            } while (term >= E);
            // end

            return answer;
        }

        public int Task7(int n)
        {
            int answer = 0;

            // code here
            int sum = 0;
            while (sum < n)
            {
                answer++;
                sum += answer;
            }
            // end

            return answer;
        }

        public int Task8(double L, double v)
        {
            int t = 0;
            const double R = 6371.0;

            // code here
            while (true)
            {
                double h = v * t;
                double d = Math.Sqrt((R + h) * (R + h) - R * R);
                if (d > L)
                    break;
                t++;
            }
            // end

            return t;
        }
    }
}
