using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication2.Pages
{
    /// <summary>
    /// Logique d'interaction pour UserControl1.xaml
    /// </summary>
    public partial class Page1 : System.Windows.Controls.UserControl
    {
        public Page1()
        {
            InitializeComponent();

           
             
         }

        private void load(object sender, RoutedEventArgs e)
        {

            canvas.Children.Clear();
            foreach (CheckoutSet d in utilsDB.listCheckout())
            {
                string templatse = "<ControlTemplate xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation' TargetType=\"Thumb\"  >" +
               "  <Image   Source=\"/WpfApplication2;component/carre-vert.gif\"  /> " +
              "</ControlTemplate>";

                System.Windows.Controls.Primitives.Thumb thumb = new System.Windows.Controls.Primitives.Thumb();
                //thumb.DragDelta += new DragDeltaEventHandler(Thumb_DragDelta);
                //  thumb.Template = template;
                thumb.Template = (ControlTemplate)XamlReader.Parse(templatse);
                thumb.PreviewMouseDown   += thumb_MouseDown;
                canvas.Children.Add(thumb);


                Canvas.SetLeft(thumb, d.X);
                Canvas.SetTop(thumb, d.Y);


            }
            foreach (SectionsSet d in utilsDB.listSections())
            {

                string templatsee = "<ControlTemplate xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation' TargetType=\"Thumb\"  >" +
              "  <Image   Source=\"/WpfApplication2;component/carre-noir.jpg\"  /> " +
             "</ControlTemplate>";

                System.Windows.Controls.Primitives.Thumb thumbe = new System.Windows.Controls.Primitives.Thumb();
                //thumbe.DragDelta += new DragDeltaEventHandler(Thumb_DragDelta);
                //  thumb.Template = template;
                thumbe.Template = (ControlTemplate)XamlReader.Parse(templatsee);
                thumbe.PreviewMouseDown += thumb_MouseDown;

                canvas.Children.Add(thumbe);

                Canvas.SetLeft(thumbe, d.X);
                Canvas.SetTop(thumbe, d.Y);


            }
        }

        private void thumb_MouseDown(object sender, MouseButtonEventArgs e)
        {
           System.Windows.Controls.Primitives.Thumb thumb =(System.Windows.Controls.Primitives.Thumb) e.Source;
           int pos = canvas.Children.IndexOf(thumb);


            List<UIElement> elements = canvas.Children.Cast<UIElement>().ToList();
           int i = 0;
           foreach (CheckoutSet d in utilsDB.listCheckout())
           {
               if (i == pos)
               {
                   this.Content = new CheckOutV(d);
               }
               //utilsDB.UpdateCheckout((int)Canvas.GetLeft(elements[i]), (int)Canvas.GetTop(elements[i]), d.EmployeesId, d.Id);
               i++;
           }

           foreach (SectionsSet d in utilsDB.listSections())
           {
               if (i == pos)
               {
                   this.Content = new itemview(d);

               }
               utilsDB.UpdateSections((int)Canvas.GetLeft(elements[i]), (int)Canvas.GetTop(elements[i]), d.CategoriesId, d.EmployeesId, d.Id);

               i++;
           }
            
        }

      
   

       
     
 
       
 
    }
}
