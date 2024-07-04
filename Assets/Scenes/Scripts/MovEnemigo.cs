using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float velocidadEnemigo;

    private AudioSource sonidoDestrucsion;
    private GameObject audioManager;

    private void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("audioManager");
        sonidoDestrucsion = audioManager.GetComponent<AudioSource>();
    }

    private void Update()
    {
        transform.Translate(0f, 0f, -1f * velocidadEnemigo * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Nave"))
        {
            sonidoDestrucsion.Play();
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    
    }
}
