using System;

namespace Data_structures
{
    class MyArray
    {
        int[] intArray;

        public MyArray(int i)
        {              
            intArray = new int[i];          
        }

        public void AddElement(int element, int position)
        {            
            if(position>=intArray.Length)
                 Console.WriteLine("Array is not big enough");
            else{
                intArray[position]=element;                
            }
        }

        public void PrintArray()
        {
            for(int i=0; i<intArray.Length; i++)
                Console.Write(intArray[i] + " ");                
        }
    }
}