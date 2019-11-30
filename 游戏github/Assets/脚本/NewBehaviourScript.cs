using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class globl
{

    public static string nextSceneName;
}

public class testmain : MonoBehaviour
{
    public Text loadingText1;
    public Image progressBar1;
    public Text loadingText2;
    public Image progressBar2;
    public static int curProgressValue = 0;
    public static int curProgressValue1 = 0;
    public static int curProgressValue2 = 0;
    private AsyncOperation operation;
    private float starttime = 0.1f;
    private float nextime = 0.0f;
    public string startscene;
    private string finallyscene;
    public string finallyscene1;
    public string finallyscene2;
    public int addvalue1;
    public int addvalue2;

    //private bloodtiao b = new bloodtiao(); 
    // Use this for initialization
    int change(int curProgressValue, int addvalue)
    {
        if (curProgressValue < 100 && Time.time > nextime)
        {
            curProgressValue += addvalue;
            nextime = Time.time + starttime;
        }
        return curProgressValue;
    }
    void Start()
    {
        if (SceneManager.GetActiveScene().name == startscene)
        {
            //启动协程
            if (addvalue1 > addvalue2)
                StartCoroutine(AsyncLoading(finallyscene1));
            else
                StartCoroutine(AsyncLoading(finallyscene2));
        }
    }

    IEnumerator AsyncLoading(string finallyscene)
    {
        operation = SceneManager.LoadSceneAsync(finallyscene);
        //阻止当加载完成自动切换
        operation.allowSceneActivation = false;

        yield return operation;
    }


    // Update is called once per frame
    void Update()
    {
        int a = change(curProgressValue1, addvalue1);
        int b = change(curProgressValue2, addvalue2);
        loadingText1.text = a + "%";//实时更新进度百分比的文本显示  

        progressBar1.fillAmount = a / 100f;//实时更新滑动进度图片的fillAmount值  

        loadingText2.text = b + "%";//实时更新进度百分比的文本显示  

        progressBar2.fillAmount = b / 100f;//实时更新滑动进度图片的fillAmount值  
        if (addvalue1 > addvalue2)
            curProgressValue = change(curProgressValue1, addvalue1);
        else
            curProgressValue = change(curProgressValue2, addvalue2);
        if (curProgressValue == 100)
        {
            operation.allowSceneActivation = true;//启用自动加载场景    
        }
    }
}
