using System;
class Assignment
{
    public static void Questions()
    {
        int[] arr = {1,2,3,2,1,4,2};
        Dictionary<int, int> freq = new Dictionary<int, int>();
        foreach(int j in arr)
        {
            if(freq.ContainsKey(j)){
            freq[j]++;
            }
            else
            {
                freq[j] = 1;
            }
        }
        foreach(KeyValuePair<int,int> kvp in freq)
        {
            Console.WriteLine($"{kvp.Key} - {kvp.Value}");
        }
        
        // int[] arr1 = {1,3,5};
        // int[] arr2 = {2,4,6};
        // int[] result = new int[arr1.Length + arr2.Length];
        // int i = 0 , j = 0, k =0;
        // while(i < arr1.Length && j < arr2.Length)
        // {
        //     if(arr1[i] <= arr2[j])
        //     {
        //         result[k++] = arr1[i++];
        //     }
        //     else
        //     {
        //         result[k++] = arr2[j++];
        //     }
        // }
        // while(i < arr1.Length)
        // {
        //     result[k++] = arr1[i];
        //     i++;
        // }
        // while(j < arr2.Length)
        // {
        //     result[k++] = arr2[j++];
        // }

        // foreach(int a in result)
        // {
        //     Console.Write(a+" ");
        // }
    }
}