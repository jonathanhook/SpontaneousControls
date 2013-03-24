using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SpontaneousControls.Engine.Outputs.Discrete;

namespace SpontaneousControls.UI.Outputs.Discrete
{
    public partial class WebBrowserOutputControl : UserControl
    {
        private const string BACK = "Back";
        private const string FORWARD = "Forward";
        private const string REFRESH = "Refresh";
        private const string STOP = "Stop";
        private const string SEARCH = "Search";
        private const string FAVORITES = "Favorites";
        private const string HOME = "Home";

        private WebBrowserOutput output;

        public WebBrowserOutputControl(WebBrowserOutput output)
        {
            InitializeComponent();
            this.output = output;

            PopulateActionList();
        }

        private void PopulateActionList()
        {
            actionCombo.Items.Add(BACK);
            actionCombo.Items.Add(FORWARD);
            actionCombo.Items.Add(REFRESH);
            actionCombo.Items.Add(STOP);
            actionCombo.Items.Add(SEARCH);
            actionCombo.Items.Add(FAVORITES);
            actionCombo.Items.Add(HOME);
            actionCombo.SelectedIndex = 0;
        }

        private void actionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = actionCombo.SelectedItem.ToString();
            if (selection == BACK)
            {
                output.EventType = WebBrowserOutput.WebBrowserEventType.BrowserBack;
            }
            else if (selection == FORWARD)
            {
                output.EventType = WebBrowserOutput.WebBrowserEventType.BrowserForward;
            }
            else if (selection == REFRESH)
            {
                output.EventType = WebBrowserOutput.WebBrowserEventType.BrowserRefresh;
            }
            else if (selection == STOP)
            {
                output.EventType = WebBrowserOutput.WebBrowserEventType.BrowserStop;
            }
            else if (selection == SEARCH)
            {
                output.EventType = WebBrowserOutput.WebBrowserEventType.BrowserSearch;
            }
            else if (selection == FAVORITES)
            {
                output.EventType = WebBrowserOutput.WebBrowserEventType.BrowserFavorites;
            }
            else if (selection == HOME)
            {
                output.EventType = WebBrowserOutput.WebBrowserEventType.BrowserHome;
            }
        }
    }
}
