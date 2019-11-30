using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class 传数据 : MonoBehaviour
{

   public int a;
    public int b;
    public string fir;
    public string sec;
    private AsyncOperation mAsyncOperation1;
        private AsyncOperation mAsyncOperation2; //异步加载信息
    // Start is called before the first frame update
    void Start()
    {
        Invoke("jump", 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
       
      
           
       
        
    }
    public void jump()
    {
        SceneManager.LoadSceneAsync("程序员可点击版初始界面");

    }
}
