using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class UIManager : MonoBehaviour
{

    #region SingleTone
    private static UIManager Instance = null;

    public static UIManager GetInstance()
    {
        if (Instance == null)
        {
        GameObject go = new GameObject("@UIManager");
        Instance = go.AddComponent<UIManager>();

        DontDestroyOnLoad(go);
        }
        return Instance;
    }
    #endregion

    #region UIControl
    Dictionary<string, GameObject> uiList = new Dictionary<string, GameObject>();

    public void OpenUI(string uiName)
    {
        if (uiList.ContainsKey(uiName) == false)
        {
        Object uiObj = Resources.Load("UI/" + uiName);
        GameObject go = (GameObject)Instantiate(uiObj);
        uiList.Add(uiName, go);
        }
        else
        {
            uiList[uiName].SetActive(true);
        }

    }

    public void CloseUI(string uiName)
    {
        if (uiList.ContainsKey(uiName) == true)
        uiList[uiName].SetActive(false);
    }

    public GameObject GetUI(string uiName)
    {
        if (uiList.ContainsKey(uiName) == true)
        {
            return uiList[uiName];
        }

        return null;
    }

    public void ClearUIList()
    {
        uiList.Clear();
    }

    #endregion

    public void GetEventSystem()
    {
        if (FindObjectOfType<EventSystem>() == false)
        {
            GameObject go = new GameObject("EventSystem");
            go.AddComponent<EventSystem>();
            go.AddComponent<StandaloneInputModule>();
        }
        
    }
}
