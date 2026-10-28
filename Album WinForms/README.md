# Album WinForms

Esercizio C# con `DataTable` e `DataGridView`, inclusa la parte facoltativa sui brani.

Scegli una categoria e premi **Mostra album**. Con **Calcola statistiche** vedi il titolo più vecchio e la durata media degli album in griglia. Selezionando un album, nella seconda griglia compaiono i suoi brani.

`Album` e `Brani` contengono i dati di esempio. `Dati` filtra le tabelle e calcola le statistiche. `WindowsFormAlbum` gestisce gli eventi; il file `.Designer.cs` contiene i controlli.

## Avvio

Servono Windows e .NET 10. Dalla cartella del repository:

```sh
dotnet run --project "Album WinForms/AlbumWinForms.csproj"
```

Puoi anche aprire il `.csproj` in Visual Studio. Su macOS puoi compilare con `dotnet build`, ma per eseguire la form serve Windows.

## Dati di prova

| Categoria | Album più vecchio | Durata media in minuti |
|---|---|---:|
| rock | The dark side of the moon | 50,50 |
| classica | Variazioni Goldberg | 62,50 |
| jazz | Kind of Blue | 40,50 |
| pop | Arrival | 48,00 |

Ci sono due album per categoria e due brani per album. Cambiare la ComboBox non modifica la griglia finché non premi **Mostra album**.

## Stile del codice

Come in Parco veicoli: una classe per file, nessun namespace, tipi espliciti e parentesi graffe su righe separate. `.editorconfig` fissa quattro spazi di indentazione e segnala gli errori di stile durante la compilazione.

Per controllare la formattazione:

```sh
dotnet format whitespace "Album WinForms/AlbumWinForms.csproj" --verify-no-changes --no-restore
```
