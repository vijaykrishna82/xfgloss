﻿using System;
using Android.Content;
using Android.Support.V4.Content;
using Android.Util;

namespace XFGloss.Droid.Utils
{
	public static class ThemeUtil
	{
		static TypedValue typedVal;

		public static int DpToPx(Context context, int dp)
		{
			return (int)(TypedValue.ApplyDimension(ComplexUnitType.Dip, dp, context.Resources.DisplayMetrics) + 0.5f);
		}

		public static int SpToPx(Context context, int sp)
		{
			return (int)(TypedValue.ApplyDimension(ComplexUnitType.Sp, sp, context.Resources.DisplayMetrics) + 0.5f);
		}

		public static int ColorFromResourceId(Context context, int resourceId, int defaultValue)
		{
			int result = defaultValue;

			if (typedVal == null)
			{
				typedVal = new TypedValue();
			}

			try
			{
				Android.Content.Res.Resources.Theme theme = context.Theme;
				if (theme != null && theme.ResolveAttribute(resourceId, typedVal, true))
				{
					if (typedVal.Type >= DataType.FirstInt && typedVal.Type <= DataType.LastInt)
					{
						result = typedVal.Data;
					}
					else if (typedVal.Type == DataType.String)
					{
						result = ContextCompat.GetColor(context, typedVal.ResourceId);
					}
				}
			}
			#pragma warning disable RECS0022 // A catch clause that catches System.Exception and has an empty body
			catch (Exception) { }
			#pragma warning restore RECS0022 // A catch clause that catches System.Exception and has an empty body

			return result;
		}

		public static int WindowBackground(Context context, int defaultValue)
		{
			return ColorFromResourceId(context, Android.Resource.Attribute.WindowBackground, defaultValue);
		}

		public static int TextColorPrimary(Context context, int defaultValue)
		{
			return ColorFromResourceId(context, Android.Resource.Attribute.TextColorPrimary, defaultValue);
		}

		public static int TextColorSecondary(Context context, int defaultValue)
		{
			return ColorFromResourceId(context, Android.Resource.Attribute.TextColorSecondary, defaultValue);
		}

		public static int ColorPrimary(Context context, int defaultValue)
		{
			return ColorFromResourceId(context, Android.Resource.Attribute.ColorPrimary, defaultValue);
		}

		public static int ColorPrimaryDark(Context context, int defaultValue)
		{
			return ColorFromResourceId(context, Android.Resource.Attribute.ColorPrimaryDark, defaultValue);
		}

		public static int ColorAccent(Context context, int defaultValue)
		{
			return ColorFromResourceId(context, Android.Resource.Attribute.ColorAccent, defaultValue);
		}

		public static int ColorControlNormal(Context context, int defaultValue)
		{
			return ColorFromResourceId(context, Android.Resource.Attribute.ColorControlNormal, defaultValue);
		}

		public static int ColorControlActivated(Context context, int defaultValue)
		{
			return ColorFromResourceId(context, Android.Resource.Attribute.ColorControlActivated, defaultValue);
		}

		public static int ColorControlHighlight(Context context, int defaultValue)
		{
			return ColorFromResourceId(context, Android.Resource.Attribute.ColorControlHighlight, defaultValue);
		}

		public static int ColorButtonNormal(Context context, int defaultValue)
		{
			return ColorFromResourceId(context, Android.Resource.Attribute.ColorButtonNormal, defaultValue);
		}
	}
}