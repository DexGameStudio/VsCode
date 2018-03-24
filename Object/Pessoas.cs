namespace Object
{
    public class Pessoas
    {
        public string Nome{get;set;}

        public string Idade{get;set;}

        public Pessoas(string nome, int idade){
            this.Nome += nome;
            this.Idade += idade;
        }

        public override string ToString(){
            return "Nome: " + this.Nome + " Idade: " + this.Idade;
        }

    }
}