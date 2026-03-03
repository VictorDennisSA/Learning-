using System.Collections.Generic;
using System.Diagnostics;
string[] diasSemana = new string[7] { "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sabado", "Domingo"};
foreach(string s in diasSemana)
{
    Console.WriteLine($"\n{s}");
}
Thread.Sleep(2000);
Console.Clear();
List<string> Alunos = new List<string>();
Alunos.Add("Jefferson");
Alunos.Add("Jovisgleison");
Alunos.Add("Kleberson");
Alunos.Add("Carimbo");
Alunos.Add("Antoniesco");
Alunos.Add("Claytonuário");
//Console.WriteLine($"\n{Alunos[3]}");

for (int i = 0; i < Alunos.Count; i++)
{
    Console.WriteLine($"\n{Alunos[i]}");
}
Thread.Sleep(3000);
Console.Clear();

bool existe = Alunos.Contains("Carimbo");
Console.WriteLine($"Carimbo é { existe}");
Thread.Sleep(2000);
Console.Clear();

Alunos.Sort();
foreach(string s in Alunos) 
{
    Console.WriteLine(s);
}
    
//Alunos.Clear();