# Apple Picker - Enhanced Edition 

A 3D arcade-style catching game built with Unity where players control baskets to catch falling apples while avoiding dangerous branches!

![Unity](https://img.shields.io/badge/Unity-2021.3.33f1-blue)
![C#](https://img.shields.io/badge/C%23-Game%20Development-green)

##  Screenshots
<img width="1800" alt="Apple Picker Gameplay" src="https://github.com/user-attachments/assets/5500a1c1-8bfe-4366-8f8c-935319dfa39f" />

##  Description
Apple Picker is a fun, fast-paced game where you move baskets left and right to catch apples falling from a moving tree. Score points by catching apples, but watch out - catching a branch means instant game over! The game features multiple rounds with increasing difficulty as you lose baskets.

##  Features
- **4 Baskets System**: Start with 4 baskets and lose one each time an apple hits the ground
- **Branch Obstacle**: Occasionally branches fall from the tree - catch one and it's game over!
- **Round Counter**: Progress through 4 rounds as you lose baskets
- **Start Screen**: Clean UI with a start button to begin the game
- **High Score Tracking**: Your best score is saved using PlayerPrefs
- **Restart Button**: Easy restart when the game ends
- **Responsive Controls**: Smooth mouse-controlled basket movement

## How to Play
1. Click **Start Game** to begin
2. Move your mouse left and right to control the baskets
3. Catch apples (+100 points each) and avoid branches
4. Missing an apple = lose a basket and advance to the next round
5. Catching a branch = instant game over
6. Game ends after 4 rounds or when you catch a branch

##  Game Mechanics
- **Apples**: Fall frequently, worth 100 points each
- **Branches**: Fall rarely (~10% chance), cause instant game over
- **Baskets**: Start with 4, lose one per missed apple
- **Rounds**: Progress from Round 1 to Round 4
- **High Score**: Persistent across game sessions

## Getting Started

### Prerequisites
- Unity 2021.3.33f1 or later

### Installation
```bash
git clone https://github.com/Ferannn-TDE/Apple-Picker-Game.git
cd Apple-Picker-Game
```
1. Open the project in Unity
2. Open the `_Scene_0` scene
3. Press Play!

##  Built With
- Unity 2021.3.33f1
- C#
- Unity UI System

##  Project Context
This project was created as part of a Unity game development course, demonstrating skills in:
- Unity game development
- C# scripting
- UI/UX design
- Game state management
- Prefab instantiation
- Collision detection
- Score tracking

##  License
This project is open source and available under the MIT License.

##  Acknowledgments
- Built following Unity game development principles
- Apple Picker base concept from game development curriculum

---

**Enjoy the game! 🎮🍎**
