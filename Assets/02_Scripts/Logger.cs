

using System.Diagnostics;
using Debug = UnityEngine.Debug;

public static class Logger
{
    [Conditional("UNITY_EDITOR")]
    public static void Log(string msg)
    {
        Debug.Log($"<color=#ffff00>{msg}</color>");
    }
}
