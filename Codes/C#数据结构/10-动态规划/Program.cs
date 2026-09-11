// 钢条切割问题
int n = 5;//我们要切割售卖的钢条的长度

int[,] Result = new int[11, 4];
int[] result = new int[11];
int[] p = { 0, 1, 5, 8, 9, 10, 17, 17, 20, 24, 30 };//索引代表 钢条的长度，值代表价格
Console.WriteLine(UpDown(0, p));
Console.WriteLine(UpDown(1, p));
Console.WriteLine(UpDown(2, p));
Console.WriteLine(UpDown(3, p));
Console.WriteLine(UpDown(4, p));
Console.WriteLine(UpDown(5, p));
Console.WriteLine(UpDown(6, p));
Console.WriteLine(UpDown(7, p));
Console.WriteLine(UpDown(8, p));
Console.WriteLine(UpDown(9, p));
Console.WriteLine(UpDown(10, p));
Console.ReadKey();

Console.WriteLine(TopDown2(0, p, result));
Console.WriteLine(TopDown2(1, p, result));
Console.WriteLine(TopDown2(2, p, result));
Console.WriteLine(TopDown2(3, p, result));
Console.WriteLine(TopDown2(4, p, result));
Console.WriteLine(TopDown2(5, p, result));
Console.WriteLine(TopDown2(6, p, result));
Console.WriteLine(TopDown2(7, p, result));
Console.WriteLine(TopDown2(8, p, result));
Console.WriteLine(TopDown2(9, p, result));
Console.WriteLine(TopDown2(10, p, result));

Console.ReadKey();

Console.WriteLine(BottomUp(0, p, result));
Console.WriteLine(BottomUp(1, p, result));
Console.WriteLine(BottomUp(2, p, result));
Console.WriteLine(BottomUp(3, p, result));
Console.WriteLine(BottomUp(4, p, result));
Console.WriteLine(BottomUp(5, p, result));
Console.WriteLine(BottomUp(6, p, result));
Console.WriteLine(BottomUp(7, p, result));
Console.WriteLine(BottomUp(8, p, result));
Console.WriteLine(BottomUp(9, p, result));
Console.WriteLine(BottomUp(10, p, result));


Console.ReadKey();

// 递归 不好
static int UpDown(int n, int[] p)//求得长度为n的最大收益
{
	if (n == 0) return 0;
	int tempMaxPrice = 0;
	for (int i = 1; i < n + 1; i++)
	{
		int maxPrice = p[i] + UpDown(n - i, p);
		if (maxPrice > tempMaxPrice)
		{
			tempMaxPrice = maxPrice;
		}
	}
	return tempMaxPrice;
}

static int TopDown2(int n, int[] p, int[] result)//求得长度为n的最大收益
{
	if (n == 0) return 0;
	if (result[n] != 0)
	{
		return result[n];
	}
	int tempMaxPrice = 0;
	for (int i = 1; i < n + 1; i++)
	{
		int maxPrice = p[i] + TopDown2(n - i, p, result);
		if (maxPrice > tempMaxPrice)
		{
			tempMaxPrice = maxPrice;
		}
	}
	result[n] = tempMaxPrice;
	return tempMaxPrice;
}

static int BottomUp(int n, int[] p, int[] result)
{
	for (int i = 1; i < n + 1; i++)
	{
		//下面取得 钢条长度为i的时候的最大收益
		int tempMaxPrice = -1;
		for (int j = 1; j <= i; j++)
		{
			int maxPrice = p[j] + result[i - j];
			if (maxPrice > tempMaxPrice)
			{
				tempMaxPrice = maxPrice;
			}
		}
		result[i] = tempMaxPrice;
	}
	return result[n];
}

// 背包问题
int m;
int[] w = { 0, 3, 4, 5 };
int[] pp = { 0, 4, 5, 6 };

Console.WriteLine(BagProb(10, 3, w, pp));
Console.WriteLine(BagProb(3, 3, w, pp));
Console.WriteLine(BagProb(4, 3, w, pp));
Console.WriteLine(BagProb(5, 3, w, pp));
Console.WriteLine(BagProb(7, 3, w, pp));

Console.ReadKey();
//m是背包容量
//i是物品个数
// wp 是物品的重量和价值的数组
int BagProb(int m, int i, int[] w, int[] p)//返回值是m可以存储的最大价值
{
	if (i == 0 || m == 0) return 0;
	if (Result[m, i] != 0)
	{
		return Result[m, i];
	}

	if (w[i] > m)
	{
		Result[m, i] = BagProb(m, i - 1, w, p);
		return Result[m, i];
	}
	else
	{
		int maxValue1 = BagProb(m - w[i], i - 1, w, p) + p[i];
		int maxValue2 = BagProb(m, i - 1, w, p);
		if (maxValue1 > maxValue2)
		{
			Result[m, i] = maxValue1;
		}
		else
		{
			Result[m, i] = maxValue2;
		}
		return Result[m, i];
	}
}