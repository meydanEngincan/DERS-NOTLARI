--go -- programlamada ki parantez bloklar� gibi.

--declare @sayi int -- de�i�ken tan�mlad�k
--set @sayi=15 -- de�i�kene de�er atad�k.
--print @sayi -- normal yaz� olarak ekrana yazd�
--select @sayi -- tablo olarak eksana yazd�rd�k
--go --

--go--
--declare @kategoriSayisi int
--Select @kategoriSayisi = COUNT(*) from Categories
--select @kategoriSayisi = COUNT(Categories.CategoryID) from Categories
--print @kategoriSayisi
--go

--go
--declare @sonKategori NVARCHAR(100)
--select @sonKategori = Top 1 Northwind.dbo.Categories.CategoryName from Categories
--print @sonKategori
--go

print getdate()
DECLARE @SAYI INT 
SET @SAYI=10
print CONVERT(NVARCHAR(5),@SAYI)
PRINT CONVERT(NVARCHAR(4),1995)
PRINT TRY_CONVERT (NVARCHAR(3),1493) -- 1493 SAYISINI NVARCHARA �EV�RMEYE �ALI� �EV�RMEZSE HATA VERMEZ.

DECLARE @HECE NVARCHAR(20)
SELECT @HECE=RIGHT ('MEHMET',2) -- MEHMET�N SA�DAN SON 2 HARF�N� ALIR.
PRINT @HECE

SELECT @HECE = SUBSTRING('KADIK�Y',0,5)