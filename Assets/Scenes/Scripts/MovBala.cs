using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovBala : MonoBehaviour
{
    [SerializeField] private Transform SalDisparo;
    [SerializeField] public GameObject InstansDisparo;
    [SerializeField] private float PowerDisparo;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject clon = Instantiate(InstansDisparo, SalDisparo.position, SalDisparo.transform.rotation);
            clon.GetComponent<Rigidbody>().velocity = transform.forward * PowerDisparo;
            Destroy(clon, 10);
        }
    }



}
