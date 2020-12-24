using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyspawn : MonoBehaviour
{
    public GameObject en;
    public Renderer enR;
    public int x, z;
    public static int enCount;
    Color e;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Enemymake());
    }



    IEnumerator Enemymake()
    {

        while (enCount < 100) 
        {
            float a, b, c,cab,height;
            x = Random.Range(0, 560);
            z = Random.Range(0, 560);
            c = Random.Range(0.0f, 1.0f);
            b = Random.Range(0.0f, 1.0f);
            cab = Random.Range(0.0f, 1.0f);
            e = new Color (c,b,cab);
          
          
            a = Random.Range(0.5f, 3.5f);
            height = Random.Range(0.5f, 4.5f);
           
            en.transform.localScale= new Vector3(a,height,a);
           // enR = Renderer;
         

            GameObject clone = Instantiate(en, new Vector3(x, 2, z), Quaternion.identity);
            clone.GetComponent<Renderer>().material.color = e;
            yield return new WaitForSeconds(0.1f);
            enCount += 1;
        }
        
    }
}
