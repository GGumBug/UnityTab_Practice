using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScene : MonoBehaviour
{
    private void Start() {
        UIManager.GetInstance().GetEventSystem();

        GameObject character = ObjectManager.GetInstance().CreativeCharater();
        character.transform.localPosition = new Vector3(0, 1.1f, 0);
        character.transform.localScale = new Vector3(3f, 3f, 3f);

        UIManager.GetInstance().OpenUI("UIProfile");
        UIManager.GetInstance().OpenUI("UIActionMenu");
    }
}
