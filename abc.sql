
use master
create database ClothingShop
drop database ClothingShop
use ClothingShop
create table menus(
    id int PRIMARY KEY IDENTITY(1,1) not NULL ,
    name NVARCHAR(50),
    link NVARCHAR(max),
    meta NVARCHAR(50),
    hide BIT,
    [order] int,
    datebegin smalldatetime DEFAULT getDate(),
)
insert into menus(name,link,meta,hide,[order]) 
VALUES
(N'Trang chủ','trang-chu','trang-chu',1,1),
(N'Phụ nữ','san-pham/quan-ao-nu','san-pham/quan-ao-nu',1,2),
(N'Nam giới','san-pham/quan-ao-nam','san-pham/quan-ao-nam',1,3),
(N'Thể thao','san-pham/quan-ao-the-thao','san-pham/quan-ao-the-thao',1,4),
(N'Tin tức','tin-tuc','tin-tuc',1,5),
(N'Liên hệ','lien-he','lien-he',1,6);
create table navbars(
    id int PRIMARY KEY IDENTITY(1,1) not NULL ,
    name NVARCHAR(50),
    link NVARCHAR(max),
    meta NVARCHAR(50),
    hide BIT,
    [order] int,
    datebegin smalldatetime DEFAULT getDate(),
)
insert into navbars(name,link,meta,hide,[order]) 
VALUES
(N'Tài khoản','thong-tin-tai-khoan','thong-tin-tai-khoan',0,1),
(N'Giỏ hàng','gio-hang','gio-hang',1,2),
(N'Đăng nhập','dang-nhap','dang-nhap',1,3),
(N'Đăng ký','dang-ky','dang-ky',1,4),
(N'Đăng xuất','dang-xuat','dang-xuat',0,5)
drop table navbars
create table categories(
    id int PRIMARY KEY IDENTITY(1,1) not NULL ,
    name NVARCHAR(50),
    meta NVARCHAR(50),
    hide BIT DEFAULT 1,
    [order] int,
    datebegin smalldatetime DEFAULT getDate()
)
insert into categories(name,meta,[order])
VALUES(N'Quần áo nam','quan-ao-nam',1),
(N'Quần áo nữ','quan-ao-nu',2),
(N'Quần áo thể thao','quan-ao-the-thao',3),
(N'Túi xách','tui-xach',4)

create table products(
    id int PRIMARY KEY IDENTITY(1,1) not NULL ,
    category_id int not null,
    name NVARCHAR(50),
    price int,
    images NVARCHAR(100),
    quantity int,
    meta NVARCHAR(50),
    hide BIT,
    [order] int,
    datebegin smalldatetime DEFAULT getDate(),
    FOREIGN KEY (category_id) REFERENCES categories(id)
)
insert into products(name, price, images,quantity,category_id, meta,hide,[order])
VALUES
(N'Áo khoắc',300000,'ladies/6.jpg',20,1,'ao-khoac',1,1),
(N'Áo tay dài',300000,'ladies/6.jpg',30,2,'ao-tay-dai',1,2),
(N'Quần jean',300000,'ladies/6.jpg',40,1,'quan-jean',1,3),
(N'Quần short',300000,'ladies/6.jpg',50,3,'quan-short',1,4)
select * from products
create table brands(
    id int PRIMARY KEY IDENTITY(1,1) not NULL ,
    name NVARCHAR(50),
    meta NVARCHAR(50),
    hide BIT,
    [order] int,
    datebegin smalldatetime DEFAULT getDate(),
)
insert into brands(name,meta,hide,[order]) 
VALUES
(N'Gucci','gucci',1,1),
(N'Louis Vuitton','louis-vuitton',1,3),
(N'Adidas','adidas',1,2)

create table product_details(
    id int PRIMARY KEY IDENTITY(1,1) not NULL ,
    product_id int not null,
    brand_id int not null,
    colour NVARCHAR(50),
    size NVARCHAR(20),
    meta NVARCHAR(50),
    hide BIT DEFAULT 1,
    [order] int,
    datebegin smalldatetime DEFAULT getDate(),
    FOREIGN KEY (product_id) REFERENCES products(id),
    FOREIGN KEY (brand_id) REFERENCES brands(id)
)
insert into product_details(product_id,brand_id,colour,size,meta)
VALUES(1,1,N'Màu đen','M','chi-tiet'),
(1,3,N'Màu đỏ','L','chi-tiet'),
(2,3,N'Màu vàng','XL','chi-tiet'),
(3,2,N'Màu cam','M','chi-tiet'),
(4,2,N'Màu xanh','XL','chi-tiet')

create table banners(
    images NVARCHAR(100) PRIMARY KEY not NULL,
    meta NVARCHAR(50),
    hide BIT,
    [order] int,
    datebegin smalldatetime DEFAULT getDate()
)
insert into banners(images, meta, hide, [order])
VALUES
('carousel/banner-1.jpg','banner-1',1,1),
('carousel/banner-2.jpg','banner-2',1,2)

drop table menus