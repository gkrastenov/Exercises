using AdventureApp.Adapters;
using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;
using System.Drawing;

namespace AdventureApp
{
    public class Fragment_Profile : Android.Support.V4.App.Fragment
    {
        private TextView usernameText;

        private TabLayout tabLayout;
        private ViewPager viewPager;
        private Button friendsButton;

        private string username;
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);          
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.fragment_profile, container, false);   
            // Use this to return your custom view for this Fragment
            usernameText = view.FindViewById<TextView>(Resource.Id.nickname);
            usernameText.Text = username;

            viewPager = view.FindViewById<ViewPager>(Resource.Id.viewpager);
            setupViewPager(viewPager);

            tabLayout = view.FindViewById<TabLayout>(Resource.Id.tabs_menu);
            tabLayout.SetupWithViewPager(viewPager);

            friendsButton = view.FindViewById<Button>(Resource.Id.btn_showFriends);
            friendsButton.Text = ConvertBtnFriendsText();
            friendsButton.Click += FriendsButton_Click;

            return view;
        }
        public void SetName(string name)
        {
            username = name;
        }
        private void FriendsButton_Click(object sender, System.EventArgs e)
        {
            FriendsActivity friendsActivity = new FriendsActivity();
            // maybe have to dispose fragment ???
        }

        public void setupViewPager(ViewPager viewPager)
        {
            InitialFragmentFragment();
            ProfileViewPager adapter = new ProfileViewPager(FragmentManager);
            adapter.addFragment(fragment_posts, "Posts");
            adapter.addFragment(fragment_likedPosts, "Liked");

            viewPager.Adapter = adapter;
        }

        private Fragment_PostsOfUser fragment_posts;
        private Fragment_LikedPostOnUser fragment_likedPosts;

        private void InitialFragmentFragment()
        {
            fragment_posts = new Fragment_PostsOfUser();
            fragment_likedPosts = new Fragment_LikedPostOnUser();  
        }

        private string ConvertBtnFriendsText()
        {
            string text = "0 friends";

            // add logic for firends more 1000 , 10000, 100000, 1mln

            return text;
        }
    }
    
}