﻿using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using Uno.UI.Controls;
using Uno.Extensions;
using Uno.UI.Extensions;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
	public partial class FlipView : Selector
	{
		private NativePagedView PagedView { get { return InternalItemsPanelRoot as NativePagedView; } }

		protected override void UpdateItems()
		{
			if (PagedView != null && PagedView.Adapter == null)
			{
				PagedView.Adapter = new FlipViewAdapter()
				{
					Owner = this
				};
				PagedView.AddOnPageChangeListener(new FlipViewPageChangeListener { Owner = this });
				//Set CurrentItem in case SelectedIndex has changed prior to FlipView becoming visible
				PagedView.CurrentItem = SelectedIndex;
			}
			PagedView?.Adapter.NotifyDataSetChanged();
			base.UpdateItems();
			RequestLayout();
		}

		partial void OnSelectedIndexChangedPartial(int oldValue, int newValue, bool animateChange)
		{
			var pager = PagedView;
			if (pager == null)
			{
				return;
			}
			if (newValue != pager.CurrentItem)
			{
				//Update PagedView state if necessary, to avoid an IllegalStateException
				UpdateItemsIfNeeded();

				pager.SetCurrentItem(newValue, smoothScroll: animateChange);
			}
		}

		private class FlipViewPageChangeListener : Android.Support.V4.View.ViewPager.SimpleOnPageChangeListener
		{
			private WeakReference<FlipView> _ownerReference;
			/// <summary>
			/// The FlipView which uses this listener. This property is backed by a weak reference.
			/// </summary>
			internal FlipView Owner
			{
				get { return _ownerReference?.GetTarget(); }
				set { _ownerReference = new WeakReference<FlipView>(value); }
			}
			public override void OnPageSelected(int position)
			{
				var owner = Owner;
				if (owner.SelectedIndex != position)
				{
					owner.SelectedIndex = position;
				}
			}
		}
	}
}