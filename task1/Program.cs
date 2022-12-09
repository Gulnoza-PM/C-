int a,b,c;
a=int.Parse(Console.ReadLine()!);
b=int.Parse(Console.ReadLine()!);
c = int.Parse(Console.ReadLine()!);
int maxim;
if(a>b&&a>c)maxim=a;
else 
if(b>a&&b>c) maxim=b;
else 
if(c>a&&c>b) maxim=c;
Console.WriteLine(maxim);