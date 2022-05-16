// See https://aka.ms/new-console-template for more information
//sum, average, largest number

{
    double sum=0,avg=0;
    Console.Write("How many numbers do you want to enter?");
    int n = Int32.Parse(Console.ReadLine());
    double[] numbers = new double[n];
    for(int i=0; i<numbers.Length;i++)
    {
        Console.Write("Number {0}:", i+1);
        numbers[i] = Convert.ToDouble(Console.ReadLine());
        sum += numbers[i];
    }
    avg = sum / numbers.Length;

    Console.WriteLine("The sum is: "+sum);
    Console.WriteLine("The average is:"+avg);

    Console.ReadKey();
}