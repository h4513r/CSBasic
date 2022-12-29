namespace OopAbstraction;

internal class Dog : Animal
{
    //thự thi lại cái phương thức abstract của animal
    //buộc phải dùng từ khóa override vào
  
    public override void ShowInfo()
    {
        Console.WriteLine("this is a dog");
    }
}
