﻿// See https://aka.ms/new-console-template for more information
using TP_MOD5_1302213121;
Console.Write("Masukkan NIM: ");
string nim = Console.ReadLine();
DataGeneric_1302213121<string> data = new DataGeneric_1302213121<string>(nim);
data.PrintData_1302213121();