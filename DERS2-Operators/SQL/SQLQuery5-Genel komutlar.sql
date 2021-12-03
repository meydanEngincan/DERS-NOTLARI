--go -- programlamada ki parantez bloklarý gibi.

--declare @sayi int -- deðiþken tanýmladýk
--set @sayi=15 -- deðiþkene deðer atadýk.
--print @sayi -- normal yazý olarak ekrana yazdý
--select @sayi -- tablo olarak eksana yazdýrdýk
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
PRINT TRY_CONVERT (NVARCHAR(3),1493) -- 1493 SAYISINI NVARCHARA ÇEVÝRMEYE ÇALIÞ ÇEVÝRMEZSE HATA VERMEZ.

DECLARE @HECE NVARCHAR(20)
SELECT @HECE=RIGHT ('MEHMET',2) -- MEHMETÝN SAÐDAN SON 2 HARFÝNÝ ALIR.
PRINT @HECE

SELECT @HECE = SUBSTRING('KADIKÖY',0,5)