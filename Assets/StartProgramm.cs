using Firebase.Storage;
using Unity.Notifications.Android;
using UnityEngine;

public class StartProgramm : MonoBehaviour
{
    void Start()
    {
        FirebaseStorage storage = FirebaseStorage.DefaultInstance;

        var channel = new AndroidNotificationChannel()
        {
            Id = "channel_id",
            Name = "Default Channel",
            Importance = Importance.Default,
            Description = "Generic notifications",
        };
        AndroidNotificationCenter.RegisterNotificationChannel(channel);

        var notification = new AndroidNotification();
        notification.Title = "Your Title";
        notification.Text = "Your Text";
        notification.FireTime = System.DateTime.Now.AddMinutes(1);

        AndroidNotificationCenter.SendNotification(notification, "channel_id");
    }
}
