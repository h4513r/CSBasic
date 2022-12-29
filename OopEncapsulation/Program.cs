using OopEncapsulation;

SunFlower flower = new();
//flower.Protected(); => error vì chỉ có quan hệ giữa các class
flower.Internal();         //trong cùng project/assembly
//flower.PrivateProtected(); //hoặc private hoặc là protected thì được dùng
flower.ProtectedInternal();
flower.Public();
//flower.Private(); => error vì  chỉ đứng tại class đó mới được dùng