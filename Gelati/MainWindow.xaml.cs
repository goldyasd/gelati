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

namespace nsGelati
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Gelati g = new Gelati("Gelati.csv");
            dg.ItemsSource = g;
            
        }

        private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Gelato g = e.AddedItems[0] as Gelato;
            Ingredienti i = new Ingredienti("Ingredienti.csv");
            Ingredienti ingredientifiltrati = new();
            foreach(Ingrediente ing in i)
            {
                if(ing.IdGelato == g.Id)
                {
                    ingredientifiltrati.Add(ing);
                }
            }
            dg1.ItemsSource = ingredientifiltrati;
            
        }
    }
}
