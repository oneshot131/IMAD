using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ZodiacSigns
{
    public partial class TabbedPageSample : TabbedPage
    {
        public TabbedPageSample()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

            ToolbarItem current = (ToolbarItem)sender;
            if( current.Text == "Add")
            {
                current.Text = "Another";
                Navigation.PushAsync(new NewItemPage());
            }
            else if( current.Text == "Delete")
            {

            }
        }
    }
}
