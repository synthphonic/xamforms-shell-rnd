using System;

namespace XamFormsShell.Infrastructure
{
	public interface IErrorHandler
	{
		void HandleError(Exception ex);
	}
}
