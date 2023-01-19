using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toplayici : MonoBehaviour
{
    GameObject küp;
    int yukseklik;

    void Start()
    {
        küp = GameObject.Find("küp");
         
    }

    // Update is called once per frame
    void Update()
    {
        küp.transform.position = new Vector3(transform.position.x, yukseklik + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -yukseklik, 0);

    }

    public void YukseklikAzalt()
    {
        yukseklik--;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Topla"&&other.gameObject.GetComponent<toplanabilirkup>().GetToplandiMi() == false)
        {
            yukseklik += 1;
            other.gameObject.GetComponent<toplanabilirkup>().ToplandiYap();
            other.gameObject.GetComponent<toplanabilirkup>().IndexAyarla(yukseklik);
            other.gameObject.transform.parent = küp.transform;
        }
    }
}
