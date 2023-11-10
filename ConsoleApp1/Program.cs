//высокий уровень, 3.4, 2 вар

Console.WriteLine($"|    x   |     f(x)    |");
for( double x = -2; x <= 3; x+=0.5)
{
    double n = 0;
    for(double k = 1;k <= 5; k++) 
    {
        double sumF = 1;
        for(double factorial = 1; factorial <= k+1; factorial++) sumF *= factorial;
        n += (Math.Pow(-2, k + 1) * sumF / Math.Pow(x + 2.5, k + 1));
    }
    Console.WriteLine($"|{x,6:F2} {"|",2}{n,11:F2}{"  |",2}");
}
