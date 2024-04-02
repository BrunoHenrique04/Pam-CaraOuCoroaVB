﻿namespace CaraOuCoroa
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
            } else
            {
                labelResult.Text = "COROA";
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
