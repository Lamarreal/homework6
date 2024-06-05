

static void Proggram()
{
	try
	{
		Console.WriteLine("Enter two numbes, second number must be greater than first");
		Console.Write("> ");
		string? Inp1 = Console.ReadLine();
        Console.Write("> ");
        string? Inp2 = Console.ReadLine();

		int int1 = Convert.ToInt32(Inp1);
		int int2 = Convert.ToInt32(Inp2);

		int Count = 0;
        int Count2 = 0;
        int Count3 = 0;

        List<int> doubles = new();
        List<int> NonPair = new();

        List<int> DividedbyNine = new();

        if (int1 >= int2)
			throw new Exception("second number must be greater than firs");

		for (int i = int1 + 1; i < int2; i++)
		{
			Console.Write("{0}   ", i);
		}

		Console.WriteLine("\n               ");

        for (int i = int2; i > int1; i--)
        {
            Console.Write("{0}   ", i);
        }
        Console.WriteLine("\n               ");
        for (int i = int1 + 1; i < int2; i++)
        {
			if (i % 7 == 0)
				Console.Write("{0}   ", i);
        }
        Console.WriteLine("\n               ");

        for (int i = int1 + 1; i < int2; i++)
        {
            if (i % 5 == 0)
                Count++;
        }
		Console.WriteLine("{0} numbers can be divided by 5", Count);

        int Nines = 0;
        int two = 0;
        int three = 0;

        for (int i = int1 + 1; i < int2; i++)
        {
            if (i % 9 == 0)
            {
                Nines+=i;
                DividedbyNine.Add(i);
            }
                
        }

        for (int i = int1 + 1; i < int2; i++)
        {
            if (i % 2 == 0)
            {
                Count2++;
                two += i;
                doubles.Add(i);
            } 
            else
            {
                three += i;
                Count3++;
                NonPair.Add(i);
            }
               
        }

        Console.WriteLine("\n               ");

        Console.WriteLine("{0} doubles {1} nonpair", Count2, Count3);

        int DividedByNineAverage = Nines / DividedbyNine.Count();
        int DividedByTwoAverage = two / Count2;
        int NonPairAverage = three / Count3;


        Console.WriteLine("Average: {0} doubles {1} nonpair  {2} devided by nine", DividedByTwoAverage, NonPairAverage,DividedByNineAverage);
    }
	catch (Exception e)
	{
		Console.Clear();
		Console.WriteLine($"{e.Message}");
		Proggram();
	}

}



Proggram();