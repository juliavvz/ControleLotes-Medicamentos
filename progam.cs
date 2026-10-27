using System;

class Program
{
    static void Main(string[] args)
    {
        Medicamentos gerenciador = new Medicamentos();
        int opcao = -1;

        while (opcao != 0)
        {
            Console.WriteLine("\n--- OPÇÕES DO SELETOR ---");
            Console.WriteLine("0. Finalizar processo");
            Console.WriteLine("1. Cadastrar medicamento");
            Console.WriteLine("2. Consultar medicamento (sintético)");
            Console.WriteLine("3. Consultar medicamento (analítico + lotes)");
            Console.WriteLine("4. Comprar medicamento (cadastrar lote)");
            Console.WriteLine("5. Vender medicamento");
            Console.WriteLine("6. Listar medicamentos");
            Console.Write("Escolha uma opção: ");
            
            if (!int.TryParse(Console.ReadLine(), out opcao)) continue;

            switch (opcao)
            {
                case 0:
                    break;
                case 1:
                    Console.Write("ID: "); int id = int.Parse(Console.ReadLine());
                    Console.Write("Nome: "); string nome = Console.ReadLine();
                    Console.Write("Laboratório: "); string lab = Console.ReadLine();
                    gerenciador.adicionar(new Medicamento(id, nome, lab));
                    Console.WriteLine("Cadastrado com sucesso!");
                    break;

                case 2:
                    Console.Write("ID do medicamento: ");
                    int idBusca2 = int.Parse(Console.ReadLine());
                    Medicamento m2 = gerenciador.pesquisar(new Medicamento(idBusca2, "", ""));
                    if (m2.GetId() != 0) Console.WriteLine(m2.ToString());
                    else Console.WriteLine("Não encontrado.");
                    break;

                case 3:
                    Console.Write("ID do medicamento: ");
                    int idBusca3 = int.Parse(Console.ReadLine());
                    Medicamento m3 = gerenciador.pesquisar(new Medicamento(idBusca3, "", ""));
                    if (m3.GetId() != 0)
                    {
                        Console.WriteLine(m3.ToString());
                        foreach (var l in m3.GetLotes())
                        {
                            Console.WriteLine("   -> Lote: " + l.ToString());
                        }
                    }
                    else Console.WriteLine("Não encontrado.");
                    break;

                case 4:
                    Console.Write("ID do medicamento: ");
                    int idMed = int.Parse(Console.ReadLine());
                    Medicamento mComp = gerenciador.pesquisar(new Medicamento(idMed, "", ""));
                    if (mComp.GetId() != 0)
                    {
                        Console.Write("ID do Lote: "); int idLote = int.Parse(Console.ReadLine());
                        Console.Write("Quantidade: "); int qtdeLote = int.Parse(Console.ReadLine());
                        Console.Write("Data de Vencimento (dd/MM/yyyy): "); DateTime venc = DateTime.Parse(Console.ReadLine());
                        
                        mComp.comprar(new Lote(idLote, qtdeLote, venc));
                        Console.WriteLine("Lote adicionado!");
                    }
                    else Console.WriteLine("Medicamento não encontrado.");
                    break;

                case 5:
                    Console.Write("ID do medicamento: ");
                    int idVend = int.Parse(Console.ReadLine());
                    Medicamento mVend = gerenciador.pesquisar(new Medicamento(idVend, "", ""));
                    if (mVend.GetId() != 0)
                    {
                        Console.Write("Quantidade a vender: "); int qtdeV = int.Parse(Console.ReadLine());
                        bool sucesso = mVend.vender(qtdeV);
                        if (sucesso) Console.WriteLine("Venda realizada com sucesso!");
                        else Console.WriteLine("Estoque insuficiente.");
                    }
                    else Console.WriteLine("Medicamento não encontrado.");
                    break;

                case 6:
                    Console.WriteLine("\n--- LISTA DE MEDICAMENTOS ---");
                    foreach (var med in gerenciador.GetLista())
                    {
                        Console.WriteLine(med.ToString());
                    }
                    break;
            }
        }
    }
}
