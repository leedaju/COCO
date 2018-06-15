package kr.ac.hansung.cse.controller;

import java.util.List;


import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;

import kr.ac.hansung.cse.model.Question;
import kr.ac.hansung.cse.service.ChocoService;

@Controller
@RequestMapping("/admin")
public class AdminController {
	
	@Autowired
	private ChocoService chocoService;
	
	@RequestMapping
	public String AdminPage() {
		return "admin";
	}
	
	@RequestMapping("/questionInventory")
	public String getQuestion(Model model) { //Controller가 db조회에서 question정보가져와서 model에 넣어주면 getQuestion에서 display해준다.
		
		List<Question> questions = chocoService.getQuestions();
		model.addAttribute("questions",questions);
		
		return "questionInventory";
	}	
}
