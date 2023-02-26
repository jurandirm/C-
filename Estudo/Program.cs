using Estudos.Modelos;
internal class Program

{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        Console.WriteLine("*** ESTUDOS ***");
        Console.WriteLine(" ");

        Console.Write("Digite seu nome: ");
        string? nome = Console.ReadLine();

        Console.WriteLine("Seja bem vindo " + nome);

        Usuario usuario = new Usuario();
        Console.Write("Digite o seu nome: ");
        usuario.Nome = Console.ReadLine();
        Console.Write("Digite o seu e-mail: ");
        usuario.Email = Console.ReadLine();
        Console.WriteLine(usuario.ObterLogin());
    }
}