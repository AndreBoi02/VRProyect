using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] Animator door;
    bool b1,b2,b3 = false;

    void Update() {
        if (!b1 || !b2 || !b3) {
            return;
        }
        openDoor();
    }

    void openDoor() {
        door.Play("Door");
    }

    public void turnOnBool(int t_i) {
        switch (t_i)
        {
            case 1:
                b1 = true;
                break;
            case 2:
                b2 = true;
                break;
            case 3:
                b3 = true;
                break;
        }
    }
}
