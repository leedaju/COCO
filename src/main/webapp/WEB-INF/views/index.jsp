<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<%@ page language="java" contentType="text/html; charset=UTF-8" pageEncoding="UTF-8"%>

<!doctype html>
<html lang="en">
<head>
<meta charset="utf-8">

<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
<meta name="description" content="">
<meta name="author" content="">

<title>CHOCO</title>
<!-- Bootstrap core CSS -->
<link href="<c:url value="/resources/css/bootstrap.min.css"/>" rel="stylesheet">
<!-- Custom styles for this template -->
<link href="<c:url value="/resources/css/carousel.css"/>" rel="stylesheet">
</head>

<body>
	<!-- logo & menu bar -->
	<header>
		<nav class="navbar navbar-expand-md navbar-dark fixed-top" style="background-color: #001d2d;">
			<a class="navbar-brand col-sm-3 col-md-2 mr-0" href="<c:url value="/" />"> 
				<img src="<c:url value="/resources/images/logo.png"/>" width="50%" height="50%" alt="logo">
			</a>
			<button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarCollapse" aria-controls="navbarCollapse"
				aria-expanded="false" aria-label="Toggle navigation">
				<span class="navbar-toggler-icon"></span>
			</button>
			<div class="collapse navbar-collapse" id="navbarCollapse">
				<ul class="navbar-nav mr-auto">
					<li class="nav-item active">
						<a class="nav-link" href="<c:url value="/"/>"> Home &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						 <span class="sr-only">(current)</span>
						</a>
					</li>
					<li class="nav-item active">
						<a class="nav-link" href="<c:url value="grammar"/>"> Game 
						 <span class="sr-only">(current)</span>
						</a>
					</li>
				</ul>
			</div>
		</nav>
	</header>
	<!-- logo & menu bar end 부분 -->
	<!-- 메인화면 맨 위 상단 welcome 부분 -->
	<div class="jumbotron p-3 p-md-5 text-white rounded" style="background: #1f3847;">
		<div class="col-md-6 px-0">
			<h1 class="display-6 font-italic">Welcome to Python Coding World!</h1>
		</div>
	</div>
	<!-- 메인화면 맨 위 상단 welcome end 부분 -->
	<!-- 게임 이미지 & 게임 설명부분 -->
	<main role="main"> 
	<br>
	<div class="container marketing">
		<div class="row">
			<!-- 출력문  -->
			<div class="col-md-4">
				<div class="card mb-4 box-shadow">
					<img class="card-img-top" src="<c:url value="/resources/images/print.PNG"/>" alt="game1img" width=348px; height=243px;>
					<div class="card-body">
						<p class="card-text">
							<h2>출력문</h2>
							드래그 앤 드롭을 사용하여 파이썬 언어의 출력구문을 익히는 게임입니다. 앞의 설명을 보고 블럭을 옮겨 순서에 맞게 배열해보세요! 정답을 맞추면 깃발이 뽑히고 소스와 결과창이 출력됩니다.
						<br><br><br>
						</p>
					</div>
				</div>
			</div>
			<!-- 출력문 end 부분 -->
			<!-- 입력문 -->
			<div class="col-md-4">
				<div class="card mb-4 box-shadow">
					<img class="card-img-top" src="<c:url value="/resources/images/input.PNG"/>" alt="inputgame" width=348px; height=243px;>
					<div class="card-body">
						<p class="card-text">
						<h2>입력문</h2>
						출력문을 배울 때 했던 게임과 비슷한 게임입니다. 블럭을 옮겨서 문법에 알맞게 배열해보세요. 아무것도 들어가지 않는 곳에는 '빈칸' 블럭을 꼭 넣어주어야해요. 빈칸을 다 맞추면 깃발이 뽑힙니다. 하지만 끝이 아니에요! 질문에 대한 답까지 직접 입력하여 입력문에 대해 완전히 익혀보세요!
						</p>
					</div>
				</div>
			</div>
			<!-- 입력문 end 부분 -->
			<!-- 조건문 -->
			<div class="col-md-4">
				<div class="card mb-4 box-shadow">
					<img class="card-img-top" src="<c:url value="/resources/images/cond.PNG"/>" alt="game2img" width=348px; height=243px;>
					<div class="card-body">
						<p class="card-text">
						<h2>조건문</h2>
						앞서 배운 출력문, 입력문과 같은 방식의 게임입니다. if가 들어가는 조건문을 배우고 순서에 따라 블록을 맞춰주세요! 한 칸씩 맞추다보면 금세 깃발을 뽑을 수 있을 거예요! <br><br><br><br>
						</p>
					</div>
				</div>
			</div>
			<!-- 조건문 end 부분 -->
			<!-- 반복문 -->
			<div class="col-md-4">
				<div class="card mb-4 box-shadow">
					<img class="card-img-top" src="<c:url value="/resources/images/loop.PNG"/>" alt="inputgame" width=348px; height=243px;>
					<div class="card-body">
						<p class="card-text">
						<h2>반복문</h2>
						for가 들어가는 반복문의 쓰임새를 익히는 게임입니다. 결과창을 보고 왼쪽의 소스창의 빈 칸을 채워보세요! 코딩실력은 물론 사고력까지 키울 수 있답니다. <br><br><br><br>
						</p>
					</div>
				</div>
			</div>
			<!-- 반복문 end 부분 -->
			<!-- 연산자 -->
			<div class="col-md-4">
				<div class="card mb-4 box-shadow">
					<img class="card-img-top" src="<c:url value="/resources/images/game2.PNG"/>" alt="game2img" width=348px; height=243px;>
					<div class="card-body">
						<p class="card-text">
						<h2>연산자</h2>
						연산자를 이용하여 맞게 계산식을 세운 양과 틀리게 계산식을 세운 표범 중에 양만을 선택하는 게임! 일종의 두더지 게임과 비슷해요. 다만 위에 식이 있으니 잘 익히고 모르는 것을 파악하면 좋을 것 같아요. 마지막에 몇 개나 맞추었는지 점수 까지 알려줍니다! 눈을 크게 뜨고 선택해보세요!
						</p>
					</div>
				</div>
			</div>
			<!-- 연산자 end 부분 -->
			<!-- 자료형 -->
			<div class="col-md-4">
				<div class="card mb-4 box-shadow">
					<img class="card-img-top" src="<c:url value="/resources/images/game6.PNG"/>" alt="game6img" width=348px; height=243px;>
					<div class="card-body">
						<p class="card-text">
						<h2>자료형</h2>
						짝 맞추기 게임이에요. 단순해보이지만 정확하게 알지 못하면 틀린답니다. 먼저 문자형 카드를 누른 뒤에 그에 걸맞는 나머지 카드를 선택하세요. 짝이 맞춰지면 카드는 사라집니다. 다시하기를 누르면 문제가 나오니 여러번 해 보세요. 짝을 다 맞추면 성공입니다!
						</p>
					</div>
				</div>
			</div>
			<!-- 자료형 end 부분 -->
		</div>
	</div>
</main>
<!-- 게임이미지&게임설명 end 부분 -->

	<!-- Bootstrap core JavaScript
    ================================================== -->
	<!-- Placed at the end of the document so the pages load faster -->
	<script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
	<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
	<script src="<c:url value="/resources/js/bootstrap.min.js"/>"></script>
	<!-- Just to make our placeholder images work. Don't actually copy the next line! -->
</body>
</html>
