using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float velocidadEnemigo;
  
    private void Update()
    {
        transform.Translate(0f, 0f, -1f * velocidadEnemigo * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Nave"))
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    
    }
}
