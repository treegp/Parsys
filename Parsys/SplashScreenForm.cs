﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parsys
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            
            InitializeComponent();
        }

        private void SplashScreenForm_Load(object sender, EventArgs e)
        {
            SplashScreenProgressBar.MarqueeAnimationSpeed = 25;
            
        }
    }
}
