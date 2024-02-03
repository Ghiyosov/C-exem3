
List<int> list = new List<int>() {1, 0, 5, -4, 5, 10 ,-80, 24, 0, -4, 100, 24, 45, 6, -1};
for (int i = 2; i < 8; i++)
{
    System.Console.WriteLine(list[i]);
}
System.Console.WriteLine("-------------------------------");
var list2 = list.Distinct();
foreach (var item in list2)
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine("-------------------------------");
list.Sort();
foreach (var item in list)
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine("------------------------------");
for (int i = 0; i < list.Count; i++)
{
    if (list[i]<0) list[i] = 0;
}
foreach (var item in list)
{
    System.Console.WriteLine(item);
}

