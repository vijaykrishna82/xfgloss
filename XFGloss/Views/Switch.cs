﻿using System;
using Xamarin.Forms;
using XFGloss.Models;

namespace XFGloss.Views
{
	public class Switch : IXFGlossSwitchProperties
	{
		#region TintColor

		public static readonly BindableProperty TintColorProperty =
            BindableProperty.CreateAttached(XFGlossPropertyNames.TintColor,
												typeof(Color), typeof(Xamarin.Forms.Switch), Color.Default);

		public static Color GetTintColor(BindableObject bindable)
		{
			return (Color)bindable.GetValue(TintColorProperty);
		}

		public static void SetTintColor(BindableObject bindable, Color value)
		{
			bindable.SetValue(TintColorProperty, value);
		}

		#endregion

		#region OnTintColor

		public static readonly BindableProperty OnTintColorProperty =
            BindableProperty.CreateAttached(XFGlossPropertyNames.OnTintColor,
											typeof(Color), typeof(Xamarin.Forms.Switch), Color.Default);

		public static Color GetOnTintColor(BindableObject bindable)
		{
			return (Color)bindable.GetValue(OnTintColorProperty);
		}

		public static void SetOnTintColor(BindableObject bindable, Color value)
		{
			bindable.SetValue(OnTintColorProperty, value);
		}

		#endregion

		#region ThumbTintColor

		public static readonly BindableProperty ThumbTintColorProperty =
            BindableProperty.CreateAttached(XFGlossPropertyNames.ThumbTintColor,
											typeof(Color), typeof(Xamarin.Forms.Switch), Color.Default);

		public static Color GetThumbTintColor(BindableObject bindable)
		{
			return (Color)bindable.GetValue(ThumbTintColorProperty);
		}

		public static void SetThumbTintColor(BindableObject bindable, Color value)
		{
			bindable.SetValue(ThumbTintColorProperty, value);
		}

		#endregion

		#region ThumbOnTintColor

		public static readonly BindableProperty ThumbOnTintColorProperty =
            BindableProperty.CreateAttached(XFGlossPropertyNames.ThumbOnTintColor,
											typeof(Color), typeof(Xamarin.Forms.Switch), Color.Default);

		public static Color GetThumbOnTintColor(BindableObject bindable)
		{
			return (Color)bindable.GetValue(ThumbOnTintColorProperty);
		}

		public static void SetThumbOnTintColor(BindableObject bindable, Color value)
		{
			bindable.SetValue(ThumbOnTintColorProperty, value);
		}

		#endregion

		#region Interface implementation

		WeakReference<BindableObject> _bindable;

		public Switch(BindableObject bindable)
		{
			_bindable = new WeakReference<BindableObject>(bindable);
		}

		public BindableObject Bindable
		{
			get
			{
				BindableObject bindable;
				if (_bindable.TryGetTarget(out bindable))
				{
					return bindable;
				}

				return null;
			}
			set
			{
				_bindable.SetTarget(value);
			}
		}

		public Color TintColor
		{
			get
			{
				var bindable = Bindable;
				return (bindable == null) ? Color.Default : Switch.GetTintColor(bindable);
			}

			set
			{
				var bindable = Bindable;
				if (bindable != null)
				{
					Switch.SetTintColor(bindable, value);
				}
			}
		}

		public Color OnTintColor
		{
			get
			{
				var bindable = Bindable;
				return (bindable == null) ? Color.Default : Switch.GetOnTintColor(bindable);
			}

			set
			{
				var bindable = Bindable;
				if (bindable != null)
				{
					Switch.SetOnTintColor(bindable, value);
				}
			}
		}

		public Color ThumbTintColor
		{
			get
			{
				var bindable = Bindable;
				return (bindable == null) ? Color.Default : Switch.GetThumbTintColor(bindable);
			}

			set
			{
				var bindable = Bindable;
				if (bindable != null)
				{
					Switch.SetThumbTintColor(bindable, value);
				}
			}
		}

		public Color ThumbOnTintColor
		{
			get
			{
				var bindable = Bindable;
				return (bindable == null) ? Color.Default : Switch.GetThumbOnTintColor(bindable);
			}

			set
			{
				var bindable = Bindable;
				if (bindable != null)
				{
					Switch.SetThumbOnTintColor(bindable, value);
				}
			}
		}
		#endregion
	}
}