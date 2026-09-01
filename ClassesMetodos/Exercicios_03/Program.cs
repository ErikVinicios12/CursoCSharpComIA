//l - Crie um método chamado AumentarPotencia que recebe um parâmetro do tipo int por valor chamado 
//potencia e retorna um int representando o aumento de potencia.
//(para aumentar a potência incremente 3 ao parâmetro recebido)
//m- Invocar o método criado e passar o valor do argumento por valor e exibir os valores. Explique o 
//comportamento da passagem do argumento por valor
//n- Crie uma sobrecarga para o método AumentarPotencia que recebe um parâmetro do tipo int por referência
//chamado potencia e retorna um int representando o aumento de potencia.
//(para aumentar a potência incremente 5 ao parâmetro recebido)
//o- Explique a sobrecarga de métodos
//p- Invocar o método e passar o valor do argumento por referência e exibir os valores. Explique o 
//comportamento da passagem do argumento por referência

int potencia = 0;

Movimento mov = new Movimento();

// Invocando o método AumentarPotencia passando o argumento por valor
mov.AumentarPotencia(potencia);

Console.WriteLine("Valor da potência após passar por valor: " + potencia); // O valor de potencia permanece 0, pois a passagem por valor cria uma cópia do argumento.

// Invocando o método AumentarPotencia passando o argumento por referência
mov.AumentarPotencia(ref potencia);

Console.WriteLine("Valor da potência após passar por referência: " + potencia); // O valor de potencia é atualizado, pois a passagem por referência permite modificar o argumento original.

public class Movimento
{
    public int AumentarPotencia(int p)
    {
        return p += 3;
    }

    public int AumentarPotencia(ref int p)
    {
        return p += 5;
    }
}

