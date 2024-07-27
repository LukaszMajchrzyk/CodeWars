using System.Reflection;


//UniqueInOrder("AAAABBBCCDAABBB");
//
//static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
//{
//  List<T> list = new List<T>();
//  bool bFirst = true;
//  T previous = default(T);
//  foreach (T current in iterable)
//  {
//    if (!bFirst)
//    {
//      if (!previous.Equals(current)) list.Add(current);
//    }
//    else
//    {
//      bFirst = false;
//      list.Add(current);
//    }
//    previous = current;
//  }
//  return list;
//}
