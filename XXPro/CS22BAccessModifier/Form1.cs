using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS22BAccessModifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BPub b = new BPub();
            BInternal bInternal = new BInternal();

            b.GetPublic();　//どこからでも
            b.GetInternal();　//同じアセンブリ内
            b.GetInternalProtected();
        }
    }
}
