using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 找不同 : MonoBehaviour
     
{
    public GameObject GO;
    public GUIText guit;
    public float imagexl=0, imagexr=0,imageyl=0,imageyr=0;//你设置的区域左右上下，值为正
    public float Imagex=0, Imagey=0;//你控件的中心位置
    public float Finaxl = 0, Finaxr = 0, Finayl = 0, Finayr = 0;//最终判断区域的位置
    public float X, Y;//鼠标点击位置
    // Start is called before the first frame update
    void Start()
    {
        //这里根据具体的属性来更改其中的属性
        this.Imagex = GO.GetComponent<Image>().transform.localPosition.x;
        this.Imagey = GO.GetComponent<Image>().transform.localPosition.y;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            Setmousepoint();
            Setfinal();
            Showmousepoint();
            ShowImage();
            Showsetxy();
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
        
        
        print("X为"+X);
        print("Y为"+Y);

    }
    public void Setx(float imagexl,float imagexr)
    {
        this.imagexl = imagexl;
        this.imagexr = imagexr;
        
    }
    public void Sety(float imageyl, float imageyr)
    {
        this.imageyl = imageyl;
        this.imageyr = imageyr;
        
    }
    public void Showsetxy()
    {
        print("setX为"+imagexl+" "+imagexr);
        print("setY为"+imageyl+" "+imageyr);
    }
    /*public void setImagexy()
    {
        this.Imagex= GO.GetComponent<Text>().transform.localPosition.x;
        this.Imagey= GO.GetComponent<Text>().transform.localPosition.y;
    }*/
    public void ShowImage()
    {
        print("ImageX为" + Imagex);
        print("ImageY为" + Imagey);
    }
    public void Setfinal()
    {
        this.Finaxl = Imagex - this.imagexl;
        this.Finaxr = Imagex + this.imagexr;
        this.Finayl = Imagey - this.imageyl;
        this.Finayr = Imagey + this.imageyr;
    }
    public void Click()
    {
        print(Finaxl + " " + Finaxr + " " + Finayl+" "+Finayr);

        if ((X > Finaxl) && (X < Finaxr) && (Y > Finayl) && (Y < Finayr))
        {
            print("点击了规定区域");
        }
    }

}
