
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

        public Type Type { get; set; }
        public string Title { get; set; }
    }
}
