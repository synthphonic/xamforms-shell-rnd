using Xamarin.Forms;

namespace XamFormsShell
{
	public partial class XamFormsAppShell : Shell
	{
		public XamFormsAppShell()
		{
			InitializeComponent();

			BindingContext = new XamFormsAppShelllViewModel();
		}
	}
}
