﻿namespace OopAbstraction;


//kế thừa dùng dấu :
internal abstract class Cat : Animal
{
    //con kế thừa cha, mà cha là abstract, con phải thực thi lại các phương thức abstract, nếu không con cũng là abstract
    private bool gender;

    //1 phương thức mà chỉ có 1 câu lệnh duy nhất
    //chuyển thành expression body
    public void ShowCat() => Console.WriteLine("this is a cat");
}
