using UnityEngine;
using System.IO;

public static class ScreenShotManager
{
    public static void Capture(string fileName = "screenshot.png")
    {
        string folderPath = Path.Combine(Application.persistentDataPath, "Screenshots");

        if (!Directory.Exists(folderPath))
            Directory.CreateDirectory(folderPath);

        string fullPath = Path.Combine(folderPath, fileName);

        ScreenCapture.CaptureScreenshot(fullPath);
        Debug.Log($"📸 Screenshot saved to: {fullPath}");
    }
}
