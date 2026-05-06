using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86_V2.model
{
    /// <summary>
    /// Classe métier interne pour mémoriser les informations de motif
    /// </summary>
    internal class Motif
    {
        public int IdMotif { get; }
        public string Libelle { get; }

        /// <summary>
        /// Modele du motif
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        public Motif(int idmotif, string libelle)
        {
            this.IdMotif = idmotif;
            this.Libelle = libelle;
        }
    }
}
