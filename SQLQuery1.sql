create table Country (
CountryId integer not null,
CountryName varchar(100) not null,
primary key (CountryId)
);

create table Depot(
DepotId integer not null,
DepotName varchar(100) not null,
CountryId integer not null,
primary key (DepotId),
foreign key (CountryId) references Country (CountryId)
);

create table DrugType(
DrugTypeId integer not null,
DrugTypeName varchar(100) not null,
Weight float not null,
primary key (DrugTypeId)
);

drop table  DrugType;
drop table DrugUnit;

create table DrugUnit(
DrugUnitId integer not null,
PickNumber integer,
DepotId integer,
DrugTypeId integer not null,
primary key (DrugUnitId),
foreign key (DepotId) references Depot(DepotId),
foreign key (DrugTypeId) references DrugType(DrugTypeId)
);


insert into Country values (1,'Belarus');
insert into Country values (2,'United States of America');

insert into Depot values (1,'Depot 1',1);
insert into Depot values (2,'Depot 2',2);

delete DrugUnit;
delete Depot;

insert into DrugType values (1,'NZT',1);
insert into DrugType values (2,'AAA',2);

declare @i int=0,
		@a int=0,
		@drType varchar(100);
while @i<100
begin
if (@a>=10)
	set @a=0;
else
	set @a=@a+1;
if (@i%2=0)
	insert into DrugUnit values (6500+@i*10,@a,null,1);
else
	insert into DrugUnit values (6500+@i*10,@a,null,2);

set @i=@i+1;
end;


