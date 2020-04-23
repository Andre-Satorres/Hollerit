using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que esse serviço da web seja chamado a partir do script, usando ASP.NET AJAX, remova os comentários da linha a seguir. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    public Service () {

        //Remova os comentários da linha a seguir se usar componentes designados 
        //InitializeComponent(); 
    }

    [WebMethod]
    public double calcularINSS(double salario)
    {
        double salAntes = salario;

        if (salario <= 1659.38)
            salario *= 0.92;
        else
        if (salario <= 2765.66)
            salario *= 0.91;
        else
        if (salario <= 5531.31)
            salario *= 0.89;
        else
            salario -= 5531.31 * 0.11;

        return salAntes - salario;
    }

    [WebMethod]
    public double descontaDependentes(int filhos)
    {
        return (189.59 * filhos);
    }

    [WebMethod]
    public double calcularIR(double salario)
    {
        double salAntes = salario;

        if (salario >= 1903.99 && salario <= 2826.65)
            salario *= 0.925;
        else
        if (salario <= 3751.05)
            salario *= 0.85;
        else
        if (salario <= 4664.68)
            salario *= 0.775;
        else
            salario *= 0.725;

        return salAntes - salario;
    }

    [WebMethod]
    public double calcularFGTS(double salario)
    {
        return salario * 0.08;
    }

}