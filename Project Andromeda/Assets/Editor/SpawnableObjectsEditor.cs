using UnityEngine;
using UnityEditor;

public class SpawnableObjectsEditor {

    private static int _count;

    [MenuItem("Assets/Create/Spawnable Objects")]
    public static void CreateSpawnableObjects() {
        SpawnableObjects asset = ScriptableObject.CreateInstance<SpawnableObjects>();

        AssetDatabase.CreateAsset(asset, string.Format("Assets/SpawnableObjects {0}.asset", _count++));
        AssetDatabase.SaveAssets();

        EditorUtility.FocusProjectWindow();

        Selection.activeObject = asset;
    }
}