using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace oooh
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CheatsPage : ContentPage
	{
        string cheats;
		public CheatsPage ()
		{
			InitializeComponent ();
		}
        private void BtnCheats1_Clicked(object sender, EventArgs e)
        {
            cheats = "Jogo";
            //Navegacao para a pagina da estoria do aluno
            Navigation.PushAsync(new AddGamePage(cheats));
        }
    }
}