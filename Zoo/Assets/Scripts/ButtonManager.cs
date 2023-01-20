using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private GameObject pan;
    [SerializeField] private Button moveB;
    [SerializeField] private int upDir, downDir;

    [SerializeField] private List<Sprite> moveBSprites = new List<Sprite>();
    private bool panel = false;
    public void PanelMove() {

        panel = !panel;

        if (!panel) {

            pan.transform.DOMoveY(upDir, 0.75f);
            // .onComplete(() => moveB.gameObject.SetActive(false));
        }
        else { pan.transform.DOMoveY(downDir, 0.75f); }
    }
}
