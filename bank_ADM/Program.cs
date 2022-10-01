using bank_ADM.Funcionarios;
using bank_ADM.SistemaInterno;
using bank_ADM.Utilitario;


Console.WriteLine("Bem vindo a area de administração do banco.");

CalcularBonificacao();
UsarSistema();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Console.WriteLine("-------- CRIANDO CONTAS --------");
    Designer julio = new Designer("145.123.852-00");
    Diretor kleuber = new Diretor("123.456.789-10");
    Auxiliar gabriel = new Auxiliar("789.123.456-55");
    GerenteDeContas ana = new GerenteDeContas("446.123.761-71");
    Console.WriteLine("-------- FINALIZADO CRIAÇÃO DE CONTAS --------");

    julio.Nome = "Julio";
    kleuber.Nome = "Kleuber";
    gabriel.Nome = "Gabriel";
    ana.Nome = "Ana";


    Console.WriteLine("-------- LISTA DE VALORES DOS SALARIOS SEM AUMENTO --------");
    Console.WriteLine("Salario sem aumento de julio: " + julio.Salario);
    Console.WriteLine("Salario sem aumento de kleuber: " + kleuber.Salario);
    Console.WriteLine("Salario sem aumento de gabriel: " + gabriel.Salario);
    Console.WriteLine("Salario sem aumento de ana: " + ana.Salario);
    Console.WriteLine("-------- FIM DA LISTA DOS VALORES DOS SALARIOS SEM AUMENTO --------");

    julio.AumentarSalario();
    kleuber.AumentarSalario();
    gabriel.AumentarSalario();
    ana.AumentarSalario();

    Console.WriteLine("-------- LISTA DE VALORES DOS SALARIOS COM AUMENTO --------");
    Console.WriteLine("Salario sem aumento de julio: " + julio.Salario);
    Console.WriteLine("Salario sem aumento de kleuber: " + kleuber.Salario);
    Console.WriteLine("Salario sem aumento de gabriel: " + gabriel.Salario);
    Console.WriteLine("Salario sem aumento de ana: " + ana.Salario);
    Console.WriteLine("-------- FIM DA LISTA DOS VALORES DOS SALARIOS COM AUMENTO --------");


    gerenciador.Registrar(julio);
    gerenciador.Registrar(kleuber);
    gerenciador.Registrar(gabriel);
    gerenciador.Registrar(ana);

    Console.WriteLine("-------- BONIFICAÇÕES --------");
    Console.WriteLine("Bonificação de julio: " + julio.getBonificacao());
    Console.WriteLine("Bonificação de kleuber: " + kleuber.getBonificacao());
    Console.WriteLine("Bonificação de gabriel: " + gabriel.getBonificacao());
    Console.WriteLine("Bonificação de ana: " + ana.getBonificacao());
    Console.WriteLine("-------- FIM DAS BONIFICAÇÕES --------");
}

void UsarSistema()
{
    SistemaInterno sistemaInterno = new SistemaInterno();

    Diretor fernando = new Diretor("456.176.953-55");
    GerenteDeContas gabriela = new GerenteDeContas("123.456.789.10");

    fernando.Nome = "Fernando";
    fernando.Senha = "123";
    gabriela.Nome = "Gabriela";
    gabriela.Senha = "312";

    sistemaInterno.Logar(fernando,"123");
    sistemaInterno.Logar(gabriela, "321");

}