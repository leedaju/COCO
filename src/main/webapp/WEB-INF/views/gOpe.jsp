<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>

<!doctype html>
<html lang="en">
<head>
<meta charset="utf-8">

<meta name="viewport"
	content="width=device-width, initial-scale=1, shrink-to-fit=no">
<meta name="description" content="">
<meta name="author" content="">

<title>CHOCO</title>

<!-- Bootstrap core CSS -->
<link href="<c:url value="/resources/css/bootstrap.min.css"/>" rel="stylesheet">
<!-- Custom styles for this template -->
<link href="<c:url value="/resources/css/carousel.css"/>" rel="stylesheet">
<link href="<c:url value="/resources/css/main.css"/>" rel="stylesheet">
<!-- unity css -->
<link rel="stylesheet" href="<c:url value="/resources/css/style.css"/>">
<!-- unity js -->
<script src="<c:url value="/resources/ojs/UnityProgress.js"/>"></script>
<script src="<c:url value="/resources/ojs/UnityLoader.js"/>"></script>
<!-- 연산자 game 불러오기 -->
<script>
	var gameInstance = UnityLoader.instantiate("gameContainer",
			"/resources/build/OperateWebGL.json", {
				onProgress : UnityProgress
			});
</script>
</head>

<body>
	<!-- logo & menu bar -->
	<header>
		<nav class="navbar navbar-expand-md navbar-dark fixed-top" style="background-color:#001d2d;">
  		<a class="navbar-brand col-sm-3 col-md-2 mr-0" href="<c:url value="/" />">
  			<img src="<c:url value="/resources/images/logo.png"/>" width="50%" height="50%"  alt="logo">
  		</a>
			<button class="navbar-toggler" type="button" data-toggle="collapse"
				data-target="#navbarCollapse" aria-controls="navbarCollapse"
				aria-expanded="false" aria-label="Toggle navigation">
				<span class="navbar-toggler-icon"></span>
			</button>
			<div class="collapse navbar-collapse" id="navbarCollapse">
				<ul class="navbar-nav mr-auto">
					<li class="nav-item active"><a class="nav-link"
						href="<c:url value="/"/>"> Home
							&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="sr-only">(current)</span>
					</a></li>

					<li class="nav-item active"><a class="nav-link"
						href="<c:url value="grammar"/>" style="font-weight: 900;">
							Game <span class="sr-only">(current)</span>
					</a></li>
				</ul>
			</div>
		</nav>
	</header>
	<!-- logo & menu bar end 부분 -->
	<!-- side bar -->
	<div class="container-fluid">
		<div class="row">
			<div class="col-md-2 d-none d-md-block sidebar"
				style="background: #1f3847;">
				<div class="sidebar-sticky" style="padding: 10px 0 0 10px;">
					<ul class="nav flex-column"
						style="margin: 10px 0 0 10px; height: 1000px">
						<li class="nav-item" style="font-weight: 900; font-size: large;"><a class="nav-link active" href="<c:url value="grammar"/>" style="color: #FFFFFF;"> 
							<span data-feather="home"></span>
								Grammar <span class="sr-only">(current)</span>
						</a></li>
						<li class="nav-item"><a class="nav-link active" href="<c:url value="gPrint"/>"
							style="color: #FFFFFF;"> <span data-feather="home"></span>
								출력문 <span class="sr-only">(current)</span>
						</a></li>
						<li class="nav-item"><a class="nav-link" href="<c:url value="gInput"/>"
							style="color: #FFFFFF;"> <span data-feather="file"></span>
								입력문
						</a></li>
						<li class="nav-item"><a class="nav-link" href="<c:url value="gCond"/>"
							style="color: #FFFFFF;"> <span data-feather="shopping-cart"></span>
								조건문
						</a></li>
						<li class="nav-item"><a class="nav-link" href="<c:url value="gLoop"/>"
							style="color: #FFFFFF;"> <span data-feather="users"></span>
								반복문
						</a></li>
						<li class="nav-item"><a class="nav-link" href="<c:url value="gOpe"/>"
							style="color: #FFFFFF; font-weight: 900; font-size: large;"> <span data-feather="bar-chart-2"></span>
								연산자
						</a></li>
						<li class="nav-item"><a class="nav-link" href="<c:url value="gType"/>"
							style="color: #FFFFFF;"> <span data-feather="layers"></span>
								자료형
						</a></li>
					</ul>
				</div>
			</div>
		</div>
	</div>
	<!-- side bar end 부분 -->
	<!-- unity game 위치 & 크기 지정 -->
	<div class="webgl-content">
	<br>
		<div id="gameContainer" style="margin-left:1%; width: 1024px; height: 768px"></div>
		<div class="footer">
			<div class="fullscreen" onclick="gameInstance.SetFullscreen(1)"></div>
		</div>
	</div>
	<!-- unity game 위치 & 크기 지정 end 부분 -->
	<!-- Bootstrap core JavaScript
    ================================================== -->
	<!-- Placed at the end of the document so the pages load faster -->
	<script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN"
		crossorigin="anonymous"></script>
	<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"
		crossorigin="anonymous"></script>
	<script src="<c:url value="/resources/js/bootstrap.min.js"/>"></script>
	<!-- Just to make our placeholder images work. Don't actually copy the next line! -->
</body>
</html>
