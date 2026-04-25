using UnityEngine;

public class CameraTakip : MonoBehaviour
{
    public Transform hedef;
    Vector3 mesafe=Vector3.zero;
    public float takiphizi=0.15f;
    void Start()
    {
        mesafe=transform.position-hedef.position;

    }
    void LateUpdate()
    {
        Vector3 mevcutPos=transform.position;
        Vector3 hedefPos=new Vector3(mevcutPos.x,hedef.position.y+mesafe.y,hedef.position.z+mesafe.z);
        Vector3 yeniPos=Vector3.Lerp(transform.position,hedefPos,takiphizi);
        transform.position=yeniPos;
    }

}
