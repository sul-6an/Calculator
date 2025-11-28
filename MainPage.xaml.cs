namespace Kalkulator
{
    public partial class MainPage : ContentPage
    {
        double value1 = 0;
        double value2 = 0;
        double result = 0;
        string oberator = string.Empty;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnNumberClick(object sender, EventArgs e)
        {

            var btn = (Button)sender;
            screenLabel.Text += btn.Text;

        }

        private void OnClearClick(object sender, EventArgs e)
        {

            screenLabel.Text = "";
            value1 = value2 = result = 0;

        }

        private void OnOperatorClick(object sender, EventArgs e)
        {

            if (screenLabel.Text != "")
            {
                value1 = Convert.ToDouble(screenLabel.Text);
                var btn = (Button)sender;
                oberator = btn.Text;
                screenLabel.Text = "";
            }

        }

        private void OnEqualClick(object sender, EventArgs e)
        {

            if (screenLabel.Text != "")
            {
                value2 = Convert.ToDouble(screenLabel.Text);

                switch (oberator)
                {
                    case "+": result = value1 + value2; break;
                    case "-": result = value1 - value2; break;
                    case "x": result = value1 * value2; break;
                    case "÷":
                        if (value2 != 0) result = value1 / value2;
                        else result = 0;
                        break;
                }

                screenLabel.Text = result.ToString();

            }

        }

        private void OnNegClick(object sender, EventArgs e)
        {

            screenLabel.Text = (-Convert.ToDouble(screenLabel.Text)).ToString();

        }

        private void OnPerClick(object sender, EventArgs e)
        {

            screenLabel.Text = (Convert.ToDouble(screenLabel.Text) / 100).ToString();

        }

        private void Released(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            btn.Opacity = 1;
        }

        private void Press(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            btn.Opacity = 0.5;
        }
    }
}
