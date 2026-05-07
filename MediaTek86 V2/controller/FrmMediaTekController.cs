using MediaTek86_V2.dal;
using MediaTek86_V2.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86_V2.controller
{
    /// <summary>
    /// Contrôleur de FrmHabilitations
    /// </summary>
    internal class FrmMediaTekController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Absence
        /// </summary>
        private readonly AbsenceAcces absenceAcces;
        /// <summary>
        /// objet d'accès aux opérations possible sur Personnel
        /// </summary>
        private readonly PersonnelAcces personnelAcces;
        /// <summary>
        /// objet d'accès aux opérations possible sur Service
        /// </summary>
        private readonly ServicesAcces servicesAcces;
        /// <summary>
        /// objet d'accès aux opérations possible sur Motif
        /// </summary>
        private readonly MotifAcces motifAcces;

        /// <summary>
        /// Récupère les acces aux données
        /// </summary>
        public FrmMediaTekController()
        {
            absenceAcces = new AbsenceAcces();
            personnelAcces = new PersonnelAcces();
            servicesAcces = new ServicesAcces();
            motifAcces = new MotifAcces();
        }

        /// <summary>
        /// Récupère et retourne les infos des personnels
        /// </summary>
        /// <returns>liste des personnels</returns>
        public List<Personnel> GetLesPersonnels()
        {
            return personnelAcces.GetLesPersonnels();
        }

        /// <summary>
        /// Récupère et retourne les infos des absences d'un personnel
        /// </summary>
        /// <param name="idpesronnel">liste des absences d'un personnel</param>
        public List<Absence> GetLesAbsences(int idpesronnel)
        {
            return absenceAcces.GetLesAbsences(idpesronnel);
        }

        /// <summary>
        /// Récupère et retourne les services
        /// </summary>
        public List<Service> GetLesServices()
        {
            return servicesAcces.GetLesServices();
        }

        /// <summary>
        /// Récupère et retourne les motifs
        /// </summary>
        public List<Motif> GetLesMotifs()
        {
            return motifAcces.GetLesMotifs();
        }

        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à supprimer</param>
        public void DelPersonnel(Personnel personnel)
        {
            personnelAcces.DelPersonnel(personnel);
        }

        /// <summary>
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à ajouter</param>
        public void AddPersonnel(Personnel personnel)
        {
            personnelAcces.AddPersonnel(personnel);
        }

        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à modifier</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            personnelAcces.UpdatePersonnel(personnel);
        }

        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence"></param>
        public void AddAbsence(Absence absence)
        {
            absenceAcces.AddAbsence(absence);
        }

        /// <summary>
        /// Demande de suppression d'un profil
        /// </summary>
        /// <param name="absence">objet absence à supprimer</param>
        public void DelAbsence(Absence absence)
        {
            absenceAcces.DelAbsence(absence);
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence">objet absence à modifier</param>
        public void UpdateAbsence(Absence absence)
        {
            absenceAcces.UpdateAbsence(absence);
        }

        /// <summary>
        /// Demande de verification des créneaux pour les absences
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="dateDebut"></param>
        /// <param name="dateFin"></param>
        /// <param name="ancienneDateDebut"></param>
        /// <returns></returns>
        public Boolean AbsenceCreneau(int idpersonnel, DateTime dateDebut, DateTime dateFin, DateTime ancienneDateDebut)
        {
            return absenceAcces.AbsenceCreneau(idpersonnel, dateDebut, dateFin, ancienneDateDebut);
        }
    }
}
