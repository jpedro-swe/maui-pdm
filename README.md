# 🍕 MAUI PDM - História da Pizza

<p align="center">
  <img src="https://img.shields.io/badge/MAUI-.NET%2010-512BD4?style=for-the-badge&logo=dotnet" alt="MAUI" />
  <img src="https://img.shields.io/badge/C%23-100%25-239120?style=for-the-badge&logo=csharp" alt="C#" />
  <img src="https://img.shields.io/badge/Platform-Android%20%7C%20iOS%20%7C%20Windows-0078D4?style=for-the-badge" alt="Plataformas" />
</p>

Aplicativo mobile desenvolvido em .NET MAUI para apresentar a história de duas pizzas famosas: a calabresa e a marguerita. O projeto foi criado como exemplo prático de uso de `TabbedPage` e navegação por abas em interfaces mobile.

## 📱 Sobre o projeto

Este repositório contém uma aplicação mobile simples, visualmente atraente e educativa, com foco em:

- criação de interfaces com XAML;
- uso de `TabbedPage` em MAUI;
- organização da estrutura por views;
- apresentação de conteúdo com imagens e textos;
- estudo de programação para dispositivos móveis.

A aplicação foi desenvolvida em linguagem C# com a tecnologia .NET MAUI, permitindo execução em diferentes plataformas:

- Android
- iOS
- macOS
- Windows

## ✨ Funcionalidades

- Navegação por abas com duas páginas principais;
- Conteúdo histórico sobre a pizza calabresa;
- Conteúdo histórico sobre a pizza marguerita;
- Layout visual amigável com imagens e fundo temático;
- Estrutura pronta para expansão e adaptação.

## 🧩 Estrutura do projeto

```text
maui-pdm/
├── App.xaml
├── App.xaml.cs
├── MauiProgram.cs
├── appUsandoTabbedPage_45732167.csproj
├── appUsandoTabbedPage_45732167.slnx
├── LICENSE.txt
├── README.md
├── Platforms/
│   └── Windows/
├── Properties/
├── Resources/
│   ├── AppIcon/
│   ├── Fonts/
│   ├── Images/
│   ├── Raw/
│   └── Splash/
├── Views/
│   └── Principal.xaml
│   └── Principal.xaml.cs
└── .gitignore
```

## 🛠️ Tecnologias utilizadas

- C#
- .NET MAUI
- XAML
- Visual Studio / .NET SDK
- Microsoft.Extensions.Logging

## 🚀 Como executar

### 1) Clone o repositório

```bash
git clone https://github.com/jpedro-swe/maui-pdm.git
cd maui-pdm
```

### 2) Restaure os pacotes

```bash
dotnet restore
```

### 3) Compile o projeto

```bash
dotnet build
```

### 4) Execute o aplicativo

Para Android:

```bash
dotnet build -f net10.0-android
```

> Caso queira rodar em outra plataforma, ajuste o target framework conforme o ambiente de desenvolvimento disponível.

## 📸 Tela principal

A tela principal está localizada em `Views/Principal.xaml` e utiliza `TabbedPage` para separar os conteúdos em abas com foco nas principais pizzas históricas.

## 🧠 Objetivo didático

Este projeto foi pensado como um exemplo didático para a disciplina de Programação para Dispositivos Móveis, demonstrando conceitos básicos de:

- desenvolvimento mobile;
- criação de interfaces com XAML;
- navegação em abas;
- uso de imagens e textos em app mobile;
- organização de código em projetos MAUI.

## 📘 Licença

Este projeto está licenciado sob a licença MIT. Consulte o arquivo `LICENSE.txt` para mais detalhes.

## 👤 Autor

Projeto desenvolvido por João Pedro em contexto de estudo e prática de desenvolvimento de aplicações móveis com .NET MAUI.

---

Se quiser, também posso criar uma versão do README com visual mais premium, com badges, screenshot placeholders e uma seção de "Como funciona" mais detalhada.
