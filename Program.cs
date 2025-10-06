int n=0;
int z = 0;
int zbroj=0;

Console.WriteLine("Unesite broj n: ");
n = int.Parse(Console.ReadLine());

/*for(int i=0; i<=n; i++)
{
    zbroj += i;
}
Console.WriteLine("Ukupni Fibonacijev zbroj je: {0}" , zbroj);*/
do
{
    z++;
    if (z % 2 == 0)
    {
        zbroj += z;
    }
} while (z < n);
Console.WriteLine("Ukupni Fibonacijev zbroj je: {0}", zbroj);