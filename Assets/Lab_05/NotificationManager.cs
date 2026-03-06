using UnityEngine;
using UnityEngine.Android;
//using Unity.Notifications.Android;
//#endif


public class NotificationManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetupChannel();
        //RequestPermissions();
    }

    // Update is called once per frame
    public void SetupChannel()
    {

    }
}

   /* #if UNITY_ANDROID
        var channel = new AndroidNotificationChannel()
        {
        Id = "channel_id"
        }
    
}
   */