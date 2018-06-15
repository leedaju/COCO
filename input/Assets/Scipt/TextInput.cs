//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//public class TextInput : MonoBehaviour
//{

//    // 싱글턴 인스턴스 선언
//    public static TextInput instance = null;

//    public InputField Send; // 데이터를 보내는 인풋필드
//    private string Sendurl; // 결과물 보내는 url
//    public Text Mtext; // 문제 
//    public RawImage OutImg; // 이미지
//    public Text OutText, OutText2; // 보낸 데이터 바로 출력
//    public int i;



//    void Awake()
//    {    // 싱글턴 인스턴스 할당
//        instance = this;
//    }
//    void Start()
//    {
//        Sendurl = "http://chocohsu.cafe24.com/SendInput.php";
//        i = Random.Range(0, 2);
//        Ran();
//    }



//    // Update is called once per frame
//    public int Ran()
//    {

//        if (i == 0)
//        {
//            Mtext.text = "(\"나이를 입력하세요\")";
//        }
//        else
//        {
//            Mtext.text = "(\"이름을 입력하세요\")";
//        }
//        Debug.Log(i);
//        return i;
//    }


//    public void SendBtn()
//    {
//        StartCoroutine(SendCo());
//        StartCoroutine(LoadImg());
//    }

//    IEnumerator SendCo()
//    {
//        WWWForm form = new WWWForm();
//        form.AddField("result", Send.text);

//        WWW webRequest = new WWW(Sendurl, form);

//        yield return webRequest;
//        OutText.text = Send.text;
//        OutText2.text = Send.text;
//    }

//    public IEnumerator LoadImg()
//    {
//        string ur = "";
//        if (i == 0)
//        {
//            ur = "http://chocohsu.cafe24.com/image/image5.jpg";
//        }
//        else if (i == 1)
//        {
//            ur = "http://chocohsu.cafe24.com/image/image6.jpg";
//        }

//        WWW www = new WWW(ur);
//        yield return www;
//        Texture2D texT = www.texture;
//        OutImg.texture = texT;
//    }
//}
