using System;
using System.Collections.Generic;
using Seu_Rit.Interfaces;

namespace Seu_Rit
{
	public class AulasRepositorio : IRepositorio<Aulas>
	{
        private List<Aulas> listaAula = new List<Aulas>();
		public void Atualiza(int id, Aulas objeto)
		{
			listaAula[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaAula[id].Excluir();
		}

		public void Insere(Aulas objeto)
		{
			listaAula.Add(objeto);
		}

		public List<Aulas> Lista()
		{
			return listaAula;
		}

		public int ProximoId()
		{
			return listaAula.Count;
		}

		public Aulas RetornaPorId(int id)
		{
			return listaAula[id];
		}
	}
}