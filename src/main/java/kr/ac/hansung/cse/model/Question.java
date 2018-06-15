package kr.ac.hansung.cse.model;

import org.springframework.web.multipart.MultipartFile;

import lombok.Getter;
import lombok.Setter;
import lombok.ToString;

@Getter
@Setter
@ToString
public class Question {
	private int q_no;
	private String q_type;
	private String g_type;
	private String sourceimg; // db에서 파일명 읽어와서 출력할것
	private String printimg;
	private MultipartFile sImage;  //해당 column이미지에 대한 정보 저장
	private MultipartFile pImage;
}
