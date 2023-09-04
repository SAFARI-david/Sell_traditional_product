*{
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    text-decoration: none;
    text-transform: capitalize;
   
}
html{
    font-size: 62.5%;
    scroll-behavior: smooth;
    overflow-x: hidden;
}
.header{
    position: fixed;
    padding: 2rem 7%;
    justify-content: space-between;
    display:flex;
    /* align-items: center; */
    width: 100%;
   
}
.headers{
    /* position: fixed; */
    padding: 2rem 7%;
    justify-content: space-between;
    display:flex;
    /* align-items: center; */
    width: 100%;
    height: 9vh;
    padding-top: 0px;
    padding-left: 50px;
    background-color: rgb(8, 0, 255,50%)
}
#logo{
    font-size: 3.5rem;
    color: white;
}
#logo img{
    height: 8vh;
    width: 15vh;
    border-radius: 20%;
}
#logo a{
    text-decoration: none;
}
#logo a:hover{
    background-color: orange;
    text-decoration: none;
}
#logo span{
    color: orange;
}
.icons #menu-bars{
    color: orange;
    font-size: 4rem;
}
.iconss #menu-bars{
    color: rgb(255, 255, 255);
    font-size: 4rem;
}

.navbar{
    position: absolute;
    /* top: 50px; */
    left: -300%;
    right: -100%;
    width: 80%;
    height: 10vh;
    background-color: orange;
    color: rgb(0, 0, 0);
    padding: 10px;
    transition: .5s;
    margin-left: 50px;
    
}

.navbar.active{
    left: 0%;
}
.navbar a{
    /* display: block; */
    margin: 1rem;
    padding: 1rem;
    color: rgb(0, 0, 0);
    font-size: 1.5rem;
    text-decoration: none;
    left: 0%;
    font-size: 20px;

}
.inner-text-background h1{
    color: white;
    font-size: 30px
}
.inner-text-background h2{
    color:orange;
    font-size: 30px
}
.inner-text-background h3{
    color: white;
    font-size: 14px
}
.conference{
    padding: 3rem 7%;
    flex: 1;
  overflow-y: scroll;
  max-height: 80vh;
   
}
.confere{
    padding: 3rem 7%;
    flex: 1;
}
.confere h1{
    color: black;
    text-align: center;
    font-size: 40px;
    margin-bottom: 12px;
}
.confere h1 span{
    color: rgb(255, 166, 0,0.5);
}
.conference h1{
    color: black;
    text-align: center;
    font-size: 40px;
    margin-bottom: 12px;
}
.conference h1 span{
    color: rgb(255, 166, 0,0.5);
}
.mainconference{
   /* background-color: rgb(255, 0, 0); */
    display: flex;
    justify-content: center;
    flex-wrap: wrap;   
    gap: 10px;
    
    
}
.mainconference .innerr h1{
    text-align: left;
}
.mainconference .innerr h2{
    text-align: left;
}
.mainconference .innerr .myview a{
    font-size: 22px;
    margin-top: 5px;
}
.innerconference{
    flex: 1 1 300px;
    padding: 2rem 3rem;
    text-align: center;
    /* box-shadow: rgb(12, 11, 11); */
    /* border-left: 2px solid rgba(19, 18, 18, 0.1); */
    /* border-bottom: 2px solid rgba(0, 0, 0, 0.1);; */
    border-radius: 10px;
    /* box-shadow: 0 0 5px rgba(0, 0, 0, 0.5); */
    /* background-color: rgba(61, 61, 62, 0.5); */
    

}
.innerspeaker{
    flex: 1 1 300px;
    padding: 2rem 3rem;
    text-align: center;
    /* box-shadow: rgb(12, 11, 11); */
    border-left: 2px solid orange;
    /* border-bottom: 2px solid orange; */
    border-radius: 10px;
    box-shadow: 0 0 5px rgba(0, 0, 0, 0.1);
    

}
.innerr{
    flex: 1 1 300px;
    padding: 2rem 3rem;
    text-align: center;
    /* box-shadow: rgb(12, 11, 11); */
    border-left: 2px solid rgb(255, 166, 0,0.1);
    /* border-bottom: 2px solid orange; */
    border-radius: 10px;
    box-shadow: 0 0 5px rgba(0, 0, 0, 0.1);
    

}
.innerconference:hover{
    box-shadow: 0 0 5px rgba(173, 192, 1, 0.5);
}
.innerconference .conferenceicon{
    width: 100px;
    height: 100px;
    /* background-color: black; */
    line-height: 50px;
    text-align: center;
    border-radius: 100%;
    margin: 0 auto;
    margin-bottom: 15px;
}
.innerspeaker .conferenceicon{
    width: 100px;
    height: 100px;
    background-color: black;
    line-height: 50px;
    text-align: center;
    border-radius: 100%;
    margin: 0 auto;
    margin-bottom: 15px;
}
.innerconference h1{
    font-size: 20px;
    font-style: italic;
    font-weight: bold;
}
.innerspeaker h1{
    font-size: 20px;
    font-style: italic;
    font-weight: bold;
}
.innerconference p{
    padding: 0 2rem;
    font-size: 1.5rem;
}
.innerspeaker p{
    padding: 0 2rem;
    font-size: 1.5rem;
}
.innerspeaker span{
    font-size: 2rem;
    color: orange;
}
.innerconference span{
    font-size: 2rem;
    color: orange;
}
.innerconference .myview{
    font-size: 20px;
    width: auto;
    height: 10px;
    display: block;
    gap: 10px;
    justify-content: space-between;
    margin: 20px;
}
.innerconference .myview a{
    text-decoration: none;
}

.view-detail{
    padding: 5rem 7%;
    background-color: orange;

}
.main-detail{
    display: flex;
    justify-content: center;
    align-items: center;
    flex-wrap: wrap;
}

.inner-detail{
    flex: 1 1 4rem;
}
.inner-detail img{
    width: 40%;
    height: 40%;
    border-radius: 50%;
}
.inner-detail h1{
    color: rgb(18, 27, 48);
    font-size: 40px;
}
.inner-detail p{
    color: white;
    font-size: 1.5rem;
    padding: 1rem 0;
    margin-bottom: 25px;
}

.inner-detail a{
    padding: 2rem 4rem;
    background-color: black;
    color: lightcoral;
    font-size: 2.5rem;
    border-radius: 15px;
}

.inner-detail-image{
    text-align: center;
}
.view{
    padding: 2rem 4rem;
    background-color: black;
    color: lightcoral;
    font-size: 2.5rem;
    border-radius: 15px;

}

.speaker{
    display: flex;
   
}
.inner-speaker{
    margin: 10px;
}

.inner-speaker img{
    width: 40%;
    height: 20%;
    border-radius: 30%;
}
.inner-speaker a{
    font-size: 1rem;
}
.inner-speaker p{
    font-size: 1.5rem;
}
.inner-speaker h1{
    text-align: center;
    font-size: 2rem;
    font-style: italic;
}
.inner-speaker ul li{
    list-style-type: none;
}


.footer-distribute{
	background: #444;
	box-shadow: 0 1px 1px 0 rgba(0, 0, 0, 0.12);
	box-sizing: border-box;
	width: 100%;
	font: bold 16px sans-serif;
	text-align: left;
	padding: 50px 60px 40px;
	overflow: hidden;
}
.footer-distribute .footer-lef{
	float: left;
}

/* The company logo */

.footer-distribute h3{
	color:  #ffffff;
	font: normal 36px 'Roboto', cursive;
	margin: 0 0 10px;
}

.footer-distribute h3 span{
	color:  #5383d3;
}

/* Footer links */

.footer-distribute .footer-links{
	color:  #ffffff;
	margin: 0 0 10px;
	padding: 0;
}

.footer-distribut .footer-links a{
	display:inline-block;
	line-height: 1.8;
	text-decoration: none;
	color:  inherit;
}

.footer-distribute .footer-company-name{
	color:  #8f9296;
	font-size: 14px;
	font-weight: normal;
	margin: 0;
}

/* Footer social icons */

.footer-distribute .footer-icons{
	margin-top: 40px;
}

.footer-distribute .footer-icons a{
	display: inline-block;
	width: 35px;
	height: 35px;
	cursor: pointer;
	background-color:  #33383b;
	border-radius: 2px;

	font-size: 20px;
	color: #ffffff;
	text-align: center;
	line-height: 35px;

	margin-right: 3px;
	margin-bottom: 5px;
}

/* Footer Right */

.footer-distribute .footer-righ{
	float: right;
}

.footer-distribute .footer-righ p{
	display: inline-block;
	vertical-align: top;
	margin: 15px 42px 0 0;
	color: #ffffff;
}

/* The contact form */

.footer-distribute form{
	display: inline-block;
}

.footer-distribute form input,
.footer-distribute form textarea{
	display: block;
	border-radius: 3px;
	box-sizing: border-box;
	background-color:  #1f2022;
	box-shadow: 0 1px 0 0 rgba(255, 255, 255, 0.1);
	border: none;
	resize: none;

	font: inherit;
	font-size: 14px;
	font-weight: normal;
	color:  #d1d2d2;

	width: 400px;
	padding: 18px;
}

.footer-distribute ::-webkit-input-placeholder {
	color:  #5c666b;
}

.footer-distribute ::-moz-placeholder {
	color:  #5c666b;
	opacity: 1;
}

.footer-distribute :-ms-input-placeholder{
	color:  #5c666b;
}


.footer-distribute form input{
	height: 55px;
	margin-bottom: 15px;
}

.footer-distribute form textarea{
	height: 100px;
	margin-bottom: 20px;
}

.footer-distribute form button{
	border-radius: 3px;
	background-color:  #33383b;
	color: #ffffff;
	border: 0;
	padding: 15px 50px;
	font-weight: bold;
	float: right;
}

/* If you don't want the footer to be responsive, remove these media queries */

@media (max-width: 1000px) {

	.footer-distribute {
		font: bold 14px sans-serif;
	}

	.footer-distribute .footer-company-name{
		font-size: 12px;
	}

	.footer-distribute form input,
	.footer-distribute form textarea{
		width: 250px;
	}

	.footer-distribute form button{
		padding: 10px 35px;
	}

}


.container {
    position: relative;
    height: 200px;
    width: 400px;
    /* background-color: lightgray; */
  }
  .containerr {
    position: relative;
    height: 70vh;
    flex: 1;
    overflow-y: scroll;
  }
  .left-division h1{
    color: black;
    text-align: center;
    font-size: 17px;
    margin-bottom: 12px;
}
.left-division h1 span{
    color: rgb(255, 166, 0,0.9);
}
  .absolute-box {
    position: absolute;
    top: 50px;
    left: 50px;
    width: 200px;
    height: 100px;
    background-color: blue;
    color: white;
    padding: 10px;
  }
  .payment small{
      background-color: aqua;
      /* color: blue; */
      /* font-size: 15px; */
      border-radius: 50%;
  }ntainer

  .payment span{
      color: orange;
      /* font-size: 34px; */

  }
  .flex-container {
      display: flex;
  }

  .box {
      flex: 1;
      padding: 10px;
      /* border: 1px solid black; */
      display: flex;
      flex-direction: column;
      justify-content: left;
      /* background-color: rgba(186, 183, 183, 0.1); */
      /* margin-left: 10px; */
      padding-left: 20px;
      padding-top: 0;
      margin-top: 0;
      border-radius: 5%;
      

  }
  .box h3{
      padding-left: 20px;
      padding-top: 0;
      margin-top: auto;
      text-decoration: underline;
      font-size: 14px;
      text-align: left;
  }
  .boxx {
      flex: 1;
      width: 20%;
      padding: 10px;
      /* border: 1px solid black; */
      display: flex;
      flex-direction: column;
      justify-content: left;
      /* background-color: rgb(102, 93, 93,30%); */
      

  }
  .boxxx{
      flex: 1;
      padding: 10px;
      /* border: 1px solid black; */
      display: flex;
      flex-direction: column;
      justify-content: left;
      /* background-color: rgb(102, 93, 93,30%); */
      /* margin-left: 10px; */
      padding-left: 20px;
      text-align: left;

  }
  .boxxx small{
      font-size: 14px;
  }
  .boxxx span{
      color: rgb(11, 11, 11,70%);
      font-size: 12px;
  }
  .box li{
      text-align: left;
      
  }
    