namespace ConsoleApp1
{
	internal class Program
	{
		//static void Main(string[] args)
		//{
		//    int[] arr = { 1, 2, 3 };

		//    var result = arr.Aggregate((x, y) => x + y);
		//    Console.WriteLine(result);
		//}
		// 1.damiweret sakutari agregacia
		// 2.standartuli agregaciit mipovet shemtxveviti ricxvebidan kvealze didi kenti
		// 3.Sheecadet shedzlebisdagvarad win wawiot proekti!!!
		// 4.gamaxsenet rom daviwkot unit of work!

		static void Main(string[] args)
		{
			int[] arr = { 1, 2, 3 };

			var result = MyAggregate(arr, (x, y) => x + y);
			Console.WriteLine("myAggregate result: " + result);


			//int[] arr1 = { 1, 3, 2, 7, 4, 5 };

			//var largestOdd = arr1
			//    .Where(x => x % 2 != 0)
			//    .Aggregate((x, y) => x > y ? x : y);

			//Console.WriteLine("Largest odd number: " + largestOdd);

			int[] arr1 = { 1, 3, 2, 7, 4, 5 };

			var largestOdd = MyAggregate(arr1.Where(x => x % 2 != 0).ToArray(), (x, y) => x > y ? x : y);

			Console.WriteLine("Largest odd number: " + largestOdd);
		}

		static T MyAggregate<T>(T[] array, Func<T, T, T> func)
		{
			if (array == null || array.Length == 0)
				throw new ArgumentException("Array is empty or null");

			T result = array[0];
			for (int i = 1; i < array.Length; i++)
			{
				result = func(result, array[i]);
			}
			return result;
		}
	}
}

