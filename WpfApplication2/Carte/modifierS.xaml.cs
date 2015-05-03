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

namespace WpfApplication2.Carte
{
    /// <summary>
    /// Logique d'interaction pour modifierS.xaml
    /// </summary>
    public partial class modifierS : UserControl
    {
        private CheckoutSet p;

        public modifierS()
        {
            InitializeComponent();
           // liste.Items.Add("fez"); liste.Items.Add("dfez");
            valider.IsEnabled = false;

        }

        public modifierS(CheckoutSet p)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.p = p;
            
            //Prenom.Text = p.Nom; 
            valider.IsEnabled = true;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            utilsDB.UpdateCheckout(p.X,p.Y,p.EmployeesId, p.Id);
            this.Content = new listeS();
        }

        private void annuler_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new listeS();
        }

        private void supprimer_Click(object sender, RoutedEventArgs e)
        {
            utilsDB.RemoveCheckout(  p.Id);
        }
    }
}
