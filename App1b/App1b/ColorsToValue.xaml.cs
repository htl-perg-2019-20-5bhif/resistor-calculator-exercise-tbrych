using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1b
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ColorsToValue : ContentPage
    {

        private ColorValue FirstColorValue;

        public ColorValue FirstColor
        {
            get => FirstColorValue;
            set
            {
                this.FirstColorValue = value;
                OnPropertyChanged(nameof(FirstColor));
            }
        }

        private ColorValue SecondColorValue;

        public ColorValue SecondColor
        {
            get => SecondColorValue;
            set
            {
                this.SecondColorValue = value;
                OnPropertyChanged(nameof(SecondColor));
            }
        }

        private ColorValue ThirdColorValue;

        public ColorValue ThirdColor
        {
            get => ThirdColorValue;
            set
            {
                this.ThirdColorValue = value;
                OnPropertyChanged(nameof(ThirdColor));
            }
        }
        private string FourthColorValue;

        public string FourthColor
        {
            get => FourthColorValue;
            set
            {
                this.FourthColorValue = value;
                OnPropertyChanged(nameof(FourthColor));
            }
        }

        private long ValueValue = 0;
        public long Value
        {
            get => ValueValue;
            set
            {
                ValueValue = value;
                OnPropertyChanged(nameof(Value));
            }
        }

        public ColorLists Lists { get; set; }

        public ColorsToValue()
        {
            Lists = new ColorLists();
            InitializeComponent();
            BindingContext = this;
        }

        private void CalculateOhm(object sender, EventArgs e)
        {
            // Here some magic will happen
            if (FirstColor != null && SecondColor != null && ThirdColor != null && FourthColor != null) {
                Value = (FirstColor.Value * 10 + SecondColor.Value) * ThirdColor.Value; 
            }

        }
    }
}