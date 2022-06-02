create database THI_TN
use THI_TN
create table coso(
	macs nchar(3) primary key,
	tencs nvarchar(40) unique,
	diachi nvarchar(100)
)
create table khoa(
	makh nchar(8) primary key,
	tenkh nvarchar(40) unique,
	macs nchar(3),
	foreign key(macs) references coso(macs),
)
create table lop(
	malop nchar(8) primary key,
	tenlop nvarchar(40) unique,
	makh nchar(8),
	foreign key(makh) references khoa(makh),
)
create table monhoc(
	mamh nchar(5) primary key,
	tenmh nvarchar(40) unique,
)
create table sinhvien(
	masv nchar(8) primary key,
	ho nvarchar(40),
	ten nvarchar(10),
	ngaysinh datetime,
	diachi nvarchar(40),
	malop nchar(8),
	foreign key(malop) references lop(malop),
)

create table giaovien(
	magv nchar(8) primary key,
	ho nvarchar(40),
	ten nvarchar(10),
	hocvi nvarchar(40),
	makh nchar(8),
	foreign key(makh) references khoa(makh),
)
create table giaovien_dangky(
	magv nchar(8),
	malop nchar(8),
	mamh nchar(5),
	trinhdo char(1) check(trinhdo in('A','B','C')),
	ngaythi datetime,
	lan smallint check(lan >=1 and lan <=2),
	socauthi smallint check(socauthi >=10 and socauthi <=100),
	thoigian smallint check(thoigian >=15 and thoigian <=60),
	foreign key(magv) references giaovien(magv),
	foreign key(malop) references lop(malop),
	foreign key(mamh) references monhoc(mamh),
	primary key(malop, mamh, lan),
)
create table bode(
	mamh nchar(5),
	cauhoi int primary key IDENTITY(1,1),
	trinhdo char(1) check(trinhdo in ('A','B','C')),
	noidung text,
	A nvarchar(100),
	B nvarchar(100),
	C nvarchar(100),
	D nvarchar(100),
	dap_an char(1) check(dap_an in ('A','B','C','D')),
	magv nchar(8),
	foreign key(mamh) references monhoc(mamh),
	foreign key(magv) references giaovien(magv),
)
create table bangdiem(
	masv nchar(8),
	mamh nchar(5),
	lan smallint check(lan>=1 and lan<=2),
	ngaythi datetime,
	diem float check(diem between 0 and 10),
	baithi text,
	foreign key(masv) references sinhvien(masv),
	foreign key(mamh) references monhoc(mamh),
	primary key(masv, mamh, lan),
)
create table account(
	username varchar(40) primary key,
	pass varchar(40),
	macs nchar(3),
	quyen int,
	foreign key(macs) references coso(macs),
)
insert into coso(macs,tencs,diachi) values
('CS1',N'Cao đẳng TDT',N'Ngô Tất Tố'),
('CS2',N'Đại học TDT',N'Nguyễn Hữu Thọ')
insert into coso(macs,tencs,diachi) values
('CS',N'Đại học TDT Lâm Đồng',N'Lâm Đồng')

insert into monhoc(mamh,tenmh) values
('5180A',N'Cơ sở dữ liệu phân tán'),
('5180B',N'Hệ cơ sở dữ liệu'),
('5180C',N'Cấu trúc rời rạc'),
('5180D',N'Phương pháp tính'),
('5180E',N'Phát triển game'),
('5180F',N'Lập trình web')

insert into khoa(makh,tenkh,macs) values
('18050281',N'Công nghệ thông tin','CS2'),
('18050H81','Quản trị kinh doanh','CS1'),
('18060E81','Ngôn ngữ Anh','CS1'),
('18060181','Luật','CS1'),
('18050901','Điện','CS1'),
('18060192','Xã hội','CS1')

insert into lop(malop,tenlop,makh) values
('190A0281',N'Kỹ thuật phần mềm K23','18050281'),
('190B0281',N'Công nghệ thông tin K23','18050H81'),
('190C0281',N'Quản trị khách sạn K23','18060E81'),
('190D0281',N'Quản trị nhà hàng K23','18060181'),
('190E0281',N'Ngôn ngữ Anh K22','18050901'),
('190F0281',N'Luật K22','18060192'),
('190G0281',N'Điện K22','18050281'),
('190H0281',N'Điện K23','18050H81'),
('190I0281',N'Ngôn ngữ Anh K23','18060E81'),
('190J0281',N'Kỹ thuật phần mềm K22','18050901'),
('190K0281',N'Luật K23','18060192')

set dateformat dmy

insert into sinhvien(masv,ho,ten,ngaysinh,diachi,malop) values
('51802085',N'Nguyễn Duy',N'Khánh','24/04/2000 11:11:11 ',N'Đà Lạt','190A0281'),
('51802083',N'Nguyễn Ngọc',N'Kha','24/03/1999 11:11:11 ',N'Gia Lai','190B0281'),
('51800371',N'Nguyễn Trường Khương',N'Duy','28/02/2001 11:11:11 ',N'Hồ Chí Minh','190C0281'),
('51800001',N'Nguyễn Văn',N'A','1/1/2001 11:11:11 ',N'Hồ Chí Minh','190E0281'),
('51800002',N'Nguyễn Văn',N'B','2/2/2001 11:11:11 ',N'Đăk Lăk','190G0281'),
('51800003',N'Nguyễn Văn',N'C','3/3/2001 11:11:11 ',N'Hà Nội','190I0281'),
('51800004',N'Nguyễn Văn',N'D','4/4/2001 11:11:11 ',N'Tây Ninh','190J0281'),
('51800005',N'Nguyễn Thị',N'E','5/5/2001 11:11:11 ',N'Đăk Nông','190K0281')

insert into giaovien(magv,ho,ten,hocvi,makh) values
('5100E123',N'Nguyễn Thanh',N'Khương',N'Thạc sĩ','18050281'),
('7100E234',N'Trần Lương Quốc',N'Đại',N'Thạc sĩ','18050H81'),
('8100E234',N'Nguyễn Ngọc',N'Kha',N'Giáo sư','18060E81'),
('E180E234',N'Trần Thanh',N'Phước',N'Thạc sĩ','18060181'),
('0100E234',N'Võ Hoàng',N'Anh',N'Thạc sĩ','18060192'),
('3100E234',N'Trần',N'Anh',N'Thạc sĩ','18050281')

insert into bode(mamh,trinhdo,noidung,A,B,C,D,dap_an,magv) values
('5180B','A',N'Có mấy loại phân mảnh?',N'1',N'2',N'3',N'4','B','5100E123'),
('5180B','A',N'Có mấy loại phân mảnh ngang?',N'2',N'3',N'4',N'5','A','5100E123'),
('5180B','A',N'Có mấy loại mệnh đề?',N'4',N'3',N'2',N'1','C','5100E123'),
('5180B','B',N'Một hệ quản trị CSDL không có chức năng nào trong các chức năng dưới đây?',N'Cung cấp môi trường tạo lập CSDL',N'Cung cấp môi trường cập nhật và khai thác dữ liệu',N'Cung cấp công cụ quản lí bộ nhớ',N'Cung cấp công cụ kiểm soát, điều khiển truy cập vào CSDL.','C','7100E234'),
('5180B','B',N'Ngôn ngữ định nghĩa dữ liệu thật chất là:',N'Ngôn ngữ lập trình Pascal',N'Ngôn ngữ C',N'Các kí hiệu toán học dùng để thực hiện các tính toán',N'Hệ thống các kí hiệu để mô tả CSDL','D','7100E234'),
('5180B','B',N'Ngôn ngữ định nghĩa dữ liệu bao gồm các lệnh cho phép:',N'Đảm bảo tính độc lập dữ liệu',N'Khai báo kiểu dữ liệu, cấu trúc dữ liệu và các ràng buộc trên dữ liệu của CSDL',N'Mô tả các đối tượng được lưu trữ trong CSDL',N'Khai báo kiểu dữ liệu của CSDL','B','7100E234'),
('5180B','C',N'Ngôn ngữ thao tác dữ liệu thật chất là:',N'Ngôn ngữ để người dùng diễn tả yêu cầu cập nhật hay khai thác thông tin',N'Ngôn ngữ để người dùng diễn tả yêu cầu cập nhật thông tin',N'Ngôn ngữ SQL',N'Ngôn ngữ bậc cao','A','7100E234'),
('5180B','C',N'Ngôn ngữ thao tác dữ liệu bao gồm các lệnh cho phép:',N'Nhập, sửa, xóa dữ liệu',N'Khai báo kiểu, cấu trúc, các ràng buộc trên dữ liệu của CSDL',N'Khai thác dữ liệu như: tìm kiếm, sắp xếp, kết xuất báo cáo…',N'Câu A và C','D','7100E234'),
('5180B','C',N'Ngôn ngữ CSDL được sử dụng phổ biến hiện nay là:',N'SQL',N'Access',N'Foxpro',N'Java','A','7100E234'),
('5180B','C',N'Những nhiệm vụ nào dưới đây không thuộc nhiệm vụ của công cụ kiểm soát, điều khiển truy cập vào CSDL?',N'Duy trì tính nhất quán của CSDL',N'Cập nhật (thêm, sửa, xóa dữ liệu)',N'Khôi phục CSDL khi có sự cố',N'Phát hiện và ngăn chặn sự truy cập không được phép','B','7100E234')

insert into bangdiem(masv,mamh,lan,ngaythi,diem,baithi) values
('51802083','5180A','1','15/01/2021 11:11:11 ','8',N'Giữa Kỳ'),
('51802085','5180B','2','15/04/2021 11:11:11 ','9',N'Cuối Kỳ'),
('51800371','5180C','1','17/01/2021 11:11:11 ','8.5',N'Giữa Kỳ')


insert into account(username, pass, macs, quyen) values
('admin2','admin','CS2',1),
('coso1','coso1','CS1',2),
('coso2','coso2','CS2',3),
('giangvien1','giangvien1','CS1',4),
('giangvien2','giangvien2','CS2',4),
('sinhvien1','sinhvien1','CS1',5),
('sinhvien2','sinhvien2','CS2',5)

