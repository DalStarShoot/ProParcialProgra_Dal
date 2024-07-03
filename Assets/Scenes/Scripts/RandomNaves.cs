using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RandomNaves : MonoBehaviour
{
    [SerializeField] private Transform[] puntoDeInstancia;

    [SerializeField] private GameObject instanciaEnemiga;
    private int numeroRandom;

    [SerializeField] private float tiempo;

    private void Start()
    {
        StartCoroutine(TiempoNaveEnemiga());
    }

    IEnumerator TiempoNaveEnemiga()
    {
        while (true)
        {
            yield return new WaitForSeconds(tiempo);
            Instantiate(instanciaEnemiga, puntoDeInstancia[numeroRandom]);
            numeroRandom = Random.Range(0, puntoDeInstancia.Length);
        }
    }
}
