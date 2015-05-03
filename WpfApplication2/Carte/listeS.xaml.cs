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

namespace WpfApplication2.Carte
{
    /// <summary>
    /// Logique d'interaction pour listeS.xaml
    /// </summary>
    public partial class listeS : UserControl
    {
        public listeS()
        {
        
            InitializeComponent();
       
      
        }

 

        private void Liste_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
                
                if (Liste.SelectedItem != null)
                {
                    //MessageBox.Show(Liste.SelectedItem.ToString());
                    this.Content = new modifierS((CheckoutSet)Liste.SelectedItem);
                }
        }


        private void load(object sender, RoutedEventArgs e)
        {
            Liste.Items.Clear();
            foreach (CheckoutSet d in utilsDB.listCheckout())
            {
                Liste.Items.Add(d);

            }
            foreach (SectionsSet d in utilsDB.listSections())
            {
                Liste.Items.Add(d);

            }
        }

    

      

  
      
    }
}
