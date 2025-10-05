namespace Lab2
{
    public class White
    {
        const double E = 0.0001;

        public int Task1(int n)
        {
            int answer = 0;
            // code here
            for (int i = 1; i <= n; i++)
                answer += 3 * i - 1;
            // end
            return answer;
        }

        public double Task2(int n)
        {
            double answer = 0;
            // code here
            for (int i = 1; i <= n; i++)
                answer += 1.0 / i;
            // end
            return answer;
        }

        public long Task3(int n)
        {
            long answer = 1;
            // code here
            for (int i = 1; i <= n; i++)
                answer *= i;
            // end
            return answer;
        }

        public long Task4(int a, int b)
        {
            long answer = 1;
            // code here
            for (int i = 0; i < b; i++)
                answer *= a;
            // end
            return answer;
        }

        public int Task5(int L)
        {
            int answer = 0;
            // code here
            long prod = 1;
            int n = 1;
            while (prod <= L)
            {
                prod *= n;
                n += 3;
            }
            answer = n - 3;
            // end
            return answer;
        }

        public double Task6(double x)
        {
            double answer = 1;
            // code here
            double term = 1;
            int i = 1;
            while (term > E)
            {
                term *= x / i;
                answer += term;
                i++;
            }
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

        public double Task8(double L, double v)
        {
            double answer = 0;
            // code here
            double t = 0.0;
            double s = 0.0;
            double dt = 0.001;
            while (s < L)
            {
                s += v * dt;
                t += dt;
                v = v - 0.01 * v; // пример уменьшения скорости
            }
            answer = t;
            // end
            return answer;
        }
    }
}
