using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    #region SingleTone
    private static ObjectManager Instance = null;

    public static ObjectManager GetInstance()
    {
        if (Instance == null)
        {
            GameObject go = new GameObject("@ObjectManager");
            Instance = go.AddComponent<ObjectManager>();

            DontDestroyOnLoad(go);
        }

        return Instance;
    }
    #endregion

    public GameObject CreativeCharater()
    {
        Object characterObj = Resources.Load("Sprite/Character");
        GameObject character = (GameObject)Instantiate(characterObj);

        return character;
    }

    public GameObject CreativeMonster()
    {
        Object monsterObj = Resources.Load("Sprite/Monster1");
        GameObject monster = (GameObject)Instantiate(monsterObj);

        return monster;
    }

    public ParticleSystem CreativeEffect()
    {
        Object effectObj = Resources.Load("Effect/Hit_Particle");
        GameObject hit = (GameObject)Instantiate(effectObj);

        return hit.GetComponent<ParticleSystem>();
    }
}
