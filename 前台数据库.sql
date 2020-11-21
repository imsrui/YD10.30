create table About(
About_Id	uniqueidentifier	primary key,
About_Title	Varchar(255)	Not null,
About_Content	Varchar(255)	Not null,
About_Image	Varchar(255)	null,
About_WebMenuId	uniqueidentifier	  null,
About_DeleteId	int	Not null default 1,
About_CreateTime	dateTime	Not null,
About_UpdateTime	dateTime	Not null
)

create table Contact(
Contact_Id	uniqueidentifier	primary key,
Contact_Address	Varchar(255)	Not null,
Contact_QQ	Varchar(255)	Not null,
Contact_Phone	Varchar(255)	Not null,
Contact_WorkTime	Varchar(255)	Not null,
Contact_QRCode	Varchar(255)	Not null,
Contact_DeleteId	int	Not null default 1 ,
Contact_Createtime	dateTime	Not null,
Contact_UpdateTime	dateTime	Not null

)

create table Explanation(

Explanation_Id	uniqueidentifier	primary key,
LoanType_Id	uniqueidentifier	 null,
Explanation_Detail	Varchar(255)	Not null,
Explanation_DeleteId	int	Not null default 1,
Explanation_CreateTime	dateTime	Not null,
Explanation_UpdateTime	dateTime	Not null

)

create table Order1(

Order_Id	uniqueidentifier	primary key,
Order_Name	Varchar(255)	Not null,
Order_Price	int	 null,
Order_Content	Varchar(255)	Not null,
Order_WebMenusId	uniqueidentifier	Not null,
Order_CreateTime	dateTime	Not null,
Order_UpdateTime	dateTime	Not null


)

create table Massage(

Massage_Name	Varchar(255)	primary key,
Massage_Phone	Varchar(255)	Not null,
Massage_OrderId	Varchar(255)	Not null,
Massage_Email	Varchar(255)	Not null,
Massage_site	Varchar(255)	Not null,
Massage_Link	Varchar(255)	Not null,
Massage_Address	Varchar(255)	Not null,
Massage_CreateTime	dateTime	Not null,
Massage_UpdateTime	dateTime	Not null

)

create table Free(


Free_Id	uniqueidentifier	primary key,
Free_Name	Varchar(255)	Not null,
Free_Title	Varchar(255)	Not null,
Free_Price	int	Not null,
Free_Publish	Varchar(255)	Not null,
Free_Author	Varchar(255)	Not null,
Free_Content	Varchar(255)	Not null,
Free_Catalohue	Varchar(255)	Not null,
Free_Portion	Varchar(255)	Not null,
Free_CreateTime	dateTime	Not null,
Free_UpdateTime	dateTime	Not null
)