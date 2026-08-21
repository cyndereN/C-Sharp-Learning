// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

//string str1 = "434-32n";
//string str2 = "32423432";

//Console.WriteLine(@"1\n1\t2\\");
//Console.WriteLine(Regex.IsMatch(str1, @"\d\d\d\d\d\d"));
//Console.WriteLine(Regex.IsMatch(str2, @"\d\d\d\d\d\d"));
//Console.WriteLine(Regex.IsMatch(str1, @"\d*"));
//Console.WriteLine(Regex.IsMatch(str2, @"\d\d\d\d\d\d"));
//Console.WriteLine(Regex.IsMatch(str1, @"si*"));//s  si sii siiiii
//Console.WriteLine(Regex.IsMatch(str2, @"11*"));
//Console.WriteLine(Regex.IsMatch(str1, @"^4"));
//Console.WriteLine(Regex.IsMatch(str2, @"^4"));
//Console.WriteLine(Regex.IsMatch(str1, @"4$"));
//Console.WriteLine(Regex.IsMatch(str2, @"4$"));
//\d 数字                  \D补集
//\w 大小写字母 0-9 _        \W补集
//Console.WriteLine(Regex.IsMatch(str1, @"^\d*$"));
//Console.WriteLine(Regex.IsMatch(str2, @"^\d*$"));
//Console.WriteLine(Regex.IsMatch(str1, @"^\w*$"));
//Console.WriteLine(Regex.IsMatch(str2, @"^\w*$"));


//Console.WriteLine(Regex.IsMatch("a", @"[abcd]"));
//Console.WriteLine(Regex.IsMatch("e", @"[abcd]"));
//Console.WriteLine(Regex.IsMatch("y", @"[a-gx-z]"));
//Console.WriteLine(Regex.IsMatch("h", @"[a-gx-z]"));
//Console.WriteLine(Regex.IsMatch("h", @"[A-H]"));
//Console.WriteLine(Regex.IsMatch("h", @"[^A-H]"));// ^取反 取得除了什么之外的字符

//是否是合法标识符的
//string re = @"^[a-zA-Z_]\w*$";
//Console.WriteLine(Regex.IsMatch("sdfd", re));
//Console.WriteLine(Regex.IsMatch("23dfd", re));
//Console.WriteLine(Regex.IsMatch("sdf3dD", re));
//Console.WriteLine(Regex.IsMatch("_sdf3dD", re));
//Console.WriteLine(Regex.IsMatch("_sdf3d-D", re));

//string str = "www.sikiedu.com";

//Console.WriteLine( Regex.Replace(str,@"[a-z]","*") );

// 5-12
//string re = @"^\d{5,12}$";
//Console.WriteLine(Regex.IsMatch("456", re));
//Console.WriteLine(Regex.IsMatch("4d56", re));
//Console.WriteLine(Regex.IsMatch("1234567891248", re));
//Console.WriteLine(Regex.IsMatch("654874", re));

//Console.WriteLine(Regex.IsMatch("4", @"\d|a"));
//Console.WriteLine(Regex.IsMatch("a", @"\d|a"));
//Console.WriteLine(Regex.IsMatch("b", @"\d|a"));

//Console.WriteLine(Regex.IsMatch("aa", @"a{2}"));
//Console.WriteLine(Regex.IsMatch("ab", @"a{2}"));
//Console.WriteLine(Regex.IsMatch("abb", @"(ab){2}"));// abb
//Console.WriteLine(Regex.IsMatch("abab", @"(ab){2}"));// abb
Console.WriteLine(Regex.IsMatch("(", @"\("));// abb