// Faça um programa que carregue 1 array tamanho 6 com números inteiros. 
// Calcule e imprima a quantidade de números ímpares e a quantidade de números pares.

int [] num = new int[6];
int impar = 0;
int par = 0;

for (int i = 0; i < 6; i++) {
 
Console.WriteLine($"Digite um numero inteiro:");
num[i] = int.Parse(Console.ReadLine());

if (num [i] % 2 == 0){
par++;

 }else {

    impar++;
 }

}

Console.WriteLine($"a quantia de numeros impares {impar} ");
Console.WriteLine($"a quantia de numeros pares {par} ");