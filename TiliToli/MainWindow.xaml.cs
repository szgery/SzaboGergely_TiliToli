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

namespace TiliToli
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         //variable to count the steps
         public int steps = 0;

         public MainWindow()
         {
             InitializeComponent();
             Button First = (Button)FindName("Button1");
             Button Second = (Button)FindName("Button2");
             Button Third = (Button)FindName("Button3");
             Button Fourth = (Button)FindName("Button4");
             Button Fifth = (Button)FindName("Button5");
             Button Sixth = (Button)FindName("Button6");
             Button Seventh = (Button)FindName("Button7");
             Button Eighth = (Button)FindName("Button8");

             First.IsEnabled = false;
             Second.IsEnabled = false;
             Third.IsEnabled = false;
             Fourth.IsEnabled = false;
             Fifth.IsEnabled = false;
             Sixth.IsEnabled = false;
             Seventh.IsEnabled = false;
             Eighth.IsEnabled = false;
         }

         private void Button1_Click(object sender, RoutedEventArgs e)
         {
             Button egyikGomb = sender as Button;
             Button nullaGomb = (Button)FindName("Button0");
             int vTav = Math.Abs((int)(egyikGomb.Margin.Left - nullaGomb.Margin.Left));
             int fTav = Math.Abs((int)(egyikGomb.Margin.Top - nullaGomb.Margin.Top));
             if ((vTav <120 && fTav == 0) || (fTav < 120 && vTav == 0)) {
                 var seged = egyikGomb.Margin;
                 egyikGomb.Margin = nullaGomb.Margin;
                 nullaGomb.Margin = seged;
                 steps++;
                 Steps.Content = "Steps: " + steps;
             }

            if((int)(Button1.Margin.Left) == 23 && (int)(Button1.Margin.Top) == 61 && (int)(Button2.Margin.Left) == 175 && (int)(Button2.Margin.Top) == 61 && (int)(Button3.Margin.Left) == 327 && (int)(Button3.Margin.Top) == 61 && (int)(Button4.Margin.Left) == 23 && (int)(Button4.Margin.Top) == 213 && (int)(Button5.Margin.Left) == 175 && (int)(Button5.Margin.Top) == 213 && (int)(Button6.Margin.Left) == 327 && (int)(Button6.Margin.Top) == 213 && (int)(Button7.Margin.Left) == 23 && (int)(Button7.Margin.Top) == 365 && (int)(Button8.Margin.Left) == 175 && (int)(Button8.Margin.Top) == 365)
                    {
                string message = Convert.ToString(steps) + " lépésből kiraktad!";
                MessageBox.Show("You won!", "tilitoli");
                steps = 0;
            }
         }
            private void NewGame_Click_1(object sender, RoutedEventArgs e)
         {
             Mix();
         }

         public void Mix()
         {
             Button First = (Button)FindName("Button1");
             Button Second = (Button)FindName("Button2");
             Button Third = (Button)FindName("Button3");
             Button Fourth = (Button)FindName("Button4");
             Button Fifth = (Button)FindName("Button5");
             Button Sixth = (Button)FindName("Button6");
             Button Seventh = (Button)FindName("Button7");
             Button Eighth = (Button)FindName("Button8");

             First.IsEnabled = true;
             Second.IsEnabled = true;
             Third.IsEnabled = true;
             Fourth.IsEnabled = true;
             Fifth.IsEnabled = true;
             Sixth.IsEnabled = true;
             Seventh.IsEnabled = true;
             Eighth.IsEnabled = true;

             Random r = new Random();

             steps = 0;
             int rN = 0;
             int run = 0;
             int Mix = r.Next(10, 101);
             Steps.Content = "Steps: " + steps;
             Button nullGomb = (Button)FindName("Button0");
             do
             {
                 rN = r.Next(1, 9);
                 string Button = "Button" + rN;
                 Button RandomButton = (Button)FindName(Button);
                 int vtav = Math.Abs((int)(RandomButton.Margin.Left - nullGomb.Margin.Left));
                 int ftav = Math.Abs((int)(RandomButton.Margin.Top - nullGomb.Margin.Top));
                 if ((vtav < 130 && ftav == 0) || (ftav < 130 && vtav == 0))
                 {
                     var seged = RandomButton.Margin;
                     RandomButton.Margin = nullGomb.Margin;
                     nullGomb.Margin = seged;
                     run++;
                 }
             } while (run != Mix);
         }    


    }              
}

