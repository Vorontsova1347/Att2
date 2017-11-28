using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
   public class ListUtils
    {
        public IList<int> list { get; set; }
        public ListUtils(IList<int> list)
        {
            this.list = list;
        }
        public List<int> CreateNewList(IList<int> list2)
        {
            List<int> res = new List<int>();
            foreach (int item in list)
            {
                foreach(int element in list2)
                {
                    if (Math.Abs(element)!=Math.Abs(item) && item!=0 &&
                        element!=0 && Math.Abs(element)!=1 && 
                        item % element == 0)
                    {
                        res.Add(item);
                        break;
                    }
                }
            }
            return res;
        }
        public static List<int> ToList(string str)
        {
            return new List<int>(IOUtils.ConvertStringToArray(str));
        }
        public static string ToString(List<int> list)
        {
            int[] res = list.ToArray();
            return IOUtils.ConvertArrayToString(res);
        }
    }
}
