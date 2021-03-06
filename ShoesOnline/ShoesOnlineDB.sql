CREATE DATABASE ShoesOnlineDB
USE ShoesOnlineDB

CREATE TABLE Account(
	ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Email VARCHAR(512) NOT NULL UNIQUE,
	Phone VARCHAR(10) NOT NULL UNIQUE,
	Password VARCHAR(100) NOT NULL,
	Role VARCHAR(10) DEFAULT 'Customer' NOT NULL,
	FullName NVARCHAR(512) NOT NULL,
	Gender VARCHAR(10) NOT NULL,
	AvatarPath VARCHAR(512) DEFAULT NULL
)
INSERT INTO Account(Email, Phone, Password, Role, FullName, Gender) VALUES ('admin@gmail.com',  '012456789', '123456789', 'Admin', N'Admin siêu cấp', 'M')
INSERT INTO Account(Email, Phone, Password, FullName, Gender) VALUES ('customer@gmail.com', '2345678910', '123456789', N'Người mua giày thông minh', 'F')
INSERT INTO Account(Email, Phone, Password, Role, FullName, Gender) VALUES ('seller@gmail.com', '2345678911', '123456789', 'Seller', N'Shop giày Lươn Quang Thắng', 'M')


CREATE TABLE Shoes(
	ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Name NVARCHAR(512) NOT NULL,
	Type VARCHAR(512) NOT NULL,
	Price INT NOT NULL,
	Quantity INT NOT NULL,
	Size NVARCHAR(512) NOT NULL,
	Color NVARCHAR(512) NOT NULL,
	Desciption NTEXT NOT NULL,
	ImagePath NVARCHAR(512) DEFAULT NULL, --Ảnh đại diện của sản phẩm
)
INSERT INTO Shoes(Name, Type, Price, Quantity, Size, Color, Desciption, ImagePath) 
VALUES (N'Nike Air Max 97 By You', 'Classic, Female, Male', 220000, 1000, '24, 42', 'White, Grey', N'Bring back the nostalgia of long summer days from your childhood with a hot colour palette and a wavy mesh that alludes to the mesmerising optical illusion of heat rising from the tarmac. Classic layers get a new level of appeal with material choices, pop colours and Metallic Silver that hearkens back to the real OG: Nike Air Max 97 By You.', 'https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/be40c75c-8733-4889-aa85-2b46897f050c/custom-nike-air-force-97-by-you.png')
INSERT INTO Shoes(Name, Type, Price, Quantity, Size, Color, Desciption, ImagePath) 
VALUES (N'Nike Air Max 02 By You',  'Street Style, Female, Male', 150000, 1000, '24, 42', 'White, Grey', N'Chrome details nod to the iconic original a modern—even futuristic—panache to the laid-back colours conjuring the dog days of summer. The air bag also gets a whole new look with options to highlight this key feature with a metallic pop.','https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/a7fe656c-8e72-437d-be1c-23236b6cea3f/custom-nike-air-force-97-by-you.png')
INSERT INTO Shoes(Name, Type, Price, Quantity, Size, Color, Desciption, ImagePath) 
VALUES (N'Adidas Ultra Boost',  'Classic, Female, Male', 300000, 1000, '24, 42', 'White, Grey', N'The Ultra Boost remains one of adidas’ most notable offerings. And here, following Bond-grade colorways and collegiate themes, the silhouette is heating up in a way far more literal than it ever has. The “Heat Map” nickname is more than self-explanatory. Clusters of red, yellow, green, and blue appear atop the construction’s key fixtures, gradating from the latter end to the former at every instance. Certain sections — the heel, for example — appear far larger in relation to the toe, side, and tongue,','https://sneakernews.com/wp-content/uploads/2021/10/adidas-ultra-boost-heat-map-GZ2922-release-date-2.jpg')
INSERT INTO Shoes(Name, Type, Price, Quantity, Size, Color, Desciption, ImagePath) 
VALUES (N'Air Force 1',  'Street Style, Female, Male', 750000, 1000, '24, 42', 'White, Grey', N'The Nike Air Force 1 Shadow puts a playful twist on a classic b-ball design.Using a layered approach, doubling the branding and exaggerating the midsole, it highlights AF-1 DNA with a bold, new look.','https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/b400702a-d372-4cb9-96fd-ecc5c6de1df9/air-force-1-shadow-shoes-mN8Glx.png')
INSERT INTO Shoes(Name, Type, Price, Quantity, Size, Color, Desciption, ImagePath) 
VALUES (N'Nike Air Max 97',  'Classic, Female, Male', 450000, 1000, '24, 42', 'White, Grey', N'Inspired by Japanese bullet trains, the Nike Air Max 97 lets you push your style full speed ahead.Taking the revolutionary full-length Nike Air unit that shook up the running world and adding the original "silver bullet" colours, it lets you ride in first-class comfort.','https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/1632439a-15ca-4213-842e-4e8b062a6c86/air-max-97-shoes-bfqJQG.png')
INSERT INTO Shoes(Name, Type, Price, Quantity, Size, Color, Desciption, ImagePath) 
VALUES (N'Yezzy 700',  'Street Style, Female, Male', 120000, 1000, '24, 42', 'White, Grey', N'The Yeezy 700 V3 emerges with a look almost exactly like the 2020  colorway. However, the design is differentiated by the RPU cage,  the silhouette is heating up in a way far more literal than it ever has. The “Heat Map” nickname is more than ','https://cdn.flightclub.com/750/TEMPLATE/277780/1.jpg')
INSERT INTO Shoes(Name, Type, Price, Quantity, Size, Color, Desciption, ImagePath) 
VALUES (N'Addidas',  'Classic, Female, Male', 2990000, 80000, '24, 42', 'White, Grey', N'The Nike Air Force  Shadow puts a playful twist on a classic b-ball design.Using a layered approach, doubling the branding and exaggerating the midsole,','https://static.nike.com/a/images/t_PDP_1280_v1/f_auto,q_auto:eco/e5af7319-a671-4187-a10a-020e09e7b3db/air-max-2021-mens-shoes-fnRMh3.png')
INSERT INTO Shoes(Name, Type, Price, Quantity, Size, Color, Desciption, ImagePath) 
VALUES (N'Air Jordan 1 Mid ', 'Street Style, Female, Male', 560000, 1000, '24, 42', 'White, Grey', N'The Air Jordan 1 Mid brings full-court style and premium comfort to an iconic look. Its Air-Sole unit cushions play on the hardwood, while the padded collar gives you a supportive feel.','https://static.nike.com/a/images/t_PDP_864_v1/f_auto,b_rgb:f5f5f5/00af1c33-f280-446d-97e0-97056c96473d/air-jordan-1-mid-shoe-86f1ZW.png')


CREATE TABLE ShoesImage(
	IDShoes INT FOREIGN KEY REFERENCES Shoes(ID),
	AllImagePath NVARCHAR(512) DEFAULT NULL
)
INSERT INTO ShoesImage(IDShoes, AllImagePath) 
VALUES (1, 'https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/be40c75c-8733-4889-aa85-2b46897f050c/custom-nike-air-force-97-by-you.png')
INSERT INTO ShoesImage(IDShoes, AllImagePath) 
VALUES (1, 'https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/be40c75c-8733-4889-aa85-2b46897f050c/custom-nike-air-force-97-by-you.png')
INSERT INTO ShoesImage(IDShoes, AllImagePath) 
VALUES (1, 'https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/be40c75c-8733-4889-aa85-2b46897f050c/custom-nike-air-force-97-by-you.png')
INSERT INTO ShoesImage(IDShoes, AllImagePath) 
VALUES (1, 'https://static.nike.com/a/images/t_PDP_1728_v1/f_auto,b_rgb:f5f5f5/be40c75c-8733-4889-aa85-2b46897f050c/custom-nike-air-force-97-by-you.png')


CREATE TABLE Cart(
	ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	IDAccount INT FOREIGN KEY REFERENCES Account(ID),
	IDShoes INT FOREIGN KEY REFERENCES Shoes(ID),
	Size NVARCHAR(512) NOT NULL,
	Color NVARCHAR(512) NOT NULL,
	Quantity NVARCHAR(512) NOT NULL,
	AddDate DATE NOT NULL DEFAULT GETDATE()
)
INSERT INTO Cart(IDAccount, IDShoes, Size, Color, Quantity) 
VALUES (3, 1, '33', 'White', '10')
INSERT INTO Cart(IDAccount, IDShoes, Size, Color, Quantity) 
VALUES (3, 2, '33', 'White', '10')
INSERT INTO Cart(IDAccount, IDShoes, Size, Color, Quantity) 
VALUES (3, 3, '33', 'White', '10')


CREATE TABLE Comment(
	ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	IDAccount INT FOREIGN KEY REFERENCES Account(ID),
	CommentContent NTEXT NOT NULL,
	CommentDate DATE NOT NULL DEFAULT GETDATE()
)
INSERT INTO Comment(IDAccount, CommentContent)
VALUES (3, N'Sản phẩm đẹp đúng như mô tả')
INSERT INTO Comment(IDAccount, CommentContent)
VALUES (3, N'Mang giày vào chạy nhanh hơn cả đi bộ')

CREATE TABLE Rating(
	IDComment INT FOREIGN KEY REFERENCES Comment(ID),
	IDShoes INT FOREIGN KEY REFERENCES Shoes(ID),
	Star INT NOT NULL
)
INSERT INTO Rating(IDComment, IDShoes, Star)
VALUES (1, 1, 5)
INSERT INTO Rating(IDComment, IDShoes, Star)
VALUES (2, 2, 5)

CREATE TABLE CommentShoes(
	IDComment INT FOREIGN KEY REFERENCES Comment(ID),
	IDShoes INT FOREIGN KEY REFERENCES Shoes(ID)
)
INSERT INTO CommentShoes(IDComment, IDShoes)
VALUES (1, 1)
INSERT INTO CommentShoes(IDComment, IDShoes)
VALUES (2, 2)

CREATE TABLE News(
	NewsTitle NVARCHAR(512) NOT NULL,
	NewsImageAddress VARCHAR(512) NOT NULL,
	NewsDescription NVARCHAR(512) NOT NULL,
	NewsContent  NTEXT NOT NULL,
	NewsReleaseDate DATE NOT NULL DEFAULT GETDATE(),
	NewsCategory NVARCHAR(512) NOT NULL --Xu hướng, Ưu đãi, Sự kiện, Giới thiệu
)

CREATE TABLE Shop(
	ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Name NVARCHAR(512) NOT NULL,
	Introduction NTEXT NOT NULL,
	Address NVARCHAR(512) NOT NULL,
	ShopAvatarPath VARCHAR(512) DEFAULT NULL
)

CREATE TABLE PendingShoes(
	ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Name NVARCHAR(512) NOT NULL,
	Type VARCHAR(512) NOT NULL,
	Price INT NOT NULL,
	Quantity INT NOT NULL,
	Size NVARCHAR(512) NOT NULL,
	Color NVARCHAR(512) NOT NULL,
	Desciption NTEXT NOT NULL,
	ImagePath NVARCHAR(512) DEFAULT NULL, --Ảnh đại diện của sản phẩm
)

CREATE TABLE PendingShoesImage(
	IDPendingShoes INT FOREIGN KEY REFERENCES PendingShoes(ID),
	AllImagePath NVARCHAR(512) DEFAULT NULL
)

CREATE TABLE PendingShoesShop(
	IDShop INT FOREIGN KEY REFERENCES Shop(ID),
	IDPendingShoes INT FOREIGN KEY REFERENCES PendingShoes(ID),
)