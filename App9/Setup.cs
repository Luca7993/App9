using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.WindowsUWP.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace App9
{
    public class Setup : MvxWindowsSetup
    {
        public Setup(Frame rootFrame) : base(rootFrame)
        {
        }
        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();
        }

        protected override IMvxApplication CreateApp()
        {
            return new MyApp();
        }

        protected override Cirrious.CrossCore.Plugins.IMvxPluginManager InitializePluginFramework()
        {
            return base.InitializePluginFramework();
        }

        public override void LoadPlugins(Cirrious.CrossCore.Plugins.IMvxPluginManager pluginManager)
        {
            base.LoadPlugins(pluginManager);
        }
    }
}
