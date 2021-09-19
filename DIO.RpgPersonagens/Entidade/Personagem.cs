using DIO.RpgPersonagens.Enum;
using System;

namespace DIO.RpgPersonagens.Entidade
{
    public class Personagem : PersonagemBase
    {
        private Classe Classe { get; set; }
        private String NomeJogador { get; set; }

        private String NomePersonagem { get; set; }

        private String Raca { get; set; }

        private int Forca { get; set; }

        private int Destreza { get; set; }

        private int Vitalidade { get; set; }

        private int Energia { get; set; }

        private bool Removido { get; set; }

        public Personagem()
        {

        }

        public Personagem(int id, Classe classe, string nomeJogador, string nomePersonagem, string raca, int forca, int destreza, int vitalidade, int energia)
        {
            this.Id = id;
            this.Classe = classe;
            this.NomeJogador = nomeJogador;
            this.NomePersonagem = nomePersonagem;
            this.Raca = raca;
            this.Forca = forca;
            this.Destreza = destreza;
            this.Vitalidade = vitalidade;
            this.Energia = energia;
            this.Removido = false;
        }

        public String RetornaNomeJogador()
        {
            return this.NomeJogador;
        }

        public String RetornaNomePersonagem()
        {
            return this.NomePersonagem;
        }

        public int RetornaId()
        {
            return this.Id;
        }

        public void Remover()
        {
            this.Removido = true;
        }

        public bool RetornaRemovido()
        {
            return this.Removido;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Classe: " + this.Classe + Environment.NewLine;
            retorno += "Nome do Jogador: " + this.NomeJogador + Environment.NewLine;
            retorno += "Nome do personagem: " + this.NomePersonagem + Environment.NewLine;
            retorno += "Raça: " + this.Raca + Environment.NewLine;
            retorno += "Morto: " + this.Removido;
            return retorno;
        }
    }
}
