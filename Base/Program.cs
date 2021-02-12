using System;

namespace Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();

        static void Main(string[] args)
        {
            string opcaoUsuario = obterOpcaoUsuario();
            
            while(opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "1":
                        ListarSeries();
                        break;
                    case "1":
                        ListarSeries();
                        break;
                    case "1":
                        ListarSeries();
                        break;
                    case "1":
                        ListarSeries();
                        break;
                    case "1":
                        ListarSeries();
                        break;
                    default:

                }
            }

        }         

        private static string obterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Séries a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine();

            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("6 - Limpar série");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }

        private static void ListarSeries()
        {
            Console.WriteLine("1 - Listar séries");
            var lista = repositorio.Lista();
            if(lista.Count == 0)
            {
                Console.WriteLine("Nenhuma Série Cadastrada.");
                return;
            }
            foreach(var serie in lista)
            {
                Console.WriteLine("#ID {0}: - {1}",serie.getId(), serie.getTitulo());
            }
        }


    }//***********
}
