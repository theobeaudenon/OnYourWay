﻿using System;
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
    public partial class CheckOutV : UserControl
    {
        private CheckoutSet d; 

 

  

        public CheckOutV(CheckoutSet d )
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.d = d; 
          
            EmployeesSet emps = utilsDB.GetEmployee(d.EmployeesId);

            emp.Content = emps.ToString();


            Liste.Items.Clear();
            foreach (ProductsSet ds in utilsDB.listProduct())
            {

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
