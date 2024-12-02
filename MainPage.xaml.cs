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
     
            var res = litros * 3.78;
            ResLit.Text = res.ToString("F2"); 
        }

        private void Button_Clicked2(object sender, EventArgs e)
        {
            var litrosMet = Double.Parse(LitrosMetros.Text);
            var res1 = litrosMet * 1000;
        }

        private void Button_Clicked3(object sender, EventArgs e)
        {

        }

        private void Button_Clicked4(object sender, EventArgs e)
        {

        }

        private void Button_Clicked5(object sender, EventArgs e)
        {

        }

        private void Button_Clicked6(object sender, EventArgs e)
        {

        }
    }

}
