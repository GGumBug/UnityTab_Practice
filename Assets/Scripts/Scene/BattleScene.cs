using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleScene : MonoBehaviour
{
    private void Start() {
        UIManager.GetInstance().GetEventSystem();

        GameObject monster = ObjectManager.GetInstance().CreativeMonster();
        monster.transform.localPosition = new Vector3(0, 1.1f, 0);
        monster.transform.localScale = new Vector3(3f, 3f, 3f);

        UIManager.GetInstance().OpenUI("UIProfile");

        BattleManager.GetInstance().StartBattle(new Monster1());
    }
}
