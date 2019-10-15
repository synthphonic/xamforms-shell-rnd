using System;
using XamFormsShell.Infrastructure;
using XamFormsShell.Models;

namespace XamFormsShell.ViewModels
{
	public class ItemDetailViewModel : BaseViewModel
	{
		public Item Item { get; set; }
		public ItemDetailViewModel(Item item = null)
		{
			Title = item?.Text;
			Item = item;
		}
	}
}
