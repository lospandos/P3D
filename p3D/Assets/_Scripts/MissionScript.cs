using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionScript : MonoBehaviour
{
    private okntrl player;
    public Transform karakter;
    public int yasamsayisi;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision y)
    {
        if (y.collider.gameObject.tag.Equals("player"))
        {

            Debug.Log("dokundu yesil");
            
        }
        if (y.collider.gameObject.tag.Equals("player"))
        {
            Debug.Log("dokundu mavi");
            
        }
        if (y.collider.gameObject.tag.Equals("player"))
        {
            Debug.Log("dokundu mavi");

        }
    }
}
