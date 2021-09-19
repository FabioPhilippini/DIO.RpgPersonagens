using DIO.RpgPersonagens.Entidade;
using DIO.RpgPersonagens.Interface;
using System;
using System.Collections.Generic;

namespace DIO.RpgPersonagens.Repositorio
{
    public class PersonagemRepositorio : IRepositorio<Personagem>
    {

        private List<Personagem> listaPersonagens = new List<Personagem>();

        public void Atualizar(int id, Personagem personagem)
        {
            listaPersonagens[id] = personagem;
        }

        public void Excluir(int id)
        {
            listaPersonagens[id].Remover();
        }

        public void Inserir(Personagem personagem)
        {
            listaPersonagens.Add(personagem);
        }

        public List<Personagem> Lista()
        {
            return listaPersonagens;
        }

        public int ProximoId()
        {
            return listaPersonagens.Count;
        }

        public Personagem RetornaPorId(int id)
        {
            return listaPersonagens[id];
        }
    }
}
