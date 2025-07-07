# ✊✋✌️ Rock Paper Scissors

A fun, single-player Rock Paper Scissors game built with .NET WPF following the MVVM pattern. Challenge a simple AI bot and track your wins, losses, and ties in real time!

---

## 📋 Table of Contents
- [About](#about)  
- [Features](#features)  
- [Technologies](#technologies)  
- [Architecture](#architecture)  
- [Installation & Setup](#installation--setup)  

---

## 🧠 About

This project was a first jump into interactive AI: a desktop Rock Paper Scissors game with a simple decision‑making bot. It demonstrates WPF UI development, command binding, and basic MVVM structure.

---

## 🚀 Features

- **Interactive Gameplay**  
  Click “Rock,” “Paper,” or “Scissors” to play against the AI.  
- **Simple AI Bot**  
  Chooses moves at random, letting you practice strategy.  
- **Score Tracking**  
  Displays current wins.  
- **MVVM Pattern**  
  Clean separation of View, ViewModel, and Model for maintainability.  
- **Responsive UI**  
  Resizes smoothly and provides instant feedback on each round.

---

## 🛠️ Technologies

- **.NET 8**  
- **C#**  
- **WPF (Windows Presentation Foundation)**  
- **MVVM Light Toolkit** 
- **Visual Studio 2022**

---

## 🏗️ Architecture

- **Model**  
  - `GameResult` enum & result-calculation logic  
  - `Score` class to hold win/loss/tie counts  
- **ViewModel**  
  - `MainViewModel` exposes `ICommand` properties for each move  
  - Properties for current scores and last-round result  
- **View**  
  - `MainWindow.xaml` binds buttons and labels to ViewModel commands & properties  
  - DataTemplates for clean UI separation  

---

## ⚙️ Installation & Setup

1. **Prerequisites**  
   - Windows 10/11  
   - .NET SDK 8.0  
   - Visual Studio 2022 (or newer) with WPF workload  

2. **Clone the repository**  
   ```bash
   git clone https://github.com/MarcusK00/RockPaperScissors.git
   cd RockPaperScissors
