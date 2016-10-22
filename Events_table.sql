create table Events(
[id] int identity(1,1) not null,
[text] nvarchar(250) null,
[start_date] datetime not null,
[end_date] datetime not null,
primary key (id)
)