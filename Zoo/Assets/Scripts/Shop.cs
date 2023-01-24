using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Shop : MonoBehaviour
{
    Clicker clicker;

    private GameObject curButton;

    [SerializeField] private List<GameObject> animalPanels = new List<GameObject>();

    [SerializeField] private List<AnimalAttributeSO> animalSos = new List<AnimalAttributeSO>();

    [SerializeField] private List<GameObject> animalList = new List<GameObject>(); //동물이 담긴다

    [SerializeField] private List<int> animalPriceList = new List<int>(); //동물 가격이 담긴다


    private void Awake() {

        clicker = GetComponent<Clicker>();
    }

    public void AnimalShopSetting() {

        for (int i = 0; i < animalSos.Count; i++) {

            // animalPanels[i].transform.GetChild(0).GetComponent<Sprite>() = tlqkf;
        }
    }

    public void AnimalShop() { //동물 구매

        curButton = EventSystem.current.currentSelectedGameObject; //누른 버튼의 이름을 받아온다
        
        for (int i = 0; i < animalList.Count; i++) { //동물리스트 길이 만큼 반복

            if (animalList[i].name == curButton.name && animalPriceList[i] <= clicker.curGold) {
                //누른 버튼과 동물의 이름이 같으며 필요한 돈보다 현재 돈이 많다면

                clicker.curGold -= animalPriceList[i]; //돈을 차감한다
                if (Input.GetKeyDown(KeyCode.E))
                    animalList[i].SetActive(true); //동물을 켜준다
            }
        }
    }
}
