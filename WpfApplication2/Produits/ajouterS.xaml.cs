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
            //utilsDB.AddWaiter(nom.Text, prenom.Text);
            MessageBox.Show("Le produit a été ajouter avec succés");
            //nom.Text = "";
            //prenom.Text = "";
            this.Content = new ajouterS();
        }
    }
}
