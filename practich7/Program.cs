int number, prev, proshloe;

    Console.WriteLine("Введите последовательность чисел (окончить ввод числом 10000):");

   
    prev = int.Parse(Console.ReadLine());
    proshloe = 1;


    do
    {
        number = int.Parse(Console.ReadLine());
        proshloe++;

        if (number < prev)
        {
            Console.WriteLine($"Последовательность не упорядочена. Нарушение на позиции {proshloe}.");
            return;
        }

        prev = number;

    } while (number != 10000);

    Console.WriteLine("Последовательность упорядочена по возрастанию.");
