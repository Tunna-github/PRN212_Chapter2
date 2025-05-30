using OOP2;
using OOP4_ResumeOOP2;
using System.Diagnostics;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

FulltimeEployee fe = new FulltimeEployee();
fe.Id = 1;
fe.Name = "Putin";
fe.IdCard = "12345";
fe.Birthday = new DateTime(1952, 12, 25);
Console.WriteLine(fe);
Console.WriteLine("=>Age=" + fe.Tuoi());
Console.WriteLine(fe.CheckBirthday());