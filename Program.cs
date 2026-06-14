namespace design_pattern_prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design Pattern - Prototype");
            Funcionario funcionario1 = new Funcionario("João", "Desenvolvedor", 5000);
            Console.WriteLine("Funcionário Original:"+funcionario1.ToString());
            Funcionario funcionario2 = funcionario1.Clone();
            Console.WriteLine("Funcionário Clonado:"+funcionario2.ToString());
        }
    }
}