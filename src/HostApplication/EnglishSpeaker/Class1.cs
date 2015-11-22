using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts.AddInViews;
using System.Windows.Forms;

namespace EnglishSpeaker
{
    [System.AddIn.AddIn("English Speaker")]
    public class Class1 : Contracts.AddInViews.ISpeaker
    {
        public string Say(SayWhat what)
        {
            MessageBox.Show(what.ToString());
            return what.ToString();
        }
    }
}
