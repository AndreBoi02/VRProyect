using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Content.Interaction;

public class Botones : MonoBehaviour
{
    //public Animator puertaAnimator;
    [SerializeField] XRPushButton botonInteractable;
    [SerializeField] Door door;
    [SerializeField] int i;

    [SerializeField] AudioClip audioClip;
    AudioSource audioSource;

    private void Start() {
        //// Obtn el componente XRBaseInteractable del botn
        //botonInteractable = GetComponent<XRPushButton>();

        //// Suscrbete al evento de presionar el botn
        botonInteractable.selectEntered.AddListener(playAudio);
        //botonInteractable.selectEntered.AddListener(playAudio);

        audioSource = gameObject.GetComponent<AudioSource>();
        door = GameObject.Find("Door_Middle_C").GetComponent<Door>();
        audioSource.clip = audioClip;
    }

    private void playAudio(SelectEnterEventArgs args) {
        //// Activa la animacin de la puerta
        //puertaAnimator.SetTrigger("open");
        door.turnOnBool(i);
        audioSource.Play();
    }
}