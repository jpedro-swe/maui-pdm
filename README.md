# 🍕 MAUI PDM - História da Pizza

Aplicativo mobile desenvolvido em .NET MAUI para demonstrar o uso de `TabbedPage` em um projeto de disciplina de Programação para Dispositivos Móveis.

O app apresenta duas abas com informações sobre a origem e a história de duas pizzas muito conhecidas: a calabresa e a marguerita, com textos ilustrados e uma interface visual agradável.

## 📱 Visão geral

Este projeto foi criado para explorar:

- uso de `TabbedPage` em MAUI;
- organização de telas em `Views`;
- criação de interface com XAML;
- desenvolvimento de um app para Android/iOS/macOS/Windows;
- apresentação de conteúdo educativo em formato de app mobile.

## ✨ Funcionalidades

- interface com múltiplas abas de navegação;
- páginas com textos sobre a origem da pizza calabresa e da pizza marguerita;
- imagens e layout visual com tema de pizzaria;
- estrutura básica pronta para expansão.

## 🛠️ Stack tecnológica

- C#
- .NET MAUI
- XAML
- Microsoft.Extensions.Logging

## 📁 Estrutura do projeto

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
└── Principal.xaml.cs
```

## 🚀 Pré-requisitos

Antes de rodar o projeto, certifique-se de ter instalado:

- .NET SDK 10.0
- workload do MAUI
- um emulador ou dispositivo físico para executar o app

Se estiver em Windows, também pode ser necessário configurar o ambiente para Android/Windows MAUI.

## ▶️ Como executar

1. Clone o repositório:

```bash
git clone https://github.com/jpedro-swe/maui-pdm.git
cd maui-pdm
```

2. Restaure os pacotes:

```bash
dotnet restore
```

3. Execute o build do projeto:

```bash
dotnet build
```

4. Inicie o app em um emulador ou dispositivo:

```bash
dotnet build -f net10.0-android
```

> Ajuste a plataforma conforme o ambiente de desenvolvimento e o dispositivo alvo.

## 🧠 Sobre a tela principal

A tela principal foi implementada em `Views/Principal.xaml` e usa `TabbedPage` para separar os conteúdos em abas, oferecendo uma navegação simples e visualmente atrativa.

## 📌 Observações

Este projeto é uma aplicação didática, ideal para fins de estudo e aprendizado de desenvolvimento móvel com .NET MAUI.

## 🏷️ Licença

Este projeto está licenciado sob a licença MIT conforme o arquivo `LICENSE.txt`.

---

Desenvolvido como exemplo de aplicação MAUI para a disciplina de Programação para Dispositivos Móveis.
