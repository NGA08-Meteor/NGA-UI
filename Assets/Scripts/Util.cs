using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

static class Util
{

    // Util.SceneMove("MainScreen");
    public static void SceneMove(string sceneName)
    {
        SceneManager.LoadScene(scenename);
    }
}
