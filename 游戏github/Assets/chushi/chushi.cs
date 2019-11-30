using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chushi : MonoBehaviour
{
    // Start is called before the first frame update
    public void b()
    {
        SceneManager.LoadScene("boss");
    }
    public void p()
    {
        SceneManager.LoadSceneAsync("电脑屏幕");
    }
}
