using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Friends_from_MegaVideo_player
{
    public partial class XML_Viewer : Form
    {
        public XML_Viewer()
        {
            InitializeComponent();
            Uri path = new Uri(Friends_from_MegaVideo_player.Properties.Settings.Default.FilePath);
            webBrowser1.Url = path;
        }
        
    }
}
