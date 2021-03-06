/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [MsCauHoi]
      ,[DapAnofTS]
  FROM [SATHACHBANGLAI1].[dbo].[TTDapAn]


create table TTDapAn
(
STTCauHoi int,
MsCauHoi int,
DapAnofTS char(7)
)

create function dbo.Check_Dap_An()
Returns int
begin
declare @SoLuong int;
Set @SoLuong= (SELECT Count(*) FROM TTCauHoi O INNER JOIN TTDapAn C ON C.MsCauHoi = O.MaCH and C.DapAnofTS=O.DapAn)
return @SoLuong;
End;

print dbo.Check_Dap_An()

alter proc [Xem_Dap_An_Sai]
as
SELECT STTCauHoi, MaCH,DapAn FROM TTCauHoi O INNER JOIN TTDapAn C ON C.MsCauHoi = O.MaCH and C.DapAnofTS != O.DapAn
exec [Xem_Dap_An_Sai]

USE [SATHACHBANGLAI1]
GO
/****** Object:  StoredProcedure [dbo].[Xem_Dap_An_Sai]    Script Date: 3/31/2018 10:05:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[Xem_Dap_An_Sai]
as
SELECT STTCauHoi, MaCH,DapAn FROM TTCauHoi O INNER JOIN TTDapAn C ON C.MsCauHoi = O.MaCH and C.DapAnofTS != O.DapAn
