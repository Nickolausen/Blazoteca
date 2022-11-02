# Blazoteca
 Progetto Blazor 5^F

## Documentazione
---
### Come modificare il layout di default del template Blazor
1. Primo step
Crea, all'interno della cartella Shared, un file `.razor` che contiene il layout custom. **DEVE obbligatoriamente contenere la direttiva `@inherits LayoutComponentBase` e, di conseguenza, implementare da qualche parte `@Body` (il corpo del sito)**.

2. Secondo step
Entra all'interno di `App.razor` e rimpiazza tutte le occorrenze di "MainLayout" con il nome del file del custom layout.

---
### Come caricare il Bootstrap Bundle
1. Primo step: ottieni il bundle
Copia tutto il file minificato e incollalo in un file chiamato `bootstrap.bundle.min` situato nel primo livello della cartella `wwwroot`.

2. Secondo step: collega il file al progetto
Cerca `_Layout.cshtml` nella cartella `Pages` e includi il file come se fosse un normale script JS.

---
### Isolare i componenti
Un componente è composto da un file `NomeComponente.razor` contenente il codice HTML e un corrispettivo Scoped CSS `NomeComponente.razor.css`. Per gli stili comuni a tutti i componenti, fai riferimento al foglio di stile `site.css` (le variabili dei colori, per esempio, sono salvate lì).
