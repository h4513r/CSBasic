using System.Text;
using ExtentionMethod;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Console.WriteLine("vui lòng nhập vào giá trị cho biến i: ");

int i = int.TryParse(Console.ReadLine(), out int result)?result:0;

CheckNumber.CheckIsGreaterThan(i, 100);

i.CheckIsGreaterThan(100);

Program pro = new();
pro.Hello();