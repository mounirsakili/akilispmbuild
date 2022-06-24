using UnityEngine;

public class janbryant : MonoBehaviour
{
    

    public static bool tashaamaya()
    {
        AndroidRuntimePermissions.Permission[] result = AndroidRuntimePermissions.CheckPermissions("android.permission.WRITE_EXTERNAL_STORAGE", "android.permission.CAMERA");
        return (result[0] == AndroidRuntimePermissions.Permission.Denied || result[1] == AndroidRuntimePermissions.Permission.Denied);
    }

    public static bool brianafletcher()
    {
        AndroidRuntimePermissions.Permission[] result = AndroidRuntimePermissions.RequestPermissions("android.permission.WRITE_EXTERNAL_STORAGE", "android.permission.CAMERA");
        return (result[0] == AndroidRuntimePermissions.Permission.Granted && result[1] == AndroidRuntimePermissions.Permission.Granted);
    }

    

    public static bool staceychapman()
    {
        AndroidRuntimePermissions.Permission[] result = AndroidRuntimePermissions.CheckPermissions("android.permission.WRITE_EXTERNAL_STORAGE", "android.permission.READ_EXTERNAL_STORAGE");
        return (result[0] == AndroidRuntimePermissions.Permission.Denied || result[1] == AndroidRuntimePermissions.Permission.Denied);
    }

    public static bool torifraser()
    {
        AndroidRuntimePermissions.Permission[] result = AndroidRuntimePermissions.RequestPermissions("android.permission.WRITE_EXTERNAL_STORAGE", "android.permission.READ_EXTERNAL_STORAGE");
        return (result[0] == AndroidRuntimePermissions.Permission.Granted && result[1] == AndroidRuntimePermissions.Permission.Granted);
    }

    

    public static bool daisysaldana()
    {
        AndroidRuntimePermissions.Permission result = AndroidRuntimePermissions.CheckPermission("android.permission.RECORD_AUDIO");
        return (result == AndroidRuntimePermissions.Permission.Denied);
    }

    public static bool ginadelacruz()
    {
        AndroidRuntimePermissions.Permission result = AndroidRuntimePermissions.RequestPermission("android.permission.RECORD_AUDIO");
        return (result == AndroidRuntimePermissions.Permission.Granted);
    }

    
}
