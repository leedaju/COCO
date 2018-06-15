using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using UnityEngine.UI;

public class LoadData : MonoBehaviour {

    public static LoadData instance = null;

    private string Loadurl;
    private string Sendurl;

    public Text Mtext;
    public Text OutText, OutText2;
    public InputField Send;
    public RawImage Img;
    public int i;

    void Awake()
    {
        instance = this;
    }
    void Start () {
        Loadurl = "http://chocohsu.cafe24.com/InputTest.php";
        Sendurl = "http://chocohsu.cafe24.com/SendInput.php";
        StartCoroutine(GetData());
        i = Random.Range(0, 2);
    }
	
    public IEnumerator GetData()
    {
        WWW www = new WWW(Loadurl);
        yield return www;

        if (string.IsNullOrEmpty(www.error))
        {
            DispData(www.text);
        } else
        {
            Debug.Log("error: " + www.text);
        }
    }

    void DispData(string strJsonData)
    {
        var N = JSON.Parse(strJsonData);

        Debug.Log(i);

        string syntax3 = N[i][5].ToString();

        Debug.Log(syntax3);
        string Question = syntax3.Replace("\"", "");
        string Question2 = Question.Replace("\\", "\"");
        Mtext.text = Question2;
    }

    public void SendBtn()
    {
        StartCoroutine(SendCo());
        StartCoroutine(LoadImg());
       
    }

    IEnumerator SendCo()
    {
        WWWForm form = new WWWForm();
        form.AddField("result", Send.text);

        WWW webRequest = new WWW(Sendurl, form);

        yield return webRequest;
        OutText.text = Send.text;
        OutText2.text = Send.text;
    }
    public IEnumerator LoadImg()
    {
        string ur = "";

        if (i==0)
        {
            ur = "http://chocohsu.cafe24.com/image/image5.jpg"; 
        }
        else if (i==1)
        {
            ur = "http://chocohsu.cafe24.com/image/image6.jpg";
        }

        WWW www = new WWW(ur);
        yield return www;
        Texture2D texT = www.texture;
        Img.texture = texT;

    }






}

