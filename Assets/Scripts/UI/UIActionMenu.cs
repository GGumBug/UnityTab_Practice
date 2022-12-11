using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIActionMenu : MonoBehaviour
{
    public Button btnpractice;
    public Button btnhealing;
    public Button btnbattle;

    private void Start() {
        btnbattle.onClick.AddListener(OnClickBattle);
    }

    void OnClickBattle()
    {
        ScenesManager.GetInstance().ChangeScene(Scene.Battle);
    }

}
