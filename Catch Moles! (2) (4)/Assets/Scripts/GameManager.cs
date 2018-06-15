using UnityEngine;
using System.Collections;

public enum GameState
{
    Ready,
    Play,
    End
}

public class GameManager : MonoBehaviour {

    public GameState GS;                  // 게임매니져의 상태관리
                                          // GameManager class가 아닌 외부에 GameState라는 게임 상태의 종류를 선언 했기 때문에
                                          // GameManager 스크립트의 내부에서 사용하려면 GameState라는 타입으로 새롭게 변수를 선언해야한다.

    public Hole[] Holes;                // 구멍 스크립트들(배열로)
    public float LimitTime;             // 게임 제한 시간
    public GUIText TimeText;            // 게임 제한시간을 표기하기 위한 GUIText.

    public int Count_Bad;               // 틀린 두더지를 잡은 횟수
    public int Count_Good;              // 옳은 두더지를 잡은 횟수

    public GameObject FinishGUI;        // 결과화면을 보여주기 위한 오브젝트
    public GUIText Final_Count_Bad;     // 결과화면에서 틀린두더지를 잡은 숫자를 보여 주는 GUIText
    public GUIText Final_Count_Good;    // 결과화면에서 착한 두더지를 잡은 숫자를 보여 주는 GUIText
    public GUIText Final_Score;         // 결과화면에서 착한 두더지를 잡은 숫자를 보여 주는 GUIText

    public AudioClip ReadySound;        // 레디하는 경우에 플레이 할 사운드
    public AudioClip GoSound;           // 고하 는경우에 플레이 할 사운드
    public AudioClip FinishSound;       // 끝나고 결과화면이 나올 경우에 플레이 할 사운드

    void Start()
    {
        GetComponent<AudioSource>().clip = ReadySound;
        GetComponent<AudioSource>().Play();
    }

	public void GO(){

        GS = GameState.Play;
        GetComponent<AudioSource>().clip = GoSound;
        GetComponent<AudioSource>().Play();
    }

    // 매 프레임에서 실행되는 시점 함수
    void Update()
    {
        if (GS == GameState.Play)
        {
            LimitTime -= Time.deltaTime;
            if (LimitTime <= 0)
            {
                LimitTime = 0;
                // 게임이 끝나는 시점 --> 음수가 되면 종료되는
                End();

            }
        }

        // string.Format(필요값);
        // 필요값 --> ("보여줄 문자 {0}", {0}의 위치에 들어갈 문자열로 변환하고 싶은 값)
        //  N2 --> 소숫점 2자리 아래까지 보여주어라
        TimeText.text = string.Format("{0:N2}", LimitTime);
    }

	void End(){

		GS= GameState.End;
		Final_Count_Bad.text = string.Format("{0}",Count_Bad);  // 결과 화면에 보일 값들을 string으로 변환해서 대입
        Final_Count_Good.text = string.Format("{0}",Count_Good);
		Final_Score.text = string.Format("{0}",Count_Bad*100-Count_Good*200);
		FinishGUI.gameObject.SetActive(true); // GUI들을 Active시켜서 화면에 보이게 하는
		// audio.clip = FinishSound;
		// audio.Play();

	}
}
