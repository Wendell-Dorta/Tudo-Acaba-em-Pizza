using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using TAEPClass;
using System.Text;
using System.Threading.Tasks;
using TAEPClass;
using System.Security.Cryptography.X509Certificates;


public static class Banco
{
 
    private static string strconn = @"server=127.0.0.1;database=tudo_acaba_em_pizza_db;user id=root;password=";
    
    public static string caminho = @"C:\xampp\htdocs\projeto-web\";
   
    public static string caminhoFotos = caminho+ @"\images\";  
    public static MySqlCommand Abrir()
    {
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection cn = new MySqlConnection(strconn);
        try
        {
            cn.Open();
            cmd.Connection = cn;
        }
        catch (Exception)
        {
            throw;
        }
        return cmd;
    }
}