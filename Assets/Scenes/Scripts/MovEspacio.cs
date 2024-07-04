using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovEspacio : MonoBehaviour
{
    public float velocidadEspacio = 0.005f;
   
    void Update()
    {
        float offset = Time.time + velocidadEspacio;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, offset);
    }
}
