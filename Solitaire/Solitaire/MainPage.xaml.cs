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

        public bool game = true;
        Random random = new Random();
        public int tapped=0;
        int timeEllapsed = 1;
        List<CardsObject> cards = new List<CardsObject>();
        List<CardsObject> cardsRemaning = new List<CardsObject>();
        StackLayout decksp = new StackLayout { Padding = new Thickness(10, 10) };
        public int selectedPriority; //priority of card that is selected
        public Boolean isBlack;
        public int selectedPriority2; 
        public Boolean isBlack2;

        public MainPage()
        {
            InitializeComponent();
            LoadCards load = new LoadCards();
            load.LoadImages(cards);
            placeCards();
            placeDeck();
            Shuffle(cards);
            startTimer();
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
                        hide.GestureRecognizers.Add(tap);
                    }

                    decksp.WidthRequest = 100;
                    decksp.HeightRequest = 100;
                    decksp.HorizontalOptions = LayoutOptions.Fill;
                    decksp.VerticalOptions = LayoutOptions.Fill;

                    deckGrid.Children.Add(decksp);
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

                    TapGestureRecognizer tap3 = new TapGestureRecognizer();
                    tap3.Tapped += Tap_Tapped3;
                    tap3.NumberOfTapsRequired = 1;
                    cards[randomNumber].Image.GestureRecognizers.Add(tap3);

                    Grid.SetRow(sp, i);
                    Grid.SetColumn(sp, j);
                    cards.RemoveAt(randomNumber); //eliminate duplicates 
                    Thread.Sleep(50);
                }
            }
            
        }

        //card on table clicked event attempt.... difficulty aquiring the card priority
        //this is where i got stuck
        private void Tap_Tapped3(object sender, EventArgs e)
        {
            Image stackCard = (Image)sender;

            for (int i = 0, length = cards.Count(); i < length; i++)
            {
                //tried to get the priority of card by matching the tapped card source 
                //by checking if the cards list source matches, when debbuging stackCard shows null
                
                if (stackCard.Source == cards[i].Image.Source)
                {
                    selectedPriority2 = cards[i].Priority;
                    isBlack2 = cards[i].IsBlack;
                    
                }
            }
        }

        private void Tap_Tapped(object sender, EventArgs e)
        {
            tapped++;
            //make card visible
            cards[tapped].Image.IsVisible = true;

            
            //at 3 taps removes a card from grid number 1
            if (tapped > 3)
            {
                decksp.Children.RemoveAt(1);
                //undo the select of card
                var lastUndo = decksp.Children.ElementAt(2);
                lastUndo.HeightRequest = 100;
                lastUndo.BackgroundColor = Color.Default;
            }
            //remove cards and start stack from the top
            if (tapped == cards.Count - 1)
            {
                tapped = 1;
                decksp.Children.RemoveAt(2);
                decksp.Children.RemoveAt(1);
                
            }
            //add image to the stack
            decksp.Children.Add(cards[tapped].Image);
            //tapped event for card on top 
            if (tapped > 2)
            {
                Image last = (Image)decksp.Children[3];
                //save selected card properties 
                selectedPriority = cards[tapped].Priority;
                isBlack = cards[tapped].IsBlack;
                
                labelVar.Text = "Priority: " + selectedPriority + " black? "+ isBlack.ToString();
                //tap event on card
                TapGestureRecognizer tap2 = new TapGestureRecognizer();
                tap2.Tapped += Tap_Tapped2;
                tap2.NumberOfTapsRequired = 1;
                last.GestureRecognizers.Add(tap2);
            }
        }

        //tap event for select card in deck
        private void Tap_Tapped2(object sender, EventArgs e)
        {
            //change 4th element in stack to red
            var last = decksp.Children.ElementAt(decksp.Children.Count - 1);
            last.HeightRequest = 110;

            last.BackgroundColor = Color.Red;
        }

        //Fisher-Yates shuffle acquired from stack overflow 
        private void Shuffle(List<CardsObject> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                CardsObject value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public void startTimer()
        {
            //increments timer every second
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                labelVar2.Text = "Timer: " + timeEllapsed;
                timeEllapsed++;

                return game;
            });

            labelVar2.TextColor = Color.DarkGreen;
            labelVar2.FontSize = 15;
            labelVar2.HorizontalTextAlignment = TextAlignment.Start;
            labelVar2.VerticalTextAlignment = TextAlignment.Start;
        }

        //not implemented but the theory behind the priority and isBlack booleans 
        public void matchCards(int selectedPriority, int selectedPriority2, Boolean isBlack, Boolean isBlack2)
        {
            //check first selected card is one number smaller than second selected card and is oposite color
            if(selectedPriority == selectedPriority2-1 && isBlack != isBlack2)
            {
                //add to stack
            }
        }

    }
}
