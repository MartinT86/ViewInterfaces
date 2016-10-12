using ViewInterfaces.Interfaces;

namespace ViewInterfaces.Models
{
    public class HomeViewModel : ICanRenderTitleSection, ICanRenderBodySection
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string ImageUrl { get; set; }
        public string ImageCaption { get; set; }
        public string BodyCopy { get; set; }
    }
}