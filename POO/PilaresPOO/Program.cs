﻿// Herança
// Abstração
// Encapsulamento
// Polimorfismo

using PilaresPOO.Classes.Apredizagem;
System.Console.Clear();

Aluno persona = new Aluno();
persona.Nome = "Higor";

// System.Console.WriteLine($"{persona.Nome} nasceu com {persona.Idade} anos");

//dados professor
Professor sam = new Professor(12334);
sam.Nome = "Samanta";
sam.Idade = 22;



//dados alunos
// Aluno isaacBorgers = new Aluno();
// isaacBorgers.Nome = "Isaac Borgers";
// isaacBorgers.Idade = 16;
// isaacBorgers.CPF = "698.999.599-49";
// isaacBorgers.Peso = 89.7f;
// isaacBorgers.Altura = 1.80f;
// isaacBorgers.Matricula = 12345;
// isaacBorgers.Curso = "Dev";
// isaacBorgers.Media = 7.9f;

// Console.WriteLine($"Curso: {isaacBorgers.Curso}");
// Console.WriteLine($"    Professor: {sam.Nome}");
// Console.WriteLine($"    Identificação do Professor: {sam.NIF}");
// Console.WriteLine($"Aluno: {isaacBorgers.Nome}");
// Console.WriteLine($"Matricula: {isaacBorgers.Matricula}");
// Console.WriteLine($"Idade {isaacBorgers.Idade}");
// Console.WriteLine($"CPF: {isaacBorgers.CPF}");
// Console.WriteLine($"Peso: {isaacBorgers.Peso}");
// Console.WriteLine($"Altura: {isaacBorgers.Altura}");



////////////////// VEICULOS ///////////////////

Carro carro1 = new Carro();
carro1.Marca = "Toyota";
carro1.Modelo = "Supra MK4";
carro1.Potencia = "326 cv";
carro1.QtdPassageiro = 2;
carro1.QtdPortas = 2;

Moto moto1 = new Moto();
moto1.Marca = "BMW";
moto1.Modelo = "F800";
moto1.Potencia = "87 cv";
moto1.QtdPassageiro = 2;

Aviao aviao1 = new Aviao();
aviao1.Marca = "Boeing ";
aviao1.Modelo = "Boeing 777";
aviao1.Potencia = "165.000 cv";
aviao1.QtdPassageiro = 440;
aviao1.QtdPortas = 6;

Console.WriteLine($"marca: {carro1.Marca}");
Console.WriteLine($"modelo: {carro1.Modelo}");
Console.WriteLine($"Potencia: {carro1.Potencia}");
Console.WriteLine($"Passageitos: {carro1.QtdPassageiro}");
Console.WriteLine($"Portas: {carro1.QtdPortas}");
carro1.Ligar();
carro1.Desligar();
carro1.Buzinar();
System.Console.WriteLine();
Console.WriteLine($"marca: {moto1.Marca}");
Console.WriteLine($"modelo: {moto1.Modelo}");
Console.WriteLine($"Potencia: {moto1.Potencia}");
Console.WriteLine($"Passageitos: {moto1.QtdPassageiro}");
moto1.Ligar();
moto1.Desligar();
moto1.Buzinar();
System.Console.WriteLine();
Console.WriteLine($"marca: {aviao1.Marca}");
Console.WriteLine($"modelo: {aviao1.Modelo}");
Console.WriteLine($"Potencia: {aviao1.Potencia}");
Console.WriteLine($"Passageitos: {aviao1.QtdPassageiro}");
Console.WriteLine($"Portas: {aviao1.QtdPortas}");
aviao1.Ligar();
aviao1.Desligar();
aviao1.Buzinar();

