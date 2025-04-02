using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

class Program
{
    static void Main()
    {
        string caminhoArquivo = "dados.json";

        if (File.Exists(caminhoArquivo))
        {

            string dadosJson = File.ReadAllText(caminhoArquivo);

            var dadosFaturamento = JsonSerializer.Deserialize<double[]>(dadosJson);

            var faturamentoValidos = dadosFaturamento.Where(f => f > 0).ToArray();

            double menorFaturamento = faturamentoValidos.Min();
            double maiorFaturamento = faturamentoValidos.Max();
            double media = faturamentoValidos.Average();

            int diasAcimaDaMedia = faturamentoValidos.Count(f => f > media);
        }
    }
}