using MediaTek86_V2.controller;
using MediaTek86_V2.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86_V2.view
{
    /// <summary>
    /// Fenêtre d'affichage des absences
    /// </summary>
    public partial class FrmMediaTekAbsence : Form
    {
        /// <summary>
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursDeModifAbsence = false;
        /// <summary>
        /// Objet pour gérer la liste des absences
        /// </summary>
        private readonly BindingSource bdgAbsences = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des motifs
        /// </summary>
        private readonly BindingSource bdgMotifs = new BindingSource();
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmMediaTekController controller;
        /// <summary>
        /// Titre des fenêtres d'information
        /// </summary>
        private readonly String titreFenetreInformation = "Information";
        /// <summary>
        /// Variable pour idpersonnel
        /// </summary>
        private int idpersonnel;

        /// <summary>
        /// Construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FrmMediaTekAbsence(int idpersonnel)
        {
            this.idpersonnel = idpersonnel;
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisations :
        /// Création du controleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FrmMediaTekController();
            RemplirListeAbsences(idpersonnel);
            RemplirListeMotifs();
            EnCourseModifAbsence(false);
        }

        /// <summary>
        /// Affiche les absences
        /// </summary>
        private void RemplirListeAbsences(int idpersonnel)
        {
            List<Absence> lesAbsences = controller.GetLesAbsences(idpersonnel);
            bdgAbsences.DataSource = lesAbsences;
            dgvAbsences.DataSource = bdgAbsences;
            dgvAbsences.Columns["idpersonnel"].Visible = false;
            dgvAbsences.Columns["datedebutavant"].Visible = false;
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Affiche les motifs
        /// </summary>
        private void RemplirListeMotifs()
        {
            List<Motif> lesMotifs = controller.GetLesMotifs();
            bdgMotifs.DataSource = lesMotifs;
            cboMotif.DataSource = bdgMotifs;
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                EnCourseModifAbsence(true);
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                dtpDebut.Value = absence.DateDebut;
                dtpFin.Value = absence.DateFin;
                cboMotif.SelectedIndex = cboMotif.FindStringExact(absence.Motif.Libelle);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", titreFenetreInformation);
            }
        }

        /// <summary>
        /// Modification d'affichage suivant si on est en cours de modif ou d'ajout d'une absence
        /// </summary>
        /// <param name="modif"></param>
        private void EnCourseModifAbsence(Boolean modif)
        {
            enCoursDeModifAbsence = modif;
            grbLesAbsences.Enabled = !modif;
            if (modif)
            {
                grbAbsence.Text = "Modifier une absence";
            }
            else
            {
                grbAbsence.Text = "Ajouter une absence";
                dtpDebut.Value = DateTime.Now;
                dtpFin.Value = DateTime.Now;
                cboMotif.SelectedIndex = -1;
            }
        }

        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + absence.DateDebut + " " + absence.DateFin + " pour motif: " + absence.Motif.Libelle + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelAbsence(absence);
                    RemplirListeAbsences(idpersonnel);
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", titreFenetreInformation);
            }
        }

        /// <summary>
        /// Demande d'enregistrement de l'ajout ou de la modification d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (controller.AbsenceCreneau(idpersonnel, dtpDebut.Value, dtpFin.Value, dtpDebut.Value))
            {
                MessageBox.Show("Une absence existe déjà sur cette période.", titreFenetreInformation);
                return;
            }
            if (cboMotif.SelectedIndex == -1)
            {
                MessageBox.Show("Tous les champs doivent être remplis.", titreFenetreInformation);
                return;
            }
            if (dtpDebut.Value > dtpFin.Value)
            {
                MessageBox.Show("La date de début ne peut pas être après la date de fin.", titreFenetreInformation);
                return;
            }

            Motif motif = (Motif)bdgMotifs.List[bdgMotifs.Position];
            if (enCoursDeModifAbsence)
            {
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                DateTime ancienneDateDebut = absence.DateDebutAvant;
                absence.DateDebut = dtpDebut.Value;
                absence.DateFin = dtpFin.Value;
                absence.DateDebutAvant = ancienneDateDebut;
                absence.Motif = motif;
                controller.UpdateAbsence(absence);
            }
            else
            {
                Absence absence = new Absence(idpersonnel, dtpDebut.Value, dtpFin.Value, motif, dtpDebut.Value);
                controller.AddAbsence(absence);
            }
            RemplirListeAbsences(idpersonnel);
            EnCourseModifAbsence(false);
        }

        /// <summary>
        /// Annule la demande d'ajout ou de modification d'un personnel
        /// Vide les zones de saisie du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCourseModifAbsence(false);
            }
        }

        /// <summary>
        /// Bouton pour gérer les personnels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPersonnel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
