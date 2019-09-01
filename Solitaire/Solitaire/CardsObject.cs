using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Solitaire
{
    public class CardsObject
    {
        public CardsObject(Image image, string name, Boolean isBlack)
        {
            Image = image;
            Name = name;
            IsBlack = isBlack;
        }

        public string Name { get; set; }
        public Image Image { get; set; }
        public Boolean IsBlack { get; set; }
    }
}
