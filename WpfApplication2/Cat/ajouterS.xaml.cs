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
            utilsDB.AddCategorie(nom.Text);
            ModernDialog.ShowMessage("La catégorie a été ajouter avec succés", "", MessageBoxButton.OK);
            nom.Text = "";
           
        }
    }
}
