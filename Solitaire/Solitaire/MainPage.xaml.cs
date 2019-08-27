using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Solitaire
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //Grid grid = new Grid
            /* {
                 VerticalOptions = LayoutOptions.FillAndExpand,
                 RowDefinitions =
                 {
                     new RowDefinition { Height = GridLength.Auto },
                     new RowDefinition { Height = GridLength.Auto },
                     new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                     new RowDefinition { Height = new GridLength(100, GridUnitType.Absolute) }
                 },
                 ColumnDefinitions =
                 {
                     new ColumnDefinition { Width = GridLength.Auto },
                     new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                     new ColumnDefinition { Width = new GridLength(100, GridUnitType.Absolute) }
                 }
             };



             grid.Children.Add(new Label
             {
                 Text = "Cards here",
                 TextColor = Color.Yellow,
                 BackgroundColor = Color.Green,
                 HorizontalTextAlignment = TextAlignment.Center,
                 VerticalTextAlignment = TextAlignment.Center,
             }, 1, 2);

             grid.Children.Add(new Label
             {
                 Text = "Space for deck",
                 TextColor = Color.Yellow,
                 BackgroundColor = Color.DarkGreen,
                 HorizontalTextAlignment = TextAlignment.Center,
                 VerticalTextAlignment = TextAlignment.Center
             }, 0, 1, 1, 4);

             this.Content = grid;

     */
            InitializeComponent();
        }
    }
}
