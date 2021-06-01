using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuKontrol : MonoBehaviour {
    public AudioClip altin, dusme;
    private float hiz=10;
    public OyunKontrol oyunKontrol;
	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
        if (oyunKontrol.oyunAktif) { 
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        x *= Time.deltaTime * hiz;
        y *= Time.deltaTime * hiz;
        transform.Translate(x, 0f, y);
        }
    }
     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("altın")) {
            AudioSource.PlayClipAtPoint(altin, transform.position);
            oyunKontrol.AltinArttir();
            Destroy(collision.gameObject);
            
        }
        else if (collision.gameObject.tag.Equals("dusman")){
            AudioSource.PlayClipAtPoint(dusme,transform.position);
            oyunKontrol.Oyundurdur();
            oyunKontrol.oyunAktif = false;
            
            
            
        }
    }
}
