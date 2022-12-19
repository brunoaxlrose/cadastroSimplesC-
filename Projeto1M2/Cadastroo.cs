public class Cadastroo
{
    //Atributos 
    private string usuario,senha, repitaSenha, nome, sobrenome, email, ocupacao, 
                   pais, estado, cidade, cpf, escolaridade, areaFormacao;
    //Construtor
    public Cadastroo()
    {
        this.usuario = "";
        this.senha = "";
        this.repitaSenha = "";
        this.nome = "";
        this.sobrenome = "";
        this.email = "";
        this.ocupacao = "";
        this.pais = "";
        this.estado = "";
        this.cidade = "";
        this.cpf = "";
        this.escolaridade = "";
        this.areaFormacao = "";
    }
    //Métodos SET/ GET
    public void setUsuario(string par_Usuario)
    {
        this.usuario = par_Usuario;
    }
    public string getUsuario()
    {
        return this.usuario;
    }
    public void setSenha(string par_Senha)
    {
        this.senha = par_Senha;
    }
    public string getSenha()
    {
        return this.senha;
    }
    public void setRepitaSenha(string par_RepitaSenha)
    {
        this.repitaSenha = par_RepitaSenha;
    }
    public bool validarSenhas()
    {
        return (this.senha == this.repitaSenha);
    }
    public string getRepitaSenha()
    {
        return this.repitaSenha;
    }
    public void setNome(string par_Nome)
    {
        this.nome = par_Nome;
    }
    public string getNome()
    {
        return this.nome;
    }
    public void setSobrenome(string par_Sobrenome)
    {
        this.sobrenome = par_Sobrenome;
    }
    public string getSobrenome()
    {
        return this.sobrenome;
    }
    public void setEmail(string par_Email)
    {
        this.email = par_Email;
    }
    public string getEmail()
    {
        return this.email;
    }
    public void setOcupacao(string par_Ocupacao)
    {
        this.ocupacao = par_Ocupacao;
    }
    public string getOcupacao()
    {
        return this.ocupacao;
    }
    public void setPais(string par_Pais)
    {
        this.pais = par_Pais;
    }
    public string getPais()
    {
        return this.pais;
    }
    public void setEstado(string par_Estado)
    {
        this.estado = par_Estado;
    }
    public string getEstado()
    {
        return this.estado;
    }
    public void setCidade(string par_Cidade)
    {
        this.cidade = par_Cidade;
    }
    public string getCidade()
    {
        return this.cidade;
    }
    public void setCPF(string par_CPF)
    {
        this.cpf = par_CPF;
    }
    public string getCPF()
    {
        return this.cpf;
    }
    public void setEscolaridade(string par_Escolaridade)
    {
        this.escolaridade = par_Escolaridade;
    }
    public string getEscolaridade()
    {
        return this.escolaridade;
    }
    public void setAreaFormacao(string par_AreaFormacao)
    {
        this.areaFormacao = par_AreaFormacao;
    }
    public string getAreaFormacao()
    {
        return this.areaFormacao;
    }
}
