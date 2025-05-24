using System.Text;

string do_math(double a, double b, string op)
{
    string result = "";
    switch (op)
    {
        case "+":
            result = $"{a}+{b}={a + b}";
            break;
        case "-":
            result = a + " - " + b + "=" + (a - b);
            break;
        case "*":
            result = $"{a}*{b} = {a * b}";
            break;
        case "/":
            if (b == 0)
                result = "Mẫu số phải khác 0";
            else
                result = $"{a} / {b} = {a / b}";
            break;
        default:
            result = "Nhập phép toán tào lao";
            break;
    }
    return result;
}

Console.OutputEncoding = Encoding.UTF8;
double a, b;
Console.WriteLine("Enter a: ");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Enter b: ");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Choose +, -, *, /");
string op = Console.ReadLine();
string result = do_math(a, b, op);
Console.WriteLine(result);