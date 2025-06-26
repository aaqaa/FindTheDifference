using UnityEditor;
using UnityEngine;
using UnityEditor.AddressableAssets;
using UnityEditor.AddressableAssets.Settings;
using System.Collections.Generic;

public class BulkAddressableEditor : EditorWindow
{
    [MenuItem("Tools/Addressables/Bulk Rename Addresses")]
    public static void ShowWindow() => GetWindow<BulkAddressableEditor>("Bulk Rename");

    string find = "";
    string replace = "";

    void OnGUI()    
    {
        GUILayout.Label("Bulk Address Rename", EditorStyles.boldLabel);
        find = EditorGUILayout.TextField("Find:", find);
        replace = EditorGUILayout.TextField("Replace:", replace);

        if (GUILayout.Button("Apply to Selected Entries"))
            BulkRenameSelected();
    }

    void BulkRenameSelected()
    {
        var settings = AddressableAssetSettingsDefaultObject.Settings;
        if (settings == null)
        {
            Debug.LogError("Addressables Settings not found");
            return;
        }

        // Collect selected asset paths
        var selected = new HashSet<string>();
        foreach (var obj in Selection.objects)
        {
            var path = AssetDatabase.GetAssetPath(obj);
            if (!string.IsNullOrEmpty(path))
                selected.Add(path);
        }

        if (selected.Count == 0)
        {
            Debug.LogWarning("No assets selected.");
            return;
        }

        // Gather all addressable entries
        var allEntries = new List<AddressableAssetEntry>();
        settings.GetAllAssets(allEntries, false);

        int count = 0;
            foreach (var entry in allEntries)
        {
            if (!selected.Contains(entry.AssetPath))
                continue;

            if (string.IsNullOrEmpty(find))
                continue;

            string newAddr = entry.address.Replace(find, replace);
            if (newAddr != entry.address)
            {
                entry.SetAddress(newAddr);
                Debug.Log($"Renamed: {entry.AssetPath} -> {newAddr}");
                count++;
            }
        }

        if (count > 0)
        {
            settings.SetDirty(AddressableAssetSettings.ModificationEvent.EntryMoved, null, true);
            AssetDatabase.SaveAssets();
            Debug.Log($"Renamed {count} address{(count > 1 ? "es" : "")}.");
        }
        else Debug.Log("No addresses changed.");
    }
}
