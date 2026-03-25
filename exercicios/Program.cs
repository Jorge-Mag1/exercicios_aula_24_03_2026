using System.Runtime.CompilerServices;

namespace exe01
{
    internal class Program
    {

        /// <summary>
        /// 📋 SUMÁRIO DOS EXERCÍCIOS DE VARIÁVEIS E TIPOS DE DADOS
        /// =====================================================
        ///
        /// Exercício 1: Declaração de variáveis básicas
        /// - Aprender a declarar variáveis com tipos diferentes
        /// - Usar string (texto), int (números inteiros) e bool (verdadeiro/falso)
        /// - Utilizar o método GetType() para descobrir o tipo da variável
        ///
        /// Exercício 2: Reatribuição de valores
        /// - Entender que variáveis podem mudar de valor
        /// - Declarar uma variável e depois atribuir um novo valor
        ///
        /// Exercício 3: Flexibilidade do tipo object
        /// - Conhecer o tipo object que pode guardar qualquer tipo de dado
        /// - Ver como o tipo pode mudar durante a execução
        ///
        /// Demonstração adicional:
        /// - Conhecer outros tipos: double (decimais), char (um caractere), decimal (precisão monetária)
        /// </summary>




        static void Main(string[] args)
        {
            Console.WriteLine("\n📋 EXERCÍCIOS DE VARIÁVEIS E TIPOS DE DADOS");
            Console.WriteLine("==========================================================================================================\n");
 
            // ===================================================
            // EXERCÍCIO 1: Declaração de variáveis básicas
            // ===================================================
            // Objetivo: Aprender a criar variáveis com os tipos mais comuns
            // string → guarda texto
            // int → guarda números inteiros
            // bool → guarda verdadeiro (true) ou falso (false)
            Console.WriteLine("====================================================================================");
            Console.WriteLine("📝 Exercício 1: Variáveis básicas");
            Console.WriteLine("==================================================================================== \n");

            string nome = "Jorge";
            int idade = 32;
            bool aluno = true;

            Console.WriteLine("=== FICHA INSCRIÇÃO ===");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade + " anos");
            Console.WriteLine("É aluno? " + aluno);



            // ===================================================
            // EXERCÍCIO 2: Reatribuição de valores
            // ===================================================
            // Objetivo: Mostrar que variáveis podem receber novos valores
            // A mesma variável pode guardar um valor diferente mais tarde
            
            Console.WriteLine("====================================================================================");
            Console.WriteLine("📝 Exercício 2: Reatribuição de valores");
            Console.WriteLine("==================================================================================== \n");

            Console.WriteLine($"Olá {nome}, para além do teu nome e idade, {idade} anos, queremos mais informação.");
            Console.WriteLine("Qual o teu sobrenome?");
            string sobreNome = (Console.ReadLine()); 
            Console.WriteLine("Qual a tua altura?");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Desculpa, que idade tens mesmo?");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("ATUALIZAÇÃO:");
            Console.WriteLine($"Olá {nome} {sobreNome}, a tua altura é de {altura}m, e tens {idade} anos!");

 
            // ===================================================
            // EXERCÍCIO 3: Tipo object (equivalente ao any)
            // ===================================================
            // Objetivo: Entender que o tipo object pode guardar qualquer coisa
            // É como uma caixa que pode conter diferentes tipos de objetos

            Console.WriteLine("======================================================================================");        
            Console.WriteLine("📝 Exercício 3: Flexibilidade do tipo object");
            Console.WriteLine("====================================================================================== \n");

            object qualquerCoisa;
            qualquerCoisa = 17;

            Console.WriteLine($"O número preferido do {nome}, é o {qualquerCoisa}!");
    
            qualquerCoisa = "branco";

            Console.WriteLine($"A cor preferida do {nome}, é o {qualquerCoisa}!");
    

 
            // ===================================================
            // DEMONSTRAÇÃO ADICIONAL DE TIPOS
            // ===================================================
            // Objetivo: Conhecer mais tipos disponíveis em C#
            // double → números decimais (com vírgula)
            // char → um único caractere (letra)
            // decimal → números decimais com alta precisão (usado para dinheiro)
          
            Console.WriteLine("======================================================================================");        
            Console.WriteLine("📝 Exercício 4: Demonstração adicional de tipos");
            Console.WriteLine("====================================================================================== \n");

            Console.WriteLine($"{nome} pesquisa na loja online um produto...");

            decimal precoProduto = 19.99m;
            char codigoProduto = 'H';
            double classificacaoProduto = 4.50;
            bool stockProduto = true;

            Console.WriteLine($"Código Produto: {codigoProduto}");
            Console.WriteLine($"Preço: {precoProduto}€");
            Console.WriteLine($"Classificação: {classificacaoProduto} estrelas");
            
            Console.WriteLine($"Produto disponível em stock?");
            if (stockProduto) 
            {
                Console.WriteLine($"Produto em Stock!");
            } 
            else 
            {
                Console.WriteLine($"Produto Esgotado.");
            }



        }
    }
}

    
    