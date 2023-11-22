SELECT dbo.tblStockIn.id, dbo.tblStockIn.refNo, dbo.tblStockIn.bookCode, dbo.tblBook.bookTitle, dbo.tblStockIn.qty, dbo.tblStockIn.stockInDate, dbo.tblStockIn.stockInBy FROM dbo.tblBook INNER JOIN dbo.tblStockIn ON dbo.tblBook.bookCode = dbo.tblStockIn.bookCode

SELECT * from tblStockIn

SELECT bookCode, bookTitle, qty FROM tblBook WHERE bookTitle LIKE 'The%' ORDER BY bookTitle;

DELETE FROM tblStockIn