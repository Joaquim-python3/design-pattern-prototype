namespace design_pattern_prototype
{
    public class Funcionario : IPrototype<Funcionario>
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, string cargo, double salario)
        {
            Nome = nome;
            Cargo = cargo;
            Salario = salario;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Cargo: {Cargo}, Salário: {Salario}";
        }

    
        // funcao clone para criar uma cópia do objeto atual
        public Funcionario Clone()
        {
            return new Funcionario(this.Nome, this.Cargo, this.Salario);

        }

    }
}