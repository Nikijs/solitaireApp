using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Solitaire
{
    class LoadCards
    {
        public void LoadImages(List<CardsObject> card)
        {
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.AH.png"), IsVisible = false }, "AceHearts", false, 14));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.AD.png"), IsVisible = false }, "AceDiamonds", false, 14));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.KH.png"), IsVisible = false }, "KingHearts", false, 13));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.KD.png"), IsVisible = false }, "AceDiamonds", false, 13));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.QH.png"), IsVisible = false }, "QueenHearts", false, 12));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.QD.png"), IsVisible = false }, "QueenDiamonds", false, 12));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.JH.png"), IsVisible = false }, "JackHearts", false, 11));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.JD.png"), IsVisible = false }, "JackDiamonds", false, 11));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.10H.png"), IsVisible = false }, "TenHearts", false, 10));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.10D.png"), IsVisible = false }, "TenDiamonds", false, 10));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.9H.png"), IsVisible = false }, "NineHearts", false, 9));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.9D.png"), IsVisible = false }, "NineDiamonds", false, 9));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.8H.png"), IsVisible = false }, "EightHearts", false, 8));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.8D.png"), IsVisible = false }, "EightDiamonds", false, 8));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.7H.png"), IsVisible = false }, "SevenHearts", false, 7));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.7D.png"), IsVisible = false }, "SevenDiamonds", false, 7));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.6H.png"), IsVisible = false }, "SixHearts", false, 6));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.6D.png"), IsVisible = false }, "SixDiamonds", false, 6));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.5H.png"), IsVisible = false }, "FiveHearts", false, 5));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.5D.png"), IsVisible = false }, "FiveDiamonds", false, 5));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.4H.png"), IsVisible = false }, "FourHearts", false, 4));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.4D.png"), IsVisible = false }, "FourDiamonds", false, 4));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.3H.png"), IsVisible = false }, "ThreeHearts", false, 3));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.3D.png"), IsVisible = false }, "ThreeDiamonds", false, 3));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.2H.png"), IsVisible = false }, "TwoHearts", false, 2));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.2D.png"), IsVisible = false }, "TwoDiamonds", false, 2));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.AS.png"), IsVisible = false }, "AceSpades", true, 14));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.AC.png"), IsVisible = false }, "AceClubs", true, 14));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.KS.png"), IsVisible = false }, "KingSpades", true, 13));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.KC.png"), IsVisible = false }, "AceClubs", true, 13));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.QS.png"), IsVisible = false }, "QueenSpades", true, 12));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.QC.png"), IsVisible = false }, "QueenClubs", true, 12));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.JS.png"), IsVisible = false }, "JackSpades", true, 11));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.JC.png"), IsVisible = false }, "JackClubs", true, 11));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.10S.png"), IsVisible = false }, "TenSpades", true, 10));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.10C.png"), IsVisible = false }, "TenClubs", true, 10));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.9S.png"), IsVisible = false }, "NineSpades", true, 9));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.9C.png"), IsVisible = false }, "NineClubs", true, 9));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.8S.png"), IsVisible = false }, "EightSpades", true, 8));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.8C.png"), IsVisible = false }, "EightClubs", true, 8));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.7S.png"), IsVisible = false }, "SevenSpades", true, 7));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.7C.png"), IsVisible = false }, "SevenClubs", true, 7));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.6S.png"), IsVisible = false }, "SixSpades", true, 6));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.6C.png"), IsVisible = false }, "SixClubs", true, 6));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.5S.png"), IsVisible = false }, "FiveSpades", true, 5));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.5C.png"), IsVisible = false }, "FiveClubs", true, 5));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.4S.png"), IsVisible = false }, "FourSpades", true, 4));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.4C.png"), IsVisible = false }, "FourClubs", true, 4));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.3S.png"), IsVisible = false }, "ThreeSpades", true, 3));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.3C.png"), IsVisible = false }, "ThreeClubs", true, 3));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.2S.png"), IsVisible = false }, "TwoSpades", true, 2));
            card.Add(new CardsObject(new Image { Source = ImageSource.FromResource("Solitaire.Cards.2C.png"), IsVisible = false }, "TwoClubs", true, 2));

        }
    }
}
