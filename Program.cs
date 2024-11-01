namespace ConsoleApp1
{
	internal class Program
	{

		//1.damiweret sakutari agregacia
		//2.standartuli agregaciit mipovet shemtxveviti ricxvebidan kvealze didi kenti
		//3.Sheecadet shedzlebisdagvarad win wawiot proekti!!!
		//4.gamaxsenet rom daviwkot unit of work!

		static void Main(string[] args)
		{
			int[] arr = { 1, 2, 3 };

			var result = arr.MyAggregatee((x, y) => x + y);
			Console.WriteLine("myAggregate result: " + result);


			int[] arr1 = { 1, 3, 2, 7, 4, 5,8 };

			var largestOdd = arr1.Where(x => x % 2 != 0).Aggregate((x, y) => x > y ? x : y);

			Console.WriteLine("Largest odd number: " + largestOdd);

		
		}
	}
}

