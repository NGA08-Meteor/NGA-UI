using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenemove : MonoBehaviour
{
    public string scenename;

    public void sm()
    {
        SceneManager.LoadScene(scenename);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
