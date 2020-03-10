using System;
using System.Collections.Generic;
using System.Text;

namespace ElectionMobileApp.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Register,
        Landing,
        Search
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
