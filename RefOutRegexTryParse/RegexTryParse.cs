namespace RefOutRegexTryParse;

internal class RegexTryParse
{

    public void CheckNumberByRegex()
    {
        string? str = null;
        Console.WriteLine("vui lòng nhập số: ");
        str = Console.ReadLine();

        if (new Regex("^[0-9]+$").IsMatch(str))
        {
            int result = int.Parse(str);
            Console.WriteLine($"{nameof(result)}={result}");
        }
    }

    public void CheckStringByTryParse()
    {
        string? str = null;
        Console.WriteLine("vui lòng nhập số: ");
        str = Console.ReadLine();

        if (double.TryParse(str, out double i))
        {
            Console.WriteLine($"{nameof(i)}={i}");
        }
    }

    public void TryCatchBug()
    {
        Console.WriteLine("vui lòng nhập số lượng: ");
        string? amount = Console.ReadLine();
        try
        {
            int total = int.Parse(amount);
            if (total <= 0)
            {
                throw new Exception("phải lớn hơn 0");
            }
        }
        catch (Exception) when (amount.Contains("$"))
        {
            Console.WriteLine("amount ko được có dấu $");
        }
        catch (Exception e)
        {
            Console.WriteLine($"{e.GetType()} : {e.Message}");
        }
    }
}
