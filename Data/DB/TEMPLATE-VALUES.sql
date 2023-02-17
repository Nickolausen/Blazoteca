USE [DB_Bottiglie]
GO

DROP TABLE IF EXISTS [dbo].[Bottiglia];
GO

CREATE TABLE Bottiglia (
	ID INT IDENTITY(1,1) PRIMARY KEY,
	Nome VARCHAR(150) NOT NULL,
	AnnoProduzione INT NOT NULL,
	ProvinciaProduzione VARCHAR(50) NOT NULL,
	RegioneProduzione VARCHAR(30) NOT NULL,
	Prezzo FLOAT(2) NOT NULL,
	PercentualeSconto INT DEFAULT 0 NOT NULL,
	Gradazione FLOAT(2) NOT NULL,
	Descrizione VARCHAR(500) NOT NULL,
	PercorsoImmagine VARCHAR(500) NOT NULL
)

INSERT INTO Bottiglia(Nome, AnnoProduzione, ProvinciaProduzione, RegioneProduzione, Prezzo, PercentualeSconto, Gradazione, Descrizione, PercorsoImmagine) 
	VALUES ('Romandiola Romagna Albana Dolce Aura Dolce', 2019, 'Ravenna (RA)', 'Emilia-Romagna', 8.54, 0, 9.00, 'L''Albana di Romagna DOCG è un''uva antichissima conosciuta e descritta da oltre 100 anni; 
			è il primo vino bianco italiano ad ottenere la DOCG. Le uve vengono raccolte manualmente la prima decade di settembre e la fermentazione avviene in acciaio in assenza delle bucce. 
			Affinamento per 8 mesi sulle fecce fini.', 'https://static.xtrawine.com/Global/Images/XW/products/wines/26129_RomandiolaRomagnaAlbanaDolceAuraDolce_2019_1.jpg')

INSERT INTO Bottiglia(Nome, AnnoProduzione, ProvinciaProduzione, RegioneProduzione, Prezzo, PercentualeSconto, Gradazione, Descrizione, PercorsoImmagine) 
	VALUES ('Bosco Eliceo DOP Fortana Frizzante', 2020, 'Ferrara (FE)', 'Emilia-Romagna', 6.90, 5, 9.00, 'Colore rosso rubino vivace con riflessi porpora, naso caratterizzato da frutti rossi e neri freschi, ciliegia e amarena, su un fondo scuro con note terrose/vegetali. Al sorso è rustico e asciutto, lascia il palato magnificamente pulito.', 'https://cdn.shopify.com/s/files/1/0410/8887/6700/products/Matterellifortanafrizz_600x.png')

INSERT INTO Bottiglia(Nome, AnnoProduzione, ProvinciaProduzione, RegioneProduzione, Prezzo, PercentualeSconto, Gradazione, Descrizione, PercorsoImmagine) 
	VALUES ('Colli Bolognesi DOP Merlot "Guidesco"', 2018, 'Bologna (BO)', 'Emilia-Romagna', 25.50, 0, 14.5, 'Rubino fitto e luminoso, denso. Naso incisivo e modulato su sentori di prugna in confettura, un varietale vegetale, tabacco, spezie dolci, pepe, legno, polvere di caffé e balsamicità. 
			Sorso solido e ben avvolgente, arriva ad esprimere tutta la sua grande personalità in un equilibrio perfetto. Ritorno di frutta e spezie a regalare infinita lunghezza.', 'https://cdn.shopify.com/s/files/1/0410/8887/6700/products/Folesanoguidesco_600x.png')

INSERT INTO Bottiglia(Nome, AnnoProduzione, ProvinciaProduzione, RegioneProduzione, Prezzo, PercentualeSconto, Gradazione, Descrizione, PercorsoImmagine) 
	VALUES ('Colli d''Imola DOP Cabernet Sauvignon Riserva "Grifaia"', 2019, 'Bologna (BO)', 'Emilia-Romagna', 13.20, 0, 14.00, 'Colore rosso rubino intenso con riflessi granati.
			Al naso sensazioni balsamiche speziate intrecciate ad eleganti nuances di cioccolato, tabacco vaniglia e cacao.
			In bocca ben bilanciato con un''acidità ed un tannino eleganti. Finale lungo e persistente.', 'https://cdn.shopify.com/s/files/1/0410/8887/6700/products/merlotta_grifaia_7473bd02-ae29-4eb6-b697-90cb6152bf9d_600x.png')

INSERT INTO Bottiglia(Nome, AnnoProduzione, ProvinciaProduzione, RegioneProduzione, Prezzo, PercentualeSconto, Gradazione, Descrizione, PercorsoImmagine) 
	VALUES ('Romagna DOP Sangiovese Superiore', 2021, 'Forlì-Cesena (FC)', 'Emilia-Romagna', 6.60, 10, 13.50, 'Colore rosso rubino, al naso sentori fruttati (ciliegia, prugna) e floreali (violetta).
			in bocca asciutto e fresco. Caratteristico.', 'https://cdn.shopify.com/s/files/1/0410/8887/6700/products/balducci_sang_sup_600x.png')
