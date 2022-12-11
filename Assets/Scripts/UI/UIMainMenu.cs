using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIMainMenu : MonoBehaviour
{
    public Button btnStart;

    private void Start() {
        btnStart = GetComponentInChildren<Button>();
        btnStart.onClick.AddListener(OnClickStart);
    }
    void OnClickStart()
    {
        ScenesManager.GetInstance().ChangeScene(Scene.Main);
    }
}
