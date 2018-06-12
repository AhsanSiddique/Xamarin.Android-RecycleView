using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.Widget;
using XamarinRecycleView.Adapter;

namespace XamarinRecycleView
{
    [Activity(Label = "RecycleView", MainLauncher = true, Theme ="@style/Theme.AppCompat.Light.DarkActionBar")]
    public class MainActivity : Activity
    {
        RecyclerView mRecycleView;
        RecyclerView.LayoutManager mLayoutManager;
        PhotoAlbum mPhotoAlbum;
        PhotoAlbumAdapter mAdapter;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            mPhotoAlbum = new PhotoAlbum();
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            mRecycleView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            mLayoutManager = new LinearLayoutManager(this);
            mRecycleView.SetLayoutManager(mLayoutManager);
            mAdapter = new PhotoAlbumAdapter(mPhotoAlbum);
            mAdapter.ItemClick += MAdapter_ItemClick;
            mRecycleView.SetAdapter(mAdapter);
        }

        private void MAdapter_ItemClick(object sender, int e)
        {
            int photoNum = e + 1;
            Toast.MakeText(this, "This is photo number " + photoNum, ToastLength.Short).Show();
        }
    }
}

