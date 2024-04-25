namespace DesafioFundamentos.Models
{
    public class Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        private readonly decimal PrecoInicial = precoInicial;
        private readonly decimal PrecoPorHora = precoPorHora;
        private readonly List<string> Veiculos = new();
        public void AdicionarVeiculo()
        {
            Console.Write("Digite a placa do veículo para estacionar: ");
            Veiculos.Add(Console.ReadLine().ToUpper());
            Console.Write("Veículo cadastrado!");
        }

        public void RemoverVeiculo()
        {
            Console.Write("Digite a placa do veículo para remover: ");
            var placa = Console.ReadLine().ToUpper();
            if (Veiculos.Any(x => x == placa))
            {
                Console.Write("Quantas horas ficou estacionado: ");
                var horasEstacionado = decimal.Parse(Console.ReadLine());
                var valorTotal = PrecoInicial + PrecoPorHora * horasEstacionado;
                Veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido");
                Console.WriteLine($"Preço inicial: {PrecoInicial}");
                Console.WriteLine($"Preço por hora: {PrecoPorHora}");
                Console.WriteLine($"Total a pagar R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado! Tente novamente: ");
            }
        }

        public void ListarVeiculos()
        {
            if (Veiculos.Count != 0)
            {
                Console.WriteLine("Veículos estacionados!");
                foreach (var placa in Veiculos)
                {
                    Console.Write("Placa: ");
                    Console.WriteLine(placa);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}