using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System;
using System.Threading;

namespace Solitaire
{
    public partial class MainPage : ContentPage
    {

        private CardsObject black;
        private CardsObject red;
        Random random = new Random();

        public void LoadImages(List<CardsObject> card)
        {
            card.Add(new CardsObject(new Image { Source = "Cards/AH.png", IsVisible = true }, "AceHearts"));
            card.Add(new CardsObject(new Image { Source = "Cards/AD.png", IsVisible = true }, "AceDiamonds"));
            card.Add(new CardsObject(new Image { Source = "Cards/KH.png", IsVisible = true }, "KingHearts"));
            card.Add(new CardsObject(new Image { Source = "Cards/KD.png", IsVisible = true }, "AceDiamonds"));
            card.Add(new CardsObject(new Image { Source = "Cards/QH.png", IsVisible = true }, "QueenHearts"));
            card.Add(new CardsObject(new Image { Source = "Cards/QD.png", IsVisible = true }, "QueenDiamonds"));
            card.Add(new CardsObject(new Image { Source = "Cards/JH.png", IsVisible = true }, "JackHearts"));
            card.Add(new CardsObject(new Image { Source = "Cards/JD.png", IsVisible = true }, "JackDiamonds"));
            card.Add(new CardsObject(new Image { Source = "Cards/10H.png", IsVisible = true }, "TenHearts"));
            card.Add(new CardsObject(new Image { Source = "Cards/10D.png", IsVisible = true }, "TenDiamonds"));
            card.Add(new CardsObject(new Image { Source = "Cards/9H.png", IsVisible = true }, "NineHearts"));
            card.Add(new CardsObject(new Image { Source = "Cards/9D.png", IsVisible = true }, "NineDiamonds"));
            card.Add(new CardsObject(new Image { Source = "Cards/8H.png", IsVisible = true }, "EightHearts"));
            card.Add(new CardsObject(new Image { Source = "Cards/8D.png", IsVisible = true }, "EightDiamonds"));
            card.Add(new CardsObject(new Image { Source = "Cards/7H.png", IsVisible = true }, "SevenHearts"));
            card.Add(new CardsObject(new Image { Source = "Cards/7D.png", IsVisible = true }, "SevenDiamonds"));
            card.Add(new CardsObject(new Image { Source = "Cards/6H.png", IsVisible = true }, "SixHearts"));
            card.Add(new CardsObject(new Image { Source = "Cards/6D.png", IsVisible = true }, "SixDiamonds"));
            card.Add(new CardsObject(new Image { Source = "Cards/5H.png", IsVisible = true }, "FiveHearts"));
            card.Add(new CardsObject(new Image { Source = "Cards/5D.png", IsVisible = true }, "FiveDiamonds"));
            card.Add(new CardsObject(new Image { Source = "Cards/4H.png", IsVisible = true }, "FourHearts"));
            card.Add(new CardsObject(new Image { Source = "Cards/4D.png", IsVisible = true }, "FourDiamonds"));
            card.Add(new CardsObject(new Image { Source = "Cards/3H.png", IsVisible = true }, "ThreeHearts"));
            card.Add(new CardsObject(new Image { Source = "Cards/3D.png", IsVisible = true }, "ThreeDiamonds"));
            card.Add(new CardsObject(new Image { Source = "Cards/2H.png", IsVisible = true }, "TwoHearts"));
            card.Add(new CardsObject(new Image { Source = "Cards/2D.png", IsVisible = true }, "TwoDiamonds"));

            card.Add(new CardsObject(new Image { Source = "Cards/AS.png", IsVisible = true }, "AceSpades"));
            card.Add(new CardsObject(new Image { Source = "Cards/AC.png", IsVisible = true }, "AceClubs"));
            card.Add(new CardsObject(new Image { Source = "Cards/KS.png", IsVisible = true }, "KingSpades"));
            card.Add(new CardsObject(new Image { Source = "Cards/KC.png", IsVisible = true }, "AceClubs"));
            card.Add(new CardsObject(new Image { Source = "Cards/QS.png", IsVisible = true }, "QueenSpades"));
            card.Add(new CardsObject(new Image { Source = "Cards/QC.png", IsVisible = true }, "QueenClubs"));
            card.Add(new CardsObject(new Image { Source = "Cards/JS.png", IsVisible = true }, "JackSpades"));
            card.Add(new CardsObject(new Image { Source = "Cards/JC.png", IsVisible = true }, "JackClubs"));
            card.Add(new CardsObject(new Image { Source = "Cards/10S.png", IsVisible = true }, "TenSpades"));
            card.Add(new CardsObject(new Image { Source = "Cards/10C.png", IsVisible = true }, "TenClubs"));
            card.Add(new CardsObject(new Image { Source = "Cards/9S.png", IsVisible = true }, "NineSpades"));
            card.Add(new CardsObject(new Image { Source = "Cards/9C.png", IsVisible = true }, "NineClubs"));
            card.Add(new CardsObject(new Image { Source = "Cards/8S.png", IsVisible = true }, "EightSpades"));
            card.Add(new CardsObject(new Image { Source = "Cards/8C.png", IsVisible = true }, "EightClubs"));
            card.Add(new CardsObject(new Image { Source = "Cards/7S.png", IsVisible = true }, "SevenSpades"));
            card.Add(new CardsObject(new Image { Source = "Cards/7C.png", IsVisible = true }, "SevenClubs"));
            card.Add(new CardsObject(new Image { Source = "Cards/6S.png", IsVisible = true }, "SixSpades"));
            card.Add(new CardsObject(new Image { Source = "Cards/6C.png", IsVisible = true }, "SixClubs"));
            card.Add(new CardsObject(new Image { Source = "Cards/5S.png", IsVisible = true }, "FiveSpades"));
            card.Add(new CardsObject(new Image { Source = "Cards/5C.png", IsVisible = true }, "FiveClubs"));
            card.Add(new CardsObject(new Image { Source = "Cards/4S.png", IsVisible = true }, "FourSpades"));
            card.Add(new CardsObject(new Image { Source = "Cards/4C.png", IsVisible = true }, "FourClubs"));
            card.Add(new CardsObject(new Image { Source = "Cards/3S.png", IsVisible = true }, "ThreeSpades"));
            card.Add(new CardsObject(new Image { Source = "Cards/3C.png", IsVisible = true }, "ThreeClubs"));
            card.Add(new CardsObject(new Image { Source = "Cards/2S.png", IsVisible = true }, "TwoSpades"));
            card.Add(new CardsObject(new Image { Source = "Cards/2C.png", IsVisible = true }, "TwoClubs"));

        }

            public MainPage()
        {
            InitializeComponent();

            placeCards();
        }
        
        public void placeCards()
        {
            
            List<CardsObject> cards = new List<CardsObject>();
      
            LoadImages(cards);
            for (int i = 0; i < 7; i++)
            {
                cardsGrid.RowDefinitions.Add(new RowDefinition());
                cardsGrid.ColumnDefinitions.Add(new ColumnDefinition());

                for (int j = 0; j < 5; j++)
                {
                    int randomNumber = random.Next(cards.Count);

                    StackLayout sp = new StackLayout { Padding = new Thickness(10, 20) };
                    

                    sp.WidthRequest = 1500;
                    sp.HeightRequest = 1500;
                    sp.HorizontalOptions = LayoutOptions.Fill;
                    sp.VerticalOptions = LayoutOptions.Fill;
                    sp.BackgroundColor = Color.FromHex("#77d065");
                    sp.Children.Add(cards[randomNumber].Image);

                    cardsGrid.Children.Add(sp);

                   
                    Grid.SetRow(sp, i);
                    Grid.SetColumn(sp, j);
                    cards.RemoveAt(randomNumber);
                    Thread.Sleep(50);
                }
            }
           
                
            
        }



    }
}
