using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class yuvarlananEngel : MonoBehaviour
{
    public GameObject yuvarlan;//yuvarlanacak nesne ismi
    public float yHiz=4f;
    public float kaybolmaHiz=3f;

    private void Start()
    {
        StartCoroutine(yuvarlamaRutini());
    }
    IEnumerator yuvarlamaRutini()
    {
        while (true)
        {
            yuvarlananObje();
            yield return new WaitForSeconds(yHiz);
        }
    }
    void yuvarlananObje()
    {
        GameObject obje= Instantiate (yuvarlan, transform.position, Quaternion.identity);
        Destroy(obje,kaybolmaHiz);// destroy kaybolmasını sağlar
    }

}
