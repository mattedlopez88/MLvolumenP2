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
            if (ML_litros != null) {
                string ML_litrosString = ML_litros.Text;
                float ML_litrosNumber = Single.Parse(ML_litrosString);

                ML_gal.Text = (ML_litrosNumber * 0.264172).ToString();
                ML_m3.Text = (ML_litrosNumber * 0.000001).ToString();
            }
            count++;

            if (count == 1)
                ML_Convert.Text = $"Clicked {ML_litros.Text} time";
            else
                ML_Convert.Text = $"Clicked {ML_litros.Text} times";

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
