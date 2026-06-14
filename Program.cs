namespace design_pattern_prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            // objeto original
            Funcionario funcionario1 = new Funcionario("João", "Desenvolvedor", 5000);
            Console.WriteLine("Funcionário Original:"+funcionario1.ToString());
            // objeto clonado  
            Funcionario funcionario2 = funcionario1.Clone();
            Console.WriteLine("Funcionário Clonado:"+funcionario2.ToString());
            // modificando o objeto clonado
            funcionario2.Nome = "Maria";
            funcionario2.Cargo = "Analista";
            funcionario2.Salario = 6000;
            Console.WriteLine("Funcionário Original após modificação do clonado:"+funcionario1.ToString());
            Console.WriteLine("Funcionário Clonado após modificação:"+funcionario2.ToString());
        }
    }
}