using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedDaDawg : MonoBehaviour
{
    CompanionAgent companionAgent;
    [SerializeField] string m_name;

    void Start() {
        companionAgent = GameObject.Find("Sand Spider").GetComponent<CompanionAgent>();
    }
    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.G)) {
            companionAgent.feed(gameObject.transform);
        }
    }
}
