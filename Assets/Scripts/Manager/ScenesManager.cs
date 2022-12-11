using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum Scene
{
    Menu,
    Main,
    Battle
}

public class ScenesManager : MonoBehaviour
{
    #region SingleTone
    private static ScenesManager Instance = null;

    public static ScenesManager GetInstance()
    {
        if (Instance == null)
        {
        GameObject go = new GameObject("@ScenesManager");
        Instance = go.AddComponent<ScenesManager>();

        DontDestroyOnLoad(go);
        }
        return Instance;
    }
    #endregion

    #region SceneControl
    public Scene currentScene;
    public void ChangeScene(Scene scene)
    {
        UIManager.GetInstance().ClearUIList();

        currentScene = scene;
        SceneManager.LoadScene(scene.ToString());
    }
    #endregion

    
}
