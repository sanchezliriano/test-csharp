int num = 0;
while (num < 5)
{
    Console.WriteLine("Introduce un numero?");
    //num = Convert.ToInt32(Console.ReadLine());
    var numx = Console.ReadLine();
    int numInt; 
    Int32.TryParse(numx, out numInt);
    num = numInt;

    //num = int.TryParse(Console.ReadLine(), out num);
    Console.WriteLine($"Numero introducido: {numInt}");
    //the test
}

Console.WriteLine("Haz introducido un numero mayor al permitido!--");
Console.Read();