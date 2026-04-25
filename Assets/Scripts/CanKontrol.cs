using UnityEngine;

public class CanKontrol : MonoBehaviour
{
    public int maxCan=100;
    public int Toplampuan=0;
    public int gecerliCan;
    void Start()
    {
        gecerliCan=maxCan;
    }
    public void hasarAl(int HasarMiktari)
    {
        gecerliCan-=HasarMiktari;
        if (gecerliCan <= 0)
        {
            gecerliCan=0;
            gameObject.SetActive(false);
        }
    }
    public void puanArtir(int puanMiktari)
    {
        Toplampuan+=puanMiktari;
    } 
}
