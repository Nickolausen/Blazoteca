USE [DB_Bottiglie]
GO

DROP TABLE IF EXISTS [dbo].[Recensioni];
GO

CREATE TABLE Recensioni (
	ID INT IDENTITY(1,1) PRIMARY KEY,
	Utente VARCHAR(25) NOT NULL,
	TestoRecensione VARCHAR(130) NOT NULL,
	Piattaforma VARCHAR(50) NOT NULL
)

INSERT INTO Recensioni(Utente, TestoRecensione, Piattaforma) VALUES ('Nicholas Magi', 'Spedizione veloce, ampia possibilità di scelta e assistenza sempre disponibile.', 'Facebook')
INSERT INTO Recensioni(Utente, TestoRecensione, Piattaforma) VALUES ('Francesco Buda', 'Esperienza positiva. La scelta dei vini é abbastanza varia per essere un enoteca online e con una qualità medio-alta.', 'Trustpilot')
INSERT INTO Recensioni(Utente, TestoRecensione, Piattaforma) VALUES ('Domenico Bini', 'Consigliatissimo!', 'Recensioni Google')
INSERT INTO Recensioni(Utente, TestoRecensione, Piattaforma) VALUES ('Marco Crogioli', 'Ho ordinato più volte del vino e qualche volta anche amari, arrivati ghiacciati e pronti al consumo.', 'Recensioni Google')
INSERT INTO Recensioni(Utente, TestoRecensione, Piattaforma) VALUES ('Luca Pasini', 'I migliori del settore.', 'Recensioni Google')
INSERT INTO Recensioni(Utente, TestoRecensione, Piattaforma) VALUES ('Roberto Saviano', 'Ottimo servizio personalizzato in base alle preferenze ed esigenze del cliente!', 'Twitter')


