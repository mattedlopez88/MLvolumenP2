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
            count++;

            if (count == 1)
                ML_Convert.Text = $"Clicked {count} time";
            else
                ML_Convert.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(ML_Convert.Text);
        }
    }

}
