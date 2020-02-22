using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Morse
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        string entryTxt = "";
        string outText = "";
        void ClickDot(object sender, System.EventArgs e)
        {

            entryTxt += ".";
        }

        void ClickDash(object sender, System.EventArgs e)
        {
            entryTxt += "-";
        }

        //outputs the text
        void ClickSpace(object sender, System.EventArgs e)
        {
            char text = morseCode.MorseCoder(entryTxt);
            outText += text;
            entryTxt = "";
            output.Text = outText;
        }

    }
}
