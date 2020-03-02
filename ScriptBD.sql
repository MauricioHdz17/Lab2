Create database DESARROLLOSOFWARE
use DESARROLLOSOFWARE

create table Video(
	idVideo int primary key,
	titulo varchar(100),
	repro int,
	url varchar(100)
); 

Create procedure sp_video_insertar
@idvideo int,
@titulo varchar(100),
@repro int,
@url varchar(100)
as
begin
	insert into Video Values(@idVideo,@titulo,@repro,@url) 
end

EXEC sp_video_insertar 1,'Video 1',1,'yotubue.com'

Select*from Video