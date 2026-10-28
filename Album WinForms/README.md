# Album WinForms

Esercizio C# con `DataTable` e `DataGridView`, inclusa la parte facoltativa sui brani.

Scegli una categoria e premi **Mostra album**. Con **Calcola statistiche** vedi il titolo più vecchio e la durata media degli album in griglia. Selezionando un album, nella seconda griglia compaiono i suoi brani.

## Struttura

Come in ParcoVeicoli, la soluzione `WinFormsAppAlbum.slnx` contiene due progetti:

- `WinFormsLibraryAlbum`: class library con i dati. `Album` e `Brani` contengono i dati di esempio, `Dati` costruisce le `DataTable` filtrate e calcola le statistiche.
- `WinFormsAppAlbum`: applicazione Windows Forms che referenzia la library. `FormAlbum` gestisce gli eventi, il file `.Designer.cs` contiene i controlli.

## Avvio

Apri `WinFormsAppAlbum.slnx` in Visual Studio e avvia `WinFormsAppAlbum`, oppure dalla cartella del repository:

```sh
dotnet run --project "Album WinForms/WinFormsAppAlbum/WinFormsAppAlbum.csproj"
```

Servono Windows e .NET 10.

## Dati di prova

| Categoria | Album più vecchio | Durata media in minuti |
|---|---|---:|
| rock | The dark side of the moon | 50,50 |
| classica | Variazioni Goldberg | 62,50 |
| jazz | Kind of Blue | 40,50 |
| pop | Arrival | 48,00 |

Ci sono due album per categoria e due brani per album. Cambiare la ComboBox non modifica la griglia finché non premi **Mostra album**.
