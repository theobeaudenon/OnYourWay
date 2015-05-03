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
    /// Logique d'interaction pour ajouterS.xaml
    /// </summary>
    public partial class ajouterS : UserControl
    {
        public ajouterS()
        {
            InitializeComponent();
            cat.Items.Clear();
            foreach (CategoriesSet d in utilsDB.listCategorie())
            {
                cat.Items.Add(d);

            }
            if (cat.Items.Count == 0)
            {
                val1.IsEnabled = false;
            }
            else
            {
                val1.IsEnabled = true;

            }

            emp.Items.Clear();
            emp1.Items.Clear();
            foreach (EmployeesSet d in utilsDB.listEmployee())
            {
                emp.Items.Add(d);
                emp1.Items.Add(d);

            }


        }

   

        private void Button_Click_1(object sender, RoutedEventArgs e)
        { 
            //utilsDB.AddWaiter(nom.Text, prenom.Text);
            //nom.Text = "";
            //prenom.Text = "";
            CategoriesSet ss=(CategoriesSet)cat.SelectedItem;
            EmployeesSet empe = (EmployeesSet)emp.SelectedItem;

            utilsDB.AddSections(0, 0, ss.Id,empe.Id);
            MessageBox.Show("Le rayon a été ajouter avec succés");

            this.Content = new ajouterS();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                        EmployeesSet emp = (EmployeesSet)emp1.SelectedItem;

            utilsDB.AddCheckout(0, 0,emp.Id);
             MessageBox.Show("La caisse a été ajouter avec succés"); 
            this.Content = new ajouterS();
        }
    }
}
