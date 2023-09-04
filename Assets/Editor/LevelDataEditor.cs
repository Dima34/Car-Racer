using Infrastructure.Constants;
using StaticData;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

[CustomEditor(typeof(LevelStaticData))]
public class LevelStaticDataEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        LevelStaticData levelData = (LevelStaticData)target;

        if (GUILayout.Button("Collect"))
        {
            AddSceneNameData(levelData);
            TryAddPlayerStartPoint(levelData);

            EditorUtility.SetDirty(levelData);
        }
    }

    private static void AddSceneNameData(LevelStaticData levelData) =>
        levelData.LevelName = SceneManager.GetActiveScene().name;
    
    private static void TryAddPlayerStartPoint(LevelStaticData levelData)
    {
        // string respawnPointTag = Tags.PLAYER_SPAWN_POINT;
        // GameObject respawnPoint = GameObject.FindGameObjectWithTag(respawnPointTag);
        //
        // if (respawnPoint != null)
        //     levelData.PlayerStartPosition = respawnPoint.transform.position;
        // else
        //     Debug.LogWarning($"Can`t find player start position. Mark object by '{respawnPointTag}' tag");
    }
}