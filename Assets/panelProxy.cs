using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelProxy : MonoBehaviour
{
    [SerializeField] GameObject gameObjects;
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            gameObjects.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            gameObjects.SetActive(false);
        }
    }
}
