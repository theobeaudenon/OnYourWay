using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication2.Carte
{
    /// <summary>
    /// Logique d'interaction pour UserControl1.xaml
    /// </summary>
    public partial class mainC : System.Windows.Controls.UserControl
    {
        public mainC()
        {
            InitializeComponent();



             
            foreach (CheckoutSet d in utilsDB.listCheckout())
            {
                string templatse = "<ControlTemplate xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation' TargetType=\"Thumb\"  >" +
               "  <Image   Source=\"/WpfApplication2;component/carre-vert.gif\"  /> " +
              "</ControlTemplate>";

                System.Windows.Controls.Primitives.Thumb thumb = new System.Windows.Controls.Primitives.Thumb();
                thumb.DragDelta += new DragDeltaEventHandler(Thumb_DragDelta);
                //  thumb.Template = template;
                thumb.Template = (ControlTemplate)XamlReader.Parse(templatse);

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
                thumbe.DragDelta += new DragDeltaEventHandler(Thumb_DragDelta);
                //  thumb.Template = template;
                thumbe.Template = (ControlTemplate)XamlReader.Parse(templatsee);
                
                canvas.Children.Add(thumbe);

                Canvas.SetLeft(thumbe, d.X);
                Canvas.SetTop(thumbe, d.Y);
 

            }
             




         }
        private void Thumb_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {
            System.Windows.UIElement thumb = e.Source as System.Windows.UIElement;
            Canvas.SetLeft(thumb, Canvas.GetLeft(thumb) + e.HorizontalChange);
            Canvas.SetTop(thumb, Canvas.GetTop(thumb) + e.VerticalChange);
          
            if (Canvas.GetLeft(thumb) < 0)
            {

                Canvas.SetLeft(thumb, 0);
                e.Handled = false;
            }
             if (Canvas.GetTop(thumb) < 0)
            {
                Canvas.SetTop(thumb, 0);
                e.Handled = false;
            }
             if (Canvas.GetLeft(thumb) > 1200 - 52)
            {

                Canvas.SetLeft(thumb, 1200 - 52);
                e.Handled = false;
            }
             if (Canvas.GetTop(thumb) > 550-52)
            {
                Canvas.SetTop(thumb, 550 - 52);
                e.Handled = false;
            }
            
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<UIElement> elements = canvas.Children.Cast<UIElement>().ToList();
            int i = 0;
            foreach (CheckoutSet d in utilsDB.listCheckout())
            {

                utilsDB.UpdateCheckout((int)Canvas.GetLeft(elements[i]), (int)Canvas.GetTop(elements[i]), d.EmployeesId, d.Id);
                i++;
            }

            foreach (SectionsSet d in utilsDB.listSections())
            {

                utilsDB.UpdateSections((int)Canvas.GetLeft(elements[i]), (int)Canvas.GetTop(elements[i]), d.CategoriesId, d.EmployeesId, d.Id);

                i++;
            }

        }
 
       
 
    }
}
