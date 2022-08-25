using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class zombihareket : MonoBehaviour
{
    
    private GameObject oyuncu;
    private int zombiCan = 3;
    private float mesafe;
    private OyunKontrol okontrol;
    private int zPuan=10;
    private AudioSource audioSource;
    private bool zombioluyor = false;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        oyuncu = GameObject.Find("Robot_Scout_Rockie_Unity");
        okontrol = GameObject.Find("_Scripts").GetComponent<OyunKontrol>();
    }

    // Update is called once per frame
    void Update()
    {
      //GetComponent<NavMeshAgent>().destination =  oyuncu.transform.position;
        GetComponent<NavMeshAgent>().destination = oyuncu.transform.position;
        mesafe = Vector3.Distance(transform.position, oyuncu.transform.position);
        if (mesafe < 10f)
        {
            if(!audioSource.isPlaying)
            audioSource.Play();
            if(!zombioluyor)
            GetComponentInChildren<Animation>().Play("Zombie_Attack_01");
        }
        else
        {
            if (audioSource.isPlaying)
                audioSource.Stop();
        }
    }

    private void OnCollisionEnter(Collision c)
    {
        if (c.collider.gameObject.tag.Equals("mermi"))
        {
            Debug.Log("çarptý");
            zombiCan--;
            if (zombiCan == 0)
            {
                zombioluyor = true;
                okontrol.PuanArttir(zPuan);
                GetComponentInChildren<Animation>().Play("Zombie_Death_01");
                Destroy(this.gameObject, 1.668f);
            }
        }
    }
}
