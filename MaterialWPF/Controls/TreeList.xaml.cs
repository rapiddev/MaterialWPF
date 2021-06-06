// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) David Anson
// Copyright (C) Leszek Pomianowski and MaterialWPF Contributors.
// All Rights Reserved.

using System.Windows.Controls;
namespace MaterialWPF.Controls
{
    public class TreeListItem
    {
        public string Task { get; set; }
        public double Duration { get; set; }
        public string Notes { get; set; }
        public TreeListItem[] SubItems { get; set; }
        public TreeListItem()
        {
            SubItems = new TreeListItem[0];
        }
    }
    /// <summary>
    /// Interaction logic for TreeList.xaml
    /// </summary>
    public partial class TreeList : UserControl
    {
        public TreeList()
        {
            InitializeComponent();

            DataContext = new TreeListItem
            {
                SubItems = new TreeListItem[]
                {
                    new TreeListItem
                    {
                        Task = "Coding",
                        Duration = 4,
                        Notes = "It pays the bills",
                        SubItems = new TreeListItem[]
                        {
                            new TreeListItem { Task = "Write", Duration = 2, Notes = "C# or go home" },
                            new TreeListItem { Task = "Compile", Duration = 1, Notes = "WTB: SSD" },
                            new TreeListItem { Task = "Test", Duration = 1, Notes = "Works on my machine" },
                        },
                    },
                    new TreeListItem
                    {
                        Task = "Meetings",
                        Duration = 2,
                        Notes = "A necessary evil",
                        SubItems = new TreeListItem[]
                        {
                            new TreeListItem { Task = "Boring", Duration = 1, Notes = "Zzzzzz" },
                            new TreeListItem { Task = "Gossipy", Duration = 0.75, Notes = "Oh no he didn't!" },
                            new TreeListItem { Task = "Useful", Duration = 0.25, Notes = "Right away, boss" },
                        },
                    },
                    new TreeListItem
                    {
                        Task = "Communicate",
                        Duration = 1,
                        Notes = "No man is an island",
                        SubItems = new TreeListItem[]
                        {
                            new TreeListItem { Task = "Email", Duration = 0.5, Notes = "So much junk mail" },
                            new TreeListItem { Task = "Blogs", Duration = 0.25, Notes = "blogs.msdn.com/delay" },
                            new TreeListItem { Task = "Twitter", Duration = 0.25, Notes = "RT: Nothing to report" },
                        },
                    },
                    new TreeListItem
                    {
                        Task = "Eating",
                        Duration = 1.5,
                        Notes = "Fuel for the body",
                        SubItems = new TreeListItem[]
                        {
                            new TreeListItem { Task = "Lunch", Duration = 1, Notes = "Bag lunch from home" },
                            new TreeListItem
                            {
                                Task = "Snack",
                                Duration = 0.5,
                                Notes = "Still hungry",
                                SubItems = new TreeListItem[]
                                {
                                    new TreeListItem { Task = "Fruit", Duration = 0.25, Notes = "Good for you" },
                                    new TreeListItem { Task = "Candy", Duration = 0.25, Notes = "Yummy!" },
                                },
                            },
                        },
                    },
                },
            };
        }
    }
}
