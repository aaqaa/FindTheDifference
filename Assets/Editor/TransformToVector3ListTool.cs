using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System.Text;

public class TransformToVector3ListTool : EditorWindow
{
    private float yOffset = 4.1f; // Adjustable Y offset

    [MenuItem("Tools/Copy Transform Data for Level")]
    public static void ShowWindow()
    {
        GetWindow<TransformToVector3ListTool>("Transform To Vector3 Lists");
    }

    private void OnGUI()
    {
        GUILayout.Label("Difference Position Export Tool", EditorStyles.boldLabel);

        yOffset = EditorGUILayout.FloatField("Y Offset for diffPos2", yOffset);

        if (GUILayout.Button("Generate Vector3 Lists from Selection"))
        {
            GenerateVector3Lists();
        }
    }

    private void GenerateVector3Lists()
    {
        GameObject[] selected = Selection.gameObjects;

        if (selected.Length == 0)
        {
            EditorUtility.DisplayDialog("Invalid Selection", "Please select at least one GameObject.", "OK");
            return;
        }

        // Store transforms
        List<Transform> transforms = new List<Transform>();
        foreach (GameObject go in selected)
            transforms.Add(go.transform);

        // Optional: sort by position Y (top-to-bottom)
        transforms.Sort((a, b) => b.position.y.CompareTo(a.position.y));

        StringBuilder sb = new StringBuilder();

        // diffPos1
        sb.AppendLine("levelData.diffPos1 = new List<Vector3>");
        sb.AppendLine("{");
        for (int i = 0; i < transforms.Count; i++)
        {
            Vector3 pos = transforms[i].position;
            sb.Append($"    new Vector3({pos.x:F2}f, {pos.y:F2}f, {pos.z:F2}f)");
            if (i < transforms.Count - 1) sb.Append(",");
            sb.AppendLine();
        }
        sb.AppendLine("};");

        // diffPos2
        sb.AppendLine("levelData.diffPos2 = new List<Vector3>");
        sb.AppendLine("{");
        for (int i = 0; i < transforms.Count; i++)
        {
            Vector3 pos = transforms[i].position;
            sb.Append($"    new Vector3({pos.x:F2}f, {pos.y - yOffset:F2}f, {pos.z:F2}f)");
            if (i < transforms.Count - 1) sb.Append(",");
            sb.AppendLine();
        }
        sb.AppendLine("};");

        // diffScale
        sb.AppendLine("levelData.diffScale = new List<Vector3>");
        sb.AppendLine("{");
        for (int i = 0; i < transforms.Count; i++)
        {
            Vector3 scale = transforms[i].localScale;
            sb.Append($"    new Vector3({scale.x:F2}f, {scale.y:F2}f, {scale.z:F2}f)");
            if (i < transforms.Count - 1) sb.Append(",");
            sb.AppendLine();
        }
        sb.AppendLine("};");

        // numberOfDiff
        sb.AppendLine($"levelData.numberOfDiff = {transforms.Count};");

        // Copy to clipboard
        EditorGUIUtility.systemCopyBuffer = sb.ToString();
        Debug.Log("Copied to clipboard:\n" + sb.ToString());
        EditorUtility.DisplayDialog("Success", "Level data copied to clipboard!", "OK");
    }
}
    