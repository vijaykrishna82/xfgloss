﻿using System.Collections.Generic;
using Xamarin.Forms;

namespace XFGlossSample.Examples.Views.CSharp
{
	public class BackgroundColorPage : ContentPage
	{
		public BackgroundColorPage()
		{
			/*
			This is a bit of a hack. Android's renderer for TableView always adds an empty header for a 
			TableSection declaration, while iOS doesn't. To compensate, I'm using a Label to display info text
			on iOS, and the TableSection on Android since there is no easy way to get rid of it.This is a
			long-standing bug in the XF TableView on Android.
			(https://forums.xamarin.com/discussion/18037/tablesection-w-out-header)
			*/
			TableSection section;
			if (Device.OS == TargetPlatform.Android)
			{
				section = new TableSection("Cell BackgroundColor values set in C#:");
			}
			else
			{
				section = new TableSection();
			}

			section.Add(CreateBackgroundColorCells());

			var stack = new StackLayout();
			if (Device.OS == TargetPlatform.iOS)
			{
				stack.Children.Add(new Label { Text = "Cell BackgroundColor values set in C#:", Margin = new Thickness(10) });
			}
			stack.Children.Add(new TableView
			{
				Intent = TableIntent.Data,
				HeightRequest = Device.OnPlatform<double>(132, 190, 0),
				Root = new TableRoot
				{
					section
				}
			});

			Content = stack;
		}

		TextCell[] CreateBackgroundColorCells()
		{
			List<TextCell> result = new List<TextCell>();

			Dictionary<string, Color> colors = new Dictionary<string, Color>()
			{
				{ "Red", Color.Red },
				{ "Green", Color.Green },
				{ "Blue", Color.Blue }
			};

			// Iterate through the color values, creating a new text cell for each entity
			var colorNames = colors.Keys;
			foreach (string colorName in colorNames)
			{
				var cell = new TextCell();
				cell.Text = colorName;
				cell.TextColor = Color.White;

				// Assign our gloss properties - You can use the standard static setter...
				XFGloss.Views.Cell.SetBackgroundColor(cell, colors[colorName]);

				// ...or instantiate an instance of the Gloss properties you want to assign values to
				//	var gloss = new XFGloss.Views.Cell(cell);
				//	gloss.AccessoryType = accType;
				//	gloss.BackgroundColor = Color.Blue;
				//	gloss.TintColor = Color.Red;
				//	...

				result.Add(cell);
			}

			return result.ToArray();
		}
	}
}