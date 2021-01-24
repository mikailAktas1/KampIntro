using System;

namespace GenericsIntro
{
    class Program
    {
        
            static void Main(string[] args)
            {
                MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
                myDictionary.Add(3, "emre");
                myDictionary.Add(5, "ali");

                Console.WriteLine(myDictionary.Counter);

                myDictionary.Iterate();


            }
        
    }

    internal class MyDictionary<T1, T2>
    {
        public MyDictionary()
        {
        }

        public bool Counter { get; internal set; }

        internal void Add(int v1, string v2)
        {
            throw new NotImplementedException();
        }

        internal void Iterate()
        {
            throw new NotImplementedException();
        }
    }
}
}
