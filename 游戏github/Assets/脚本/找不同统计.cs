using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class 找不同统计 : MonoBehaviour
{
    public GameObject[] b;
    public int end = 0;
    private int d = 0;
   public string jump="";
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        xiang();
       
    }
    public void xiang()
    {
        for (int i = 0; i < b.Length; i++)
        {
            d += b[i].GetComponent<找不同2>().sum;
        }
        if (end == d)
        {
            SceneManager.LoadSceneAsync(jump);
        }
        print(d);
        d = 0;
    }
}
