using UnityEngine;

public class Engel_1Hareket : MonoBehaviour
{
    public float donusHizi=100f;
    public Transform donecektransform;
    void Update()
    {
        donecektransform.Rotate(Vector3.up*donusHizi *Time.deltaTime);
    }
}
