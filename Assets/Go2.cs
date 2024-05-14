using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Go2 : MonoBehaviour
{
    [SerializeField] string sceneName;
    private void OnTriggerEnter(Collider other) {
        SceneManager.LoadScene(sceneName);
    }
    
}
