package kr.ac.hansung.cse.dao;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.List;

import javax.sql.DataSource;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.jdbc.core.JdbcTemplate;
import org.springframework.jdbc.core.RowMapper;
import org.springframework.stereotype.Repository;

import kr.ac.hansung.cse.model.Question;
import kr.ac.hansung.cse.model.Result;

@Repository
public class ChocoDao {
	private JdbcTemplate jdbcTemplate;
	
	@Autowired
	public void setDataSource(DataSource dataSource) {
		jdbcTemplate = new JdbcTemplate(dataSource);
	}
	
	public List<Question> getQuestions(){
		String sqlStatement = "select * from question";
		
		return jdbcTemplate.query(sqlStatement, new RowMapper<Question>() {
			
			@Override
			public Question mapRow(ResultSet rs, int rowNum) throws SQLException{
				
				Question question = new Question();
				
				question.setQ_no(rs.getInt("q_no"));
				question.setQ_type(rs.getString("q_type"));
				question.setG_type(rs.getString("g_type"));
				question.setSourceimg(rs.getString("sourceimg"));
				question.setPrintimg(rs.getString("printimg"));
				return question;
			}
		});
	}
	
	public List<Result> getResults(){
		String sqlStatement = "select * from result";
		
		return jdbcTemplate.query(sqlStatement, new RowMapper<Result>() {
			
			@Override
			public Result mapRow(ResultSet rs, int rowNum) throws SQLException{
				Result result = new Result();
				
				result.setQ_no(rs.getInt("q_no"));
				result.setI_no(rs.getInt("i_no"));
				result.setItem(rs.getString("item"));
				
				return result;
			}
		});
	}
}
