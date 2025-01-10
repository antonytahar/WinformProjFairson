using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinformProjFairson
{
    public partial class Form1 : Form
    {
        //Déclaration des variables
        private List<objValSaisies> listeValSaisies;
        private int i;
        private string filePath = "valSaisies.txt";

        public Form1()
        {
            InitializeComponent();
            listeValSaisies = new List<objValSaisies>();
            i = listeValSaisies.Count; // Initialisation de i à la valeur du dernier index de la liste
            ChargerFichier(); // Chargement du fichier
        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSaisie.Text))
            {
                MessageBox.Show("Veuillez saisir une valeur"); // Affiche un message d'erreur
            }
            else
            { 
                listeValSaisies.Add(new objValSaisies(i, txtSaisie.Text)); //Ajout à la liste
                i++; // Incrément i pour la prochaine saisie
                ActualiserListBox(); 
            }

        }

        private void ActualiserListBox() // Actualise le ListBox pour l'affichage
        {
            listBox.Items.Clear();

            foreach (var elementValSaisie in listeValSaisies)
            {
                listBox.Items.Add(elementValSaisie.ToString()); // Ajoute l'élément au ListBox
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath)) // Création du fichier valSaisies.txt
                {
                    foreach (var valSaisie in listeValSaisies)
                    {
                        writer.WriteLine($"{valSaisie.NumSaisie}, {valSaisie.ValSaisie}"); // Ecriture de chaque ligne dans le fichier
                    }
                }

                MessageBox.Show("Enregistrement réussi dans valSaisies.txt.");
            }
            catch (Exception ex)
            {
            }
        }

        private void ChargerFichier()
        {
            string filePath = "valSaisies.txt";

            if (File.Exists(filePath))
            {
                try
                {
                    var lignes = File.ReadAllLines(filePath);
                    foreach (var ligne in lignes)
                    {
                        var splitLigne = ligne.Split('¤');
                        var valSaisie = new objValSaisies(splitLigne[0], splitLigne[1]);
                        listeValSaisies.Add(valSaisie);
                    }

                    ActualiserListBox();
                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}