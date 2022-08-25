using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;

public class introScript : MonoBehaviour
{
    public int i = 0;
    public Text konusmatext;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void skipButton()
    {
        i++;
        Debug.Log(i);
        if (i == 1)
        {
            konusmatext.text = "Rabia Torun: Dede Bu Gün Hikaye Anlatcak mýsýnnn?";
        }
        else if (i == 2)
        {
            konusmatext.text = "Dede: Tabii ki Kýzým Bu Gün Size Eski Bir Efsane Anlatacaðým.";
        }
        else if (i == 3)
        {
            konusmatext.text = "Melike Torun: Sabýrsýzlýkla Dinliyoruz Dede, ZEYNOOOO KOÞ!!!!! DEDEM BAÞLIYOR!!";
        }
        else if (i == 4)
        {
            konusmatext.text = "Dede: Yýllar Önceydi Ýnsanlýk Yok Olmuþtu Yerini Ýse Zombiler Almýþtý";
        }
        else if (i == 5)
        {
            konusmatext.text = "Dede: Dünyada Aðaçlar ve Zombilerden Baþka Hiçbir Þey Gözükmüyordu";
        }
        else if (i == 6)
        {
            konusmatext.text = "Dede: Tüm Canlýlýk Bir An da Bitmiþti";
        }
        else if (i == 7)
        {
            konusmatext.text = "Dede: Fakat Paralel Evrenden Gelen Bir Yaþam Elçisi Dünya'ya Yeniden Umut Vericekti";
        }
        else if (i == 8)
        {
            konusmatext.text = "Dede: Bizim Dünyamýzdaki Virüsü Yenebilecek DNA'ya Sahip Tek Hüçreli Canlýlar Getirecekti; 'deney S' ";
        }
        else if (i == 9)
        {
            konusmatext.text = "Dede: Fakat Ýniþ Sýrasýnda deney S'in Bulunduðu Kapsül Araçtan Fýrlayarak Daðlýk Bir Yere Çakýldý";
        }
        else if (i == 10)
        {
            konusmatext.text = "Dede: Hayatýn Devamý Ýçin Onu Bulup  Deney S'i Kutsal Taþa Yerleþtirmesi Gerekti ";
        }
        else if (i == 11)
        {
            konusmatext.text = "Zeyno Torun: Peki Dede Baþardý mý?";
        }

        else if (i == 12)
        {

            SceneManager.LoadScene("sahne1");
        }
    }
}