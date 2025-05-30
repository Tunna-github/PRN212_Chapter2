/*
 sử dụng Generic List để quản lý nhân sự với đầy đủ 
Tính năng CRUD
C -> CREATE = tạo mới dữ liệu
R -> Read/Retrive = xem, lọc, tìm kiếm, sắp xếp, thống kê...
U -> Update = sửa dữ liệu
D -> Delelte = xóa dữ liệu 
 */

//Cau 1: tao 5 nhan vien, trong do 3 nhan vien chinh thuc va 2 thoi vu, luu vao Generic list
using OOP2;
using System.Text;

List<Employee> employees = new List<Employee>();

Console.OutputEncoding = Encoding.UTF8;

FulltimeEployee fe1 = new FulltimeEployee();
fe1.Id = 1;
fe1.Name = "Putin";
fe1.IdCard = "12345";
fe1.Birthday = new DateTime(1952, 12, 25);
employees.Add(fe1);

FulltimeEployee fe2 = new FulltimeEployee();
fe2.Id = 1;
fe2.Name = "Putin";
fe2.IdCard = "12345";
fe2.Birthday = new DateTime(1952, 12, 25);
employees.Add(fe2);

FulltimeEployee fe3 = new FulltimeEployee();
fe3.Id = 1;
fe3.Name = "Putin";
fe3.IdCard = "12345";
fe3.Birthday = new DateTime(1952, 12, 25);
employees.Add(fe3);

ParttimeEmployee pe1 = new ParttimeEmployee();
pe1.Id = 1;
pe1.Name = "Putin";
pe1.IdCard = "12345";
pe1.Birthday = new DateTime(1952, 12, 25);
pe1.WorkingHour = 3;
employees.Add(pe1);

ParttimeEmployee pe2 = new ParttimeEmployee();
pe2.Id = 1;
pe2.Name = "Putin";
pe2.IdCard = "12345";
pe2.Birthday = new DateTime(1952, 12, 25);
pe2.WorkingHour = 2;
employees.Add(pe2);

//Cau 2: Xuat toan bo nhan su
Console.WriteLine("Cau 2: Xuat ra toan bo nhan vien");
employees.ForEach(e => Console.WriteLine(e));

//Cau 3: R -> Loc ra cac nhan su la chinh thuc
//cach 1
List<FulltimeEployee> fe_list = employees.OfType<FulltimeEployee>().ToList();
Console.WriteLine("Cau 3: Xuat ra nhan vien chinh thuc");
foreach(FulltimeEployee fe in fe_list)
    Console.WriteLine(fe);

//cau 4: tong luong nhan vien chinh thuc
double fe_sum_salary = fe_list.Sum(e => e.calSalary());
Console.WriteLine("Tong luong nhan vien chinh thuc");
Console.WriteLine(fe_sum_salary);

//cau 5: Tong luong nhan vien thoi vu
double pe_sum_salary = employees.OfType<ParttimeEmployee>().Sum(e=>e.calSalary());
Console.WriteLine("Tong luong nhan vien thoi vu");
Console.WriteLine(pe_sum_salary);

//BTVN: Bo sung them cac tinh nang xoa va sua(ten, ngay thang nam sinh)
void UpdateEmployee(int id, string newName, DateTime newBirthday)
{
    var employee = employees.FirstOrDefault(e => e.Id == id);
    if (employee != null)
    {
        employee.Name = newName;
        employee.Birthday = newBirthday;
        Console.WriteLine($"Đã cập nhật nhân viên ID {id}");
    }
    else
    {
        Console.WriteLine($"Không tìm thấy nhân viên với ID {id}");
    }
}

void DeleteEmployee(int id)
{
    var employee = employees.FirstOrDefault(e => e.Id == id);
    if (employee != null)
    {
        employees.Remove(employee);
        Console.WriteLine($"Đã xóa nhân viên ID {id}");
    }
    else
    {
        Console.WriteLine($"Không tìm thấy nhân viên với ID {id}");
    }
}

UpdateEmployee(1, "Teo", new DateTime(1990, 5, 10));
DeleteEmployee(1);