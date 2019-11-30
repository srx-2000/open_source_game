using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 找不同2 : MonoBehaviour
{
    public GameObject GO;
    public float Finaxl = 0, Finaxr = 0, Finayl = 0, Finayr = 0;//最终判断区域的位置
    public float X, Y;//鼠标点击位置
    public int sum=0;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Setmousepoint();
            //Showmousepoint();
            Click();
        }
    }
    public void Setmousepoint()
    {
        X = Input.mousePosition.x - Screen.width / 2f;
        Y = Input.mousePosition.y - Screen.height / 2f;
    }
    public void Showmousepoint()
    {


        print("X为" + X);
        print("Y为" + Y);

    }
    public void Setfinal(float a,float b, float c,float d)
    {
        this.Finaxl =a;
        this.Finaxr =b;
        this.Finayl =c;
        this.Finayr =d;
    }
    public void Click()
    {
        //print(Finaxl + " " + Finaxr + " " + Finayl + " " + Finayr);

        if ((X > Finaxl) && (X < Finaxr) && (Y > Finayl) && (Y < Finayr))
        {
            sum = 1;
            print(sum);   
        }
        
    }
   
}
