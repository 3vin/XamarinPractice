using System.Collections.ObjectModel;
using ParticipantRegister.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParticipantRegister.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ParticipantListPage : ContentPage
	{
		public ParticipantListPage()
		{
			this.InitializeComponent();
			this.participents = this.InitializeModel();
			this.participentsListView.ItemsSource = this.participents;
		}

		private ObservableCollection<ParticipantViewModel> InitializeModel()
		{
			ObservableCollection<ParticipantViewModel> models = new ObservableCollection<ParticipantViewModel>
			{
				new ParticipantViewModel
				{
					Name = "Sbu",
					Address = "Ivory Park",
					IDNumber = 789789456456,
					ImageUrl = "participent.png",
				},
				new ParticipantViewModel
				{
					Name = "Siya",
					Address = "Ivory Park",
					IDNumber = 789789456456,
					ImageUrl = "participent.png",
				},
				new ParticipantViewModel
				{
					Name = "Smanga",
					Address = "Ivory Park",
					IDNumber = 789789456456,
					ImageUrl = "participent.png",
				},
				new ParticipantViewModel
				{
					Name = "Sabza",
					Address = "Ivory Park",
					IDNumber = 789789456456,
					ImageUrl = "participent.png",
				}
			};

			return models;
		}

		private readonly ObservableCollection<ParticipantViewModel> participents;

		private async void AddParticipent_Button_Clicked(object sender, System.EventArgs e)
		{
			await this.Navigation.PushAsync(new AddParticipantPage());
		}
	}
}