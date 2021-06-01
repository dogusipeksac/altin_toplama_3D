using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunKontrol : MonoBehaviour {
    public bool oyunAktif=false;
    public int altinSayisi=0;
    public UnityEngine.UI.Text altinSayisiText;
    public UnityEngine.UI.Button baslaButon;
	// Use this for initialization
	void Start () {
        GetComponent<AudioSource>().Play();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void AltinArttir()
    {
        altinSayisi++;
        altinSayisiText.text = "Altın: " + altinSayisi;
    }
    public void Oyundurdur()
    {
        GetComponent<AudioSource>().Pause();
    }
    public void OyunBasla()
    {
        oyunAktif = true;
        baslaButon.gameObject.SetActive(false);
    }
}
