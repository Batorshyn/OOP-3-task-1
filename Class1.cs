using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public interface INotification
    {
        void Show(Label targetLabel, string message);
    }

    public class SuccessNotification : INotification
    {
        public void Show(Label targetLabel, string message)
        {
            targetLabel.ForeColor = Color.DarkGreen;
            targetLabel.BackColor = Color.LightGreen;
            targetLabel.Text = $"[Успіх]: {message}";
        }
    }

    public class ErrorNotification : INotification
    {
        public void Show(Label targetlabel, string message)
        {
            targetlabel.ForeColor = Color.DarkRed;
            targetlabel.BackColor = Color.MistyRose;
            targetlabel.Text = $"[Помилка]: {message}";
        }
    }

    public abstract class NotificationCreator
    {
        public abstract INotification CreateNotification();

        public void Display(Label targetLabel, string message)
        {
            INotification notification = CreateNotification();
            notification.Show(targetLabel, message);
        }
    }

    public class SuccessDialogCreator : NotificationCreator
    {
        public override INotification CreateNotification() => new SuccessNotification();
    }

    public class ErrorDialogCreator : NotificationCreator
    {
        public override INotification CreateNotification() => new ErrorNotification();
    }
}
