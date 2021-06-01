using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKontrolu : MonoBehaviour
{
    public OyunKontrol OyunKontrol;
    float hassasiyet = 2f;
    float yumusaklik = 2f;
    Vector2 gecisPozisyonu;
    Vector2 cameraPozisyonu;

    GameObject oyuncu;
    // Use this for initialization
    void Start()
    {
        oyuncu = transform.parent.gameObject;
        cameraPozisyonu.y = 12f;
    }

    // Update is called once per frame
    void Update()
    {
        if (OyunKontrol.oyunAktif) { 
        Vector2 farePozisyonu = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        farePozisyonu = Vector2.Scale(farePozisyonu, new Vector2(hassasiyet * yumusaklik, hassasiyet * yumusaklik));
        gecisPozisyonu.x = Mathf.Lerp(gecisPozisyonu.x, farePozisyonu.x, (1f / yumusaklik));
        gecisPozisyonu.y = Mathf.Lerp(gecisPozisyonu.y, farePozisyonu.y, (1f / yumusaklik));
        cameraPozisyonu += gecisPozisyonu;
        transform.localRotation = Quaternion.AngleAxis(-cameraPozisyonu.y, Vector3.right);
        oyuncu.transform.localRotation = Quaternion.AngleAxis(cameraPozisyonu.x, oyuncu.transform.up);
        }
    }
}