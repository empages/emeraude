// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Emeraude Client Builder.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.ObjectModel;
using Prism.Mvvm;

namespace Definux.Emeraude.AutoGenerated.DataTransferObjects
{
	public class SimpleResultBindable : BindableBase
	{
		private bool successed;

		public bool Successed 
		{ 
			get
			{
				return this.successed;
			}
			set
			{
				SetProperty(ref this.successed, value); 
			}
		}
	}
}
