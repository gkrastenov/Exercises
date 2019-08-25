using AdventureApp.Adapters;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;

namespace AdventureApp
{
    public class Fragment_Profile : Android.Support.V4.App.Fragment
    {
        private TextView usernameText;

        private TabLayout tabLayout;
        private ViewPager viewPager;
      
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);          

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.fragment_profile, container, false);
            // Use this to return your custom view for this Fragment
            usernameText = view.FindViewById<TextView>(Resource.Id.nickname);
            usernameText.Text = "georgikrastenov";

            viewPager = view.FindViewById<ViewPager>(Resource.Id.viewpager);
            setupViewPager(viewPager);

            tabLayout = view.FindViewById<TabLayout>(Resource.Id.tabs_menu);
            tabLayout.SetupWithViewPager(viewPager);

            return view;

        }        
        public void setupViewPager(ViewPager viewPager)
        {
            InditialFragment();
            ViewPagerAdapter adapter = new ViewPagerAdapter(FragmentManager);
            adapter.addFragment(fragment1, "Explore");
            adapter.addFragment(fragment2, "Featured");

            viewPager.Adapter = adapter;
        }

        private TextFragment1 fragment1;
        private TextFragment2 fragment2;
        private TextFragment3 fragment3;
        private void InditialFragment()
        {
            fragment1 = new TextFragment1();
            fragment2 = new TextFragment2();
            fragment3 = new TextFragment3();
           
        }
    }
    
}