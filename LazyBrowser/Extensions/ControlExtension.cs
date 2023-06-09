﻿using System.Windows.Forms;
using System;

namespace LazyBrowser.Extensions
{   
    public static class ControlExtension
    {
        public static void InvokeOnUiThreadIfRequired(this Control control, Action action)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(action);
            }
            else
            {
                action();
            }
        }
    }

}
