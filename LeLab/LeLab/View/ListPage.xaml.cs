using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LeLab.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public class Article
    {

        public String Nom { get; set; }
        public String Prix { get; set; }
        public string Description { get; set; }
    }
    public partial class ListPage : ContentPage
    {
        List<Article> articles;
       
        public ListPage()  
        {
            InitializeComponent();

            articles = new List<Article>();

            articles.Add(new Article { Nom = "Lait", Prix = "4" , Description ="Pack de lait"});
            articles.Add(new Article { Nom = "Chocolat", Prix = "2.4", Description ="70% de cacao" });
            articles.Add(new Article { Nom = "Pain", Prix = "2", Description = "Des baguettes" });
            articles.Add(new Article { Nom = "Beurre", Prix = "41", Description = "Demi-Sel" });

           maListeView.ItemsSource = articles;
            maListeView.ItemSelected += (Sender, e) =>
             {
                 if (maListeView.SelectedItem != null)
                 {
                     Article item = maListeView.SelectedItem as Article;
                     DisplayAlert(item.Nom,item.Description, "OK");
                 }
                 maListeView.SelectedItem = null;
             };
        }
    }
}