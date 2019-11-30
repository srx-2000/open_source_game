using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class 语言链接 : MonoBehaviour
{
    // Update is called once per frame
    public void project() {
        SceneManager.LoadScene("电脑编程页面");
    }
    public void e()
    {
        SceneManager.LoadScene("e页面");
    }
    public void google()
    {
        SceneManager.LoadScene("谷歌页面");
    }
    public void shop()
    {
        SceneManager.LoadScene("商城界面");
    }
    public void wangyiyinyue()
    {
        SceneManager.LoadScene("网易云音乐界面");
    }
    public void back()
    {
        SceneManager.LoadScene("程序员可点击版初始页面");
    }
    public void back_to_screen()
    {
        SceneManager.LoadScene("电脑屏幕");
    }
    public void python()
    {
        SceneManager.LoadScene("python");
    }
    public void c()
    {
        SceneManager.LoadScene("find");
    }
    public void eclipse()
    {
        SceneManager.LoadScene("eclipse");
    }
    public void php()
    {
        SceneManager.LoadScene("php");
    }
}
