using Adapter;

INotificationSender notificationSender = new SmsSenderAdapter();

notificationSender.SendNotification(1, new Notification() { Title = "text", Body = "body"});
