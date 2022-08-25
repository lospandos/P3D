using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class okntrl : MonoBehaviour
{
    public AudioClip atisSesi, olmeSesi, canAlmaSesi, yaralanmaSesi;
    private float hiz = 10;
    public Transform mermiPos;
    public GameObject mermi;
    public Image canimage;
    private float canDegeri = 100f;
    public OyunKontrol okontrol;
    public GameObject cyesil,ckirmizi,cmavi;
    public int cyesilx=0, ckirmizix=0, cmavix=0;
    private AudioSource aSource;
    public Text bilgilendiriciText;
   

    // Start is called before the first frame update
    void Start()
    {
        aSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        x *= Time.deltaTime * hiz;
        y*= Time.deltaTime * hiz;
        transform.Translate(x, 0f, y);

        if (Input.GetKeyDown(KeyCode.F))
        {
            aSource.PlayOneShot(atisSesi, 1f);
            bilgilendiriciText.text = " ";
            GameObject go = Instantiate(mermi, mermiPos.position, mermiPos.rotation) as GameObject;
            go.GetComponent<Rigidbody>().velocity = mermiPos.transform.forward * 40f;
            Destroy(go.gameObject,2f);
        }

    }
    private void OnCollisionEnter(Collision c)
    {
        if (c.collider.gameObject.tag.Equals("zombi"))
        {
            aSource.PlayOneShot(yaralanmaSesi,1f);
            Debug.Log("dokundu");
            canDegeri -= 10f;
            float x = canDegeri / 100f;
            canimage.fillAmount = x;
            canimage.color = Color.Lerp(Color.red, Color.green, x);

            if (canDegeri <= 0)
            {
                aSource.PlayOneShot(olmeSesi);
                okontrol.OyunBitti();
            }
        }
        if (c.collider.gameObject.tag.Equals("deniz"))
        {
            Debug.Log("dokundu");
            canDegeri -= 100f;
            float x = canDegeri / 100f;
            canimage.fillAmount = x;
            canimage.color = Color.Lerp(Color.red, Color.green, x);

            if (canDegeri <= 0)
            {
                aSource.PlayOneShot(olmeSesi);
                okontrol.OyunBitti();
            }
        }
        if (c.collider.gameObject.tag.Equals("yesil"))
        {
            aSource.PlayOneShot(canAlmaSesi, 1f);
            Debug.Log("dokundu yesil");
            cyesilx++;
            Destroy(cyesil);

        }
        if (c.collider.gameObject.tag.Equals("mavi"))
        {
            aSource.PlayOneShot(canAlmaSesi, 1f);
            Debug.Log("dokundu mavi");
            cmavix++;
            Destroy(cmavi);

        }

        if (c.collider.gameObject.tag.Equals("kirmizi"))
        {
            aSource.PlayOneShot(canAlmaSesi, 1f);
            Debug.Log("dokundu kirmizi");
            ckirmizix++;
            Destroy(ckirmizi);
        }


        if (c.collider.gameObject.tag.Equals("bitis"))
        {
            if (ckirmizix==1 && cmavix==1 && cyesilx==1) {
                Debug.Log("Oyunu kazandýnýz");
                SceneManager.LoadScene("sahne3");
            }
        }
    }


    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag.Equals("kalp"))
        {
            aSource.PlayOneShot(canAlmaSesi,1f);
            canDegeri += 10f;
            float x = canDegeri / 100f;
            canimage.fillAmount = x;
            canimage.color = Color.Lerp(Color.red, Color.green, x);
        }
    }


}
