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
    /// Package controller
    /// </summary>
    internal class NamespaceDoc { }
    /// <summary>
    /// Contrôleur de FrmAuthentification
    /// </summary>
    internal class FrmAuthentificationController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Authentification
        /// </summary>
        private readonly Authentification authentification;

        /// <summary>
        /// Récupère les acces aux données
        /// </summary>
        public FrmAuthentificationController()
        {
            authentification = new Authentification();
        }

        public Boolean ControleAuthentification(Responsable responsable)
        {
            return authentification.ControleAuthentification(responsable);
        }
    }
}
