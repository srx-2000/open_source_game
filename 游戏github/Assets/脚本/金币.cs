using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 金币 : MonoBehaviour
{
    public GameObject GO;
    public GUIText guit;
    public static int jin = 20;
    public 关卡 a = new 关卡();
   
   
        // Start is called before the first frame update
    void Start()
    {
        int v =a.GetCheck();
        print(v);
        v = v * 20;
        string c;
        c = Add(v);
        GO.GetComponent<Text>().text = c;
        // GO.GetComponent<Text>().text = "20";
        GameObject.DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            Click();
        }*/
       
    }
    public string Add(int x)
    {
        jin = jin + x;
        string b = jin.ToString();
        return b;
    }
    public string Reduce(int x)
    {
        jin = jin - x;
        if (!Judge())
        {
            jin = 0;
        }
        string b = jin.ToString();
        return b;
    }
    public void Click()
    {
        float X = Input.mousePosition.x - Screen.width / 2f;
        float Y = Input.mousePosition.y - Screen.height / 2f;
        float x = GO.GetComponent<Text>().transform.localPosition.x;
        float y = GO.GetComponent<Text>().transform.localPosition.y;
        if (X > (x - 55) && X < (x + 31) && Y > (y+3) && Y < (y + 50))
        {
            string c;
            c = Reduce(5);
            GO.GetComponent<Text>().text = c;
        }
    }
    public bool Judge()
    {
        if (jin > 0)
        {
            return true;
        }
        else return false;
    }
   public int Getnum()
    {
        return jin;
    }


}
