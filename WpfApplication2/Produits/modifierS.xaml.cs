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

namespace WpfApplication2.Produits
{
    /// <summary>
    /// Logique d'interaction pour modifierS.xaml
    /// </summary>
    public partial class modifierS : UserControl
    {
        private ProductsSet p;

        public modifierS()
        {
            InitializeComponent();
           // liste.Items.Add("fez"); liste.Items.Add("dfez");
            valider.IsEnabled = false;

        }

        public modifierS(ProductsSet p)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            cat.Items.Clear();
            foreach (CategoriesSet d in utilsDB.listCategorie())
            {
                cat.Items.Add(d);
            }

            prix.Text = Convert.ToString(p.Prix);
            this.p = p;
            nom.Text = p.Nom;
            int tmp = 0;
            if (int.TryParse(prix.Text, out tmp))
            {
                
            }
            tmp = p.Prix;
            dispo.IsChecked = p.CheckEmpty;
            cat.Items.Clear();
            foreach (CategoriesSet d in utilsDB.listCategorie())
            {
                cat.Items.Add(d);

            }
            cat.SelectedItem = utilsDB.GetCategorie(p.CategoriesId);
            valider.IsEnabled = true;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //utilsDB.UpdateWaiter(Nom.Text, Prenom.Text, p.Id);
            this.Content = new listeS();
        }

        private void annuler_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new listeS();
        }

        private void supprimer_Click(object sender, RoutedEventArgs e)
        {
            utilsDB.RemoveProduct(  p.Id);
        }
    }
}
