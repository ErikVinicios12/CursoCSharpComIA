try
{
    var client = new HttpClient();
    HttpResponseMessage response = client.GetAsync("https://macoratti.net/dados/poesia.txt").Result;
    if (response.IsSuccessStatusCode)
    {
        Console.WriteLine("Arquivo acessado com sucesso!\n" +
            $"StatusCode: {response.StatusCode}");
    }
    else
    {
        throw new HttpRequestException($"Erro: {(int)response.StatusCode}"); // define o ex.Message como "Erro: {
    }
}
catch (HttpRequestException ex) when (ex.Message.Contains("404"))
{
    Console.WriteLine("Página não encontrada");
}
catch (HttpRequestException ex) when (ex.Message.Contains("401"))
{
    Console.WriteLine("Acesso não autorizado!");
}
catch (HttpRequestException ex) when (ex.Message.Contains("400"))
{
    Console.WriteLine("Requisição inválida");
}
catch (HttpRequestException ex) when (ex.Message.Contains("500"))
{
    Console.WriteLine("Erro interno do servidor");
}
catch (Exception ex) // sempre bom colocar esta exception genérica
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("\n Processamento concluido");
}