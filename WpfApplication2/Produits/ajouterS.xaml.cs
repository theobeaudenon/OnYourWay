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
    /// Logique d'interaction pour ajouterS.xaml
    /// </summary>
    public partial class ajouterS : UserControl
    {
        public ajouterS()
        {
            InitializeComponent();
           
        }

   

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CategoriesSet p = (CategoriesSet)cat.SelectedItem;
            int tmp = 0;
            if (int.TryParse(prix.Text, out tmp))
            {

            }
            utilsDB.AddProduct(nom.Text, tmp, p.Id , (bool)dispo.IsChecked);
            ModernDialog.ShowMessage("Le produit a été ajouter avec succès", "", MessageBoxButton.OK);
            //nom.Text = "";
            //prenom.Text = "";
            this.Content = new ajouterS();
        }

        private void load(object sender, RoutedEventArgs e)
        {
            cat.Items.Clear();
            foreach (CategoriesSet d in utilsDB.listCategorie())
            {
                cat.Items.Add(d);

            }
        }
    }
}
