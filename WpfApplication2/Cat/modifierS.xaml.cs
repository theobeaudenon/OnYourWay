using FirstFloor.ModernUI.Windows.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication2.cat
{
    /// <summary>
    /// Logique d'interaction pour modifierS.xaml
    /// </summary>
    public partial class modifierS : UserControl
    {
        private CategoriesSet p;

        public modifierS()
        {
            InitializeComponent();
           // liste.Items.Add("fez"); liste.Items.Add("dfez");
            valider.IsEnabled = false;

        }

        public modifierS(CategoriesSet p)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.p = p;
            
            Prenom.Text = p.Nom; 
            valider.IsEnabled = true;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            utilsDB.UpdateCategorie(Prenom.Text, p.Id);
            ModernDialog.ShowMessage("La catégorie a été modifier avec succés", "", MessageBoxButton.OK);
            this.Content = new listeS();
        }

        private void annuler_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new listeS();
        }

        private void supprimer_Click(object sender, RoutedEventArgs e)
        {
            utilsDB.RemoveCategorie(  p.Id);
            ModernDialog.ShowMessage("La catégorie a été supprimer avec succés", "", MessageBoxButton.OK);
            this.Content = new listeS();
        }
    }
}
