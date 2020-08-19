using System;

class MainClass {
	public static void Ex03 (int num1, int num2) {
		int soma;
		soma = num1 + num2;
		Console.WriteLine("A soma do {0}+{1} é igual a: {2}.", num1, num2, soma);
	}

	public static void Ex04 (float nota1, float nota2, float nota3, float nota4) {
		float media;
		media = (nota1 + nota2 + nota3 + nota4) / 4;
		Console.WriteLine("A média das notas é: {0}", media);
	}

  public static void Main (string[] args) {
		int num1, num2;

		Console.WriteLine ("Exercício 3 ");
    Console.Write ("Informe o primeiro número: ");
		num1 = int.Parse(Console.ReadLine());
		Console.Write ("Informe o segundo número: ");
		num2 = int.Parse(Console.ReadLine());

		Ex03(num1, num2);

		float nota1, nota2, nota3, nota4;

		Console.WriteLine ("Exercício 4 ");
    Console.Write ("Informe a primera nota: ");
		nota1 = float.Parse(Console.ReadLine());
		Console.Write ("Informe a segunda nota: ");
		nota2 = float.Parse(Console.ReadLine());
		Console.Write ("Informe a terceira nota: ");
		nota3 = float.Parse(Console.ReadLine());
		Console.Write ("Informe a quarta nota: ");
		nota4 = float.Parse(Console.ReadLine());

		Ex04(nota1, nota2, nota3, nota4);
  }
}