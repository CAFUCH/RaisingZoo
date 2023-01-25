using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Shop : MonoBehaviour
{
    Clicker clicker;

    private GameObject curButton;

    [SerializeField] private List<GameObject> animalPanels = new List<GameObject>(); //동물 판넬들을 담아둔 리스트
    [SerializeField] private List<GameObject> areaPanels = new List<GameObject>(); //지역 판넬들을 담아둔 리스트
    private Image animalSprite; //현재 동물 판넬의 접근하기 위한 변수

    [SerializeField] private List<AnimalAttributeSO> animalSos = new List<AnimalAttributeSO>(); //동물 SO를 담아둔 리스트

    [SerializeField] private List<GameObject> animalList = new List<GameObject>(); //동물을 담아둔 리스트


    private void Awake() {

        clicker = GetComponent<Clicker>();

        ShopPanelSetting();
    }

    public void ShopPanelSetting() { //동물 상점의 동물 판넬 설정

        for (int i = 0; i < animalSos.Count; i++) { //동물 수 만큼 반복

            //동물 상점 판넬 설정
            animalPanels[i].transform.GetChild(0).GetComponent<Image>().sprite = animalSos[i].animal1;
            animalPanels[i].transform.GetChild(1).GetComponent<Image>().sprite = animalSos[i].animal2;
            animalPanels[i].transform.GetChild(2).GetComponent<Image>().sprite = animalSos[i].animal3;

            animalPanels[i].transform.GetChild(3).GetComponent<TextMesh>().text = $"{animalSos[i].areaName} - {animalSos[i].animalName}";
            animalPanels[i].transform.GetChild(4).GetChild(1).GetComponent<TextMesh>().text = animalSos[i].priceA1Value.ToString();

            //구역 상점 판넬 설정
            areaPanels[i].transform.GetChild(0).GetComponent<Image>().sprite = animalSos[i].gImage;
            areaPanels[i].transform.GetChild(1).GetComponent<TextMesh>().text = $"{animalSos[i].areaName} - {animalSos[i].animalName}";
            animalPanels[i].transform.GetChild(2).GetChild(1).GetComponent<TextMesh>().text = animalSos[i].priceGValue.ToString();
        } 
    }

    public void AnimalBuy() {

        curButton = EventSystem.current.currentSelectedGameObject; //누른 버튼의 이름을 받아온다
        
        for (int i = 0; i < animalSos.Count; i++) { //동물 수 만큼 반복

            if (curButton.name == animalSos[i].name) { //사려는 동물과 같은 SO를 찾았다면

                if (animalSos[i].animalL == 0 && clicker.curGold >= animalSos[i].priceA1Value) { //사려는 동물이 수컷이라며 돈이 있을 때

                    animalList[i].transform.GetChild(0).gameObject.SetActive(true); //해당 동물을 켜준다
                    animalSos[i].animalL++; //레벨을 1 올려준다 = 1
                }
                
                else if (animalSos[i].animalL == 1 && clicker.curGold >= animalSos[i].priceA2Value) { //사려는 동물이 암컷이라면

                    animalList[i].transform.GetChild(1).gameObject.SetActive(true); //해당 동물을 켜준다
                    animalSos[i].animalL++; //레벨을 1 올려준다 = 2
                }

                else if (animalSos[i].animalL == 2 && clicker.curGold >= animalSos[i].priceA3Value) { //사려는 동물이 아기라면

                    animalList[i].transform.GetChild(3).gameObject.SetActive(true); //해당 동물을 켜준다
                } 
            }
        }

        // + 구매 했다면 sprite 당겨주기
    }

    public void AreaBuy() { //구역 구매

        
    }
}
