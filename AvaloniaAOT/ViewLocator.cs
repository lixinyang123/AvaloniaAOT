using Avalonia.Controls;
using Avalonia.Controls.Templates;
using AvaloniaAOT.ViewModels;
using System;

namespace AvaloniaAOT
{
    public class ViewLocator : IDataTemplate
    {
        public Control Build(object? data)
        {
            string? name = data?.GetType().FullName!.Replace("ViewModel", "View");

            // Unrecognized value passed to the parameter of method. It's not possible to guarantee the availability of the target type.
            #pragma warning disable IL2057
            Type? type = Type.GetType(name ?? string.Empty);
            #pragma warning restore IL2057

            if (type != null)
            {
                return (Control)Activator.CreateInstance(type)!;
            }
            else
            {
                return new TextBlock { Text = "Not Found: " + name };
            }
        }

        public bool Match(object? data)
        {
            return data is ViewModelBase;
        }
    }
}
