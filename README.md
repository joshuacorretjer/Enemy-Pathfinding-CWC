# Enemy Pathfinding

## Overview

A Unity 3D enemy AI and pathfinding prototype developed during a **Create with Code Live – Spring 2020** community-requested live session. The project explores Unity's Navigation Mesh (NavMesh) system to enable enemies to navigate an environment and move toward designated targets.

The prototype focuses on configuring navigable areas, implementing NavMesh Agents, and scripting enemy movement using destination-based pathfinding.

## Features

- **Navigation Mesh (NavMesh):** Configured navigable areas to define where enemy AI can and cannot move within the environment.
- **NavMesh Agent:** Implemented NavMesh Agents to control enemy navigation and movement.
- **Enemy Pathfinding:** Created a C# script that assigns destinations to NavMesh Agents, allowing enemies to navigate toward designated goals.
- **AI Navigation:** Used Unity's navigation system to handle enemy movement across the environment.

## What I Learned & Implemented

### Navigation Mesh and Environment Setup
- Learned how to create and bake Navigation Meshes to define walkable areas within a level.
- Configured navigation surfaces to determine which parts of the environment enemies can traverse.
- Explored how NavMeshes provide navigation data that AI agents use to calculate paths through an environment.

### NavMesh Agents and Pathfinding
- Created and configured NavMesh Agents to control enemy navigation.
- Developed a C# script that assigns destinations to NavMesh Agents, allowing enemies to move toward designated targets.
- Learned how NavMesh Agents use the baked navigation data to navigate around the environment.

### Additional Concepts Explored
- Learned about dynamically generating NavMeshes at runtime.
- Explored the role of NavMesh Obstacles in navigation and how they can affect agent movement and navigation paths.
- Researched dynamic NavMesh generation as an approach for environments that change during gameplay.

## Technologies & Tools

- **Game Engine:** Unity
- **Programming Language:** C#
- **IDE:** Visual Studio
- **Concepts:** Enemy AI, Artificial Intelligence, Navigation Meshes (NavMesh), NavMesh Agents, Pathfinding, Destination-Based Movement, Dynamic NavMesh Generation, NavMesh Obstacles

## Course

**Create with Code Live – Spring 2020**

A remote Unity course taught by professionals working at Unity. This project was developed during a community-requested live session based on one of the most upvoted topics in the Create with Code Live Connect group.
