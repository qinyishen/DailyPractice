using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
//自定义类型 int类型数组 使用迭代器遍历对象 要求遍历出所有偶数
//两种方法实现 枚举器 迭代器
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
                // if(myEnumerable.data[position]%2==0)
                // return myEnumerable.data[position];
                // else
                // return null;
                return myEnumerable.data[position];
            }
        }
        public bool MoveNext()
        {
            position++;
            if (position < myEnumerable.data.Length && myEnumerable.data[position] % 2 != 0)
                MoveNext();
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
            MyEnumerable myEnumerable = new MyEnumerable();
            foreach (var i in myEnumerable)
            {
                System.Console.WriteLine(i);
            }

            // int[] test = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // MyIterator mi = new MyIterator(test);
            // foreach(var i in mi){
            //     System.Console.WriteLine(i);
            // }
        }
    }
    public class MyIterator
    {
        private int[] data;
        public MyIterator(int[] data)
        {
            this.data = data;
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (var i = 0; i < data.Length; i++)
            {
                if (data[i] % 2 == 0)
                {
                    yield return data[i];
                }
            }
        }
    }
}