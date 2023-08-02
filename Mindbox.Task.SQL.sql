create table Products
(
	id int IDENTITY PRIMARY KEY,
	name ntext
)

create table Categories
(
	id int IDENTITY PRIMARY KEY,
	name ntext
)

create table productCategory
(
	productId uniqueidentifier,
	categoryId uniqueidentifier,
	PRIMARY KEY (productId, categoryId),
	FOREIGN KEY (productId) REFERENCES Products(id),
	FOREIGN KEY (categoryId) REFERENCES Categories(id)
)

insert into Products VALUES 
('Iphone'),
('Xiaomi'),
('Samsung'),
('BMW'),
('Nestea')

insert into Categories VALUES 
('Telephone'),
('Vehicle'),
('Notebook')

insert into productCategory(productId, categoryId) values
('1','1'),
('2','1'),
('3','1'),
('2','3'),
('4','2'),
('3','3')

select * from Products;
select * from Categories;
select * from productCategory;

select pr.name, cat.name
from Products pr
left join productCategory pc 
	on pr.id = pc.productId
left join Categories cat
	on pc.categoryId = cat.id;