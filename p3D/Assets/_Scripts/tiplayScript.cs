using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;
public class tiplayScript : MonoBehaviour
{
    public int t = 0;
    public Text konusmatextTiplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void skipButtonTiplay()
    {
        t++;
        Debug.Log(t);
        if (t == 1)
        {
            konusmatextTiplay.text = "Ben Tiplay Studioda Sizinle �al��mak isteyen bir gencim";
        }
        else if (t == 2)
        {
            konusmatextTiplay.text = "Verce�iniz projenin hypercasual olmas�ndan korkuyodum :D";
        }
        else if (t == 3)
        {
            konusmatextTiplay.text = "��nk� hi� tecr�bem yoktu";
        }
        else if (t == 4)
        {
            konusmatextTiplay.text = "Ve projeyi g�r�nce aman Yarabbim dedim";
        }
        else if (t == 5)
        {
            konusmatextTiplay.text = "Yapamayaca��m� anlay�nca (normalde �grenirim fakat �u an kurban bayram�n�n ilk g�n� ve tela�e var)";
        }
        else if (t == 6)
        {
            konusmatextTiplay.text = "Bende yap�m�n� 05.07.2022 de bitirdi�im oyunu sunmaya karar verdim";
        }
        else if (t == 7)
        {
            konusmatextTiplay.text = "Umar�m be�enirsiniz �imdiden e�lenceler(d�nyan�n en berbat introsu :D)";
        }

        else if (t == 8)
        {

            SceneManager.LoadScene("sahneintro");
        }
    }
}
