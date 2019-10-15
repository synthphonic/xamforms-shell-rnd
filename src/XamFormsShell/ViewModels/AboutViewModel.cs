using System;
using System.Windows.Input;
using XamFormsShell.Infrastructure;
using Xamarin.Forms;

namespace XamFormsShell.ViewModels
{
	public class AboutViewModel : BaseViewModel
	{
		public AboutViewModel()
		{
			Title = "About";

			OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
		}

		public ICommand OpenWebCommand { get; }
	}
}