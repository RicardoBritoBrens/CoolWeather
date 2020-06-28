using Xamarin.Forms;
namespace CoolWeather.Extra.Navigation
{
    public partial class CustomNavigationPage : NavigationPage
    {
        public bool IgnoreLayoutChange { get; set; } = false;

        public CustomNavigationPage() : base()
        {
            InitializeComponent();
        }
        public CustomNavigationPage(Page root) : base(root)
        {
            InitializeComponent();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            if (!IgnoreLayoutChange)
            {
                base.OnSizeAllocated(width, height);
            }
        }
    }
}
