int[] arr = new int[5];
int chet = 0;
int hlp = 0;
void Method(int a)
{
    if (a % 2 ==1)
    {
        // Нечетное
    }
    else
    {
        ++chet;
    }
}
Random rand = new Random();
for(int i =0;i<arr.Length;i++)
   arr[i] = rand.Next(100,999);
while (hlp < 5)
{
    Method(arr[hlp]);
    Console.Write(arr[hlp]);
    Console.Write(", ");
    ++hlp;
}
Console.Write(" -> ");
 Console.Write(chet);