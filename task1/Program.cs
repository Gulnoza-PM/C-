int a,b,c;
a=int.Parse(Console.ReadLine());
b=int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());
int max;
if(a>b&&a>c)max=a;
else 
if(b>a&&b>c) max=b;
else 
if(c>a&&c>b) max=c;
Console.WriteLine(max);