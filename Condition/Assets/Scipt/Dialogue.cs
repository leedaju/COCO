using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{



	[TextArea(3, 10)] // 문장 입력칸의 크기로 Textfield 이탈의 방지를 위해 설정
	public string[] sentences; // 문장의 List



}