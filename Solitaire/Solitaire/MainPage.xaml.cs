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
        List<CardsObject> cardsRemaning = new List<CardsObject>();
        StackLayout decksp = new StackLayout { Padding = new Thickness(10, 10) };

        public void LoadImages(List<CardsObject> card)
        {
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.AH.png"), IsVisible = false }, "AceHearts" , false));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.AD.png"), IsVisible = false }, "AceDiamonds", false));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.KH.png"), IsVisible = false }, "KingHearts", false));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.KD.png"), IsVisible = false }, "AceDiamonds", false));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.QH.png"), IsVisible = false }, "QueenHearts", false));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.QD.png"), IsVisible = false }, "QueenDiamonds", false));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.JH.png"), IsVisible = false }, "JackHearts", false));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.JD.png"), IsVisible = false }, "JackDiamonds", false));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.10H.png"), IsVisible = false }, "TenHearts", false));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.10D.png"), IsVisible = false }, "TenDiamonds", false));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.9H.png"), IsVisible = false }, "NineHearts", false));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.9D.png"), IsVisible = false }, "NineDiamonds", false));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.8H.png"), IsVisible = false }, "EightHearts", false));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.8D.png"), IsVisible = false }, "EightDiamonds", false));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.7H.png"), IsVisible = false }, "SevenHearts", false));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.7D.png"), IsVisible = false }, "SevenDiamonds", false));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.6H.png"), IsVisible = false }, "SixHearts", false));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.6D.png"), IsVisible = false }, "SixDiamonds", false));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.5H.png"), IsVisible = false }, "FiveHearts", false));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.5D.png"), IsVisible = false }, "FiveDiamonds", false));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.4H.png"), IsVisible = false }, "FourHearts", false));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.4D.png"), IsVisible = false }, "FourDiamonds", false));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.3H.png"), IsVisible = false }, "ThreeHearts", false));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.3D.png"), IsVisible = false }, "ThreeDiamonds", false));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.2H.png"), IsVisible = false }, "TwoHearts", false));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.2D.png"), IsVisible = false }, "TwoDiamonds", false));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.AS.png"), IsVisible = false }, "AceSpades", true));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.AC.png"), IsVisible = false }, "AceClubs", true));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.KS.png"), IsVisible = false }, "KingSpades", true));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.KC.png"), IsVisible = false }, "AceClubs", true));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.QS.png"), IsVisible = false }, "QueenSpades", true));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.QC.png"), IsVisible = false }, "QueenClubs", true));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.JS.png"), IsVisible = false }, "JackSpades", true));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.JC.png"), IsVisible = false }, "JackClubs", true));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.10S.png"), IsVisible = false }, "TenSpades", true));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.10C.png"), IsVisible = false }, "TenClubs", true));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.9S.png"), IsVisible = false }, "NineSpades", true));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.9C.png"), IsVisible = false }, "NineClubs", true));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.8S.png"), IsVisible = false }, "EightSpades", true));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.8C.png"), IsVisible = false }, "EightClubs", true));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.7S.png"), IsVisible = false }, "SevenSpades", true));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.7C.png"), IsVisible = false }, "SevenClubs", true));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.6S.png"), IsVisible = false }, "SixSpades", true));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.6C.png"), IsVisible = false }, "SixClubs", true));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.5S.png"), IsVisible = false }, "FiveSpades", true));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.5C.png"), IsVisible = false }, "FiveClubs", true));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.4S.png"), IsVisible = false }, "FourSpades", true));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.4C.png"), IsVisible = false }, "FourClubs", true));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.3S.png"), IsVisible = false }, "ThreeSpades", true));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.3C.png"), IsVisible = false }, "ThreeClubs", true));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.2S.png"), IsVisible = false }, "TwoSpades", true));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.2C.png"), IsVisible = false }, "TwoClubs", true));

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

                    
                    //Hidden card representing the whole deck of cards 
                    //3 more spaces saved for cards coming from the deck
                    if (i < 1)
                    {
                        var hide = new Image { Source = ImageSource.FromResource("Solitaire.Cards.gray_back.png") };
                        decksp.Children.Add(hide);
                        TapGestureRecognizer tap = new TapGestureRecognizer();
                        tap.Tapped += Tap_Tapped;
                        tap.NumberOfTapsRequired = 1;
                        decksp.GestureRecognizers.Add(tap);
                    }


                    decksp.WidthRequest = 100;
                    decksp.HeightRequest = 100;


                    decksp.HorizontalOptions = LayoutOptions.Fill;
                    decksp.VerticalOptions = LayoutOptions.Fill;

                    deckGrid.Children.Add(decksp);

                    Grid.SetRow(decksp, i);
                    Grid.SetColumn(decksp, j);
                    Thread.Sleep(50);
                }
            }
            
            cardsRemaning = cards;
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
                    //top card will stay visible, others hidden
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
            
            decksp.Children.Add(cards[tapped].Image);
            
            cards[tapped].Image.IsVisible = true;
            //at 3 taps removes a card from grid number 1
            if (tapped > 3)
            {
                decksp.Children.RemoveAt(tapped-tapped+1);
                
            }
            //cycle the whole deck begin at index 0
            if(tapped == cards.Count-1)
            {
                tapped = 0;
            }
        }
    }
}
