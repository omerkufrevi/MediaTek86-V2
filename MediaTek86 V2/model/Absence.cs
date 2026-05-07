using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86_V2.model
{
    /// <summary>
    /// Package model
    /// </summary>
    internal class NamespaceDoc { }
    /// <summary>
    /// Classe métier interne pour mémoriser les informations d'absence
    /// </summary>
    internal class Absence
    {
        public int IdPersonnel { get; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public Motif Motif { get; set; }
        public DateTime DateDebutAvant {  get; set; }

        /// <summary>
        /// Modele de l'absence
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="motif"></param>
        /// <param name="datedebutavant"></param>
        public Absence(int idpersonnel, DateTime datedebut, DateTime datefin, Motif motif, DateTime datedebutavant)
        {
            this.IdPersonnel = idpersonnel;
            this.DateDebut = datedebut;
            this.DateFin = datefin;
            this.Motif = motif;
            this.DateDebutAvant = datedebutavant;
        }
    }
}
