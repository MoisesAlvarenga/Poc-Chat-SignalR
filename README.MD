# Projeto chat em tempo real com C# e TypeScript usando as libs Microsoft.AspNetCore.SignalR e Microsoft.TypeScript.MSBuild no .Net


Este é o README do projeto C# com TypeScript utilizando as bibliotecas Microsoft.AspNetCore.SignalR e Microsoft.TypeScript.MSBuild no ambiente .NET. Neste documento, apresentarei uma descrição abrangente do projeto, sua finalidade, recursos principais e instruções sobre como executá-lo.

## Descrição do Projeto

O projeto C# com TypeScript é uma aplicação web em tempo real que utiliza o framework .NET Core em conjunto com o Microsoft.AspNetCore.SignalR e Microsoft.TypeScript.MSBuild. A aplicação oferece uma solução para implementar funcionalidades de comunicação em tempo real entre clientes e servidor.
## Principais Recursos

- Comunicação em tempo real: O projeto utiliza o Microsoft.AspNetCore.SignalR para permitir a comunicação bidirecional e em tempo real entre o servidor e os clientes conectados.
- Escalabilidade: A arquitetura do SignalR garante que a aplicação seja escalável, tornando-a adequada para suportar um grande número de conexões simultâneas.
- Integração com TypeScript: O Microsoft.TypeScript.MSBuild é utilizado para fornecer suporte ao TypeScript, permitindo o desenvolvimento robusto e com tipagem forte na camada de frontend.

## Requisitos do Sistema

Antes de executar o projeto, certifique-se de ter os seguintes requisitos instalados em seu sistema:

1. [.NET SDK](https://dotnet.microsoft.com/download): O projeto requer o .NET Core SDK para compilação e execução.
2. [Node.js](https://nodejs.org): O Node.js é necessário para a instalação e gerenciamento das dependências do frontend.
3. [Visual Studio Code](https://code.visualstudio.com/) (opcional): Embora você possa usar qualquer editor de texto, o Visual Studio Code oferece suporte excelente para desenvolvimento C# e TypeScript.

## Como Executar o Projeto

Siga as etapas abaixo para executar o projeto localmente:

1. Clone este repositório em sua máquina local:

```bash
git clone https://github.com/MoisesAlvarenga/Poc-Chat-SignalR
```

2. Rode o seguinte comando e o projeto vai instalar todas as dependencias, fazer o build e levantar um servidor no endereço http://localhost:5033/.

```bash
npm run start-deploy-project
```
