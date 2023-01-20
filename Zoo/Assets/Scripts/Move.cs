using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Vector3 touchStart;
    private Vector3 dir;

    private void Update() {
        
        dd();
    }

    private void dd() {

        if (Input.GetMouseButtonDown(0))
            touchStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        if (Input.GetMouseButton(0)) {

            dir = touchStart - Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Camera.main.transform.position += dir;
        }
    }

    private void OnTriggerStay2D(Collider2D other) {

        Debug.Log("충돌중");
        
        if (other.CompareTag("G")) dd();
    }
}
