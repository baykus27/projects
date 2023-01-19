using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareketler : MonoBehaviour
{
    AudioSource audioSource;

    [SerializeField]
    private float ileriGitmeHýzý;
    [SerializeField]
    private float sagasolagitmehizi;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float yatayeksen = Input.GetAxis("Horizontal") * sagasolagitmehizi * Time.deltaTime;
        this.transform.Translate(yatayeksen, 0, ileriGitmeHýzý * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Topla")
        {
            audioSource.Play();

        }
    }
}
