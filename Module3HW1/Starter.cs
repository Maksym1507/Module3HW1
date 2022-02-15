using System;
using Module3HW1.Interfaces;

namespace Module3HW1
{
    public class Starter
    {
        public Starter(INotificationService message, IMyImplementedList<int> list)
        {
            Message = message;
            List = list;
        }

        private INotificationService Message { get; }

        private IMyImplementedList<int> List { get; }

        public void Run()
        {
            Message.ShowMessage($"List capacity = {List.Capacity}\n");
            Message.ShowMessage($"Count elements in list = {List.Count}\n");

            List.Add(5);
            List.AddRange(new int[] { 1, 67, 9, 93 });

            Message.ShowMessage($"List capacity = {List.Capacity}\n");
            Message.ShowMessage($"Count elements in list = {List.Count}\n");

            Message.ShowMessage($"Output list:\n");

            foreach (var item in List)
            {
                Message.ShowMessage(item + " ");
            }

            Message.ShowMessage("\n");

            List.Add(49);

            try
            {
                List.RemoveAt(2);
                List.RemoveAt(10);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Message.ShowMessage($"Failed to remove list item: {ex.Message}\n");
            }

            List.Remove(67);
            List.Remove(9);

            Message.ShowMessage($"Output list:\n");

            foreach (var item in List)
            {
                Message.ShowMessage(item + " ");
            }

            Message.ShowMessage("\n");

            Message.ShowMessage($"List capacity = {List.Capacity}\n");
            Message.ShowMessage($"Count elements in list = {List.Count}\n");

            List.AddRange(new int[] { 31, 107, 3, -53 });

            Message.ShowMessage($"Output list before sorting:\n");

            foreach (var item in List)
            {
                Message.ShowMessage(item + " ");
            }

            Message.ShowMessage("\n");

            List.Sort();

            Message.ShowMessage($"Output sorted list:\n");

            foreach (var item in List)
            {
                Message.ShowMessage(item + " ");
            }
        }
    }
}
