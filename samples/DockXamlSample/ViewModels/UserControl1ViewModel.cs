using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia.Collections;
using CommunityToolkit.Mvvm.ComponentModel;

namespace DockXamlSample.ViewModels;

public partial class UserControl1ViewModel : ObservableObject
{
    //// AvaloniaList
    /// ObservableCollection
    [ObservableProperty]
    private AvaloniaList<UserControlItemViewModel> tableData;

    public UserControl1ViewModel()
    {
        this.TableData =
        [
            new UserControlItemViewModel() { DisplayText = "title1", Value = "value1" },
            new UserControlItemViewModel() { DisplayText = "title2", Value = "value2" },
            new UserControlItemViewModel() { DisplayText = "title2", Value = "value3" },
        ];
    }
}

public partial class UserControlItemViewModel : ObservableObject
{
    [ObservableProperty]
    public string displayText;

    [ObservableProperty]
    public string value;
}
