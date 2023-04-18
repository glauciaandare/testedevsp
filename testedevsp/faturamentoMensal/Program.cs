namespace faturamentoMensal {
    internal class Program {
        static void Main(string[] args)
        {
            double sp = 67836.43;
            double rj = 36678.66;
            double mg = 29229.88;
            double es = 27165.48;
            double outros = 19849.53;

            double total = sp + rj + mg + es + outros;

            double percentual_sp = (sp / total) * 100;
            double percentual_rj = (rj / total) * 100;
            double percentual_mg = (mg / total) * 100;
            double percentual_es = (es / total) * 100;
            double percentual_outros = (outros / total) * 100;

            Console.WriteLine("Percentual de representação do faturamento por estado:");
            Console.WriteLine("SP: " + percentual_sp.ToString("F2") + "%");
            Console.WriteLine("RJ: " + percentual_rj.ToString("F2") + "%");
            Console.WriteLine("MG: " + percentual_mg.ToString("F2") + "%");
            Console.WriteLine("ES: " + percentual_es.ToString("F2") + "%");
            Console.WriteLine("Outros: " + percentual_outros.ToString("F2") + "%");
        }
    }
}
    
