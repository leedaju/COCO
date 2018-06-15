using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
using UnityEngine.UI;


public class LoadDB : MonoBehaviour
{
    // 싱글턴 인스턴스 선언
    public static LoadDB instance = null;

    // 데이터 가져오는 걸 요청하기 위한 PHP 주소
    private string urlText = "http://chocohsu.cafe24.com/TestL.php";

    // 텍스트 출력을 위한 객체 --> 배열로 바꾸기
    public Text mText0, mText1, mText2, mText3;
    public Text imgText, imgText2;
    public int i;
    // 이미지 출력을 위한 객체
    public RawImage img;

    void Awake()
    {    // 싱글턴 인스턴스 할당
        instance = this;
    }

    void Start()
    {
        StartCoroutine(GetData());
        i = Random.Range(0, 2);
    }

    // 데이터 정보를 요청하는 코루틴 함수
    public IEnumerator GetData()
    {
        WWW www = new WWW(urlText);
        yield return www;

        if (string.IsNullOrEmpty(www.error))
        {
       
            // 데이터를 표시하는 함수 호출
            DispData(www.text);
        }
        else
        {
            Debug.Log("Error : " + www.text);
        }
    }

     
    // JSON 파일을 파싱한 후 데이터를 표시
    void DispData(string strJsonData)
    {
        var N = JSON.Parse(strJsonData);

        // JSON 오브젝트의 배열에서 랜덤으로 선택

        Debug.Log(i);
        // 배열로 바꾸기
        string syntax0 = N[i]["syntax0"].ToString();
        string syntax1 = N[i]["syntax1"].ToString();
        string syntax2 = N[i]["syntax2"].ToString();
        string syntax3 = N[i]["syntax3"].ToString();
    
        Debug.Log(syntax0 + syntax1 + syntax2 + syntax3);

  
       


        string s1 = syntax0.Replace("\"", "");
        string s2 = s1.Replace("\\", "\"");

        mText0.text = s2;

        string s3 = syntax1.Replace("\"", "");
        string s4 = s3.Replace("\\", "\"");

        mText1.text = s4;


        string s5 = syntax2.Replace("\"", "");
        string s6 = s5.Replace("\\", "\"");

        mText2.text = s6;

        string s7 = syntax3.Replace("\"", "");
        string s8 = s7.Replace("\\", "\"");

        mText3.text = s8;
        

    }



    public IEnumerator LoadImg()
{
        string ur = "";
        if (i == 0)
        {
            ur = "http://chocohsu.cafe24.com/image/image1.jpg";
        }
        else
        {
            ur = "http://chocohsu.cafe24.com/image/image2.jpg";
        }
        WWW www = new WWW(ur);
    yield return www;
    Texture2D tt = www.texture;
    img.texture = tt;
}

}

