namespace CaraOuCoroa
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            PickerLadoMoeda.SelectedIndex = 0;
        }

        private void BtnGirarMoeda_Clicked(object sender, EventArgs e)
        {
            int escolha = Convert.ToInt32(PickerLadoMoeda.SelectedIndex) ;
            count = new Random().Next(1, 3);
            if (count == 1) {
                labelResult.Text = "CARA";
                ImageCoin.Source = "cara.png";
            } else
            {
                labelResult.Text = "COROA";
                ImageCoin.Source = "coroa.png";
            }
            if(escolha == count-1)
            {
                acertou.Text = "Ae, Parabens.";
            } else
            {
                acertou.Text = "Puts, Não deu.";
            }
            
        }
    }

}
