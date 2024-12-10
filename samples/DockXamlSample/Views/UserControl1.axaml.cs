using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using DockXamlSample.ViewModels;

namespace DockXamlSample.Views;

public partial class UserControl1 : UserControl
{
    public UserControl1()
    {
        AvaloniaXamlLoader.Load(this);
    }
}
