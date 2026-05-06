using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86_V2.model
{
    /// <summary>
    /// Classe métier interne pour mémoriser les informations de service
    /// </summary>
    internal class Service
    {
        public int IdService { get; }
        public string Nom { get; }

        /// <summary>
        /// Modele du service
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public Service(int idservice, string nom)
        {
            this.IdService = idservice;
            this.Nom = nom;
        }

        /// <summary>
        /// Définit l'information à afficher (juste le nom)
        /// </summary>
        /// <returns>nom du service</returns>
        public override string ToString()
        {
            return this.Nom;
        }
    }
}
