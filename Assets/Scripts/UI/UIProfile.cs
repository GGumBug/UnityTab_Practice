using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIProfile : MonoBehaviour
{
    public Slider hpBar;
    public Image imgFill;

    public TMP_Text txtHp;
    public TMP_Text txtlv;
    public TMP_Text txtname;
    public TMP_Text txtgold;

    private void Start() {
        SetProfilReperence();
    }

    public void SetProfilReperence()
    {
        hpBar.maxValue = GameManager.GetInstance().maxHp;
        hpBar.value = GameManager.GetInstance().curHp;
        txtHp.text = $"{GameManager.GetInstance().curHp} / {GameManager.GetInstance().maxHp}";
        txtlv.text = $"Lv. {GameManager.GetInstance().lv}";
        txtname.text = GameManager.GetInstance().playerName;
        txtgold.text = $"{GameManager.GetInstance().gold.ToString()} G";
    }



}
