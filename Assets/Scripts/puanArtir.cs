using System;
using UnityEngine;

public class puanArtir : MonoBehaviour
{
    [SerializeField] int puanMiktari=5;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<CanKontrol>().puanArtir(puanMiktari);
            Destroy(gameObject);
        }
    }
}
