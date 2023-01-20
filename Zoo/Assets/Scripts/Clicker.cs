using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{

    [SerializeField] private int gold; //현재 골드
    public int curGold {

        get { return gold; }

        set { gold = value; }
    }

    [SerializeField] private int goldValue; //한 번 터치에 몇 골드를 벌 수 있는지
    public int goldV {

        get { return goldValue; }

        set { goldValue = value; }
    }

    private bool coolT; //터치 쿨타임

    private void Awake() {
        
        StartCoroutine(ClickDealy());
    }

    public void Click() {

        coolT = false;
        gold += goldValue;
    }

    IEnumerator ClickDealy() {

        while (coolT) {
            
            yield return new WaitForSecondsRealtime(0.1f);

            coolT = true;
        }
    }
}
