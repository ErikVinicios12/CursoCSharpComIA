// Evento serve para executar vários metodos ao mesmo tempo quando o usuário executar uma ação, como por exemplo, clicar em um botão.
// Ele é muito utilizado em interfaces gráficas para responder a eventos do usuário.

using Eventos;

Pedido pedido = new Pedido();
pedido.onCriarPedido += Email.EnviarEmail; // Adiciona o método EnviarEmail ao evento onCriarPedido
pedido.onCriarPedido += SMS.EnviarSMS; // Adiciona o método EnviarSMS ao evento onCriarPedido

pedido.CriarPedido("joao@example.com", "123456789");
