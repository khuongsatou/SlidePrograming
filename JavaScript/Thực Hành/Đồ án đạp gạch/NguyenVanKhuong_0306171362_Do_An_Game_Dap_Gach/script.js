	/* Nguyễn Văn Khương -->
	<!-- 0306171362 -->
	<!-- CDTH17D */


		//Khai báo một cái frame
		var canvas = document.getElementById("game");
		var context = canvas.getContext("2d");

		//mảng tạo nhiều gạch
		var createArrGach=[];

		//một số thuộc tính phụ
		var isMoveLeft=false;
		var isMoveRight=false;
		var TongDiemUse=0;
		var TongDiemWin=50;
		var GameWin=false;
		var GameOver=false;

		//di chuyển
		//nhấn vào
		document.addEventListener('keydown', function(event) {
			if (event.keyCode == 37) {
				isMoveLeft = true;
			}else if (event.keyCode == 39 ) {
				isMoveRight = true;
			}
		});

		//thả ra
		document.addEventListener('keyup', function(event) {
			if (event.keyCode==37) {
				isMoveLeft = false;
			}else if (event.keyCode == 39) {
				isMoveRight = false;
			}
		});

		//Draw Canvas
		class Canvas{
			constructor(){
				this.width = null;
				this.height = null;
			}
			
		}

		//Draw Thanh chắn
		class ThanhDieuKhien extends Canvas{
			constructor(){
				super();
				this.x=null;
				this.y=null;
				this.speed=null;
			}

			setThanhDieuKhien(){
				this.x=0;
				this.y=canvas.height-21;
				this.width = 100;
				this.height = 20;
				this.speed=20;

				
			}

			createThanhDieuKhien(){
				context.beginPath();
				context.rect(this.x,this.y,this.width,this.height);
				context.fillStyle="blue";
				context.fill();
				context.closePath();
			}

			setUpDateThanhDieuKhien(){
				//set cho bien cha
				ThanhDieuKhien.x=this.x;
				ThanhDieuKhien.width=this.width;
				ThanhDieuKhien.height=this.height;
			}

			

			LangNgheSuKien() {
				if (isMoveLeft) {
					this.x-=this.speed;
				}
				else if (isMoveRight) {
					this.x+=this.speed;
				}

				//xử lí thành canvas
				if (0 > this.x) {
					this.x = 0;
				}else if (this.x > canvas.width-this.width) {
					this.x=canvas.width-this.width;
				}
			}
		}


		//Draw gạch
		class Gach extends ThanhDieuKhien{
			constructor(){
				super();
				this.margin=null;
				this.offsetX=null;
				this.offsetY=null;
				this.row=null;
				this.col=null;
			}
			setGach(){
				this.width = 70;
				this.height = 15;
				this.margin = 25;
				this.offsetX=25;
				this.offsetY=25;
				this.row=5;
				this.col=10;
				
			}

			setUpdateGach(){
				Gach.width=this.width;
				Gach.height=this.height;
			}
			addGachArr(){
				//khởi tạo Arr gạch
				for (var i = 0; i < this.row; i++) {
					for (var j = 0; j <  this.col ; j++) {
						createArrGach.push(
						{
							x: this.offsetX + j * (this.width  + this.margin),
							y: this.offsetY + i * (this.height + this.margin),
							isBroken:false,
							tempW:this.width,
							tempH:this.height
						});
						
					}
				}
			}
			createGach(){
				createArrGach.forEach(function(g){
					if (!g.isBroken) {
						context.beginPath();
						context.rect(g.x , g.y , g.tempW , g.tempH );
						context.fillStyle="#FF0019";
						context.fill();
						context.closePath();
					}
				});
			}

			
		}




		//draw ball
		class Ball extends ThanhDieuKhien{
			constructor(){
				super();
				this.dx=null;
				this.dy=null;
				this.radius=null;
			}

			setBall(){
				this.x = canvas.width/2;
				this.y = canvas.height/2;
				this.dx = 5.4;
				this.dy = 6.5;
				this.radius = 8;
			}

			setUpdateBall(){
				Ball.x=this.x;
				Ball.y=this.y;
				Ball.dx=this.dx;
				Ball.dy=this.dy;
				Ball.radius=this.radius;
			}
			createBall(){
				context.beginPath();
				context.arc(this.x, this.y, this.radius, 0, Math.PI*2, true);
				context.fillStyle="black";
				context.fill();
				context.stroke();
				context.closePath();
			}

			updatePosition(){
				this.x -= this.dx;
				this.y -= this.dy;
			}

			vaChamBallVoiCanvas(){
				if (this.x < this.radius 
					|| this.x > canvas.width - this.radius
					) {
					this.dx=-this.dx;
				}

				if (this.y < this.radius
					|| this.y > canvas.height - this.radius) {
					this.dy=-this.dy;
				}

				if (this.y > canvas.height - this.radius) {
					GameOver=true;
				}
			}


			vaChamThanhDieuKhien(){
				if (this.x + this.radius >= ThanhDieuKhien.x && 
					this.x + this.radius <= ThanhDieuKhien.x + ThanhDieuKhien.width &&
					this.y + this.radius >= canvas.height - ThanhDieuKhien.height &&
					this.y + this.radius >= ThanhDieuKhien.height

					) {
					this.dy=-this.dy+1;
				
				}
		
			}

			vaChamGach(){
				createArrGach.forEach(function (g) {
					if (!g.isBroken) {
						if (Ball.x >=g.x && Ball.x <= g.x + Gach.width &&
							Ball.y + Ball.radius >= g.y && Ball.y - Ball.radius <= g.y + Gach.height
							) {
						Ball.dy =-Ball.dy;
						g.isBroken = true;
						TongDiemUse++;
							
							if (TongDiemUse>=TongDiemWin) {
								GameWin=true;
							}

						}
					}
				});


			}

			//end class ball
	}

			//Khởi Tạo and Gọi
			myThanhDieuKhien = new ThanhDieuKhien();
			myBall           = new Ball();
			myGach           = new Gach();

			//__Thanh điều Khiển
			myThanhDieuKhien.setThanhDieuKhien();

			//__Ball
			myBall.setBall();

			//__Gach
			myGach.setGach();

			//tạo nhiều gạch
			myGach.addGachArr();


		function ActionLoop() {
			
			if (!GameWin) {
				if (!GameOver) {
					//xóa canvas
					context.clearRect(0, 0, canvas.width,canvas.height);
					
					//hàm xử lí thanh điều khiển
					myThanhDieuKhien.createThanhDieuKhien();
					myThanhDieuKhien.LangNgheSuKien();
					myThanhDieuKhien.setUpDateThanhDieuKhien();

					//hàm xử lí ball
					myBall.createBall();
					myBall.setUpdateBall();
					myBall.updatePosition();
					myBall.vaChamBallVoiCanvas();
					myBall.vaChamThanhDieuKhien();
					myBall.vaChamGach();

					//hàm xử lí gạch
					myGach.createGach();
					myGach.setUpdateGach();


					//action animation
					requestAnimationFrame(ActionLoop);
				}else{
					alert("Điểm Của Bạn:"+ TongDiemUse +"->Thua Rồi Đấy Cũng nghỉ luôn đi..");
				}
			}
			else{
				alert("Điểm Của Bạn:"+ TongDiemUse+"Bạn Thắng Rồi Đấy Tắt máy nghỉ...");
			}
		}
		
		ActionLoop();
	

	
