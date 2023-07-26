using System;
namespace YourNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que escreva no console:
            //A média aritmética de altura---------------------------ok
            //A média aritmética de peso-----------------------------ok
            //O nome e IMC de cada uma das pessoas ------------------ok
            //O nome da pessoa mais alta e sua altura----------------ok
            //O nome da pessoa mais baixa e sua altura---------------ok
            //O nome da pessoa mais pesada e seu peso----------------ok
            //O nome da pessoa mais leve e seu peso------------------ok
            //O nome da pessoa com o maior IMC e seu valor------------ok
            //O nome da pessoa com o menor IMC e seu valor------------ok
            //Considere o cálculo do IMC como: IMC = peso/(altura*altura)
            string[,] dadosPessoas = {
            {"Ana", "Paulo", "Márcia", "Pedro", "Beatriz"},
            {"1.70", "1.72", "1.62", "1.90", "1.53" },
            {"80", "90", "61", "84", "49"}
            };
            //----------------recebendo alturas
            var alturaAna = dadosPessoas[1, 0];
            var alturaPaulo = dadosPessoas[1, 1];
            var alturaMarcia = dadosPessoas[1, 2];
            var alturaPedro = dadosPessoas[1, 3];
            var alturaBeatriz = dadosPessoas[1, 4];
            float mediaAlturas = (float.Parse(alturaAna) + float.Parse(alturaPaulo) + float.Parse(alturaMarcia) + float.Parse(alturaPedro) + float.Parse(alturaBeatriz)) / 5;
            Console.WriteLine($"A média aritmética de altura é: {mediaAlturas}");
            //----------------recebendo pesos
            var pesoAna = dadosPessoas[2, 0];
            var pesoPaulo = dadosPessoas[2, 1];
            var pesoMarcia = dadosPessoas[2, 2];
            var pesoPedro = dadosPessoas[2, 3];
            var pesoBeatriz = dadosPessoas[2, 4];
            float mediapeso = (float.Parse(pesoAna) + float.Parse(pesoPaulo) + float.Parse(pesoMarcia) + float.Parse(pesoPedro) + float.Parse(pesoBeatriz)) / 5;
            Console.WriteLine($"A média aritmética do peso é: {mediapeso}");
            //----------------calculando IMCs
            //ana
            var imcAna = (float.Parse(pesoAna))/((float.Parse(alturaAna)) * (float.Parse(alturaAna)));
            Console.WriteLine($"O IMC da Ana é: {imcAna}");
            //paulo
            var imcPaulo = (float.Parse(pesoPaulo)) / ((float.Parse(alturaPaulo)) * (float.Parse(alturaPaulo)));
            Console.WriteLine($"O IMC do Paulo é: {imcPaulo}");
            //marcia
            var imcMarcia = (float.Parse(pesoMarcia)) / ((float.Parse(alturaMarcia)) * (float.Parse(alturaMarcia)));
            Console.WriteLine($"O IMC da Marcia é: {imcMarcia}");
            //Pedro
            var imcPedro = (float.Parse(pesoPedro)) / ((float.Parse(alturaPedro)) * (float.Parse(alturaPedro)));
            Console.WriteLine($"O IMC do Pedro é: {imcPedro}");
            //Beatriz
            var imcBeatriz = (float.Parse(pesoBeatriz)) / ((float.Parse(alturaBeatriz)) * (float.Parse(alturaBeatriz)));
            Console.WriteLine($"O IMC do Beatriz é: {imcBeatriz}");
            //----------------comparando alturas: ANA

            string nomeMaisAlta = "";
            string nomeMaisBaixa = "";
            float alturaMaisAlta = 0;
            float alturaMaisBaixa = float.MaxValue;

            for (int i = 0; i < dadosPessoas.GetLength(1); i++)
            {
                string nomePessoa = dadosPessoas[0, i];
                float altura = float.Parse(dadosPessoas[1, i]);

                if (altura > alturaMaisAlta)
                {
                    alturaMaisAlta = altura;
                    nomeMaisAlta = nomePessoa;
                }

                if (altura < alturaMaisBaixa)
                {
                    alturaMaisBaixa = altura;
                    nomeMaisBaixa = nomePessoa;
                }
            }

            Console.WriteLine($"A pessoa mais alta é {nomeMaisAlta} com altura de {alturaMaisAlta:0,00} centimetros.");
            Console.WriteLine($"A pessoa mais baixa é {nomeMaisBaixa} com altura de {alturaMaisBaixa:0,00} centimetros.");
            //-----------------------------------
            //--------------PESO

            string nomeLeve = "";
            string nomePesado = "";
            float pesoPesado = 0;
            float pesoLeve = float.MaxValue;

            for (int i = 0; i < dadosPessoas.GetLength(1); i++)
            {
                string nomePessoa = dadosPessoas[0, i];
                float peso = float.Parse(dadosPessoas[2, i]);

                if (peso > pesoPesado)
                {
                    pesoPesado = peso;
                    nomePesado = nomePessoa;
                }

                if (peso < pesoLeve)
                {
                    pesoLeve = peso;
                    nomeLeve = nomePessoa;
                }
            }

            Console.WriteLine($"A pessoa mais pesada é {nomePesado} com {pesoPesado} quilos.");
            Console.WriteLine($"A pessoa mais leve é {nomeLeve} com {pesoLeve} quilos.");

            //----------IMC DE NOVO DE UM JEITO DIFERENTE---------------

            float maiorIMC = float.MinValue;
            float menorIMC = float.MaxValue;
            string nomeMaiorIMC = "";
            string nomeMenorIMC = "";

            for (int i = 0; i < dadosPessoas.GetLength(1); i++)
            {
                string nome = dadosPessoas[0, i];
                float altura = float.Parse(dadosPessoas[1, i]);
                float peso = float.Parse(dadosPessoas[2, i]);

                float imc = peso / (altura * altura);

                if (imc > maiorIMC)
                {
                    maiorIMC = imc;
                    nomeMaiorIMC = nome;
                }

                if (imc < menorIMC)
                {
                    menorIMC = imc;
                    nomeMenorIMC = nome;
                }
            }

            Console.WriteLine($"A pessoa com maior IMC é {nomeMaiorIMC} com IMC de {maiorIMC}");
            Console.WriteLine($"A pessoa com menor IMC é {nomeMenorIMC} com IMC de {menorIMC}");

            //tive dificuldade com a questão de conversão de string mas espero que seja um resultado bom.
            //obrigada pelas aulas e até uma proxima! :)
        }
    }
}