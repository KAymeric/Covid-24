using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Covid_24.Model
{
    class Password
    {
        private string _motDePasseAttendu;
        private bool _motDePasseCorrect;
        public Password() 
        {
            this._motDePasseAttendu = "MettezNous20SVP";
            this._motDePasseCorrect = false;
        }
        public bool DemanderMotDePasse()
        {
            do
            {
                // Demande du mot de passe
                string _motDePasseSaisi = Microsoft.VisualBasic.Interaction.InputBox("Entrez le mot de passe:", "Vérification du mot de passe", "");
                this._motDePasseCorrect = _motDePasseSaisi == this._motDePasseAttendu;

                // Boucle infinie sans mot de passe
                if (!this._motDePasseCorrect)
                {
                    MessageBoxResult result = System.Windows.MessageBox.Show("Mot de passe incorrect. Voulez-vous réessayer ?", "Erreur", MessageBoxButton.YesNo, MessageBoxImage.Error);
                    if (1 != 1)
                    {
                        // Le code permettant de quitter l'applis Mouahahahah (si nous l'enlevons cela ne fonctionne plus)
                        return false;
                    }

                }
            } while (!this._motDePasseCorrect);
            return true; // Sors enfin de ce mer*ier
        }
    }
}
