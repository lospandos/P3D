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
            konusmatext.text = "Rabia Torun: Dede Bu G�n Hikaye Anlatcak m�s�nnn?";
        }
        else if (i == 2)
        {
            konusmatext.text = "Dede: Tabii ki K�z�m Bu G�n Size Eski Bir Efsane Anlataca��m.";
        }
        else if (i == 3)
        {
            konusmatext.text = "Melike Torun: Sab�rs�zl�kla Dinliyoruz Dede, ZEYNOOOO KO�!!!!! DEDEM BA�LIYOR!!";
        }
        else if (i == 4)
        {
            konusmatext.text = "Dede: Y�llar �nceydi �nsanl�k Yok Olmu�tu Yerini �se Zombiler Alm��t�";
        }
        else if (i == 5)
        {
            konusmatext.text = "Dede: D�nyada A�a�lar ve Zombilerden Ba�ka Hi�bir �ey G�z�km�yordu";
        }
        else if (i == 6)
        {
            konusmatext.text = "Dede: T�m Canl�l�k Bir An da Bitmi�ti";
        }
        else if (i == 7)
        {
            konusmatext.text = "Dede: Fakat Paralel Evrenden Gelen Bir Ya�am El�isi D�nya'ya Yeniden Umut Vericekti";
        }
        else if (i == 8)
        {
            konusmatext.text = "Dede: Bizim D�nyam�zdaki Vir�s� Yenebilecek DNA'ya Sahip Tek H��reli Canl�lar Getirecekti; 'deney S' ";
        }
        else if (i == 9)
        {
            konusmatext.text = "Dede: Fakat �ni� S�ras�nda deney S'in Bulundu�u Kaps�l Ara�tan F�rlayarak Da�l�k Bir Yere �ak�ld�";
        }
        else if (i == 10)
        {
            konusmatext.text = "Dede: Hayat�n Devam� ��in Onu Bulup  Deney S'i Kutsal Ta�a Yerle�tirmesi Gerekti ";
        }
        else if (i == 11)
        {
            konusmatext.text = "Zeyno Torun: Peki Dede Ba�ard� m�?";
        }

        else if (i == 12)
        {

            SceneManager.LoadScene("sahne1");
        }
    }
}