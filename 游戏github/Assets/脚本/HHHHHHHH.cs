using UnityEngine;

using System.Collections;

public class HHHHHHHH : MonoBehaviour
{

    public GUIStyle progressbar_bj;   //背景图

    public GUIStyle progressbar_qj;   //前景图

    public GameObject obj;

    WWW www;

    bool loading = true;

    public Texture img;

    float Length = 0;

    void Start()
    {

        StartCoroutine(ABC("[img]http://images.earthcam.com/ec_metros/ourcams/fridays.jpg[/img]"));


}

    // Update is called once per frame

    void Update()

    {

        if (!www.isDone)

        {

            print(www.progress);

            loading = true;

        }

        else

        {

            loading = false;

            obj.GetComponent<Renderer>().material.mainTexture = www.texture;

            www = null;

        }

    }

    void OnGUI()

    {

        //~ GUI.Skin=big;

        if (loading)

        {

            GUI.Label(new Rect(100, 30, 200, 30),"", progressbar_bj);

            GUI.Label(new Rect(100, 30, www.progress * 200, 30),"", progressbar_qj);

            GUI.Label(new Rect(150, 35, 200, 30),"Loading:    "+(www.progress * 100).ToString().Substring(0, 2) +"%");

        }

    }

    public IEnumerator ABC(string URL)

    {

        www = new WWW(URL);

        yield return www;

    }

}