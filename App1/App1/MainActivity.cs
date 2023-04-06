using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.RecyclerView.Widget;

namespace App1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private EditText _inputEditText;
        private RecyclerView _recyclerView;
        private WordCountAdapter _adapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            _inputEditText = FindViewById<EditText>(Resource.Id.input_edit_text);
            _recyclerView = FindViewById<RecyclerView>(Resource.Id.recycler_view);

            _adapter = new WordCountAdapter();
            _recyclerView.SetAdapter(_adapter);
            _recyclerView.SetLayoutManager(new LinearLayoutManager(this));

            var button = FindViewById<Button>(Resource.Id.count_button);
            button.Click += (sender, e) =>
            {
                var input = _inputEditText.Text;
                var words = input.Split(' ');

                var wordCount = new Dictionary<string, int>();
                foreach (var word in words)
                {
                    if (wordCount.ContainsKey(word))
                    {
                        wordCount[word]++;
                    }
                    else
                    {
                        wordCount[word] = 1;
                    }
                }

                var items = wordCount.OrderBy(x => x.Value)
                                     .Select(x => new WordCountItem(x.Key, x.Value))
                                     .ToList();
                _adapter.SetItems(items);
            };
        }
    }
}