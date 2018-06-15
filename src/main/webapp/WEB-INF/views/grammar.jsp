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
<link href="<c:url value="/resources/css/main.css"/>" rel="stylesheet">
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
	<!-- logo & menu bar end -->
	<div class="container-fluid">
		<div class="row">
			<!-- side bar -->
			<div class="col-md-2 d-none d-md-block sidebar"
				style="background: #1f3847;">
				<div class="sidebar-sticky" style="padding: 10px 0 0 10px;">
					<ul class="nav flex-column" style="margin: 10px 0 0 10px; height: 1000px">
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
							style="color: #FFFFFF;"> <span data-feather="bar-chart-2"></span>
								연산자
						</a></li>
						<li class="nav-item"><a class="nav-link" href="<c:url value="gType"/>"
							style="color: #FFFFFF;"> <span data-feather="layers"></span>
								자료형
						</a></li>
					</ul>
				</div>
			</div>
			<!-- side bar end -->
			<!-- map (지도모형 메뉴) -->
			<main class="col-md-9 ml-sm-auto col-lg-10 pt-3 px-4">
        		<div class="d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pb-2 mb-3 border-bottom" onclick="showmouse(event)">      		
            		<img class="map" src="<c:url value="/resources/images/map.png"/>" alt="map">
            		<a href="<c:url value="gPrint"/>">
            		<img class="sign1" src="<c:url value="/resources/images/1.png"/>" alt="1" onmouseover='this.src="<c:url value="/resources/images/printc.png"/>"'
            			onmouseout='this.src="<c:url value="/resources/images/1.png"/>"'></a>
            		<a href="<c:url value="gInput"/>">
            		<img class="sign2" src="<c:url value="/resources/images/2.png"/>" alt="2" onmouseover='this.src="<c:url value="/resources/images/inputc.png"/>"'
            			onmouseout='this.src="<c:url value="/resources/images/2.png"/>"'></a>
            		<a href="<c:url value="gCond"/>">
            		<img class="sign3" src="<c:url value="/resources/images/3.png"/>" alt="3" onmouseover='this.src="<c:url value="/resources/images/condc.png"/>"'
            			onmouseout='this.src="<c:url value="/resources/images/3.png"/>"'></a>
            		<a href="<c:url value="gLoop"/>">
            		<img class="sign4" src="<c:url value="/resources/images/4.png"/>" alt="4" onmouseover='this.src="<c:url value="/resources/images/loopc.png"/>"'
            			onmouseout='this.src="<c:url value="/resources/images/4.png"/>"'></a>
            		<a href="<c:url value="gOpe"/>">
            		<img class="sign5" src="<c:url value="/resources/images/5.png"/>" alt="5" onmouseover='this.src="<c:url value="/resources/images/opec.png"/>"'
            			onmouseout='this.src="<c:url value="/resources/images/5.png"/>"'></a>
            		<a href="<c:url value="gType"/>">
            		<img class="sign6" src="<c:url value="/resources/images/6.png"/>" alt="6" onmouseover='this.src="<c:url value="/resources/images/charc.png"/>"'
            			onmouseout='this.src="<c:url value="/resources/images/6.png"/>"'></a>
				</div>
			</main>
			<!-- map (지도모형 메뉴) end -->
		</div>
	</div>
	<!-- Bootstrap core JavaScript
    ================================================== -->
	<!-- Placed at the end of the document so the pages load faster -->
	<script src="https://code.jquery.com/jquery-3.2.1.slim.min.js"
		integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN"
		crossorigin="anonymous"></script>
	<script
		src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"
		integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"
		crossorigin="anonymous"></script>
	<script src="<c:url value="/resources/js/bootstrap.min.js"/>">
		
	</script>
	<!-- Just to make our placeholder images work. Don't actually copy the next line! -->
</body>
</html>