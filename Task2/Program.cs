int[] arr = new int[5];
int hlp = 0;
int des = 0;
int sum = 0;
Random rand = new Random();
for(int i =0;i<arr.Length;i++)
arr[i] = rand.Next(-100,100);
while (hlp < 5)
{
    Console.Write(arr[hlp]);
    Console.Write(", ");
    ++hlp;
}
while(des < 6)
{
 sum = sum + arr[des];
 des = des + 2;
}
Console.Write(" -> ");
Console.Write(sum);