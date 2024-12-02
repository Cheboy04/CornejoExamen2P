namespace CornejoExamen2P
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var litros = Double.Parse(Litros.Text);
     
            var res = litros * 0.264172;
            ResLit.Text = res.ToString("F2"); 
        }

        private void Button_Clicked2(object sender, EventArgs e)
        {
            var litrosMet = Double.Parse(LitrosMetros.Text);
            var res1 = litrosMet * 0.001;
            LitrosMet.Text = res1.ToString("F22");
        }

        private void Button_Clicked3(object sender, EventArgs e)
        {
            var galLit = Double.Parse(GalonesLitros.Text);
            var res2 = galLit * 3.78541;
            ResGal.Text = res2.ToString("F2");
        }

        private void Button_Clicked4(object sender, EventArgs e)
        {
            var galMet = Double.Parse(GalonesMetros.Text);
            var res3 = galMet * 0.00378541;
            GalonesMet.Text = res3.ToString("F22");
        }

        private void Button_Clicked5(object sender, EventArgs e)
        {
            var metGal = Double.Parse(MetrosGalones.Text);
            var res4 = metGal * 264.172;
            MetrosGal.Text = res4.ToString("F2");
        }

        private void Button_Clicked6(object sender, EventArgs e)
        {
            var metLit = Double.Parse(MetrosLitros.Text);
            var res5 = metLit * 1000;
            MetrosLit.Text = res5.ToString("F2");
        }
    }

}
