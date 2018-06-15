package kr.ac.hansung.cse.service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import kr.ac.hansung.cse.dao.ChocoDao;
import kr.ac.hansung.cse.model.Question;
import kr.ac.hansung.cse.model.Result;

@Service
public class ChocoService {
	
	@Autowired
	private ChocoDao chocoDao;
	
	public List<Question> getQuestions(){
		return chocoDao.getQuestions();
	}
	
	public List<Result> getResults(){
		return chocoDao.getResults();
	}
}
