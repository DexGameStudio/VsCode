namespace Object
{
    public class Funcionario
    {
        public string Nome{get;set;}
        public double Salario{get;set;}



        public override string ToString(){
            return "Funcionário: " + this.Nome + " - Salário: " + this.Salario;
        }

        public override bool Equals(object o){
            Funcionario outro = (Funcionario)o;

            return this.Nome == outro.Nome;
        }

        //IMPORTANTE
        // Quando sobrescrevemos o método Equals() precisamos sobrescrever o GetHashCode
        public override int GetHashCode(){
            return 0;
        }

    }
}