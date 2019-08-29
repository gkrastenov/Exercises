using System;
using System.Collections.Generic;
using Adventure.Models.Models;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AdventureApp.Adapters
{
    public class Adapter_FriendChat : BaseAdapter<FriendChat>
    {
        private List<FriendChat> allFriendChat = new List<FriendChat>();

        Activity context;

        public override int Count => allFriendChat.Count;

        public Adapter_FriendChat(Activity context)
        {
            this.context = context;
            allFriendChat.Add(new FriendChat("TestName1"));
            allFriendChat.Add(new FriendChat("TestName2"));

        }


        public override Java.Lang.Object GetItem(int position)
        {
            return position;
        }

        public override long GetItemId(int position)
        {
            return position;
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = allFriendChat[position];
            View view = convertView;
            if (view == null)
            {
                //We must create a View:
                view = this.context.LayoutInflater.Inflate(Resource.Layout.custom_friendChat, null);
            }
            string friendName = item.Name;

            TextView textName = view.FindViewById<TextView>(Resource.Id.txt_friendName);
            textName.Text = friendName;

            return view;
        }

        public override FriendChat this[int position] => throw new NotImplementedException();

        //Fill in cound here, currently 0
        /*public override int Count
        {
            get
            {
                return 0;
            }
        }
 
    }

    class Adapter_FriendChatViewHolder : Java.Lang.Object
    {
        //Your adapter views to re-use
        //public TextView Title { get; set; }
    }*/
    }
}