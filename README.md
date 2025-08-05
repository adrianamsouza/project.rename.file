# rename.file

Projeto em C# para renomear arquivos `.csv` de uma pasta origem, movendo-os para uma pasta destino com um novo nome baseado em timestamp.

## Funcionalidade

- Busca todos os arquivos na pasta de origem.
- Renomeia cada arquivo com o padrão: `yyyyMMdd_HHmm_wallet.csv`, onde `yyyyMMdd_HHmm` representa a data e hora do processamento.
- Move os arquivos renomeados para a pasta de destino.
- Garante que não haja sobrescrita de arquivos já existentes na pasta de destino.

## Como usar

1. Altere os caminhos das variáveis `fileActual` (pasta de origem) e `newDestine` (pasta de destino) no arquivo [`Program.cs`](Program.cs) conforme sua necessidade.
2. Execute o projeto:

```sh
dotnet run
```
