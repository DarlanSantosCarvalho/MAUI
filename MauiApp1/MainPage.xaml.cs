namespace MauiApp1
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

            if (count % 2 == 0)
                CounterBtn.Text = $"Você clicou {count} vezes, um número par";
            else if (count % 2 != 0)
                CounterBtn.Text = $"Você clicou {count} vezes, um número ímpar";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
