// using System;
// class program
// {
//     public static void Main(string[] args){
//     Console.WriteLine("Enter string 1");
//     string str1=Console.ReadLine();
//     Console.WriteLine("Enter string 2");
//     string str2=Console.ReadLine();
//     string result=" ";
//     HashSet<char> h = new HashSet<char>();
//     for(int i = 0; i < str2.Length; i++)
//         {
//             h.Add(str2[i]);
//         }
//     for(int i = 0; i < str1.Length; i++)
//         {
//             if((str1[i] !='a' && str1[i] !='e'&&str1[i] !='i'&&str1[i] !='o'&&str1[i] !='u' &&str1[i] !='A'&&str1[i] !='E'&&str1[i] !='I'&&str1[i] !='O'&&str1[i] != 'U') && h.Contains(str1[i]))
//             {
//                 continue;
//             }
//             else
//             {
//                 result+=str1[i];
//             }
//         }
       
//      Console.WriteLine(result);
//      string result1=" ";
//      for(int i = 1; i < result.Length; i++)
//         {
//             if(result[i]!=result[i-1])
//             result1+=result[i];
//         }
//         Console.WriteLine(result1);
// }
// }