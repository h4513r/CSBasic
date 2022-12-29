namespace PartialClass;

internal partial class Human
{

    //1 phương thức mà chỉ có 1 câu lệnh
    //csharp sẽ không sử dụng phương thức mà dùng
    //expression body => biếu thức dưới dạng phương thức

    public void Show() =>
        Console.WriteLine($"{nameof(fullname)}={fullname}");


    public void Check() => Console.WriteLine(10 > 5 ? true : false);
}
