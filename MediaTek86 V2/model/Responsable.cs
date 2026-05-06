using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86_V2.model
{
    /// <summary>
    /// Classe métier interne pour mémoriser les informations de responsable
    /// </summary>
    internal class Responsable
    {
        public string Login { get; }
        public string Pwd { get; }

        /// <summary>
        /// Modele du responsable
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        public Responsable (string login, string pwd)
        {
            this.Login = login;
            this.Pwd = pwd;
        }
    }
}
