using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class 跳 : MonoBehaviour
{
    public 关卡 a = new 关卡();
    // Start is called before the first frame update
    void Start()
    {
        Invoke("jump", 2.0f);
        a.addCheck(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void jump()
    {
        SceneManager.LoadSceneAsync("程序员可点击版初始页面");

    }
}
