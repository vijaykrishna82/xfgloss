﻿using System;
using Xamarin.Forms;
using XFGloss.Models;

namespace XFGlossSample.Examples.ViewModels
{
	public class ThumbTintColorViewModel : IExamplesViewModel
	{
		public string PropertyDefault
		{
			get { return "Color.Default"; }
		}

		public string[] PropertyDescription
		{
			get
			{
				return new string[]
				{
					"Specifies a numeric or named XF.Color value to apply to the thumb portion of the Switch control when the control is in the \"Off\" position.",
				};
			}
		}

		public string PropertyType
		{
			get { return "Xamarin.Forms.Color"; }
		}

		public string TargetClasses
		{
			get { return "Switch, SwitchCell"; }
		}
	}
}