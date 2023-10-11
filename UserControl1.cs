using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADOTpEFM
{
    public partial class NomDate : UserControl
    {
        public NomDate()
        {
            InitializeComponent();
        }
        public string nom 
        {
            get { return Tnom.Text; }
            set { Tnom.Text = value; }
        }
        public DateTime dateN 
        {
            get { return datePi.Value; }
            set { datePi.Value = value; }
        }

    }
}
