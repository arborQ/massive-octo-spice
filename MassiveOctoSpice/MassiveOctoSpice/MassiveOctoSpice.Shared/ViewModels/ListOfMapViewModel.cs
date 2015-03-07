using MassiveOctoSpice.Common;
using MassiveOctoSpice.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace MassiveOctoSpice.ViewModels
{
    public class ListOfMapViewModel
    {
        public ListOfMapViewModel()
        {
            Load = new Command(a => {
                Items = new ObservableCollection<MapEntry>(
                    new MapEntry[] {
                        new MapEntry { Name = "dsadsad" },
                        new MapEntry { Name = "dsadsad2" },
                        new MapEntry { Name = "dsadsad3" },
                        new MapEntry { Name = "dsadsad4" },
                    }
                    );
            });
        }

        public IEnumerable<MapEntry> Items { get; set; }

        public ICommand Load { get; set; }
    }
}
