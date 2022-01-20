using System;

namespace Seu_Rit
{
	public class Aulas : EntidadeBase
	{
		// Atributos
		private Estilo Estilo { get; set; }
		private string Musica { get; set; }
		private string Professor { get; set; }
		private int Ano { get; set; }
		private string Duração { get; set; }
		private bool Excluido { get; set; }


		// Métodos
		public Aulas(int id, Estilo estilo, string musica, string professor, string duracao)
		{
			this.Id = id;
			this.Estilo = estilo;
			this.Musica = musica;
			this.Duração = duracao;
			this.Professor = professor;
			this.Excluido = false;
		}

		public override string ToString()
		{

			string retorno = "";
			retorno += "Estilo: " + this.Estilo + Environment.NewLine;
			retorno += "Musica: " + this.Musica + Environment.NewLine;
			retorno += "Duração: " + this.Duração + Environment.NewLine;
			retorno += "Professor: " + this.Professor + Environment.NewLine;
			retorno += "Excluido: " + this.Excluido;
			return retorno;
		}

		public string retornaMusica()
		{
			return this.Musica;
		}

		public int retornaId()
		{
			return this.Id;
		}
		public bool retornaExcluido()
		{
			return this.Excluido;
		}
		public string retornaDuração()
		{
		   return this.Duração;
		}
        public void Excluir() {
            this.Excluido = true;
        }
    }
}