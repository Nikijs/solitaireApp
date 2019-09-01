using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Solitaire
{
    public class CardsObject
    {
        public CardsObject(Image image, string name, Boolean isBlack, int prioroty)
        {
            Image = image;
            Name = name;
            IsBlack = isBlack;
            Priority = prioroty;
        }

        public string Name { get; set; }
        public Image Image { get; set; }
        public Boolean IsBlack { get; set; }
        public int Priority { get; set; }
    }
}
