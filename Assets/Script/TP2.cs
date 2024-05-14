using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP2 : MonoBehaviour
{
    [SerializeField] Transform tpPos;
    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = tpPos.position;
    }
}
