//w - Substituir na classe Carro o campo Ano por uma propriedade de mesmo nome e mesmo tipo.
//w1- Validar a informação do Ano de forma que se o ano informado for menor que 2000 seja atribuído 2000 e se 
//for informado maior que 2022 seja atribuído 2022 ao valor do ano.
//w2- Explicar a diferença entre campo e propriedade

public class Carro
{
    private int ano; // campo (permite o acesso ao campo para quem criar uma instância da classe e não tem controle
                     // sobre o que é atribuído a ele)
    public int Ano  // propriedade (permite o acesso ao campo para quem criar uma instância da classe e tem controle
                    // sobre o que é atribuído a ele)
                    // Isso permite mais segurança e encapsulamento, pois você pode adicionar lógica adicional no
                    // getter e setter, como validação de dados ou transformação de valores.
    {
        get { return ano; } // getter (retorna o valor do campo)
        set
        {
            if (value < 2000)
                ano = 2000;
            else if (value > 2022)
                ano = 2022;
            else
                ano = value;
        } // setter (atribui um valor ao campo)
    }
}