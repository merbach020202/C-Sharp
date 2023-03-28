//string name = "Eduardo";
//Console.WriteLine(name);

//int idade = 36;
//idade = 50;

//const int idade = 36;

//Console.WriteLine("A idade do " + name + " é " + idade + " anos" );

//float preço = 9.99F;

//bool careca = false;
//Console.WriteLine(careca);

//////////////////////////Operadores

//atribuicao =
// int x = 15;

// //operadores aritimeticos
// //soma
// Console.WriteLine(5 + 4);
// Console.WriteLine(5 + "4");  //quando algo esta entre parenteses, ele automaticamente se junta ao valor anterior, nesse caso, nao ia ser "5 + 4 = 9, ia acabar ficando "5 + "4" = 54 "

// //subtracao
// Console.WriteLine(15 - 3);

// //multiplicacao
// Console.WriteLine(5*5);

// //divisao
// Console.WriteLine(10/10);

// //modular
// Console.WriteLine(5 % 2);




/////////////////////////// //operadores de comparacao

// //igual a 
// Console.WriteLine(5 == 7);


// // maior ou igual a
// Console.WriteLine(5 >= 10);


// //menor ou igual a
// Console.WriteLine(4 <= 10);


// //maior que
// Console.WriteLine(150 > 95);



// //menor que
// Console.WriteLine( 54 < 54);



// //diferente de
// Console.WriteLine( 5 != 6);



///////////////////operadores logicos

// && : e
// || : ou
// ! : nao

// Console.WriteLine( 5 == 5 && 8 == 8); //TRUE && TRUE = TRUE ///////quando usamos &&, as 2 partes precisam ser verdadeiras para que a resposta final seja verdadeira, se 1 parte for falsa, o resultado ja vai ser falso
// Console.WriteLine( 5 == 5 && 8 == 5); //TRUE && FALSE = FALSE
// Console.WriteLine( 5 == 6 && 8 == 8); //FALSE && TRUE = FALSE
// Console.WriteLine( 5 == 6 && 8 == 5); //FALSE && FALSE = FALSE


// Console.WriteLine(2 == 2 || 3 == 3); //TRUE || TRUE = TRUE ///////quando usamos ||, as 2 partes nao precisam ser verdadeiras para que a resposta final seja verdadeira, se 1 parte for verdadeira, o resultado ja vai ser verdadeiro
// Console.WriteLine(2 == 2 || 3 == 4); //TRUE || FALSE = TRUE
// Console.WriteLine(2 == 4 || 3 == 3); //FALSE || TRUE = TRUE
// Console.WriteLine(2 == 4 || 3 == 5); //FALSE || FALSE = FALSE

// Console.WriteLine(2 == 4 || 4 == 4 && 7 == 6);

// Console.WriteLine( !(2 == 2 || 3 == 3));





//Crie um programa para calcular o IMC de uma pessoa

//Algoritimo
//nome, idade, peso, altura
//processamento: peso dividido por altura ao quadrado

//entrada
string nome = "Eduardo";
int idade = 16;
float peso = 70;
float altura = 1.86F;

//processamento
float imc = peso / (altura * altura);

//saida
Console.WriteLine($"O IMC do " + nome + " e de : " + Math.Round(imc,2)); //No Math.Round eu defini a quantidade de casas decimais que a resposta iria ter, ao inves de ficar 20,4777777777, ficou apenas 20,47.



















