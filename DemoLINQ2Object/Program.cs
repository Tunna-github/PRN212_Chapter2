using System.Text;

Console.OutputEncoding= Encoding.UTF8;
int[] arr = {100, 50, 120, 130, 80, 70, 123, 17, 237};
//Caau1: dùng linq2objec để lọc ra các số chẵn
//Cách Method syntax
var result = arr.Where(x => x % 2 == 0);
//cách Query syntax
var result2 = from x in arr
              where x % 2 == 0
              select x;
Console.WriteLine("Danh sách các số chẵn: ");
result2.ToList().ForEach(x => Console.WriteLine(x));
/*Câu 2: sắp xếp danh sách tăng dần
 */
var result3 = arr.OrderBy(x => x);
var result4 = from x in arr
              orderby x
              select x;
Console.WriteLine("\nDanh sách sau khi sắp xếp tăng dần:");
foreach(var item in result4)
{
    Console.Write(item + "\t");
}
//Câu 3: sắp xếp danh sách giảm dần
var result5 = arr.OrderByDescending(x => x);
var result6 = from x in arr
              orderby x descending
              select x;
Console.WriteLine("\nDanh sách sau khi sắp xếp giảm dần:");
foreach (var item in result6)
{
    Console.Write(item + "\t");
}

//câu 4: đếm ố lượng các số lẻ
int dem = arr.Where(x => x % 2 != 0).Count();