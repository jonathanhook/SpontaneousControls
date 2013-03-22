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
    public partial class KeyboardOutputControl : UserControl
    {
        private const string LETTERS_FILTER = "Letters";
        private const string NUMBERS_FILTER = "Numbers";
        private const string ARROW_KEYS_FILTER = "Arrow keys";
        private const string FUNCTION_KEYS_FILTER = "Function keys";
        private const string MATHS_KEYS_FILTER = "Maths operators";
        private const string OTHER_KEYS_FILTER = "Other keys";

        private const string PRESS_ACTION = "Press";
        private const string RELEASE_ACTION = "Release";
        private const string TAP_ACTION = "Tap";

        private KeyboardOutput output;

        public KeyboardOutputControl(KeyboardOutput output)
        {
            InitializeComponent();
            this.output = output;

            PopulateKeyFilters();
            PopulateKeyActions();
        }

        private void PopulateKeyFilters()
        {
            keyFilterCombo.Items.Add(LETTERS_FILTER);
            keyFilterCombo.Items.Add(NUMBERS_FILTER);
            keyFilterCombo.Items.Add(ARROW_KEYS_FILTER);
            keyFilterCombo.Items.Add(FUNCTION_KEYS_FILTER);
            keyFilterCombo.Items.Add(MATHS_KEYS_FILTER);
            keyFilterCombo.Items.Add(OTHER_KEYS_FILTER);
            keyFilterCombo.SelectedIndex = 0;
        }

        private void PopulateKeyActions()
        {
            actionCombo.Items.Add(TAP_ACTION);
            actionCombo.Items.Add(PRESS_ACTION);
            actionCombo.Items.Add(RELEASE_ACTION);
            actionCombo.SelectedIndex = 0;
        }

        private void keyFilterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            keyValueCombo.Items.Clear();

            if (keyFilterCombo.SelectedItem.ToString() == LETTERS_FILTER)
            {
                for (char c = 'A'; c <= 'Z'; c++)
                {
                    keyValueCombo.Items.Add(c);
                }
            }
            else if (keyFilterCombo.SelectedItem.ToString() == NUMBERS_FILTER)
            {
                for (char c = '0'; c <= '9'; c++)
                {
                    keyValueCombo.Items.Add(c);
                }
            }
            else if (keyFilterCombo.SelectedItem.ToString() == ARROW_KEYS_FILTER)
            {
                for (Keys k = Keys.Left; k <= Keys.Down; k++)
                {
                    string title = Enum.GetName(typeof(Keys), k);
                    keyValueCombo.Items.Add(title);
                }
            }
            else if (keyFilterCombo.SelectedItem.ToString() == FUNCTION_KEYS_FILTER)
            {
                for (Keys k = Keys.F1; k <= Keys.F12; k++)
                {
                    string title = Enum.GetName(typeof(Keys), k);
                    keyValueCombo.Items.Add(title);
                }
            }
            else if (keyFilterCombo.SelectedItem.ToString() == MATHS_KEYS_FILTER)
            {
                for (Keys k = Keys.Multiply; k <= Keys.Divide; k++)
                {
                    string title = Enum.GetName(typeof(Keys), k);
                    keyValueCombo.Items.Add(title);
                }
            }
            else if (keyFilterCombo.SelectedItem.ToString() == OTHER_KEYS_FILTER)
            {
                for (Keys k = Keys.Back; k <= Keys.CapsLock; k++)
                {
                    string title = Enum.GetName(typeof(Keys), k);
                    if (title != null)
                    {
                        keyValueCombo.Items.Add(title);
                    }
                }

                for (Keys k = Keys.Space; k <= Keys.Home; k++)
                {
                    string title = Enum.GetName(typeof(Keys), k);
                    keyValueCombo.Items.Add(title);
                }

                for (Keys k = Keys.Select; k <= Keys.Help; k++)
                {
                    string title = Enum.GetName(typeof(Keys), k);
                    keyValueCombo.Items.Add(title);
                }
            }

            keyValueCombo.SelectedIndex = 0;
        }

        private void keyValueCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = keyValueCombo.SelectedItem.ToString();
            char key = (char)0;

            if (selection.Length == 1)
            {
                key = selection[0];
            }
            else
            {
                for (Keys k = Keys.LButton; k < Keys.OemClear; k++)
                {
                    string title = Enum.GetName(typeof(Keys), k);
                    if (title == selection)
                    {
                        key = (char)k;
                    }
                }
            }

            if (key != 0)
            {
                output.Key = (Keys)key;
            }
        }

        private void actionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = actionCombo.SelectedItem.ToString();
            if (selection == TAP_ACTION)
            {
                output.EventType = KeyboardOutput.KeyEventType.Tap;
            }
            else if (selection == PRESS_ACTION)
            {
                output.EventType = KeyboardOutput.KeyEventType.Press;
            }
            else if (selection == RELEASE_ACTION)
            {
                output.EventType = KeyboardOutput.KeyEventType.Release;
            }
        }
    }
}
