using OOP2;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

FulltimeEployee obama = new FulltimeEployee();
obama.Id = 1;
obama.IdCard = "124";
obama.Name = " Barac Obama";
obama.Birthday = new DateTime(1960, 12, 25);
Console.WriteLine("Thông tin của Obama: ");
Console.WriteLine("ID=" + obama.Id);
Console.WriteLine("Name=" + obama.Name);
Console.WriteLine("IdCard=" + obama.IdCard);
Console.WriteLine("Birthday=" + obama.Birthday.ToString("dd/MM/yyyy"));
Console.WriteLine("Lương của Obama=>" + obama.calSalary());

ParttimeEmployee trump = new ParttimeEmployee()
{
    Id = 2,
    IdCard = "456",
    Name = "Donald Trump",
    Birthday = new DateTime(1954, 1, 15),
    WorkingHour = 2
};
Console.WriteLine("\nThông tin của Trump: ");
Console.WriteLine("ID=" + trump.Id);
Console.WriteLine("Name=" + trump.Name);
Console.WriteLine("IdCard=" + trump.IdCard);
Console.WriteLine("Birthday=" + trump.Birthday.ToString("dd/MM/yyyy"));
Console.WriteLine("Lương của Trump=>" + trump.calSalary());


Console.WriteLine("--------------------Thong tin cach 2 cua Employee-----------------------------");
Console.WriteLine(obama);
Console.WriteLine(trump);