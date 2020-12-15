create database QL_BANGDIAX
go
use QL_BANGDIAX
go
create table KHACHTHUE (
	MAKHACH varchar(5) primary key not null,
	HODEM nvarchar(max) not null,
	TEN nvarchar(max) not null,
	SOCMND varchar(10) not null,
	DIACHI nvarchar(max)
)
go
create table DIA (
	MADIA varchar(5) primary key not null,
	TENDIA nvarchar(max) not null,
	THELOAI nvarchar(max) not null
)
go
create table THUEDIA (
	MAKHACH varchar(5) not null,
	MADIA varchar(5) not null,
	NGAYTHUE datetime not null,
	NGAYTRA datetime,
	constraint pk_THUEDIA primary key (MAKHACH, MADIA, NGAYTHUE),
	constraint fk_MADIA foreign key (MADIA) references DIA(MADIA),
	constraint fk_MAKHACH foreign key (MAKHACH) references KHACHTHUE(MAKHACH)
)
go
insert into KHACHTHUE values 
('KH001', N'NGUYỄN VĂN', N'AN', '205005303', N'11 LÊ DUẨN ĐÀ NẴNG'), 
('KH002', N'TRẦN TUẤN', N'TÚ', '205123678', N'53 THÁI PHIÊN ĐÀ NẴNG'),
('KH003', N'LÝ', N'NAM', '203432098', N'20 LÊ DUẨN ĐÀ NẴNG')

go
insert into DIA values ('D0001', N'TỰ HỌC VISUAL BASIC', N'TIN HỌC'), ('D0002', N'TỰ HỌC PHOTOSHOP', N'TIN HỌC'), ('D0003', N'NGỮ PHÁP TIẾNG ANH CĂN BẢN', N'NGOẠI NGỮ'),
					('D0004', N'LUYỆN THI IELTS', N'NGOẠI NGỮ'), ('D0005', N'NHẠC XUÂN - HÀI HOÀI LINH 2010', N'CA NHẠC'),
					('D0006', N'CÁC CA KHÚC NHẠC CÁCH MẠNG CHỌN LỌC', N'CA NHẠC')

go
insert into THUEDIA values ('KH001', 'D0002', '04/21/2011 12:00:00', NULL), ('KH001', 'D0005', '03/26/2011 12:00:00', '03/30/2011 12:00:00'),
('KH001', 'D0006', '03/26/2011 12:00:00', '03/30/2011 12:00:00'), ('KH002', 'D0001', '04/01/2011 12:00:00', NULL),
('KH002', 'D0005', '04/01/2011 12:00:00', NULL), ('KH003', 'D0002', '04/10/2011 12:00:00', '04/17/2011 12:00:00')

select * from DIA