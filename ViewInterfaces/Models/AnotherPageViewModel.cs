using ViewInterfaces.Interfaces;

namespace ViewInterfaces.Models
{
    public class AnotherPageViewModel : ICanRenderTitleSection
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
    }
}