using System;
using Module3HW1.Interfaces;

namespace Module3HW1
{
    public class Starter
    {
        private readonly INotificationService _message;

        private readonly IMyImplementedList<int> _list;

        public Starter(INotificationService message, IMyImplementedList<int> list)
        {
            _message = message;
            _list = list;
        }

        public void Run()
        {
            _message.ShowMessage($"List capacity = {_list.Capacity}\n");
            _message.ShowMessage($"Count elements in list = {_list.Count}\n");

            _list.Add(5);
            _list.AddRange(new int[] { 1, 67, 9, 93 });

            _message.ShowMessage($"List capacity = {_list.Capacity}\n");
            _message.ShowMessage($"Count elements in list = {_list.Count}\n");

            _message.ShowMessage($"Output list:\n");

            foreach (var item in _list)
            {
                _message.ShowMessage(item + " ");
            }

            _message.ShowMessage("\n");

            _list.Add(49);

            try
            {
                _list.RemoveAt(2);
                _list.RemoveAt(10);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                _message.ShowMessage($"Failed to remove list item: {ex.Message}\n");
            }

            _list.Remove(67);
            _list.Remove(9);

            _message.ShowMessage($"Output list:\n");

            foreach (var item in _list)
            {
                _message.ShowMessage(item + " ");
            }

            _message.ShowMessage("\n");

            _message.ShowMessage($"List capacity = {_list.Capacity}\n");
            _message.ShowMessage($"Count elements in list = {_list.Count}\n");

            _list.AddRange(new int[] { 31, 107, 3, -53 });

            _message.ShowMessage($"Output list before sorting:\n");

            foreach (var item in _list)
            {
                _message.ShowMessage(item + " ");
            }

            _message.ShowMessage("\n");

            _list.Sort();

            _message.ShowMessage($"Output sorted list:\n");

            foreach (var item in _list)
            {
                _message.ShowMessage(item + " ");
            }
        }
    }
}
