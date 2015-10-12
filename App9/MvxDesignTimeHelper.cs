using Cirrious.CrossCore;
using Cirrious.CrossCore.Core;
using Cirrious.CrossCore.IoC;
using Cirrious.CrossCore.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App9
{
    public class MvxDesignTimeHelper
    {
        public MvxDesignTimeHelper()
        {
            if (!Windows.ApplicationModel.DesignMode.DesignModeEnabled)
                return;
            var iocProvider = MvxSimpleIoCContainer.Initialize();
            Mvx.RegisterSingleton(iocProvider);
        }

    }

    public static class MvxDesignTimeHelperStatic
    {
        public static void Initialize()
        {
            if (!Windows.ApplicationModel.DesignMode.DesignModeEnabled)
                return;
            var iocProvider = MvxSimpleIoCContainer.Initialize();
            Mvx.RegisterSingleton(iocProvider);
        }

    }
}
