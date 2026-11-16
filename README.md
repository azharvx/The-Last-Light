# The Last Light

A 3D first-person horror escape game built in Unity, focusing on atmospheric tension, interactive object pickups, and custom player movement mechanics.

## Description

The Last Light is an indie 3D horror puzzle game where the player must navigate through dark, claustrophobic environments, avoid hazards, and locate key items to progress. Developed entirely in Unity using C# scripting, this project features custom player controllers, smooth head-bobbing mechanics, a noise-detection system, and dynamic key-door interaction triggers.

## Screenshots
<img width="765" height="364" alt="last light screenshot" src="https://github.com/user-attachments/assets/5e309868-b6bf-4c96-829a-a1f53bded5d6" />


## Getting Started

### Dependencies

* OS: Windows 10 / 11 (64-bit)
* Game Engine: Unity 6 (6000.6.8f1)
* IDE: Visual Studio Code or Visual Studio (for viewing and editing C# scripts)

### Installing

* Clone or download this repository from GitHub:
```
git clone https://github.com/azharvx/The-Last-Light.git
```
* Open Unity Hub, click **Add -> Add project from disk**, and select the downloaded `The-Last-Light` folder.

### Executing program

* Once the project is open in the Unity Editor, navigate to the **Project Window** and find `Assets/Scenes`.
* Double-click the main game scene (`Room 1`) to open it.
* Press the **Play** button at the top center of the Unity Editor to run the game.

*(Note: The game starts directly into the first room without a main menu screen to streamline the experience.)*

### Controls

* **WASD / Arrow Keys:** Move player
* **Mouse:** Look around
* **Left Shift:** Run faster (increases the noise meter faster)
* **Spacebar:** Jump
* **E:** Pick up keys/crowbar and open doors

## Help

If the noise meter or doors do not respond in the editor, make sure the `NoiseSlider`, `Monster`, and room key/door objects are assigned in the Inspector on the Player object.

*(Note on commit history: The first 4 rooms were built locally in Unity while tracking hours on HackaTime and synced to GitHub together before building and committing Room 5 and the final exit room step by step.)*

## License

This project is open-source and available for educational and portfolio purposes.
