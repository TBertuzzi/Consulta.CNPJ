# Consulta.CNPJ

Obtenha as informações de uma Empresa através do CNPJ

###### Este componente funciona com Qualquer Plataforma .Net.

* .NET Framework 4.6.1 +
* .NET Core
* Xamarin
* Xamarin.Forms

O Componente utiliza o site https://www.receitaws.com.br para obter os dados. Pode existir uma defasagem de ate 10 dias.


**NuGet**

|Name|Info|
| ------------------- | :------------------: |
|ConsultaCNPJ|[![NuGet](https://buildstats.info/nuget/Consulta.CNPJ)](https://www.nuget.org/packages/Consulta.CNPJ/)|


Exemplo

```csharp

 static void Main(string[] args)
 {
    CNPJService service = new CNPJService();

    var cpnj = service.ConsultarCPNJ("05742247000105");
 }

```
