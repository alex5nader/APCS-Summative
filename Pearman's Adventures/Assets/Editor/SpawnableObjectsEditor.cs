using System;
using UnityEngine;
using UnityEditor;

public class SpawnableObjectsEditor {

    private static int _count;

    [MenuItem("Assets/Create/Spawnable Objects")]
    public static void CreateSpawnableObjects() {
        var asset = ScriptableObject.CreateInstance<SpawnableObjects>();

        var path = EditorUtility.SaveFilePanel("Create Spawnable Object List", "Assets/", "SpawnableObjectList", "asset");

        if (string.IsNullOrEmpty(path))
            return;
        
        AssetDatabase.CreateAsset(asset, ToRelativePath(path));
        AssetDatabase.SaveAssets();

        EditorUtility.FocusProjectWindow();

        Selection.activeObject = asset;
    }
    [MenuItem("Assets/Create/Power Up List")]
    public static void CreatePowerUplist() {
        var asset = ScriptableObject.CreateInstance<PowerUpList>();

        var path = EditorUtility.SaveFilePanel("Create Spawnable Object List", "Assets/", "SpawnableObjectList", "asset");

        if (string.IsNullOrEmpty(path))
            return;
        
        AssetDatabase.CreateAsset(asset, ToRelativePath(path));
        AssetDatabase.SaveAssets();

        EditorUtility.FocusProjectWindow();

        Selection.activeObject = asset;
    }

    [MenuItem("Assets/Create/Spawnable Object")]
    public static void CreateSpawnableObject() {
        var asset = ScriptableObject.CreateInstance<SpawnableObject>();

        var path = EditorUtility.SaveFilePanel("Create Spawnable Object", "Assets/", "Spawnable Object", "asset");

        if (string.IsNullOrEmpty(path))
            return;

        Debug.Log(string.Format("path: {0}", path));

        AssetDatabase.CreateAsset(asset, ToRelativePath(path));
        AssetDatabase.SaveAssets();

        EditorUtility.FocusProjectWindow();

        Selection.activeObject = asset;
    }

    private static string ToRelativePath(string absPath) {
        if (absPath.StartsWith(Application.dataPath))
            return "Assets" + absPath.Substring(Application.dataPath.Length);
        throw new InvalidOperationException();
    }
}