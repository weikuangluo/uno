﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uno.UI.Xaml;
using Windows.UI.Xaml;

namespace Uno.UI.Helpers.Xaml
{
	public static class SetterExtensions
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static Setter ApplyThemeResourceUpdateValues(this Setter setter, string themeResourceName, object parseContext)
		{
			setter.ThemeResourceName = themeResourceName;
			setter.ThemeResourceContext = parseContext as XamlParseContext;

			return setter;
		}
	}
}
