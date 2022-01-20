using System;

namespace Seu_Rit
{
    class Program
    {
        static AulasRepositorio repositorio = new AulasRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
                switch (opcaoUsuario)
				{
					case "1":
                        ListarAula();
						break;
					case "2":
						InserirAula();
						break;
					case "3":
						AtualizarAula();
                        break;
					case "4":
						ExcluirAula();
                        break;
					case "5":
						VisualizarAula();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}

			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
        }

        private static void ExcluirAula()
		{
			Console.Write("Digite o id da aula: ");
			int indiceAula = int.Parse(Console.ReadLine());

			repositorio.Exclui(indiceAula);
		}

        private static void VisualizarAula()
		{
			Console.Write("Digite o id da aula: ");
			int indiceAula = int.Parse(Console.ReadLine());

			var Aula = repositorio.RetornaPorId(indiceAula);

			Console.WriteLine(Aula);
		}

        private static void AtualizarAula()
		{
			Console.Write("Digite o id da aula: ");
			int indiceAula = int.Parse(Console.ReadLine());


			foreach (int i in Enum.GetValues(typeof(Estilo)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Estilo), i));
			}
			Console.Write("Digite o estilo músical: ");
			int entradaEstilo = int.Parse(Console.ReadLine());

			Console.Write("Digite o nome da música: ");
			string entradaMusica = Console.ReadLine();


			Console.Write("Duração dessa aula: ");
			string entradaduracao = (Console.ReadLine());

			Console.Write("Nome do professor: ");
			string entradaprofessor = Console.ReadLine();

			Aulas atualizaAula = new Aulas(id: indiceAula,
										estilo: (Estilo)entradaEstilo,
										musica: entradaMusica,
										duracao:entradaduracao,
										professor: entradaprofessor);

			repositorio.Atualiza(indiceAula, atualizaAula);
		}
        private static void ListarAula()
		{
			Console.WriteLine("Listar aulas");

			var lista = repositorio.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhuma aula cadastrada.");
				return;
			}

			foreach (var aula in lista)
			{
                var excluido = aula.retornaExcluido();
                
				Console.WriteLine("#ID {0}: - {1} {2}", aula.retornaId(), aula.retornaMusica(), (excluido ? "*Excluido - Faz parte da listagem Premium*" : ""));
			}
		}

        private static void InserirAula()
		{
			Console.WriteLine("Inserir nova aula");


			foreach (int i in Enum.GetValues(typeof(Estilo)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Estilo), i));
			}
			Console.Write("Digite o estilo músical: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.Write("Digite o nome da música: ");
			string entradaMusica = Console.ReadLine();

			Console.Write("Duração dessa aula: ");
			string entradaduracao = (Console.ReadLine());

			Console.Write("Nome do professor: ");
			string entradaprofessor = Console.ReadLine();

			Aulas novaAula = new Aulas(id: repositorio.ProximoId(),
										estilo: (Estilo)entradaGenero,
										musica: entradaMusica,
										duracao: entradaduracao,
										professor: entradaprofessor);

			repositorio.Insere(novaAula);
		}

        private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("Você faz o ritmo!!!");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Listar aulas de dança");
			Console.WriteLine("2- Inserir nova aula");
			Console.WriteLine("3- Atualizar lista de danças");
			Console.WriteLine("4- Excluir");
			Console.WriteLine("5- Visualizar aula");
			Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
    }
}
