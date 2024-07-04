using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float vel;
    private Rigidbody m;
  
    void Start()
    {
        m = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        float movimientohorizntal = Input.GetAxisRaw("Horizontal");
        m.velocity = new Vector2(movimientohorizntal, 0) * vel * Time.deltaTime;
    }
}
