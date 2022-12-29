using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OopExercise.entity;
using OopExercise.Helper;
using OopExercise.Service;

namespace OopExercise.Dal;

internal class DalProduct : IProduct
{
    public List<Product> list { get; set; } = new();

    public void Add()
    {
        var n = Validate<int>.Input("please enter number of list");
        for (int i = 0; i < n; i++)
        {
            Product pro = new();
            pro.Id    = Validate<string>.Input("please enter id");
            pro.Name  = Validate<string>.Input("please enter name");
            pro.Price = Validate<double>.Input("please enter price");
            pro.Quantity = Validate<int>.Input("please enter quantity");
            pro.Mfg = Validate<DateTime>.Input("please enter mfg");
            list.Add(pro);
        }
    }

    public void Show()
    {
       list.ForEach(Console.WriteLine);
    }
}
