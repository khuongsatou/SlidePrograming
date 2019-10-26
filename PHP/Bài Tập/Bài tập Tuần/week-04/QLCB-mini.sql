create database QLChuyenBay
use QLChuyenBay

create table NHANVIEN
(
	MANV nchar(15) primary key not null,
	TEN nvarchar(15),
	DCHI nvarchar(50),
	DTHOAI nchar(12),
	LUONG float,
	LOAINV bit
)

create table LOAIMB
(
	MALOAI nchar(15) primary key not null,
	HANGXS nvarchar(15)
)

create table MAYBAY
(
	SOHIEU int not null,
	MALOAI nchar(15) not null,
	primary key (SOHIEU,MALOAI)
)

create table KHANANG
(
	MANV nchar(15) not null,
	MALOAI nchar(15) not null,
	primary key (MANV,MALOAI)
)

alter table KHANANG
add constraint fk_KHANANG_NHANVIEN
foreign key (MANV)
references NHANVIEN(MANV)

alter table KHANANG
add constraint fk_KHANANG_LOAIMB
foreign key (MALOAI)
references LOAIMB(MALOAI)

alter table MAYBAY
add constraint fk_MAYBAY_LOAIMB
foreign key (MALOAI)
references LOAIMB(MALOAI)

insert into NHANVIEN
values  ('1006','Chi','12/6 Nguyen Kiem','8120012',150000,0),
		('1005','Giao','65 Nguyen Thai Son','8324467',500000,0),
		('1001','Huong','8 Dien Bien Phu','8330733',500000,1),
		('1002','Phong','1 Ly Thuong Kiet','8308117',450000,1),
		('1004','Phuong','351 Lac Long Quan','8308155',250000,0),
		('1003','Quang','78 Truong Dinh','8324461',350000,1),
		('1007','Tam','36 Nguyen Van Cu','8458188',500000,0)


insert into LOAIMB
values  ('A310','Airbus'),
		('A320','Airbus'),
		('A330','Airbus'),
		('A340','Airbus'),
		('B727','Boeing'),
		('B747','Boeing'),
		('B757','Boeing'),
		('DC10','MD'),
		('DC9','MD')

insert into KHANANG
values  ('1001','B727'),
		('1001','B747'),
		('1001','DC10'),
		('1001','DC9'),
		('1002','A320'),
		('1002','A340'),
		('1002','B757'),
		('1002','DC9'),
		('1003','A310'),
		('1003','DC9')

insert into MAYBAY
values  (10,'B747'),
		(11,'B727'),
		(13,'B727'),
		(13,'B747'),
		(21,'DC10'),
		(21,'DC9'),
		(22,'B757'),
		(22,'DC9'),
		(23,'DC9'),
		(24,'DC9'),
		(70,'A310'),
		(80,'A310'),
		(93,'B757')


