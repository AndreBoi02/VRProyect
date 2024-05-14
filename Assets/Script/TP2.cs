using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP2 : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Transform tpPos;
    private void OnTriggerEnter(Collider other)
    {
        player = other.gameObject;
        tp2(player);
    }

    void tp2(GameObject player) {
        player.transform.position = tpPos.position;
    }
}
