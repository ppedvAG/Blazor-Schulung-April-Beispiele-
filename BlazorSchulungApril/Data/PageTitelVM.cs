using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BlazorSchulungApril.Data
{
    public class PageTitelVM
    {
        private string _title;

        public string Titel
        {
            get { return _title; }
            set { _title = value;
                UpdateUI?.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler UpdateUI;


    }
}
