using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86_V2.model
{
    /// <summary>
    /// Classe métier interne pour mémoriser les informations de personnel
    /// </summary>
    internal class Personnel
    {
        public int IdPersonnel { get; }
        public string Nom { get; }
        public string Prenom { get; }
        public string Tel { get; }
        public string Mail { get; }
        public int IdService { get; }

        /// <summary>
        /// Modele du personnel
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="idservice"></param>
        public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, int idservice) 
        {
            this.IdPersonnel = idpersonnel;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Tel = tel;
            this.Mail = mail;
            this.IdService = idservice;
        }
    }
}
