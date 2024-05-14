using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playsound : MonoBehaviour
{
    AudioSource audioS;
    [SerializeField] AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        audioS = gameObject.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other) {
        audioS.clip = clip;
        audioS.Play();
    }
}
