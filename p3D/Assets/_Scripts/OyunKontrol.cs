using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class OyunKontrol : MonoBehaviour
{
    public GameObject zombi;
    private float zamanSayaci;
    private float olusumSureci = 7f;
    public Text puanText;
    private int puan;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        zamanSayaci = olusumSureci;
    }

    // Update is called once per frame
    void Update()
    {
        zamanSayaci -= Time.deltaTime;
        if (zamanSayaci < 0)
        {
            Vector3 pos = new Vector3(Random.Range(-55,114),23f,Random.Range(168,-68));
            Instantiate(zombi, pos, Quaternion.identity);
            zamanSayaci = olusumSureci;
        }
    }
    public void PuanArttir(int p)
    {
        puan += p;
        puanText.text = "" + puan;
    }
    
    public void OyunBitti()
    {
        PlayerPrefs.SetInt("puan",puan);
        SceneManager.LoadScene("sahne2");
    }
}
