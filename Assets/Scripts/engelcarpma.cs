using UnityEngine;

public class engelcarpma : MonoBehaviour
{
    [SerializeField]
    private int HasarMiktari;
    // iki nesne çarpıştığı anda gerçekleşir
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<CanKontrol>().hasarAl(HasarMiktari);
        }

    }
    // iki nesnenin çarpışması devam ederken gerçekleşir.
    void OnCollisionStay(Collision collision)
    {
        
    }
    // iki nesnenin çarpışması bittiğinde gerçekleşir
    void OnCollisionExit(Collision collision)
    {
        
    }

}
