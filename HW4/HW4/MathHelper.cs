namespace HW4
{
	public static class MathHelper
	{
		public static int Factorial(int n)
		{
			int result = 1;
			for (int i = 1; i <= n; i++)
			{
				result *= i;
			}
			return result;
		}

		public static int GCD(int a, int b)
		{
			while (b != 0)
			{
				int temp = b;
				b = a % b;
				a = temp;
			}
			return a;
		}

		public static int LCM(int a, int b)
		{
			return Math.Abs(a * b) / GCD(a, b);	
		}
	}
}
