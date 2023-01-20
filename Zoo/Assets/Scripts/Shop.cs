using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Shop : MonoBehaviour
{
    Clicker clicker;

    private GameObject curButton;
    [SerializeField] private List<GameObject> animalList = new List<GameObject>(); //동물이 담긴다
    [SerializeField] private List<int> animalPriceList = new List<int>(); //동물 가격이 담긴다

    private void Awake() {

        clicker = GetComponent<Clicker>();
    }

    public void AnimalShop() {

        curButton = EventSystem.current.currentSelectedGameObject; //누른 버튼의 이름을 받아온다
        
        for (int i = 0; i < animalList.Count; i++) {

            if (animalList[i].name == curButton.name && animalPriceList[i] <= clicker.curGold) {

                clicker.curGold -= animalPriceList[i];
                animalList[i].SetActive(true);
            }
        }
    }
}
