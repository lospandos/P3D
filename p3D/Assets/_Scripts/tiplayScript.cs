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
            konusmatextTiplay.text = "Ben Tiplay Studioda Sizinle çalýþmak isteyen bir gencim";
        }
        else if (t == 2)
        {
            konusmatextTiplay.text = "Verceðiniz projenin hypercasual olmasýndan korkuyodum :D";
        }
        else if (t == 3)
        {
            konusmatextTiplay.text = "çünkü hiç tecrübem yoktu";
        }
        else if (t == 4)
        {
            konusmatextTiplay.text = "Ve projeyi görünce aman Yarabbim dedim";
        }
        else if (t == 5)
        {
            konusmatextTiplay.text = "Yapamayacaðýmý anlayýnca (normalde ögrenirim fakat þu an kurban bayramýnýn ilk günü ve telaþe var)";
        }
        else if (t == 6)
        {
            konusmatextTiplay.text = "Bende yapýmýný 05.07.2022 de bitirdiðim oyunu sunmaya karar verdim";
        }
        else if (t == 7)
        {
            konusmatextTiplay.text = "Umarým beðenirsiniz þimdiden eðlenceler(dünyanýn en berbat introsu :D)";
        }

        else if (t == 8)
        {

            SceneManager.LoadScene("sahneintro");
        }
    }
}
