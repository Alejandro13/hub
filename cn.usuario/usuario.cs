using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cd.usuario;

namespace cn.usuario
{
    public class usuario
    {
        private string nombre = string.Empty;
        private string aPat = string.Empty;
        private string aMat = string.Empty;
        private string usr = string.Empty;
        private string contrasena = string.Empty;
        private string correo = string.Empty;

        #region propiedades
        public string Nombre
        {
            get {return this.nombre;}
            set { this.nombre = value;}
        }

        public string APat
        {
            get { return aPat; }
            set { aPat = value; }
        }

        public string AMat
        {
            get { return aMat; }
            set { aMat = value; }
        }

        public string Usr
        {
            get { return usr; }
            set { usr = value; }
        }

        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        #endregion

        #region constructores

        public usuario(){}

        public usuario(string Usr, string Contrasena)
        {
            this.usr = Usr;
            this.contrasena = Contrasena;
        }

        public usuario(string Nombre, string APat, string AMat, string Usr, string Contrasena, string Correo)
        {
            this.nombre = Nombre;
            this.aPat = APat;
            this.aMat = AMat;
            this.usr = Usr;
            this.contrasena = Contrasena;
            this.correo = Correo;
        }

        #endregion

        public bool guardaUsuario()
        {
            //devuelve true en 
            return cd.usuario.usuario.guardaUsuario(this.nombre, this.aPat, this.aMat, this.usr, this.contrasena, this.correo);
        }

        public bool verificaUsuario()
        {
            return cd.usuario.usuario.VerificaUsuario(this.usr, this.contrasena);
        }

        public void enviaCorreo()
        {
            //obtener datos
            //asignarlos
            //enviar por correo
        }
    }
}
