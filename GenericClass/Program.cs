using GenericClass;

ClassT<int> cl = new();
cl.Field = 10;
cl.Show();

ClassT<string> cl1 = new();
cl1.Field = "số 10";
cl1.Show();

ClassT<bool> cl2 = new();
cl2.Field = true;
cl2.Show();

ClassUV<bool, string> cl3 = new();
cl3.Field1 = true;
cl3.Field2 = "abc";

ClassUV<int, double> cl4 = new();
cl4.Field1 = 100;
cl4.Field2 = 105.12;