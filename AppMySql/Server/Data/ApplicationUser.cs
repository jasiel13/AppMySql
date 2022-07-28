//using AppMySql.Shared.Modelos;
//using Microsoft.AspNetCore.Identity;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace AppMySql.Server.Data
//{
//    public class ApplicationUser : IdentityUser
//    {
//        public string Nombre { get; set; }
//        public string ApellidoPaterno { get; set; }
//        public string ApellidoMaterno { get; set; }
//        public bool Activo { get; set; }
//        public string ContraseñaTextoPlano { get; set; }//poder ver la contraseña sin hash

//        //propiedades de navegacion
//        public int Id { get; set; }
//        public virtual Employee EmpleadoRelacionado { get; set; }

//        //aqui podemos agregar mas campos para el usuario identity
//    }
//}
