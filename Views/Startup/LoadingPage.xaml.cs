using TutorsBro.ViewModels.Startup;

namespace TutorsBro.Views.Startup;

public partial class LoadingPage : ContentPage
{
	public LoadingPage(LoadingPageViewModel viewModel)
	{
        InitializeComponent();

		this.BindingContext = viewModel;
	}
}