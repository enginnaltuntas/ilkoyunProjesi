using Unity.Mathematics;
using UnityEngine;

public class CarkHareket : MonoBehaviour
{
    public Transform carkNesne;

    public float donushiz=100f;
    public float harekethiz=2f;
    public float maxPosition=1.3f;
    public float minPosition=-1.3f;


    void Update()
    {
        carkNesne.Rotate(Vector3.right*donushiz*Time.deltaTime);
        float hareketYonu=Mathf.PingPong(Time.time*harekethiz,maxPosition-minPosition)+minPosition;
        carkNesne.transform.localPosition= new Vector3(carkNesne.transform.localPosition.x,
        carkNesne.transform.localPosition.y,hareketYonu);
    }
}
