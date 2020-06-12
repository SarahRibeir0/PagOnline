using System;

class Usuario{

  protected string login;
  protected string senha;
  protected string email;
  protected string telefone;

  public Usuario(string login_user, string senha_user, string email_user,string telefone_user){

    login=login_user;
    senha=senha_user;
    email=email_user;
    telefone=telefone_user;

  }

  public Usuario(){
    login="";
    senha="";
    email="";
    telefone="";

  }

  public void setLogin(string login_us){
    login=login_us;
  }
  public string getLogin(){
    return login;
  }

  public void setSenha(string senha_us){
    senha=senha_us;
  }
  public string getSenha(){
    return senha;
  }

  public void setEmail(string email_us){
    email=email_us;
  }
  public string getEmail(){
    return email;
  }

  public void setTelefone(string telefone_us){
    telefone=telefone_us;
  }
  public string getTelefone(){
    return telefone;
  }

}

class PessoaJuridica:Usuario {
  protected string cnpj;
  protected string razaoSocial;
  protected string dataAbertura;
  protected string ramoAtividade;

  public PessoaJuridica(string cnpj_pj,string razao_pj, string data_pj, string ramo_pj, string login, string senha, string email, string telefone): base(login, senha, email, telefone) {
    cnpj = cnpj_pj;
    razaoSocial = razao_pj;
    dataAbertura = data_pj;
    ramoAtividade = ramo_pj;
  }

  public PessoaJuridica(){
    cnpj ="";
    razaoSocial="";
    dataAbertura="";
    ramoAtividade="";
  }

  //SETS E GETS
  public void setCnpj(string cnpj_pj){
    cnpj = cnpj_pj;
  }

  public string getCnpj(){
    return cnpj;
  }

  public void setRazaoSocial(string razao_pj){
    razaoSocial = razao_pj;
  }

  public string getRazaoSocial(){
    return razaoSocial;
  }

  public void setDataAbertura(string data_pj){
    dataAbertura = data_pj;
  }

  public string getDataAbertura(){
    return dataAbertura;
  }

  public void setRamo(string ramo_pj){
    ramoAtividade = ramo_pj;
  }

  public string getRamo(){
    return ramoAtividade;
  }

}

class PessoaFisica:Usuario {
  protected string cpf;
  protected string nome;
  protected string rg;
  protected string nascimento;
  protected double saldo;

  public PessoaFisica(string cpf_pessoa, string nome_pessoa, string rg_pessoa, string nasc_pessoa, string login, string senha, string email, string telefone): base(login, senha, email, telefone){
    cpf = cpf_pessoa;
    nome = nome_pessoa;
    rg = rg_pessoa;
    nascimento = nasc_pessoa;
    saldo = 0;
  }

  public PessoaFisica(){
    cpf ="";
    nome ="";
    rg="";
    nascimento="";
    saldo = 0;
  }

  //SETS E GETS
  public void setCpf(string cpf_ps){
    cpf = cpf_ps;
  }

  public string getCpf(){
    return cpf;
  }

  public void setNome(string nome_ps){
    nome = nome_ps;
  }

  public string getNome(){
    return nome;
  }

  public void setRg(string rg_ps){
    rg = rg_ps;
  }

  public string getRg(){
    return rg;
  }
  
  public void setNascimento(string nasc_ps){
    nascimento = nasc_ps;
  }

  public string getNascimento(){
    return nascimento;
  }

  public double getSaldo(){
    return saldo;
  }

  private void subtrairSaldo(double saldo_ps){
    saldo = saldo - saldo_ps;
  }
  
  public void adicionarSaldo(double saldo_ps){
    saldo = saldo + saldo_ps;
  }

  public void adicionarDinheiro(){
    int numCartao;
    int cvc;
    char concluir;
    double valor;

    Console.WriteLine("\nADICIONAR DINHEIRO");
    Console.WriteLine("Valor(R$):");
    valor = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Numéro do cartão: ");
    numCartao = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("CVC: ");
    cvc = Convert.ToInt32(Console.ReadLine());

    Console.Write("Concluir operação(s ou n)? ");
    concluir = Console.ReadLine()[0];
    if(concluir == 's'){
      adicionarSaldo(valor);
      Console.WriteLine("Operação concluída com sucesso\n");
    } else {
      Console.WriteLine("Operação falhou\n");
    }

  }

  public void consultarCarteira(){
    Console.WriteLine("Saldo de "+nome+": R$"+saldo);
  }
  
  public void pagarConta(){
    double valorConta;
    string beneficiario;
    string codBarras;
    int numCartao;
    int cvc;
    char concluir;

    Console.WriteLine("\nPAGAMENTO CONTA");
    Console.WriteLine("Código de barras: ");
    codBarras = Console.ReadLine();
    Console.WriteLine("Valor(R$): ");
    valorConta = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Beneficiário: ");
    beneficiario = Console.ReadLine();
    Console.WriteLine("Numéro do cartão: ");
    numCartao = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("CVC: ");
    cvc = Convert.ToInt32(Console.ReadLine());

    Console.Write("Realizar pagamento de R$"+valorConta+" para "+beneficiario+"(s ou n): ");
    concluir = Console.ReadLine()[0];
    if(concluir == 's'){
      Pagamento conta = new Pagamento(codBarras, beneficiario, valorConta,  numCartao, cvc);
      Console.WriteLine("Operação concluída com sucesso\n");
    } else {
      Console.WriteLine("Operação falhou\n");
    }
    
  }

  public void pagarUsuario(PessoaFisica recebedor){
    double valorPagar;
    int numCartao;
    int cvc;
    char concluir;
    
    Console.WriteLine("\nPAGAMENTO");
    Console.WriteLine("Valor(R$):");
    valorPagar = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Numéro do cartão: ");
    numCartao = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("CVC: ");
    cvc = Convert.ToInt32(Console.ReadLine());

    Console.Write("Realizar pagamento de R$"+valorPagar+" para "+recebedor.nome+"(s ou n): ");
    concluir = Console.ReadLine()[0];
    if(concluir == 's'){
      Pagamento pag = new Pagamento(recebedor, valorPagar, numCartao, cvc);
      Console.WriteLine("Operação concluída com sucesso\n");
    } else {
      Console.WriteLine("Operação falhou\n");
    }

  }

  public void pagarEmpresa(PessoaJuridica recebedor){
    double valorPagar;
    int numCartao;
    int cvc;
    char concluir;
    string nomeEmpresa;
    
    Console.WriteLine("\nPAGAMENTO");
    Console.WriteLine("Valor(R$):");
    valorPagar = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Numéro do cartão: ");
    numCartao = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("CVC: ");
    cvc = Convert.ToInt32(Console.ReadLine());

    nomeEmpresa = recebedor.getRazaoSocial();
    Console.Write("Realizar pagamento de R$"+valorPagar+" para "+nomeEmpresa+"(s ou n): ");
    concluir = Console.ReadLine()[0];
    if(concluir == 's'){
      Pagamento pag = new Pagamento(recebedor, valorPagar, numCartao, cvc, "arg1","arg2");
      Console.WriteLine("Operação concluída com sucesso\n");
    } else {
      Console.WriteLine("Operação falhou\n");
    }
  }

}

class Pagamento{
  protected double valorPagamento;
  protected bool parcelamento;
  protected int  numParcelas;
  protected double valParcelas;
  protected string dataPagamento;
  protected string codBarras;
  protected int numCartao;
  protected int cvc;
  protected string beneficiario;
 
    //PAGAMENTO DE CONTA
  public Pagamento(string cod_barras, string beneficiario__pag, double valor_pag, int num_cartao, int cvc_cartao){
    codBarras = cod_barras;
    valorPagamento = valor_pag;
    numCartao = num_cartao;
    cvc = cvc_cartao;
    beneficiario = beneficiario__pag;
  }

  //PAGAMENTO ENTRE PESSOAS FISICAS
  public Pagamento(PessoaFisica recebedor, double valor_pag, int num_cartao, int cvc_cartao){
    valorPagamento = valor_pag;
    numCartao = num_cartao;
    cvc = cvc_cartao;
    recebedor.adicionarSaldo(valorPagamento);
  }

  //PAGAMENTO PARA EMPRESA
  public Pagamento(PessoaJuridica recebedor, double valor_pag, int num_cartao, int cvc_cartao, string arg1, string arg2){
    valorPagamento = valor_pag;
    numCartao = num_cartao;
    cvc = cvc_cartao;
  }

  public Pagamento(){

  }
  
  //SETS E GETS
  
  public void setValorPagamento(double valor_pag){
    valorPagamento = valor_pag;
  }

  public double getValorPagamento(){
    return valorPagamento;
  }

  public void setParcelamento(bool parcelamento_pag){
    parcelamento = parcelamento_pag;
  }

  public bool getParcelamento(){
    return parcelamento;
  }

  public void setNumParcelas(int numParc_pag){
    numParcelas = numParc_pag;
  }

  public int getNumParcelas(){
    return numParcelas;
  }

  public void setValParcelas(double valorParcelas_pag){
    valParcelas = valorParcelas_pag;
  }

  public double getValParcelas(){
    return valParcelas;
  }

  public void setDataPagamento(string data_pag){
    dataPagamento = data_pag;
  }

  public string getDataPagamento(){
    return dataPagamento;
  }

}

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}