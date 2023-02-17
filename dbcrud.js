var config = require("./dbconfig")
const sql = require("mssql")

async function getElencoBottiglie() {
    try {
        let pool = await sql.connect(config);
        let elenco = await pool.request().query("SELECT * FROM Bottiglia");

        return elenco.recordsets;
    }
    catch (error) {
        console.log(error);
    }
}

async function getBottiglia(id) {
    try {
        let pool = await sql.connect(config);
        let elenco = await pool.request()
            .input('id_bottiglia', sql.Int, id)
            .query("SELECT * FROM Bottiglia WHERE ID=@id_bottiglia");

        return elenco.recordsets;
    }
    catch (error) {
        console.log(error);
    }
}

async function getBottiglieByDescPrice() {
    try {
        let pool = await sql.connect(config);
        let elenco = 
            await pool.request().query("SELECT * FROM Bottiglia ORDER BY Bottiglia.Prezzo DESC");
        
        return elenco.recordsets;
    } catch (error) {
        console.log(error)
    }
}

async function getBottiglieByAscPrice() {
    try {
        let pool = await sql.connect(config);
        let elenco = 
            await pool.request().query("SELECT * FROM Bottiglia ORDER BY Bottiglia.Prezzo ASC");
        
        return elenco.recordsets;
    } catch (error) {
        console.log(error)
    }
}

async function getBottiglieByNewest() {
    try {
        let pool = await sql.connect(config);
        let elenco = await pool.request().query("SELECT * FROM Bottiglia ORDER BY ID DESC");

        return elenco.recordsets;
    }
    catch (error) {
        console.log(error);
    }
}

async function getRecensioni() {
    try {
        let pool = await sql.connect(config);
        let elenco = await pool.request().query("SELECT * FROM Recensioni");

        return elenco.recordsets;
    }
    catch (error) {
        console.log(error);
    }
}

module.exports = {
    getElencoBottiglie: getElencoBottiglie,
    getBottiglia: getBottiglia,
    getBottiglieByDescPrice: getBottiglieByDescPrice,
    getBottiglieByAscPrice: getBottiglieByAscPrice,
    getBottiglieByNewest: getBottiglieByNewest,
    getRecensioni: getRecensioni
}