using System;

namespace Data_structures
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //Array 
            MyArray a = new MyArray(4);
            for(int i=0; i<4; i++)
                a.AddElement(i,i);            
            a.PrintArray();            
        }
    }
}
