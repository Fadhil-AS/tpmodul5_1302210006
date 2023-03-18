// See https://aka.ms/new-console-template for more information
using tpmodul5_1302210006;

Console.Write("Masukkan nama panggilan praktikan : ");
string username = Console.ReadLine();
HaloGeneric_13302210006.SapaUser_1302210006(username);
   

Console.Write("Masukkan NIM: ");
string nim = Console.ReadLine();
DataGeneric_1302210006<string> data = new DataGeneric_1302210006<string>(nim);
data.PrintData_1302210006();


