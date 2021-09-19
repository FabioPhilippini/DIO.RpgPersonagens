using DIO.RpgPersonagens.Entidade;
using DIO.RpgPersonagens.Enum;
using DIO.RpgPersonagens.Repositorio;
using System;

namespace DIO.RpgPersonagens.ConsoleApp
{
    public class Program
    {
        static PersonagemRepositorio repositorio = new PersonagemRepositorio();
        static void Main(string[] args)
        {
            String escolha = ObterEscolhaDoUsuario();

            while (escolha.ToUpper() != "X")
            {
                switch (escolha)
                {
                    case "1":
                        ListarPersonagens();
                        break;
                    case "2":
                        InserirPersonagem();
                        break;
                    case "3":
                        AtualizarPersonagem();
                        break;
                    case "4":
                        ExcluirPersonagem();
                        break;
                    case "5":
                        VisualizarPersonagem();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                escolha = ObterEscolhaDoUsuario();
            }
            Console.WriteLine("Fim da operação obrigado.");
            Console.ReadLine();

        }

        private static void VisualizarPersonagem()
        {
            Console.Write("Digite o id do personagem: ");
            int indicePersonagem = int.Parse(Console.ReadLine());
            var personagem = repositorio.RetornaPorId(indicePersonagem);
            Console.WriteLine(personagem);
        }

        private static void ExcluirPersonagem()
        {
            Console.Write("Digite o id do personagem: ");
            int indicePersonagem = int.Parse(Console.ReadLine());
            repositorio.Excluir(indicePersonagem);
        }

        private static void AtualizarPersonagem()
        {
            Console.Write("Digite o id do personagem: ");
            int indicePersonagem = int.Parse(Console.ReadLine());
            foreach(int i in System.Enum.GetValues(typeof(Classe)))
            {
                Console.WriteLine("{0}-{1}", i, System.Enum.GetName(typeof(Classe), i));
            }

            Console.Write("Digite o número classe entre as opções dadas: ");
            int entraClasse = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do jogador(a): ");
            string entraJogador = Console.ReadLine();

            Console.Write("Digite o nome do(a) personagem: ");
            string entraPersonagem = Console.ReadLine();

            Console.Write("Digite a raça do(a) personagem: ");
            string entraRaca = Console.ReadLine();

            Console.Write("Digite a força: ");
            int statusForca = int.Parse(Console.ReadLine());

            Console.Write("Digite a destreza: ");
            int statusDestreza = int.Parse(Console.ReadLine());

            Console.Write("Digite a vitalidade: ");
            int statusVitalidade = int.Parse(Console.ReadLine());

            Console.Write("Digite a energia: ");
            int statusEnergia = int.Parse(Console.ReadLine());

            Personagem atualizarPersonagem = new Personagem(id: repositorio.ProximoId(), classe: (Classe)entraClasse,
                                                         nomeJogador: entraJogador,
                                                         nomePersonagem: entraPersonagem,
                                                         raca: entraRaca,
                                                         forca: statusForca,
                                                         destreza: statusDestreza,
                                                         vitalidade: statusVitalidade,
                                                         energia: statusEnergia);
            repositorio.Atualizar(indicePersonagem, atualizarPersonagem);
        }

        private static void InserirPersonagem()
        {
            Console.WriteLine("Inserir Personagem");
            foreach(int i in System.Enum.GetValues(typeof(Classe)))
            {
                Console.WriteLine("{0}-{1}", i, System.Enum.GetName(typeof(Classe), i));
            }

            Console.Write("Digite o número da classe entre as opções dadas: ");
            int entraClasse = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do jogador(a): ");
            string entraJogador = Console.ReadLine();

            Console.Write("Digite o nome do(a) personagem: ");
            string entraPersonagem = Console.ReadLine();

            Console.Write("Digite a raça do(a) personagem: ");
            string entraRaca = Console.ReadLine();

            Console.Write("Digite a força: ");
            int statusForca = int.Parse(Console.ReadLine());

            Console.Write("Digite a destreza: ");
            int statusDestreza = int.Parse(Console.ReadLine());

            Console.Write("Digite a vitalidade: ");
            int statusVitalidade = int.Parse(Console.ReadLine());

            Console.Write("Digite a energia: ");
            int statusEnergia = int.Parse(Console.ReadLine());

            Personagem novoPersonagem = new Personagem(id: repositorio.ProximoId(), classe:(Classe)entraClasse,
                                                         nomeJogador: entraJogador,
                                                         nomePersonagem: entraPersonagem,
                                                         raca: entraRaca,
                                                         forca: statusForca,
                                                         destreza: statusDestreza,
                                                         vitalidade: statusVitalidade,
                                                         energia: statusEnergia);
            repositorio.Inserir(novoPersonagem);

        }

        private static void ListarPersonagens()
        {
            Console.WriteLine("Listar personagens");
            var lista = repositorio.Lista();
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum personagem encontrado");
                return;
            }
            foreach(var personagem in lista)
            {
                bool removido = personagem.RetornaRemovido();
                Console.WriteLine("#ID {0}: {1} - {2}", personagem.RetornaId(), personagem.RetornaNomePersonagem(), (removido ? "*Morto*" : "*Vivo*"));
            }
        }

        private static string ObterEscolhaDoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Personagens ao seu dispor!!!!");
            Console.WriteLine("Informe a opção desejada");

            Console.WriteLine("1- Listar personagens");
            Console.WriteLine("2- Inserir novo personagem");
            Console.WriteLine("3- Atualizar personagem");
            Console.WriteLine("4- Excluir personagem");
            Console.WriteLine("5- Visualizar personagem");
            Console.WriteLine("C- Limpar tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string escolha = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return escolha;
        }
    }
}
