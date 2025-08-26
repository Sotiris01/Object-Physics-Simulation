# Unity 3D Object Physics Simulation Game

A Unity 3D physics simulation game where you can control objects, create dynamic elements, and observe physics interactions in real-time.

## Game Description

This is a 3D physics sandbox game built in Unity where players can:
- Control different objects (capsules, spheres) using keyboard input
- Create small physics objects (cubes, spheres, cylinders) that interact with each other
- Adjust object speeds and observe realistic physics collisions
- Navigate the 3D environment using mouse look controls

## Controls

### Object Movement
- **Arrow Keys**: Move the SPH (sphere) object
  - Left/Right arrows: Move along X-axis
  - Up/Down arrows: Move along Y-axis
  - Plus/Minus (or Keypad +/-): Move along Z-axis

### Capsule Movement
- **W/S**: Move forward/backward
- **A/D**: Move left/right
- **E/X**: Move up/down

### Camera Controls
- **Mouse**: Look around (first-person camera)
- Mouse cursor is locked during gameplay

### Object Creation & Speed
- **Space**: Create random objects (cubes, spheres, cylinders)
  - Single press: Creates one object
  - Hold Space: Continuously creates objects after 0.5 seconds
- **> (Period)**: Increase object speed
- **< (Comma)**: Decrease object speed
- Speed range: 1 to 150 units

## Features

- **Random Object Properties**: Each created object has:
  - Random color (RGB values)
  - Random size (1-10x scale)
  - Random initial velocity direction
  
- **Physics Simulation**: All objects use Unity's Rigidbody physics system for realistic collisions and movement

- **Real-time Speed Control**: Adjust the speed of newly created objects during gameplay

## Technical Details

- Built with Unity Engine
- Uses C# scripting
- Implements Unity's physics system (Rigidbody components)
- Real-time input handling for smooth controls

## Scripts Overview

- `SPHMovement.cs`: Controls sphere movement with arrow keys
- `CapsuleMovement.cs`: Controls capsule movement with WASD keys
- `MouseLook.cs`: Handles camera rotation with mouse input
- `CreateSmallObjects.cs`: Manages dynamic object creation
- `Object.cs`: Defines properties and behavior of created objects
- `ObjectsSpeed.cs`: Manages speed control system

## Installation & Setup

1. Clone this repository
2. Open the project in Unity (version compatible with the project)
3. Open the main scene from the Scenes folder
4. Press Play to start the simulation

## Project Structure

```
Assets/
├── Materials/          # Material files for objects
├── Physic Materials/   # Physics materials
├── Prefabs/           # Prefab objects
├── Resources/         # Resource files
├── Scenes/            # Scene files
└── Scripts/           # C# scripts
```

## Requirements

- Unity Engine (compatible version)
- Windows/Mac/Linux system capable of running Unity games

## Academic Context

This project was developed as part of a Computer Graphics course (Γραφικά) at the University of Ioannina, 4th year, 1st semester, 2020.

## License

This project is for educational purposes.
