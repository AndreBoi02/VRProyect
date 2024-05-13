using UnityEngine;

public class Teleport : MonoBehaviour {
    [SerializeField] Transform teleportTarget;
    
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            other.transform.position = teleportTarget.position;
            other.transform.rotation = teleportTarget.rotation;
        }
    }
}

