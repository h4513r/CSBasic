using OopPolymorphismOverloading;

//object initializer

BasicMath basic1 =new BasicMath();

//BasicMath basic2 =new BasicMath()
//{
//    NumberOne = 5
//};

//BasicMath basic3 =new BasicMath()
//{
//    NumberTwo = 7
//};

//BasicMath basic4 =new BasicMath()
//{
//    NumberOne = 5,
//    NumberTwo = 10

//};

basic1.Sum(); //=>0
basic1.Sum(5,6); //=>11
basic1.Sum(5);

//named argumemt
basic1.Sum(num2: 5);
basic1.Sum(num2: 5, num1:9);