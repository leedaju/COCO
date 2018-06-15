using UnityEngine;
using System.Collections;

public enum MoleState{
    // 5가지 구멍의 상태를 선언
    None,
    Open,
    Idle,
    Close,
    Catch

}

public class Hole : MonoBehaviour {

    // 두더지들의 상태 표기
    public MoleState MS;

    // 이미지들의 묶음 (여러개니까 배열 선언함) 맞는 문법 1
    public Texture[] Open_Images;
    public Texture[] Idle_Images;
    public Texture[] Close_Images;
    public Texture[] Catch_Images;

    // 어떤 두더지인지 체크하기 위한 값
    public bool GoodMole;
 

    public int PerGood = 30;  // 다른 두더지가 나올 확률을 위한 변수

    // 이미지들의 묶음 (잘못된 문법 1)
    public Texture[] Open_Images2;
    public Texture[] Idle_Images2;
    public Texture[] Close_Images2;
    public Texture[] Catch_Images2;


    // 애니메이션 속도 관리를 위한 변수들
    public float Ani_Speed;
    public float _now_ani_time;

    // 애니메이션 카운트
    int Ani_Count;

    // 사운드 플레이용
    public AudioClip Open_Sound;
    public AudioClip Catch_Sound;

	// 게임매니져에 접근하기 위한 용도의 변수
	public GameManager GM;


	void Update () {

        if (_now_ani_time >= Ani_Speed)
        {
            if (MS == MoleState.Open)
            {
                Open_Ing();  // 상태관리용 변수(MS)의 상태가 Open으로 바뀌었으니 Update문에서
                             // 언제든지 체크해서 Open_Ing를 실행하도록 한다.

            }

            if (MS == MoleState.Idle)
            {
                Idle_Ing();
            }

            if (MS == MoleState.Close)
            {
                Close_Ing();
            }

            if (MS == MoleState.Catch)
            {
                Catch_Ing();
            }

            _now_ani_time = 0;
        }
        else
        {
            _now_ani_time += Time.deltaTime;
        }

	}


    // Open 상태가 되었다고 알려주는 함수
    public void Open_On()
    {
        MS = MoleState.Open; // 스크립트의 상태를 Open으로 바꾸고
        Ani_Count = 0; // 애니메이션의 프레임 카운트를 0으로 만드는
        //audio.clip = Open_Sound;
        //audio.Play();

        int a = Random.Range(0, 100); // 0부터 100까지의 숫자 중에 하나를 뽑게 되는 변수

        if (a <= PerGood) // a가 옳은 두더지보다 나올 확률보다 작은지를 확인
        {
            GoodMole = true; // 확률보다 낮은 경우 옳은 두더지로
        }
        else
        {
            GoodMole = false; // 그렇지 않은 경우 틀린 두더지로
        }

		if(GM.GS == GameState.Ready){
			GM.GO ();
		}
    
    }

    // Open 상태가 진행되고 있다고 알려주는 함수
    public void Open_Ing()
    {
        if (GoodMole == false)  // Open_On 함수로 인해 상태가 바뀌게 되면  Open_Ing 함수가 지속적으로 실행
        {                                // 서로 다른 애니메이션을 재생
            GetComponent<Renderer>().material.mainTexture = Open_Images[Ani_Count];
        }
        else if (GoodMole)
        {
            GetComponent<Renderer>().material.mainTexture = Open_Images2[Ani_Count];
        }



        Ani_Count += 1; // 서로 다른 애니메이션을 재생

        if (Ani_Count >= Open_Images.Length) // 그림 갯수 (마지막장이 되면 실행)
        {
            // Open 애니메이션이 끝나는 시점
            // 그리고 Idle 상태로 (다음 스테이지) 넘어가라
            Idle_On();
        }
    }

    // Idle 상태가 되었다고 알려주는 함수
    public void Idle_On()
    {
        MS = MoleState.Idle;
        Ani_Count = 0;
    }

    // Idle 상태가 진행되고 있다고 알려주는 함수
    public void Idle_Ing()
    {
        if (GoodMole == false)
        {
            GetComponent<Renderer>().material.mainTexture = Idle_Images[Ani_Count];
        }
        else
        {
            GetComponent<Renderer>().material.mainTexture = Idle_Images2[Ani_Count];
        }

        Ani_Count += 1;

        if (Ani_Count >= Idle_Images.Length)
        {
            // Idle 애니메이션이 끝나는 시점
            Close_On();
        }
    }

    // Close 상태가 되었다고 알려주는 함수
    public void Close_On()
    {
        MS = MoleState.Close;
        Ani_Count = 0;
    }

    // Close 상태가 진행되고 있다고 알려주는 함수
    public void Close_Ing()
    {
        if (GoodMole == false) // 서로 다른 애니메이션을 재생
        {
            GetComponent<Renderer>().material.mainTexture = Close_Images[Ani_Count];
        }
        else
        {
            GetComponent<Renderer>().material.mainTexture = Close_Images2[Ani_Count];
        }

        Ani_Count += 1;

        if (Ani_Count >= Close_Images.Length)
        {
            // Close 애니메이션이 끝나는 시점
            // Close와 Catch 구문이 끝나는 시점에는 None으로 변경해야한다.

            StartCoroutine("Wait");
        }
    }

    // Catch 상태가 되었다고 알려주는 함수
    public void Catch_On()
    {
        MS = MoleState.Catch;
        Ani_Count = 0;
        // audio.clip = Catch_Sound;
       //  audio.Play();

		if(GoodMole==false){
			GM.Count_Bad+=1;
		}
		else
		{
			GM.Count_Good+=1;
		}
    }

    // Catch 상태가 진행되고 있다고 알려주는 함수
    public void Catch_Ing()
    { 
        if (GoodMole == false)  // 서로 다른 애니메이션을 재생
        {
            GetComponent<Renderer>().material.mainTexture = Catch_Images[Ani_Count];
        }
        else
        {
            GetComponent<Renderer>().material.mainTexture = Catch_Images2[Ani_Count];
        }
        Ani_Count += 1;

        if (Ani_Count >= Catch_Images.Length)
        {
            // Catch 애니메이션이 끝나는 시점
            StartCoroutine("Wait");
        }
    }

    public IEnumerator Wait()
    {
        MS = MoleState.None;
        Ani_Count = 0;
        float wait_Time = Random.Range(0.5f, 4.5f); // 랜덤으로 시간을 결정한다.
        yield return new WaitForSeconds(wait_Time);  //랜덤으로 정해진 시간만큼을 기다렸다가 그 다음 줄을 실행
        Open_On(); // 랜덤한 시간을 기다렸다가 Open_On을 해서 다시 애니메이션 상태로 돌린다.
       
    }

    public void OnMouseDown()
    {
        if (MS == MoleState.Idle || MS == MoleState.Open) // 두더지의 상태가 Idle, Open일 때 Catch가 가능
        {
            Catch_On();
        }
    }

}
