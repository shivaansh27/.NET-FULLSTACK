using System;
using System.Collections;
class Program
{
    public static void Main()
    {
        // int[] numbers = new int[3];
        // numbers = [10,20,30];
        // Array.Clear(numbers, 0, 2);
        //  foreach(int i in numbers)
        // {
        //     Console.Write(i+" ");
        // }

        // int[] src = {1,2,3};
        // int[] dest = new int[3];

        // Array.Copy(src,dest,2);
        // foreach(int i in dest)
        // {
        //     Console.Write($"{i} ");
        // }

        // int[] nums = {1,2};
        // int[] nums2 = {1,2};
        // Array.Resize(ref nums, 4);
        // Array.Resize(ref nums2 , 1); //Data Loss
        // Console.Write(nums.Length);

        // int[] nums = {21,43,213,32,4,5,23};
        // Console.Write(Array.Exists(nums, i => i/2));

        // List<int> numbers1 = new List<int>();
        // numbers1.Add(19);

        // Stack stack = new Stack();
        // stack.Push(10);
        // stack.Push(20);

        // Queue queue = new Queue();
        // queue.Enqueue(10);
        // queue.Enqueue(38);
        // Console.WriteLine(queue.Dequeue());

        // Dictionary<int, string> users = new Dictionary<int, string>();
        // users.Add(1,"Admin");
        // users.Add(2,"User");
        // Console.WriteLine(users[1]);

        // HashSet<int> set = new HashSet<int>();
        // set.Add(1);
        // set.Add(1);
        // set.Add(2);
        // set.Add(3);
        // set.Add(4);
        // foreach(int i in set)
        // {
        //     Console.Write(i+ " ");
        // }

        SortedList<string, string> list = new SortedList<string, string>();
        list.Add("b","B");
        list.Add("a","A");
        Console.WriteLine(list["b"]);
        // int[,] matrix =
        // {
        //     {1,2,5},
        //     {3,4,8}
        // };
        // for(int i = 0; i < matrix.GetLength(0); i++)
        // {
        //     for(int j = 0; j < matrix.GetLength(1); j++)
        //     {
        //         Console.Write(matrix[i,j]+" ");
        //     }
        // }
        // int[][] jagged = new int[2][];
        // jagged[0] = new int[] {1,2};
        // jagged[1] = new int[] {3,4,5};
        // for(int i = 0; i < jagged.Length; i++)
        // {
        //     for(int j = 0; j < jagged[i].Length; j++)
        //     {
        //         Console.Write(jagged[i][j]+" ");
        //     }
        // }
    }
}