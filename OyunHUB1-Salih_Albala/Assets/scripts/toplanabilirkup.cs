using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toplanabilirkup : MonoBehaviour
{
    bool toplandiMi;
    int index;
    public Toplayici toplayici;


    void Start()
    {
        toplandiMi = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (toplandiMi == true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }
        

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Engel")
        {
            toplayici.YukseklikAzalt();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
            
        }
    }
    public bool GetToplandiMi()
    {

        return toplandiMi;
    }
    public void ToplandiYap()
    {
        toplandiMi = true;
    }

    public void IndexAyarla(int index)
    {
        this.index = index;
        //globaldeki indexi buradaki intigerdaki indexe ayarlar.
    }
}
