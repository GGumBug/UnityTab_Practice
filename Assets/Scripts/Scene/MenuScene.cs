using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScene : MonoBehaviour
{
    private void Start() {
        UIManager.GetInstance().GetEventSystem();
        UIManager.GetInstance().OpenUI("UIMainMenu");
    }
}
