using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 关卡 : MonoBehaviour
{
    public 金币 jinbi;
    public GameObject GO;
    public GUIText guit;
    // Start is called before the first frame update
    public static int i = 1;

    void Start()
    {
        GO.GetComponent<Text>().text =Getnum();
    }

    // Update is called once per frame
    void Update()
    {
        Judeg();
    }
    public int GetCheck()
    { 
        return i;
    }
    public void addCheck(int x)
    {
        i = i + x;
        
    }
    public void Automatic()
    {
        i++;
    }
    public void Reduce()
    {
        i--;
    }
    public void Reduce(int x)
    {
        i = i - x;
    }
    public void Judeg()

    {
        if (!jinbi.Judge())
        {
            GO.GetComponent<Text>().text ="失败";
        }
    }
    public string Getnum()
    {
        string c;
        c ="关卡"+i.ToString();
        return c;
    }
    
  
}
