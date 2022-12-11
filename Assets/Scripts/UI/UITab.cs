using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITab : MonoBehaviour
{
    Button btnAttack;

    private void Start() {
        btnAttack = GetComponentInChildren<Button>();
        btnAttack.onClick.AddListener(OnAttackClick);
    }

    void OnAttackClick()
    {
        BattleManager.GetInstance().AttckMonster();
    }


}
