// using  System;
// class Program
// {
//     public static void Main(string[] args){
//     Console.WriteLine("Enter Range: ");
//     int n1=int.Parse(Console.ReadLine());
//     int n2=int.Parse(Console.ReadLine());
//     int Count=0;
//     for(int i = n1; i <= n2; i++)
//         {
//             int check=i;
//             int sum=0,rem=0;
//             while (check>0)
//             {
//                 rem=check%10;
//                 check/=10;
//                 sum+=rem;
//             }
//             int check2=i*i;
//             int sum1=0,rem1=0;
//             while (check2>0)
//             {
//                 rem1=check2%10;
//                 check2/=10;
//                 sum1+=rem1;
//             }
//             if (sum * sum == sum1)
//             {
//                 Console.WriteLine(i);
//                 Count++;
//             }
//         }
//         Console.WriteLine(Count);
// }
// }