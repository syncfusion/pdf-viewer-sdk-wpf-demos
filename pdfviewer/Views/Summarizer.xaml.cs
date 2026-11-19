using syncfusion.demoscommon.wpf;
using Syncfusion.UI.Xaml.Chat;

namespace syncfusion.pdfviewerdemos.wpf
{
    /// <summary>
    /// Interaction logic for Summarizer.xaml
    /// </summary>
    public partial class Summarizer : DemoControl
    {
        private SummarizerViewModel viewModel;
        public Summarizer()
        {

            InitializeComponent();


        }
        public Summarizer(string themename) : base(themename)
        {
            InitializeComponent();
        }
        protected override void Dispose(bool disposing)
        {
            pdfviewer1.Unload(true);
            pdfviewer1 = null;
            if (this.DataContext is SummarizerViewModel)
            {
                (this.DataContext as SummarizerViewModel).DocumentStream.Dispose();
                this.DataContext = null;
            }
            base.Dispose(disposing);
        }
        /// <summary>
        /// Handles the event when a suggestion is selected in the chat.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data containing the selected suggestion.</param>
        private void chat_SuggestionSelected(object sender, SuggestionClickedEventArgs e)
        {
            viewModel = aiAssistView.DataContext as SummarizerViewModel;
            viewModel.chat_SuggestionSelected(sender, e);
        }
    }
}
