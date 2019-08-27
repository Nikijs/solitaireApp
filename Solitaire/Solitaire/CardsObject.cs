using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Solitaire
{
    class CardsObject
    {
        public CardsObject(Image image, string name)
        {
            Image = image;
            Name = name;
        }

        public string Name { get; set; }
        public Image Image { get; set; }
    }
}
