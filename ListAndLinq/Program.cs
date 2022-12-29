


Console.InputEncoding =  Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

List<Student> list = new()
{
    new Student(){Id = 1, Name = "khắc nguyên", Gender = true, Dob = new DateTime(1982, 04, 27)} ,
    new Student(){Id = 2, Name = "trung nghị", Gender = true, Dob = new DateTime(2003, 01, 01)} ,
    new Student(){Id = 3, Name = "tuấn anh", Gender = true, Dob = new DateTime(2003, 02, 05)} ,
    new Student(){Id = 4, Name = "trung tín", Gender = true, Dob = new DateTime(2003, 09, 27)} ,
    new Student(){Id = 5, Name = "ngọc anh", Gender = false, Dob = new DateTime(2003, 03, 08)} ,
};

//duyệt qua list bằng vòng lặp foreach
//foreach (var stu in list)
//{
//    Console.WriteLine(stu);
//}

//vòng lặp foreach sẽ chuyển thành
//IEnumerator<Student> enu = list.GetEnumerator();
//while (enu.MoveNext())
//{
//    Console.WriteLine(enu.Current.ToString());
//}

//duyệt qua list
//list.ForEach(Console.WriteLine);

//linq = language integrated query
//linq to sql => website thay thế cú pháp sql trong c#
//linq to object => console
//sql => select from where group by having order by
//c# => FROM WHERE GROUP BY HAVING ORDER BY ...SELECT
//linq có 2 dạng
//style 1 => query syntax => dựa theo cú pháp của sql, dễ học, dễ dùng
//style 2 => method syntax => dựa theo lambda => khó học, khó dùng, nhưng cực nhanh

//hiển thị toàn bộ thông tin sinh viên trong list, với điều kiện id sinh viên phải lớn hơn 2

//foreach (var stu in list)
//{
//    if (stu.Id > 2)
//    {
//        Console.WriteLine(stu);
//    }
//}

//====style 1 của linq : query syntax
//var t = from stu in list
//        where stu.Id > 2
//        select stu;

//foreach (var i in t)
//{
//    Console.WriteLine(i);
//}

//====style 1 của linq thu gon
//foreach (var i in from stu in list where stu.Id > 2 select stu)
//{
//    Console.WriteLine(i);
//}


//====style 2 của linq : method syntax

//var t = list.Where(stu => stu.Id > 2);
//foreach (var i in t)
//{
//    Console.WriteLine(i);
//}

//====style 2 của linq : method syntax rut gon

//foreach (var i in list.Where(stu => stu.Id > 2))
//{
//    Console.WriteLine(i);
//}

//kế hợp với foreach của list
//list.Where(stu => stu.Id > 2)
//    .ToList()
//    .ForEach(Console.WriteLine);


//var t = from stu in list
//        select stu;
//tương đương
//IEnumerable<Student> i = from stu in list
//                        select stu;

//với linq to object 
//khi sử dụng query syntax hay method synatx thi trả về không phải là list, hay array => IEnumerable (con của ienumarator duyệt qua collection: list, array, dictionary, hashmap...) dùng để duyệt qua linq to object.

//list.ForEach(Console.WriteLine);

//t.ToList().ForEach(Console.WriteLine);

//câu lệnh foreach
//foreach (var stu in list)
//{
//    if (stu.Id > 2)
//    {
//        Console.WriteLine(stu);
//    }
//}
//==phuong thuc co san tu list (áp dụng lambda)
//list.ForEach(
//    stu =>
//    {
//        if (stu.Id > 2)
//        {
//            Console.WriteLine(stu);
//        }
//    }
//);

//linq
//linq => method syntax
//list.Where(stu => stu.Id>2)
//    .ToList()
//    .ForEach(Console.WriteLine);

//query syntax
//var t = from stu in list
//        where stu.Id >2
//        select stu;
//t.ToList().ForEach(Console.WriteLine);

//lấy thuôc tính từ sinh viên như câu select lấy các cột
//query syntax
var t = from stu in list
    where stu.Id > 2
    select new
    {
        Info     = $"{stu.Id} : {stu.Name}",
        Birthday = stu.Dob 
    };

t.ToList().ForEach(i => Console.WriteLine(i.Birthday));

//method syntax
list.Where(stu=>stu.Id>2)
    .Select(stu=>new
            {
                Info = $"{stu.Id} : {stu.Name}",
                stu.Gender
            }
    )
    .ToList()
    .ForEach(Console.WriteLine);


//sắp xếp trực tự:
list.Where(stu=>stu.Id >2)
    .OrderBy(stu => stu.Id)
    .ThenBy(stu=>stu.Name)
    .ToList()
    .ForEach(Console.WriteLine);

list.Where(stu=>stu.Id >2)
    .OrderByDescending(stu => stu.Id)
    .ThenByDescending(stu=>stu.Name)
    .ToList()
    .ForEach(Console.WriteLine);


list.Select(stu=>stu)
    .Where(stu=>stu.Id >2)
    .ToList()
    .ForEach(Console.WriteLine);

list.Where(stu=>stu.Id >2)
    .Select(stu=>stu)
    .ToList()
    .ForEach(Console.WriteLine);



