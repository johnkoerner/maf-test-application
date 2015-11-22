using System;
using System.AddIn.Hosting;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

using System.IO;
using Contracts.HostViews;

namespace HostApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Contracts.HostViews.ISpeaker> speakers;
        public MainWindow()
        {
            InitializeComponent();

            var currentDireory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var addinsFolder = Path.Combine(currentDireory, "Addins");
            AddInStore.Update(PipelineStoreLocation.ApplicationBase);
            AddInStore.RebuildAddIns(addinsFolder);

            speakers = new List<ISpeaker>();
            var addins = AddInStore.FindAddIns(typeof(Contracts.HostViews.ISpeaker), PipelineStoreLocation.ApplicationBase);
            foreach (var addin in addins)
            {
                AddInProcess addinProcess = new AddInProcess();
                var speaker = addin.Activate<ISpeaker>(addinProcess, AddInSecurityLevel.FullTrust);
                speakers.Add(speaker);
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            foreach (var speaker in speakers)
            {
                speaker.Say(SayWhat.Hello);
            }
        }
    }
}
