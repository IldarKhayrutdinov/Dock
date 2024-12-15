﻿using System.Runtime.Serialization;
using Dock.Model.Adapters;
using Dock.Model.Controls;
using Dock.Model.Core;
using ReactiveUI;

namespace Dock.Model.ReactiveUI.Core;

/// <summary>
/// Dock window.
/// </summary>
[DataContract(IsReference = true)]
public partial class DockWindow : ReactiveObject, IDockWindow
{
    private readonly IHostAdapter _hostAdapter;

    /// <summary>
    /// Initializes new instance of the <see cref="DockWindow"/> class.
    /// </summary>
    public DockWindow()
    {
        _id = nameof(IDockWindow);
        _title = nameof(IDockWindow);
        _hostAdapter = new HostAdapter(this);
    }

    /// <inheritdoc/>
    [DataMember(IsRequired = false, EmitDefaultValue = true)]
    [Reactive]
    public partial string Id { get; set; }

    /// <inheritdoc/>
    [DataMember(IsRequired = true, EmitDefaultValue = true)]
    [Reactive]
    public partial double X { get; set; }

    /// <inheritdoc/>
    [DataMember(IsRequired = true, EmitDefaultValue = true)]
    [Reactive]
    public partial double Y { get; set; }

    /// <inheritdoc/>
    [DataMember(IsRequired = true, EmitDefaultValue = true)]
    [Reactive]
    public partial double Width { get; set; }

    /// <inheritdoc/>
    [DataMember(IsRequired = true, EmitDefaultValue = true)]
    [Reactive]
    public partial double Height { get; set; }

    /// <inheritdoc/>
    [DataMember(IsRequired = false, EmitDefaultValue = true)]
    [Reactive]
    public partial bool Topmost { get; set; }

    /// <inheritdoc/>
    [DataMember(IsRequired = false, EmitDefaultValue = true)]
    [Reactive]
    public partial string Title { get; set; }

    /// <inheritdoc/>
    [IgnoreDataMember]
    [Reactive]
    public partial IDockable? Owner { get; set; }

    /// <inheritdoc/>
    [IgnoreDataMember]
    [Reactive]
    public partial IFactory? Factory { get; set; }

    /// <inheritdoc/>
    [DataMember(IsRequired = false, EmitDefaultValue = true)]
    [Reactive]
    public partial IRootDock? Layout { get; set; }

    /// <inheritdoc/>
    [IgnoreDataMember]
    [Reactive]
    public partial IHostWindow? Host { get; set; }

    /// <inheritdoc/>
    public virtual bool OnClose()
    {
        return true;
    }

    /// <inheritdoc/>
    public virtual bool OnMoveDragBegin()
    {
        return true;
    }

    /// <inheritdoc/>
    public virtual void OnMoveDrag()
    {
    }

    /// <inheritdoc/>
    public virtual void OnMoveDragEnd()
    {
    }

    /// <inheritdoc/>
    public void Save()
    {
        _hostAdapter.Save();
    }

    /// <inheritdoc/>
    public void Present(bool isDialog)
    {
        _hostAdapter.Present(isDialog);
    }

    /// <inheritdoc/>
    public void Exit()
    {
        _hostAdapter.Exit();
    }
}
