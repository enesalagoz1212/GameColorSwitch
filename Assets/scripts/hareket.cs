using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class hareket : MonoBehaviour
{
    public Rigidbody2D top;
    public float ziplamaGucu;
    public Color turkuazRenk,sariRenk,morRenk,pembeRenk;
    public string mevcutRenk;
    public SpriteRenderer ressam;
    public Transform degistirici;
    public TextMeshProUGUI skorYazisi;
    public int skor;
    public AudioSource ziplamaSesi;
    void Update()
    {
        skorYazisi.text = "Skor : " + skor;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            top.velocity = Vector2.up * ziplamaGucu;
            ziplamaSesi.Play();
        }
       
    }
   void Start()
    {
        rastgeleRenk();
    }

    void OnTriggerEnter2D(Collider2D temas)
    {
        if (temas.tag != mevcutRenk && temas.tag != "RenkDegistrici" && temas.tag!="Kontrol1"&&temas.tag!="Kontrol2")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (temas.tag =="RenkDegistrici")
        {
            skor++;
            degistirici.position = new Vector3(degistirici.position.x, degistirici.position.y + 7.5f, degistirici.position.z);
            rastgeleRenk();
        }
          

    }
    void rastgeleRenk() 
    {
        int rastgele = Random.Range(0, 4);
        switch (rastgele)
        {
            case 0:
                mevcutRenk = "Turkuaz";
                ressam.color = turkuazRenk;
                break;
            case 1:
                mevcutRenk = "Sari";
                ressam.color = sariRenk;
                break;
            case 2:
                mevcutRenk = "Mor";
                ressam.color = morRenk;
                break;
            case 3:
                mevcutRenk = "Pembe";
                ressam.color = pembeRenk;
                break;

            
        }


    }
}
