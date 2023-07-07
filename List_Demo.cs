using System;
namespace Collections_Demo
{
	//List<T> class represents the list of object which can accessed with index.
	public class List_Demo
	{
		//Creating a list of integers
		List<int> list = new List<int>();

		public void Adding()
		{
			list.Add(10);
            list.Add(20);
            list.Add(30);
			foreach(var item in list)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine("capacity of list: " + list.Capacity);
			Console.WriteLine("Count in list : " + list.Count);
            list.Add(40);
            list.Add(50);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("capacity of list: " + list.Capacity);
			Console.WriteLine("Find the element : " + list.Contains(20));
			Console.WriteLine("Remove the element :" + list.Remove(40));
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
			Console.WriteLine("*********");
            Console.WriteLine("Remove element by index");
			list.RemoveAt(3);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*********");
            Console.WriteLine("Reverse the list");
            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*********");
            list.Clear();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*********");

        }
	}
}

