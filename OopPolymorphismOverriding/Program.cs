using OopPolymorphismOverriding;

Parent pa = new();
pa.Show();
pa.Display();

ChildOne co = new();
co.Show();
co.Display();


Parent p = new ChildOne();
p.Display();
p.Show(); //show của cha, chứ ko phải của con