using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject E1;
    public GameObject E2;
    public GameObject E3;
    public GameObject E4;
    public Transform good;
    public Transform NW;
    public Transform SE;
    public float e1b = 3f;
    public float e2b = 18f;
    public float e3b = .8f;
    public float e4b = 120f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawneri());
        StartCoroutine(spawnerii());
        StartCoroutine(spawneriii());
        StartCoroutine(spawneriv());
        
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
            yield return new WaitForSeconds(e1b);
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
            yield return new WaitForSeconds(e2b);
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
            yield return new WaitForSeconds(e3b);
        }
    }

        IEnumerator spawneriv()
    {
        while (true)
        {
            float randex = Random.Range(NW.position.x , SE.position.x);
            //print(Random.Range(NW.position.x , SE.position.x).GetType());
            float randey = Random.Range(NW.position.y , SE.position.y);
            GameObject mean = Instantiate(E4, new Vector2(randex , randey), transform.rotation);
            Enemy emeny = mean.GetComponent<Enemy>();
            emeny.good = good;
            yield return new WaitForSeconds(e4b);
        }
    }
}
