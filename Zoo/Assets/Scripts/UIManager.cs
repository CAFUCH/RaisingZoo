using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    Clicker clicker;

    [SerializeField] private TextMeshProUGUI goldTxt;

    private void Awake() {
        
        if (!instance) instance = this;
        else { Destroy(gameObject); }

        clicker = GetComponent<Clicker>();
    }

    private void Update() {

        goldTxt.text = clicker.curGold.ToString(); //현재 골드를 TMPro에 연동함
    }
}
