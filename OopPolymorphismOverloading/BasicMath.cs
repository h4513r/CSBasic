﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismOverloading;
internal class BasicMath
{
    public int NumberOne { get; set; }
    public int NumberTwo { get; set; }

    //overloading (1 là constructor , 2 là các method)
    //cùng tên chỉ khác tham số hay kiểu của tham số
    //public BasicMath()
    //{
        
    //}

    //public BasicMath(int numberOne, int numberTwo)
    //{
    //    NumberOne = numberOne;
    //    NumberTwo = numberTwo;
    //}

    //public BasicMath(int numberOne)
    //{
    //    NumberOne = numberOne;
    //}

    //public BasicMath(int numberTwo)
    //{
    //    NumberTwo = NumberTwo;
    //}


    //thay vì overloading phương thức

    //optional argument => đối số lựa chọn truyền cho tham số (parameter)
    public void Sum(int num1 = 0, int num2 = default)
    {
        NumberOne = num1;
        NumberTwo = num2;
        Console.WriteLine(NumberOne + NumberTwo);
    }

    //public void Sum()
    //{
    //    NumberOne = 0;
    //    NumberTwo = 0;
    //    Console.WriteLine(NumberOne + NumberTwo);
    //}
}
