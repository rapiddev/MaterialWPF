using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MaterialWPF.Controls
{
    public class ScheduleItem
    {
        public string Task { get; set; }
        public double Duration { get; set; }
        public string Notes { get; set; }
        public ScheduleItem[] SubItems { get; set; }
        public ScheduleItem()
        {
            SubItems = new ScheduleItem[0];
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

            DataContext = new ScheduleItem
            {
                SubItems = new ScheduleItem[]
                {
                    new ScheduleItem
                    {
                        Task = "Coding",
                        Duration = 4,
                        Notes = "It pays the bills",
                        SubItems = new ScheduleItem[]
                        {
                            new ScheduleItem { Task = "Write", Duration = 2, Notes = "C# or go home" },
                            new ScheduleItem { Task = "Compile", Duration = 1, Notes = "WTB: SSD" },
                            new ScheduleItem { Task = "Test", Duration = 1, Notes = "Works on my machine" },
                        },
                    },
                    new ScheduleItem
                    {
                        Task = "Meetings",
                        Duration = 2,
                        Notes = "A necessary evil",
                        SubItems = new ScheduleItem[]
                        {
                            new ScheduleItem { Task = "Boring", Duration = 1, Notes = "Zzzzzz" },
                            new ScheduleItem { Task = "Gossipy", Duration = 0.75, Notes = "Oh no he didn't!" },
                            new ScheduleItem { Task = "Useful", Duration = 0.25, Notes = "Right away, boss" },
                        },
                    },
                    new ScheduleItem
                    {
                        Task = "Communicate",
                        Duration = 1,
                        Notes = "No man is an island",
                        SubItems = new ScheduleItem[]
                        {
                            new ScheduleItem { Task = "Email", Duration = 0.5, Notes = "So much junk mail" },
                            new ScheduleItem { Task = "Blogs", Duration = 0.25, Notes = "blogs.msdn.com/delay" },
                            new ScheduleItem { Task = "Twitter", Duration = 0.25, Notes = "RT: Nothing to report" },
                        },
                    },
                    new ScheduleItem
                    {
                        Task = "Eating",
                        Duration = 1.5,
                        Notes = "Fuel for the body",
                        SubItems = new ScheduleItem[]
                        {
                            new ScheduleItem { Task = "Lunch", Duration = 1, Notes = "Bag lunch from home" },
                            new ScheduleItem
                            {
                                Task = "Snack",
                                Duration = 0.5,
                                Notes = "Still hungry",
                                SubItems = new ScheduleItem[]
                                {
                                    new ScheduleItem { Task = "Fruit", Duration = 0.25, Notes = "Good for you" },
                                    new ScheduleItem { Task = "Candy", Duration = 0.25, Notes = "Yummy!" },
                                },
                            },
                        },
                    },
                },
            };
        }
    }
}
