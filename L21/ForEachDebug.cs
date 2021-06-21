using System.Collections.Generic;
namespace L21
{
    public class ForEachDebug
    {
        public IEnumerable<int> GetRemoveElement()
        {
            List<int> list = new List<int>();
            list = InitList();
            foreach (var i in list)
            {
                // System.Console.WriteLine(i);
                if (i % 2 == 0)
                {
                    yield return i;
                    list.Remove(i);
                }
            }
            yield break;
        }
        public List<int> InitList()
        {
            List<int> list = new List<int>();
            for (var i = 0; i < 20; i++)
            {
                list.Add(i);
            }
            return list;
        }
    }
}