﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Embedding.Plugin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CommandBindingPage : ContentPage
	{
		public CommandBindingPage ()
		{
			InitializeComponent ();
		}
	}
}