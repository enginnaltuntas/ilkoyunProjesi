using UnityEngine;

public class PlayerHareket : MonoBehaviour
{
    private float speed=5f;
    Rigidbody rb;
    void Awake()
    {
        rb=GetComponent<Rigidbody>();
    }
    private void Update()
    {
        float moveHorizantal=Input.GetAxis("Horizontal");
        float moveVertical=Input.GetAxis("Vertical");
        Vector3 hareket=new Vector3(moveHorizantal,0,moveVertical)*speed;
        rb.linearVelocity=hareket;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            Debug.Log("OYUN BİTTİ");
        }
    }
}
