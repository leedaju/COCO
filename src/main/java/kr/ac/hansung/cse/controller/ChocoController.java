package kr.ac.hansung.cse.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;

import kr.ac.hansung.cse.model.Question;
import kr.ac.hansung.cse.model.Result;
import kr.ac.hansung.cse.service.ChocoService;

@Controller
public class ChocoController {

	@Autowired
	private ChocoService chocoService;
	
	@RequestMapping("/question")
	public String getQuestions(Model model) {
		
		List<Question> questions = chocoService.getQuestions();
	
		model.addAttribute("questions", questions);
		
		return "question";
	}
	
	@RequestMapping("/result")
	public String getResults(Model model) {
		
		List<Result> results = chocoService.getResults();
		model.addAttribute("results",results);
		
		return "result";
	}
	
}
