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
        public int tapped=0;
        List<CardsObject> cards = new List<CardsObject>();

        public void LoadImages(List<CardsObject> card)
        {
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.AH.png"), IsVisible = false }, "AceHearts"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.AD.png"), IsVisible = false }, "AceDiamonds"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.KH.png"), IsVisible = false }, "KingHearts"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.KD.png"), IsVisible = false }, "AceDiamonds"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.QH.png"), IsVisible = false }, "QueenHearts"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.QD.png"), IsVisible = false }, "QueenDiamonds"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.JH.png"), IsVisible = false }, "JackHearts"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.JD.png"), IsVisible = false }, "JackDiamonds"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.10H.png"), IsVisible = false }, "TenHearts"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.10D.png"), IsVisible = false }, "TenDiamonds"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.9H.png"), IsVisible = false }, "NineHearts"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.9D.png"), IsVisible = false }, "NineDiamonds"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.8H.png"), IsVisible = false }, "EightHearts"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.8D.png"), IsVisible = false }, "EightDiamonds"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.7H.png"), IsVisible = false }, "SevenHearts"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.7D.png"), IsVisible = false }, "SevenDiamonds"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.6H.png"), IsVisible = false }, "SixHearts"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.6D.png"), IsVisible = false }, "SixDiamonds"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.5H.png"), IsVisible = false }, "FiveHearts"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.5D.png"), IsVisible = false }, "FiveDiamonds"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.4H.png"), IsVisible = false }, "FourHearts"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.4D.png"), IsVisible = false }, "FourDiamonds"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.3H.png"), IsVisible = false }, "ThreeHearts"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.3D.png"), IsVisible = false }, "ThreeDiamonds"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.2H.png"), IsVisible = false }, "TwoHearts"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.2D.png"), IsVisible = false }, "TwoDiamonds"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.AS.png"), IsVisible = false }, "AceSpades"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.AC.png"), IsVisible = false }, "AceClubs"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.KS.png"), IsVisible = false }, "KingSpades"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.KC.png"), IsVisible = false }, "AceClubs"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.QS.png"), IsVisible = false }, "QueenSpades"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.QC.png"), IsVisible = false }, "QueenClubs"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.JS.png"), IsVisible = false }, "JackSpades"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.JC.png"), IsVisible = false }, "JackClubs"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.10S.png"), IsVisible = false }, "TenSpades"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.10C.png"), IsVisible = false }, "TenClubs"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.9S.png"), IsVisible = false }, "NineSpades"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.9C.png"), IsVisible = false }, "NineClubs"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.8S.png"), IsVisible = false }, "EightSpades"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.8C.png"), IsVisible = false }, "EightClubs"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.7S.png"), IsVisible = false }, "SevenSpades"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.7C.png"), IsVisible = false }, "SevenClubs"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.6S.png"), IsVisible = false }, "SixSpades"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.6C.png"), IsVisible = false }, "SixClubs"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.5S.png"), IsVisible = false }, "FiveSpades"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.5C.png"), IsVisible = false }, "FiveClubs"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.4S.png"), IsVisible = false }, "FourSpades"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.4C.png"), IsVisible = false }, "FourClubs"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.3S.png"), IsVisible = false }, "ThreeSpades"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.3C.png"), IsVisible = false }, "ThreeClubs"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.2S.png"), IsVisible = false }, "TwoSpades"));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.2C.png"), IsVisible = false }, "TwoClubs"));

        }

            public MainPage()
        {
            InitializeComponent();
            LoadImages(cards);
            placeCards();
            placeDeck();
        }

        private void placeDeck()
        {
            for (int i = 0; i < 4; i++)
            {
                deckGrid.RowDefinitions.Add(new RowDefinition());
                deckGrid.ColumnDefinitions.Add(new ColumnDefinition());

                for (int j = 0; j < 1; j++)
                {

                    StackLayout sp = new StackLayout { Padding = new Thickness(10, 20) };
                    //Hidden card representing the whole deck of cards 
                    //3 more spaces saved for cards coming from the deck
                    if (i < 1)
                    {
                        var hide = new Image { Source = ImageSource.FromResource("Solitaire.Cards.gray_back.png") };
                        sp.Children.Add(hide);
                    }
                    

                    sp.WidthRequest = 100;
                    sp.HeightRequest = 100;
                    sp.HorizontalOptions = LayoutOptions.Fill;
                    sp.VerticalOptions = LayoutOptions.Fill;

                    deckGrid.Children.Add(sp);

                    sp.Children.Add(cards[tapped].Image);

                    //tapped event handler
                    TapGestureRecognizer tap = new TapGestureRecognizer();
                    tap.Tapped += Tap_Tapped;
                    tap.NumberOfTapsRequired = 1;

                    sp.GestureRecognizers.Add(tap);

                    Grid.SetRow(sp, i);
                    Grid.SetColumn(sp, j);
                    Thread.Sleep(50);
                }
            }
        }

        public void placeCards()
        {
 
            for (int i = 0; i < 7; i++)
            {
                cardsGrid.RowDefinitions.Add(new RowDefinition());
                cardsGrid.ColumnDefinitions.Add(new ColumnDefinition());

                for (int j = i; j < 7; j++)
                {
                    int randomNumber = random.Next(cards.Count);


                    StackLayout sp = new StackLayout { Padding = new Thickness(10, 20) };
                    if (j == i)
                    {
                        cards[randomNumber].Image.IsVisible = true;
                    }
                    else
                    {
                        var hide = new Image { Source = ImageSource.FromResource("Solitaire.Cards.gray_back.png") };
                        sp.Children.Add(hide);
                    }


                    sp.WidthRequest = 100;
                    sp.HeightRequest = 100;
                    sp.HorizontalOptions = LayoutOptions.Fill;
                    sp.VerticalOptions = LayoutOptions.Fill;

                    sp.Children.Add(cards[randomNumber].Image);

                    cardsGrid.Children.Add(sp);

                    Grid.SetRow(sp, i);
                    Grid.SetColumn(sp, j);
                    cards.RemoveAt(randomNumber);
                    Thread.Sleep(50);
                }
            }
            
        }

        private void Tap_Tapped(object sender, EventArgs e)
        {
            tapped++;
            // Grid.SetRow(sp, tapped);
            Image img = cards[tapped].Image;
            img.IsVisible = true;
           // deckGrid.SetRow(img, tapped);

            if (tapped > 3)
            {
                tapped = 0;
            }
        }
    }
}
