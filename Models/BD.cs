using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;

public class BD{
    private static string _connectionString = @"Server=localhost;DataBase=TP09;Trusted_Connection=True;";
    
    public static void añadirusuario(Usuario u){
        string sql = "INSERT INTO Usuarios(Username, Contrasena, Nombre, Email, Telefono) VALUES (@cUsername, @cContrasena, @cNombre, @cEmail, @cTelefono)";
        using(SqlConnection db = new SqlConnection(_connectionString)){
            db.Execute(sql, new{cUsername = u.Username, cContrasena = u.Contrasena, cNombre = u.Nombre, cEmail = u.Email, cTelefono = u.Telefono});
        }
    }

    public static List<Usuario> enlistarUsuarios(){
        List<Usuario> ListaUsuarios = null;
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Usuarios";
            ListaUsuarios = db.Query<Usuario>(sql).ToList();
        }
        return ListaUsuarios;
    }

    public static Usuario verificarUsuario(string Nombre, string Contra){
        Usuario veriUsuario = null;
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Usuarios WHERE Username = @nombre and Contrasena = @contra";
            veriUsuario = db.QueryFirstOrDefault<Usuario>(sql, new{nombre = Nombre, contra = Contra});       
        }
        return veriUsuario;
    }

    public static void cambiarContraseña(string Nombre, string contra){
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "UPDATE Usuarios SET Contrasena = @Contra WHERE Username = @nombre";
            db.Execute(sql, new{Contra = contra, nombre = Nombre});    
        }
    }

       public static Usuario verificarnombre(string Nombre){
        Usuario veriUsuario = null;
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Usuarios WHERE Username = @nombre";
            veriUsuario = db.QueryFirstOrDefault<Usuario>(sql, new{nombre = Nombre});       
        }
        return veriUsuario;
    }

}