package crc64a7a6b04b89628087;


public class WordCountViewHolder
	extends androidx.recyclerview.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("App1.WordCountViewHolder, App1", WordCountViewHolder.class, __md_methods);
	}


	public WordCountViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == WordCountViewHolder.class)
			mono.android.TypeManager.Activate ("App1.WordCountViewHolder, App1", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
