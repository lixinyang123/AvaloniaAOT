using Avalonia.Controls;
using Avalonia.Controls.Templates;
using AvaloniaAOT.ViewModels;
using System;

namespace AvaloniaAOT
{
    public class ViewLocator : IDataTemplate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Trimming", "IL2057")]
        public IControl Build(object? data)
        {
            string name = data?.GetType().FullName!.Replace("ViewModel", "View") ?? string.Empty;
            Type? type = Type.GetType(name);

            return type != null ? (Control)Activator.CreateInstance(type)! : (IControl)new TextBlock { Text = "Not Found: " + name };
        }

        public bool Match(object? data)
        {
            return data is ViewModelBase;
        }
    }
}
