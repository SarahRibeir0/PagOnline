using System;

class Usuario{

  protected string login;
  protected string senha;
  protected string email;
  protected string endereco;
  protected string telefone;

  public Usuario(string login_user, string senha_user, string email_user, string endereco_user, string telefone_user){

    login=login_user;
    senha=senha_user;
    email=email_user;
    endereco=endereco_user;
    telefone=telefone_user;

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

  public void setEndereco(string endereco_us){
    endereco=endereco_us;
  }
  public string getEndereco(){
    return endereco;
  }

  public void setTelefone(string telefone_us){
    telefone=telefone_us;
  }
  public string getTelefone(){
    return telefone;
  }

}

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}