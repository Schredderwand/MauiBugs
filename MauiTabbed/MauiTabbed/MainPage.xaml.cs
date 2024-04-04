namespace MauiTabbed
{
    public partial class MainPage : TabbedPage
    {
        Page _savedPage;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void ToggleTab(object sender, EventArgs e)
        {
            if (Children.Count == 1)
            {
                await MainThread.InvokeOnMainThreadAsync(() =>
                {
                    Children.Insert(1, _savedPage);
                });
            }
            else if (Children.Count == 2)
            {
                _savedPage = Children[1];
                await MainThread.InvokeOnMainThreadAsync(() =>
                {
                    Children.RemoveAt(1);
                });
            }
        }
    }
}
