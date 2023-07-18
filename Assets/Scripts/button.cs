using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    public string otherb;
    // Start is called before the first frame update
    public void Begin()
    {
        SceneManager.LoadScene("game" , LoadSceneMode.Single);
    }

    public void Level()
    {
        SceneManager.LoadScene("levels" , LoadSceneMode.Single);
    }

    public void other()
    {
        SceneManager.LoadScene(otherb , LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
