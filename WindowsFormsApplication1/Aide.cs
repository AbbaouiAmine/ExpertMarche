using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Aide : Form
    {
        public Aide()
        {
            InitializeComponent();
        }

        private void bt10_Click(object sender, EventArgs e)
        {
            labelTitre.Text = "I.Introduction";
            richTextBox1.Text = "Bienvenue dans la visionneuse d'aide Expert marché  une source d'informations essentielle pour toutes les personnes qui utilisent  cette application de gestion,  La visionneuse d'aide vous donne accès à des informations, des exemples de travail  et bien d'autres choses encore. Pour trouver ce dont vous avez besoin, parcourez la table des matières, utilisez la recherche en texte intégral ou naviguez dans le contenu à l'aide de l'index des mots clés. ";
            this.panel8.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.hand;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            labelTitre.Text = "II.Menu principale";
            richTextBox1.Text = "Au chargement de l’application Expert marché, La fenêtre  d’accueil  apparaît. Elle  vous permettre d’accéder  directement aux opérations de base, elle est divisé en  3 groupes  principaux Opération, Document, Option.";
            this.panel8.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.aide2;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            labelTitre.Text = "III.Groupe Opération ";
            richTextBox1.Text = "1.Botton Mise à jour\nLe bouton  mise à jour  charge une fenêtre qui vous permet de faire les différentes opérations de MAJ (ajout, modification, suppression, recherche),  L’utilisateur sélectionne la table voulu en cliquant sur leur nom  dans le  menu situé à gauche de la fenêtre.  La formule de mise à jour est  située à côté du menu de navigation elle  s’affiche  lors du choix de la table.\n\n 2.Attachement\nL’ajout  des attachements  est aussi disponible via le bouton attachement  situé dans le milieu de la colonne opération.\n\n3.Calendrier\nL’utilisateur peut afficher un calendrier  dans le  but  de vérifié les dates des documents  via le bouton calendrier   situer dans  la partie basse  de la colonne opération.";
            this.panel8.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.aide1;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            labelTitre.Text = "IV.Groupe document ";
            richTextBox1.Text = "L’ensemble des documents peuvent être générés à travers la colonne Document du menu principale. Les  données inclus dans les documents  sont rechargé à partir de la base de données. L’utilisateur peut choisir quelques-unes  selon le document  visionné.";
            this.panel8.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.aide3;
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            labelTitre.Text = "V.Groupe Option";
            richTextBox1.Text = "Plusieurs options  peuvent être exploitées  dans  le but  de la vérification du plusieurs informations  supplémentaires concernant  l’état de la connexion avec la base de données, l’aide …";
            this.panel8.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.aide4;
        }
    }
}
