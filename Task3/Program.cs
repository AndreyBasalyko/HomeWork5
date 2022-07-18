double[] arr = new double[5];
Random rand = new Random();
for(int i =0;i<arr.Length;i++)
arr[i] = rand.NextDouble() * 100;
int hlp = 0;
int red = 0;
int def = 0;
double min = arr[red];
double max = arr[def];
void Method(double a)
{
    if (max < a)
    {
        max = a;
    }
}
void MethodTwo(double b)
{
    if(min > b)
    {
      min = b;
    }
    
}
while (hlp < 5)
{
    Console.Write("{0,6:F2}", arr[hlp]);
    Console.Write(", ");
    ++hlp;
}
while (def < 5)
{
    Method(arr[def]);
    ++def;
}
while (red < 5)
{
    MethodTwo(arr[red]);
    ++red;
}
Console.Write(" -> ");
Console.Write("{0,6:F2}", max - min);