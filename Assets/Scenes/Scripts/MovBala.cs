using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovBala : MonoBehaviour
{
    [SerializeField] private Transform salDisparo;
    [SerializeField] public GameObject instansDisparo;
    [SerializeField] private float powerDisparo;
    [SerializeField] private AudioClip clipdisparo; 

    private AudioSource sonidoDisparoPiu;

    private void Start()
    {
        sonidoDisparoPiu = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            sonidoDisparoPiu.PlayOneShot(clipdisparo, 0.1f);
            GameObject clon = Instantiate(instansDisparo, salDisparo.position, salDisparo.transform.rotation);
            clon.GetComponent<Rigidbody>().velocity = transform.forward * powerDisparo;
            Destroy(clon, 10);
        }
    }

    

}
