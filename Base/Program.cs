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
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();

                }
                opcaoUsuario = obterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços.");

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
            Console.WriteLine("C - Limpar Console");
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
            foreach (var serie in lista)
            {
                var excluido = serie.getExcluido();
                if (!excluido)
                {
                    
                }
                Console.WriteLine("#ID {0}: - {1} {2}", serie.getId(), serie.getTitulo(), (excluido ? "*EXCLUIDO*" : ""));
            }
        }

        private static void InserirSerie()
        {
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i)); 
            }

            
            bool isNumero = false;
            int entradaGenero = 0;
            while (isNumero == false)
            {
                Console.WriteLine("Digite o genêro entre as opções acima: ");
                if (int.TryParse(Console.ReadLine(), out entradaGenero))
                {
                    isNumero = true;
                }
                else Console.WriteLine("Por favor, digite um número valido! ");

            }


            Console.WriteLine("Digite o Titulo da Série: ");
            string entradaTitulo = Console.ReadLine();

            
            isNumero = false;
            int entradaAno = 0; 
            while (isNumero == false)
            {
                Console.WriteLine("Digite o Ano de Inicio da Série: ");
                if (int.TryParse(Console.ReadLine(), out entradaAno))
                {
                    isNumero = true;
                }
                else Console.WriteLine("Por favor, digite um ano valido! ");

            }


            Console.WriteLine("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);
            repositorio.Insere(novaSerie);
            return;

        }

        private static void AtualizarSerie()
        {
            Console.WriteLine("********** Digite o ID da Série a ser Atualizada **********");
            var lista = repositorio.Lista();
            foreach (var serie in lista)
            {
                var excluido = serie.getExcluido();
                Console.WriteLine("#ID {0}: - {1} {2}", serie.getId(), serie.getTitulo(), (excluido ? "*EXCLUIDO*" : ""));
            }



            bool isNumero = false;
            int indiceSerie = 0;
            while (isNumero == false)
            {    
                if (int.TryParse(Console.ReadLine(), out indiceSerie))
                {
                    isNumero = true;
                }
                else Console.WriteLine("Por favor, digite um número valido! ");
            }

            Console.WriteLine();
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine();


            isNumero = false;
            int entradaGenero = 0;
            while (isNumero == false)
            {
                Console.WriteLine("Digite o genêro entre as opções acima: ");
                if (int.TryParse(Console.ReadLine(), out entradaGenero))
                {
                    isNumero = true;
                }
                else Console.WriteLine("Por favor, digite um número valido! ");

            }


            Console.WriteLine("Digite o Titulo da Série: ");
            string entradaTitulo = Console.ReadLine();


            isNumero = false;
            int entradaAno = 0;
            while (isNumero == false)
            {
                Console.WriteLine("Digite o Ano de Inicio da Série: ");
                if (int.TryParse(Console.ReadLine(), out entradaAno))
                {
                    isNumero = true;
                }
                else Console.WriteLine("Por favor, digite um ano valido! ");

            }


            Console.WriteLine("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);
            repositorio.Atualizar(indiceSerie, novaSerie);
            return;

        }

        private static void ExcluirSerie()
        {
            bool isNumero = false;
            int indiceSerie = 0;
            while (isNumero == false)
            {
                Console.WriteLine("Digite o Id da Série: ");
                if (int.TryParse(Console.ReadLine(), out indiceSerie))
                {
                    isNumero = true;
                }
                else Console.WriteLine("Por favor, digite um número valido! ");

            }
            repositorio.Excluir(indiceSerie);
        }

        private static void VisualizarSerie()
        {
            Console.WriteLine("********** Digite o ID da Série a ser Visualizada **********");
            var lista = repositorio.Lista();
            foreach (var serie2 in lista)
            {
                var excluido = serie2.getExcluido();
                Console.WriteLine("#ID {0}: - {1} {2}", serie2.getId(), serie2.getTitulo(), (excluido ? "*EXCLUIDO*" : ""));
            }




            bool isNumero = false;
            int indiceSerie = 0;
            while (isNumero == false)
            {
                Console.WriteLine();
                Console.WriteLine("Digite o Id da Série: ");
                if (int.TryParse(Console.ReadLine(), out indiceSerie))
                {
                    isNumero = true;
                }
                else Console.WriteLine("Por favor, digite um número valido! ");
            }
            var serie = repositorio.RetornaPorId(indiceSerie);
            Console.WriteLine(serie);
        }


    }//***********
}
