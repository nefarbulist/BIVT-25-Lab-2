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
