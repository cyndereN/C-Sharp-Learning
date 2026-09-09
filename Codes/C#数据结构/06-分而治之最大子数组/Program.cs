//// 暴力

//int[] priceArray = { 100, 113, 110, 85, 105, 102, 86, 63, 81, 101, 94, 106, 101, 79, 94, 90, 97 };
//int[] priceFluctuationArray = new int[priceArray.Length - 1];//价格波动的数组
//for (int i = 1; i < priceArray.Length; i++)
//{
//	priceFluctuationArray[i - 1] = priceArray[i] - priceArray[i - 1];
//}
//int total = priceFluctuationArray[0];//默认数组的第一个元素 是最大子数组
//int startIndex = 0;
//int endIndex = 0;
//for (int i = 0; i < priceFluctuationArray.Length; i++)
//{
//	//取得以i为子数组起点的 所有子数组 
//	for (int j = i; j < priceFluctuationArray.Length; j++)
//	{
//		//由i j 就确定了一个子数组
//		int totalTemp = 0;//临时 最大子数组的和 
//		for (int index = i; index < j + 1; index++)
//		{
//			totalTemp += priceFluctuationArray[index];
//		}
//		if (totalTemp > total)
//		{
//			total = totalTemp;
//			startIndex = i;
//			endIndex = j;
//		}
//	}
//}
//Console.WriteLine("startindex : " + startIndex);
//Console.WriteLine("endIndex : " + endIndex);
//Console.WriteLine("购买日期是第" + startIndex + "天  出售是第" + (endIndex + 1) + "天");
//Console.ReadKey();

int[] priceArray = { 100, 113, 110, 85, 105, 102, 86, 63, 81, 101, 94, 106, 101, 79, 94, 90, 97 };

int[] pf = new int[priceArray.Length - 1];//价格波动的数组

for (int i = 1; i < priceArray.Length; i++)
{
	pf[i - 1] = priceArray[i] - priceArray[i - 1];
}

static SubArray GetMaxSubArray(int low, int high, int[] array)//这个方法是用来取得array 这个数组 从low到high之间的最大子数组
{

	if (low == high)
	{
		SubArray subarray;
		subarray.startIndex = low;
		subarray.endIndex = high;
		subarray.total = array[low];
		return subarray;
	}

	int mid = (low + high) / 2; // 低区间 [low,mid]  高区间[mid=1,high]

	SubArray subArray1 = GetMaxSubArray(low, mid, array);

	SubArray subArray2 = GetMaxSubArray(mid + 1, high, array);

	//从【low,mid】找到最大子数组[i,mid]
	int total1 = array[mid];
	int startIndex = mid;
	int totalTemp = 0;
	for (int i = mid; i >= low; i--)
	{
		totalTemp += array[i];
		if (totalTemp > total1)
		{
			total1 = totalTemp;
			startIndex = i;
		}
	}
	//从【mid+1,high】找到最大子数组[mid+1,j]
	int total2 = array[mid + 1];
	int endIndex = mid + 1;
	totalTemp = 0;
	for (int j = mid + 1; j <= high; j++)
	{
		totalTemp += array[j];
		if (totalTemp > total2)
		{
			total2 = totalTemp;
			endIndex = j;
		}
	}
	SubArray subArray3;
	subArray3.startIndex = startIndex;
	subArray3.endIndex = endIndex;
	subArray3.total = total1 + total2;
	if (subArray1.total >= subArray2.total && subArray1.total >= subArray3.total)
	{
		return subArray1;
	}
	else if (subArray2.total >= subArray1.total && subArray2.total >= subArray3.total)
	{
		return subArray2;
	}
	else
	{
		return subArray3;
	}

}


SubArray subArray = GetMaxSubArray(0, pf.Length - 1, pf);
Console.WriteLine(subArray.startIndex);
Console.WriteLine(subArray.endIndex);
Console.WriteLine("我们在第" + subArray.startIndex + "天买入， 在第" + (subArray.endIndex + 1) + "天卖出");
Console.ReadKey();

struct SubArray
{
	public int startIndex;
	public int endIndex;
	public int total;
}
