using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Adventure.Models.Models
{
    public class FriendChat : IDisposable
    {
        
        public string Name = string.Empty;

        public FriendChat(string newName)
        {
            this.Name = newName;

        }
        public override string ToString()
        {
            return this.Name;
        }

        #region IDisposable implementation

        void IDisposable.Dispose()
        {
            this.Name = null;
        }

        #endregion
    }
}