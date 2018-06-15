package kr.ac.hansung.cse.controller;

import java.util.Locale;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

/**
 * Handles requests for the application home page.
 */
@Controller
public class HomeController {
	
	private static final Logger logger = LoggerFactory.getLogger(HomeController.class);
	
	@RequestMapping(value = "/", method = RequestMethod.GET)
	public String home(Locale locale, Model model) {
		
		return "index";
	}
	
	@RequestMapping("/grammar")
	public String grammarPage() {
		return "grammar";
	}
	
	@RequestMapping("/gPrint")
	public String gPrint() {
		return "gPrint";
	}
	
	@RequestMapping("/gInput")
	public String gInput() {
		return "gInput";
	}
	@RequestMapping("/gCond")
	
	public String gCond() {
		return "gCond";
	}
	
	@RequestMapping("/gLoop")
	public String gLoop() {
		return "gLoop";
	}
	
	@RequestMapping("/gOpe")
	public String gOpe() {
		return "gOpe";
	}
	
	@RequestMapping("/gType")
	public String gType() {
		return "gType";
	}

}
