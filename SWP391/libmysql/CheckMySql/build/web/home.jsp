<%-- 
    Document   : home
    Created on : Jan 14, 2024, 5:02:06 PM
    Author     : Fpt
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!doctype html>
<html class="no-js" lang="">


<!-- Mirrored from affixtheme.com/html/xmee/demo/register-22.html by HTTrack Website Copier/3.x [XR&CO'2014], Mon, 08 Jan 2024 17:00:34 GMT -->

<head>
    <meta charset="utf-8">
    <meta http-equiv="x-ua-compatible" content="ie=edge">
    <title>SCN | Home</title>
    <meta name="description" content="">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- Favicon -->
    <link rel="shortcut icon" type="image/x-icon" href="img/logo.png">
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <!-- Fontawesome CSS -->
    <link rel="stylesheet" href="css/fontawesome-all.min.css">
    <!-- Flaticon CSS -->
    <link rel="stylesheet" href="font/flaticon.css">
    <!-- Star Animation CSS -->
    <link rel="stylesheet" href="css/star-animation.css">
    <!-- Google Web Fonts -->
    <link href="https://fonts.googleapis.com/css?family=Roboto:300,400,500,700&amp;display=swap" rel="stylesheet">
    <!-- Custom CSS -->
    <link rel="stylesheet" href="css/home.css">



</head>

<body>
    <!-- Thanh nav -->
    <nav class="navbar navbar-expand-lg navbar-dark">
        <div class="container-fluid .no-padding-margin">
            <!-- Brand and toggle get grouped for better mobile display -->
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav"
                aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>

            <div class="collapse navbar-collapse" id="navbarNav">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-lg-2 navbar-list-option-left">
                            <!-- <img src="img/logo.png" alt=""> -->
                            <form class="d-flex nav-search">
                                <input class="form-control" type="search" placeholder="Search" aria-label="Search">
                                <button class="btn btn-outline-light" type="submit"
                                    style="border-radius: 0px 5px 5px 0px;"><i class="fas fa-search"></i></button>
                            </form>
                        </div>
                        <div class="col-lg-8 navbar-list-option-mid">
                            <ul class="navbar-nav">

                                <li class="nav-item">
                                    <a class="nav-link active" href="home.html"><i class="fas fa-home"></i></a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link active" href="home.html"><i class="far fa-calendar-alt"></i></a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link active" href="home.html"><i class="fas fa-store"></i></a>
                                </li>
                                <li class="nav-item">
                                    <a class="nav-link active" href="group.html"><i class="fas fa-users"></i></a>
                                </li>
                            </ul>
                        </div>
                        


                    </div>
                </div>

            </div><!-- /.navbar-collapse -->
            <div class="col-lg-2 navbar-list-option-right">
                <ul class="navbar-nav">

                    
                    <li class="nav-item">
                        <a class="nav-link active" href="home.html"><i class="fas fa-bell"></i></a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link active" href="login.html" id="link"><i
                                class="fas fa-sign-out-alt"></i></a>
                    </li>
                </ul>
            </div>
        </div><!-- /.container-fluid -->
        
    </nav>
    <!-- End Nav -->

    <div class="container-fluid body-content">
        <div class="row">
            <!-- left nav -->
            <div class="col-lg-2 body-content-left no-padding-margin">
                <div><a href="" class="body-content-left-avatar"><img src="img/avatar1.jpg">Tran Quang Tung</a></div>
                
                
                <div><a href=""><i class="fas fa-store"></i><span>Maretplace</span></a></div>
                <div><a href=""><i class="fas fa-history"></i><span>Celebrate</span></a></div>
                <div><a href="group.html"><i class="fas fa-users"></i><span>Group</span></a></div>
                <div><a href=""><i class="far fa-comment-dots"></i><span>Messages</span></a></div>
                <div><a href=""><i class="fas fa-user-cog"></i><span>Setting</span></a></div>
            </div>
            <!-- End left nav -->
            <div class="col-lg-2">

            </div>
            <!-- Content -->
            <div class="col-lg-10 content-post" >
                <!-- Start post status -->
                <div class="calendar-embedded" >
                    <iframe src="calendar.html" frameborder="0"></iframe>
                </div>
                    
              
                
                


            </div>
            
        </div>
    </div>




    </div>
    <!-- jquery-->
    <script src="js/jquery.min.js"></script>
    <!-- Bootstrap js -->
    <script src="js/bootstrap.min.js"></script>
    <!-- Imagesloaded js -->
    <script src="js/imagesloaded.pkgd.min.js"></script>
    <!-- Validator js -->
    <script src="js/validator.min.js"></script>
    <!-- Custom Js -->
    <script src="js/main.js"></script>
    <script>
        function toggleLike(btn) {
            btn.classList.toggle('liked');
        }
        document.getElementById('link').addEventListener('click', function (event) {
            var confirmation = confirm('Are you sure want to sign-out?');
            if (!confirmation) {
                event.preventDefault(); // Ngăn chặn chuyển hướng mặc định của thẻ a
            }
        });
    </script>

</body>


<!-- Mirrored from affixtheme.com/html/xmee/demo/register-22.html by HTTrack Website Copier/3.x [XR&CO'2014], Mon, 08 Jan 2024 17:00:34 GMT -->

</html>
