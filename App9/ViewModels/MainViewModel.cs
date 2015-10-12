using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;

namespace App9.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public override void Start()
        {
            base.Start();
            //Simulate Load itemlist from database
            this.ItemList = new ObservableCollection<MainDescriptor>
            {
                new MainDescriptor { Description = "itemdesc1", Name="Item1" },
                new MainDescriptor { Description = "itemdesc2", Name="Item2" },
                new MainDescriptor { Description = "itemdesc3", Name="Item3" },
                new MainDescriptor { Description = "itemdesc4", Name="Item4" },
            };
        }

        private MvxCommand<MainDescriptor> _mainMessageCommand;
        public MvxCommand<MainDescriptor> MainMessageCommand
        {
            get
            {
                _mainMessageCommand = _mainMessageCommand ?? new MvxCommand<MainDescriptor>(async item =>
                {
                    var msg = new MessageDialog("Main Message");
                    await msg.ShowAsync();
                });
                return _mainMessageCommand;
            }
        }

        private MvxCommand<MainDescriptor> _messageCommand;
        public MvxCommand<MainDescriptor> MessageCommand
        {
            get
            {
                try
                {
                    _messageCommand = _messageCommand ?? new MvxCommand<MainDescriptor>(async item =>
                    {
                        var msg = new MessageDialog("Clicked " + item.Name);
                        await msg.ShowAsync();
                    });
                }
                catch (Exception)
                {
                    
                }
                return _messageCommand;
            }
        }

        public ObservableCollection<MainDescriptor> ItemList { get; set; }
    }

    class SampleMainViewModel : MainViewModel
    {
        public SampleMainViewModel()
        {
            //MvxDesignTimeHelperStatic.Initialize();
            this.ItemList = new ObservableCollection<MainDescriptor>
            {
                new MainDescriptor { Description = "sampleitemdesc1", Name="sampleItem1" },
                new MainDescriptor { Description = "sampleitemdesc2", Name="sampleItem2" },
            };
        }
    }

    public class MainDescriptor
    {
        public string Description { get; set; }
        public string Name { get; set; }

    }
}
