# Application MediaTek86
Application C# écrite sous Visual Studio 2022 Entreprise et exploitant une BDD MySQL.<br><br>

## Présentation de l'application
### Présentation du contexte
L'entreprise cliente est spécialisée dans développement de sites internet personnalisées. Elle a développé une application interne permettant de gérer plus facilement les personnels ainsi que les absences des employés. L’utilisation de cette application consiste à gérer les informations des personnels (nom, prénom, service...) ainsi que leurs absences (dates, motifs…). Cette application est régulièrement enrichie par l’ajout de nouvelles fonctionnalités et nécessite également la mise à jour des fonctionnalités existantes.<br>
### But de l'application
Le responsable souhaite avoir <strong>un petit utilitaire pour gérer les profils, et donc les absences des différents personnels</strong>.<br>
L'application MediaTek86 représente cet utilitaire.<br>
L'application doit permettre de :
<ul>
<li>présenter la liste des personnels (nom, prénom, tel, mail, service) sachant qu'il existe une liste déterminée de service (médiation culturelle, prêt, administratif) ;</li>
<li>permettre d'ajouter un personnel ;</li>
<li>permettre de modifier ou supprimer un personnel ;</li>
<li>permettre de modifier ou supprimer ou d'ajouter une absence d'un personnel ;</li>
</ul>
La liste des services ou motifs est fixe et non modifiable via cette application.<br>

### Structure de la BDD
Voici le schéma conceptuel de données présentant la structure de la BDD qui est au format MySQL :<br>
<img width="434" height="400" alt="image" src="https://github.com/user-attachments/assets/c6c0f90e-caa3-4258-b2fe-38873fd5bc72" />

### Interface
Voici à quoi doit ressembler la fenêtre de l'application :<br>
<img width="569" height="487" alt="image" src="https://github.com/user-attachments/assets/8896c9e2-f693-401b-93ff-471f0b1fdc37" />

### Diagramme de paquetage
L'application est structurée dans le respect du pattern MVC.<br>
<img width="693" height="726" alt="image" src="https://github.com/user-attachments/assets/517110d3-94a8-4c56-8f66-5ca3761e7049" />

#### Explications sur les couches supplémentaires
L'application contient 2 paquetages supplémentaires par rapport au MVC classique :<br>
. 'bddmanager' : contient la classe qui permet d'accéder à la base de données MySQL et d'exécuter les requêtes (classe indépendante et réutilisable).<br>
. 'dal' (Data Access Layer) : répond aux demandes du paquetage 'controller' et exploite 'bddmanager' en lui demandant d'exécuter des requêtes.<br>
L'avantage de cette architecture est l'isolement de la connexion (bddmanager) par rapport au reste de l'application. Le controleur ne sait pas d'où viennent les données (cela pourrait être un autre SGBDR, voire un autre type de fichier, comme XML). Le paquetage 'dal' fait l'intermédiaire en préparant des requêtes SQL. Donc on sait dans les classes de ce paquetage, qu'il est question d'une base de données relationnelle, mais ne sait pas non plus quel est le SGBDR utilisé.<br>
Changer de SGBDR reviendrait à juste changer la classe BddManager (son contenu), donc ne travailler que sur le paquetage 'bddmanager'.<br>
Changer de type de fichier reviendrait à changer aussi les classes du paquetage 'dal', sans toucher au reste de l'application.
#### Présentation du cheminement
L'application démarre sur une vue : c'est la structure classique des applications C# de bureau, mais il serait aussi possible de démarrer sur un contrôleur principal.<br>
La vue crée une instance du contrôleur qui lui est dédié (chaque vue a son propre contrôleur). Quand elle a besoin d'accéder aux données (affichage ou demande de modifications), elle fait appel à son contrôleur.<br>
Le contrôleur fait appel aux classes de la couche 'dal' pour exécuter les demandes de la vue.<br>
Les classes de la couche 'dal' contiennent les requêtes qui doivent être exécutées et sollicitent la couche 'bddmanager' pour exécuter les requêtes.<br>
Chaque classe de la couche 'dal' est liée à une classe métier contenu dans 'model'. Ces classes correspondent aux tables de la base de données (avec une approche objet, donc pas de clés étrangères mais des références d'objets) et ne contiennent que la structure des données (propriétés, getters, setters).
Excepté 'bddmanager' qui est indépendant de l'application (réutilisable dans n'importe quelle application), toutes les couches exploitent le 'model' (pour le formatage des données).<br>
## Etapes de construction
Les différents commits montrent la création de l'application étape par étape.
### Commit "Phase 1 : Création des paquetages et classes, début de code Vue de l'application (uniquement le visuel des interfaces)"
La structure de l'application est créée (les paquetages et classes), dans le respect du diagramme de paquetage.<br>
Les classes Frames (dans la paquetage Vue) commence à être construite, uniquement le visuel.<br>
L'application n'est pas encore opérationnelle.
### Commit "Phase 2 : Création des paquetages et classes, début de code BddManager et Acces.cs dans dal et mis a jour de la Documentation"
La classe BddManager (dans la paquetage bddmanager) commence à être construite. C'est un singleton qui permet de se connecter à une BDD et d'exécuter des requêtes SQL.<br>
Commencement de la documentation et de nouveaux fichiers dans les dal pour les fonctionnalités.
### Commit "Phase 3 : Finalisation des fonctionnalitées Dal et Controller et mis a jour du doc"
Toutes les fonctionnalités sont codées.
### Commit "Phase 4 : Finalisation de la partie Vue des personnels avec les fonctionnalités associées et mise à jour du doc"
Les fonctionnalités sont liées sur la partie Vue des personnels.
### Commit "Phase 5 : Finalisation de la partie Vue des absences avec les fonctionnalités associées et mise à jour du doc"
Les fonctionnalités sont liées sur la partie Vue des absences.
### Commit "Phase 6 : Création de l'installateur de l'application et ajout du script SQL"
Création d'un installeur pour l'application.

## Installation
Il est possible de tester l'application étape par étape (commit par commit) ou de tester directement la version finale.<br>
Pour tester une version dans un environnement de développement, il faut d'abord installer les outils suivants :<br>
. SGBDR MySQL (par exemple en installant WAMP ou un logiciel similaire)<br>
. De préférence un IDE pour manipuler le code (cette application a été réalisée sous Visual Studio 2022)<br> 
Il faut ensuite :<br>
. Dans MySQL, exécuter le script contenu dans habilitations.sql (présent en racine du dépôt) pour créer et remplir la BDD.<br>
. Récupérer le code du commit voulu, l'ouvrir dans l'IDE et l'exécuter.
