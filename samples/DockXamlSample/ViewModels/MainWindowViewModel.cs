using System.Diagnostics;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Dock.Model.Controls;
using Dock.Model.Core;

namespace DockXamlSample.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
    public MainWindowViewModel()
    {
        this.UserControl1Data = new();
    }

    [ObservableProperty]
    private UserControl1ViewModel userControl1Data;
}
