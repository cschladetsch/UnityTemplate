﻿namespace UIWidgets
{
	using System;

	/// <summary>
	/// ListViewString.
	/// </summary>
	public class ListViewString : ListViewCustom<ListViewStringItemComponent, string>
	{
		[NonSerialized]
		bool isListViewStringInited = false;

		/// <summary>
		/// Items comparison.
		/// </summary>
		public readonly Comparison<string> ItemsComparison = (x, y) => x.CompareTo(y);

		/// <summary>
		/// Init this instance.
		/// </summary>
		public override void Init()
		{
			if (isListViewStringInited)
			{
				return;
			}

			isListViewStringInited = true;

			base.Init();

			DataSource.Comparison = ItemsComparison;
		}
	}
}