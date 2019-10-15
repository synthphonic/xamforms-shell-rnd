using System.Threading.Tasks;
using System.Windows.Input;
using Acr.UserDialogs;
using AsyncAwaitBestPractices.MVVM;
using XamFormsShell.Infrastructure;

namespace XamFormsShell
{
	public class XamFormsAppShelllViewModel : BaseViewModel
	{
		private ICommand _settingsCommand;

		public XamFormsAppShelllViewModel()
		{
		}

		#region SettingsCommand
		public ICommand SettingsCommand
		{
			get { return _settingsCommand ?? (_settingsCommand = new AsyncCommand(OnSettingCommand)); }
		}

		private async Task OnSettingCommand()
		{
			var config = new AlertConfig();
			config.AndroidStyleId = AlertConfig.DefaultAndroidStyleId;
			config.OkText = "Ok BEBEH";
			config.Title = "I am Title";
			config.Message = "I am Message";


			//Xamarin.Essentials.AppInfo.ShowSettingsUI();
			await UserDialogs.Instance.AlertAsync(config);
		}
		#endregion
	}
}