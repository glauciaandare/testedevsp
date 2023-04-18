using System;
using System.Linq;
using System.Text.Json;

namespace faturamentoDiario {
        internal class Program {
            static void Main(string[] args)
            {
                string json = @"{
            ""01"": 1000.50,
            ""02"": 850.00,
            ""03"": 1250.25,
            ""04"": 0.00,
            ""05"": 975.50,
            ""06"": 1150.75,
            ""07"": 1450.80,
            ""08"": 950.00,
            ""09"": 1100.25,
            ""10"": 1325.50,
            ""11"": 975.50,
            ""12"": 1175.75,
            ""13"": 1350.80,
            ""14"": 900.00,
            ""15"": 1075.25,
            ""16"": 1300.50,
            ""17"": 1075.50,
            ""18"": 1125.75,
            ""19"": 1375.80,
            ""20"": 825.00,
            ""21"": 925.25,
            ""22"": 1275.50,
            ""23"": 1125.50,
            ""24"": 1350.75,
            ""25"": 1525.80,
            ""26"": 950.00,
            ""27"": 1150.25,
            ""28"": 1425.50,
            ""29"": 1175.50,
            ""30"": 1425.75,
            ""31"": 1250.80
        }";

                // Deserializa o json em um dicionário
                var faturamento = JsonSerializer.Deserialize<Dictionary<string, double>>(json);


                double menorValor = faturamento.Values.Min();
                double maiorValor = faturamento.Values.Max();


                double mediaMensal = faturamento.Values.Where(v => v > 0).Average();


                int diasAcimaMedia = faturamento.Values.Count(v => v > mediaMensal);


                Console.WriteLine($"Menor valor de faturamento: R$ {menorValor:F2}");
                Console.WriteLine($"Maior valor de faturamento: R$ {maiorValor:F2}");
                Console.WriteLine($"Número de dias com faturamento acima da média mensal: {diasAcimaMedia}");
            }

        }
    
}
    
