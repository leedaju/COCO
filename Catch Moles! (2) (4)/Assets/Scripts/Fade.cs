using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// GUITexture를 FadeIn 시키거나 FadeOut 시킬 수 있는 역할을 한다.
// 게임을 시작할 때 화면이 어두워졌다가 점점 밝아지는 것 : FadeIn 효과

public class Fade : MonoBehaviour
{
   GUITexture Image;
   //Texture Image;
    public float Fade_Time = 2f; // Fade 효과가 진행되는 시간
    public float Fade_Max = 1f; // Fade 효과의 진하기. 0-1까지 값을 넣을 수 있으며 0은 가장 투명한 상태이고 1은 가장 어두운 상태
    float _time;
	public bool FadeIn_ing = true;
	public bool FadeOut_ing;

	void Start ()
	{
		Image = GetComponent<GUITexture> ();
        //Image = GetComponent<Texture>();
    }

	void Update ()
	{
        if (FadeIn_ing)
        {
            _time += Time.deltaTime;
            Image.color = Color.Lerp(new Color(Image.color.r, Image.color.g, Image.color.b, Fade_Max), new Color(Image.color.r, Image.color.g, Image.color.b, 0), _time / Fade_Time);
        }

        if (FadeOut_ing)
        {
            _time += Time.deltaTime;
            Image.color = Color.Lerp(new Color(Image.color.r, Image.color.g, Image.color.b, 0), new Color(Image.color.r, Image.color.g, Image.color.b, Fade_Max), _time / Fade_Time);
        }

        if (_time >= Fade_Time) {
			_time = 0;
			FadeIn_ing = false;
			FadeOut_ing = false;
		}
	}

	public void FadeIn ()
	{
		FadeIn_ing = true;
	}

	public void FadeOut ()
	{
		FadeOut_ing = true;
	}
}