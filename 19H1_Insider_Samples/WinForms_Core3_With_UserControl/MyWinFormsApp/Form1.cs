﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //MyUWPLib.MyColorPicker c = new MyUWPLib.MyColorPicker();
            //MyUWPLib.MyUserControl1 c = new MyUWPLib.MyUserControl1();

            //this.windowsXamlHost1.InitialTypeName = "Windows.UI.Xaml.Controls.TextBox";
            //this.windowsXamlHost1.InitialTypeName = "Windows.UI.Xaml.Controls.ColorPicker";
            //this.windowsXamlHost1.InitialTypeName = "MyUWPLib.MyColorPicker";
            this.windowsXamlHost1.InitialTypeName = "MyUWPLib.MainPage";
        }
    }
}
