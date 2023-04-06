using System.Collections.Generic;
using Android;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;

namespace App1
{
    public class WordCountAdapter : RecyclerView.Adapter
    {
        private List<WordCountItem> _items = new List<WordCountItem>();

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.word_count_item, parent, false);
            return new WordCountViewHolder(view);
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            var viewHolder = holder as WordCountViewHolder;
            var item = _items[position];
            viewHolder.WordTextView.Text = item.Word;
            viewHolder.CountTextView.Text = item.Count.ToString();
        }

        public override int ItemCount => _items.Count;

        public void SetItems(List<WordCountItem> items)
        {
            _items = items;
            NotifyDataSetChanged();
        }
    }

    public class WordCountViewHolder : RecyclerView.ViewHolder
    {
        public TextView WordTextView { get; }
        public TextView CountTextView { get; }

        public WordCountViewHolder(View itemView) : base(itemView)
        {
            WordTextView = itemView.FindViewById<TextView>(Resource.Id.word_text_view);
            CountTextView = itemView.FindViewById<TextView>(Resource.Id.count_text_view);
        }
    }

    public class WordCountItem
    {
        public string Word { get; }
        public int Count { get; }

        public WordCountItem(string word, int count)
        {
            Word = word;
            Count = count;
        }
    }
}