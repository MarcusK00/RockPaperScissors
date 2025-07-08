# ✊✋✌️ Rock Paper Scissors

A fun, single-player Rock Paper Scissors game built with .NET WPF following the MVVM pattern. Challenge a simple AI bot and track your wins, losses, and ties in real time!

---
![homesc](https://github.com/user-attachments/assets/bba1f046-27a7-4e3a-80b8-dd981b2ac950)
![winsc](https://github.com/user-attachments/assets/8a0a3d23-7f20-4d70-9886-1dff54f734d7)
![drawsc](https://github.com/user-attachments/assets/15f25199-ab52-4ed1-ba8b-0e15753dabbe)



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
