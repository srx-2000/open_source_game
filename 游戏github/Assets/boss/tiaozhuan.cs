using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tiaozhuan : MonoBehaviour
{
    // Start is called before the first frame update
    public void boss()
    {
        SceneManager.LoadScene("game");
    }
    public void programer()
    {
        SceneManager.LoadSceneAsync("程序员可点击版初始界面");
    }
    // Update is called once per frame
    
   
}
