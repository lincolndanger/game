using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject E1;
    public GameObject E2;
    public GameObject E3;
    public Transform good;
    public Transform NW;
    public Transform SE;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawneri());
        StartCoroutine(spawnerii());
        StartCoroutine(spawneriii());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawneri()
    {
        while (true)
        {
            float randex = Random.Range(NW.position.x , SE.position.x);
            //print(Random.Range(NW.position.x , SE.position.x).GetType());
            float randey = Random.Range(NW.position.y , SE.position.y);
            GameObject mean = Instantiate(E1, new Vector2(randex , randey), transform.rotation);
            Enemy emeny = mean.GetComponent<Enemy>();
            emeny.good = good;
            yield return new WaitForSeconds(3f);
        }
    }

    IEnumerator spawnerii()
    {
        while (true)
        {
            float randex = Random.Range(NW.position.x , SE.position.x);
            //print(Random.Range(NW.position.x , SE.position.x).GetType());
            float randey = Random.Range(NW.position.y , SE.position.y);
            GameObject mean = Instantiate(E2, new Vector2(randex , randey), transform.rotation);
            Enemy emeny = mean.GetComponent<Enemy>();
            emeny.good = good;
            yield return new WaitForSeconds(18f);
        }
    }

        IEnumerator spawneriii()
    {
        while (true)
        {
            float randex = Random.Range(NW.position.x , SE.position.x);
            //print(Random.Range(NW.position.x , SE.position.x).GetType());
            float randey = Random.Range(NW.position.y , SE.position.y);
            GameObject mean = Instantiate(E3, new Vector2(randex , randey), transform.rotation);
            Enemy emeny = mean.GetComponent<Enemy>();
            emeny.good = good;
            yield return new WaitForSeconds(.8f);
        }
    }
}
