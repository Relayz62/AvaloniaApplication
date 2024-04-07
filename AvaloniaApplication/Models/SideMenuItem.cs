
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using System;

namespace AvaloniaApplication.Models
{
    public class SideMenuItem
    {
        public SideMenuItem(Type type)
        {
            Type = type;
            Title = type.Name.Replace("ViewModel", string.Empty);
        }

        public SideMenuItem(Type type, string title) : this(type)
        {
            Title = title;
        }

        public SideMenuItem(Type type, string title, string iconKey) : this(type, title)
        {
            Application.Current!.TryFindResource(iconKey, out var icon);
            Icon = (StreamGeometry)icon;
        }

        public Type Type { get; set; }
        public string Title { get; set; }

        public StreamGeometry Icon { get; set; }
    }
}
