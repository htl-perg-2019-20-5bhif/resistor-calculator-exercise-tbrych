using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1b
{
    public class ColorLists
    {
        public List<ColorValue> SecondBandList { get; } = new List<ColorValue>() {
            new ColorValue { Color="Black", Value=0 },
            new ColorValue { Color="Brown", Value=1 },
            new ColorValue { Color="Red", Value=2 },
            new ColorValue { Color="Orange", Value=3 },
            new ColorValue { Color="Yellow", Value=4 },
            new ColorValue { Color="Green", Value=5 },
            new ColorValue { Color="Blue", Value=6},
            new ColorValue { Color="Purple", Value=7 },
            new ColorValue { Color="Grey", Value=8 },
            new ColorValue { Color="White", Value=9 }
        };

        public List<ColorValue> FirstBandList { get; }

        public List<ColorValue> ThirdBandList { get; }

        public List<string> FourthBandList { get; } = new List<string>() { "Brown", "Red", "Gold", "Silver" };

        public ColorLists()
        {
            FirstBandList = SecondBandList.GetRange(1, SecondBandList.Count() - 1);
            ThirdBandList = SecondBandList.Select(e => new ColorValue() { Color = e.Color, Value = (int)Math.Pow(10, e.Value) }).ToList();
        }
    }
}
