using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private GameObject gamePanel;
    // [SerializeField] private Button gamePanelB;
    [SerializeField] private int upDir, downDir;

    [SerializeField] private GameObject settingPanel;

    // [SerializeField] private List<Sprite> gameMoveBSprites = new List<Sprite>();
    private bool isGamePanel = false;

    private bool isSettingPanel = false;

    [SerializeField] private GameObject areaPanel;

    public void GamePanelMove() { //게임 속성 판넬을 열고 닫는 메서드

        if (!isGamePanel) {

            gamePanel.transform.DOMoveY(upDir, 0.75f);
            // .onComplete(() => moveB.gameObject.SetActive(false));
            //버튼 이미지 바꾸는 거 해결하기
        }
        else { gamePanel.transform.DOMoveY(downDir, 0.75f); }

        isGamePanel = !isGamePanel;
    }

    public void SettingPanelMove() {
        
        if (!isSettingPanel) {

            settingPanel.transform.DOMoveY(800, 0.75f);
        }
        else { settingPanel.transform.DOMoveY(-800, 0.75f); }

        isSettingPanel = !isSettingPanel;
    }

    public void AreaPanelTrue() {
        
        Debug.Log("area 버튼 눌림");
        
        areaPanel.SetActive(true);
    }
}
