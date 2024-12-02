namespace MLvolumenP2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ML_litros.Text) && float.TryParse(ML_litros.Text, out float ML_floatLitros))
            {
                ML_gal.Text = (ML_floatLitros * 0.264172).ToString();
                ML_m3.Text = (ML_floatLitros * 0.219969).ToString();
            }
            else if (!string.IsNullOrWhiteSpace(ML_gal.Text) && float.TryParse(ML_gal.Text, out float ML_floatGalones))
            {
                ML_litros.Text = (ML_floatGalones * 4.54609).ToString();
                ML_m3.Text = (ML_floatGalones * 0.00454609).ToString();
            }
            else if (!string.IsNullOrWhiteSpace(ML_m3.Text) && float.TryParse(ML_m3.Text, out float ML_floatM3))
            {
                ML_litros.Text = (ML_floatM3 * 1000).ToString();
                ML_gal.Text = (ML_floatM3 * 219.969).ToString();
            }
            
            SemanticScreenReader.Announce(ML_Convert.Text);
        }

        private void OnBorrarClicked(object sender, EventArgs e)
        {
            ML_litros.Text = "";
            ML_gal.Text = "";
            ML_m3.Text = "";
        }
    }

}
