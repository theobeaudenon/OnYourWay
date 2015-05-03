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

namespace WpfApplication2.Pages
{
    /// <summary>
    /// Logique d'interaction pour listeS.xaml
    /// </summary>
    public partial class itemview : UserControl
    {
        private SectionsSet d;
        private Page1 page1;

   

 

        public itemview(SectionsSet d )
        {
            
            InitializeComponent();
            // TODO: Complete member initialization
            this.d = d;
            CategoriesSet cate = utilsDB.GetCategorie(d.CategoriesId);
            EmployeesSet emps = utilsDB.GetEmployee(d.EmployeesId);

            emp.Content = emps.ToString();
            cat.Content = cate.ToString();
            Liste.Items.Clear();
            foreach (ProductsSet ds in utilsDB.listProduct())
            {
                if(ds.CategoriesId == d.CategoriesId)
                     Liste.Items.Add(ds);

            }
        }

 

   


        private void load(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new Page1(); 

        }

    

      

  
      
    }
}
