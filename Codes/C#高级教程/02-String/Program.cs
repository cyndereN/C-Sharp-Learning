string s = "www.google.com";

Console.WriteLine(s.Length);

Console.WriteLine(s == "www.google.com");

//s = "http://" + s;

//Console.WriteLine(s);

Console.WriteLine(s[3]);


Console.WriteLine(s.CompareTo("www.google.com"));// 0 

Console.WriteLine(s.CompareTo("www.sikiedu.com"));// -1

Console.WriteLine( s.Replace( ".","-dsf" ));

string[] vs = s.Split(".");
foreach (string v in vs)
{
    Console.WriteLine(v);
}

Console.WriteLine(s.Substring(4));
Console.WriteLine(s.Substring(4, 4));

Console.WriteLine(s.ToLower());
Console.WriteLine(s.ToUpper());


//Console.WriteLine(s.Trim()) ;

Console.WriteLine( string.Concat("www.","sikiedu.com") );


char[] cA = new char[20];
s.CopyTo(4, cA, 1, 6);
foreach (char c in cA)
{
    Console.WriteLine(c);
}


int x = 23;
int y = 545;
int he = x + y;

Console.WriteLine(string.Format(" {0}+{1}={2}  {2}{1}", x, y, he));

int money = 120000;

Console.WriteLine(string.Format("{0:C}", money));

Console.WriteLine(string.Format("{0:F2}", 23.12512));

Console.WriteLine(string.Format("{0:P1}", 0.25657));

//DateOnly
//TimeOnly
DateTime dt = System.DateTime.Now;

Console.WriteLine(string.Format("{0:yyyy-MM-dd hh:mm}", dt));
// yyyy year  MM month dd-day  HH-hour hh mm-minute ss-second

Console.WriteLine(dt.ToString("yyyy-MM-dd hh:mm"));

Console.WriteLine(s.IndexOf("."));


Console.WriteLine(s.IndexOfAny(".g".ToCharArray()));

Console.WriteLine(s.Insert(3, "-----"));

char[] cB = { 'A', 'B', 'C', 'D' };

Console.WriteLine(string.Join("、", cB));
