using System.Collections;
using System.Collections.Generic;
namespace L21
{
    public class MyEnumerator : IEnumerator
    {
        private MyEnumerable myEnumerable;
        private int position = -1;
        public MyEnumerator(MyEnumerable data)
        {
            this.myEnumerable = data;
        }
        public object Current
        {
            get
            {
                if(myEnumerable.data[position]%2==0)
                return myEnumerable.data[position];
                else
                return null;
            }
        }
        public bool MoveNext()
        {
            position++;
            return position < myEnumerable.data.Length;
        }
        public void Reset()
        {
            position = -1;
        }

    }
    public class MyEnumerable : IEnumerable
    {
        public int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator(this);
        }
        public static void Main(string[] args)
        {
            // int[] test = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            MyEnumerable myEnumerable = new MyEnumerable();
            foreach (var i in myEnumerable)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}