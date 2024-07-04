using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestrocsionBala : MonoBehaviour
{
    
    private AudioSource sonidoDestrucsion;
    private GameObject audioManager;

    private void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("audioManager");
        sonidoDestrucsion = audioManager.GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            sonidoDestrucsion.Play();
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }

}
