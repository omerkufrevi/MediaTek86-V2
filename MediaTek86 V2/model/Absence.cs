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
        public DateTime DateDebut { get; }
        public DateTime DateFin { get; }
        public int IdMotif { get; }
        public DateTime DateDebutAvant {  get; }

        /// <summary>
        /// Modele de l'absence
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="idmotif"></param>
        /// <param name="datedebutavant"></param>
        public Absence(int idpersonnel, DateTime datedebut, DateTime datefin, int idmotif, DateTime datedebutavant)
        {
            this.IdPersonnel = idpersonnel;
            this.DateDebut = datedebut;
            this.DateFin = datefin;
            this.IdMotif = idmotif;
            this.DateDebutAvant = datedebutavant;
        }
    }
}
