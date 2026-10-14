# 🎮 AZ: FRONTIER ZERO
### A Low-Poly 3D Third-Person Shooter Built with Unity

> **Explore the frontier. Survive the threat. Master every perspective.**

AZ: Frontier Zero is a low-poly 3D third-person shooter (TPS) developed with Unity and C#. Set in a hostile frontier filled with abandoned outposts, enemy forces, and unexplored locations, the game focuses on responsive combat, exploration, mission-based gameplay, and stylized environments.

The initial version will feature an over-the-shoulder third-person camera. A first-person camera mode is planned for a future update, allowing players to switch perspectives while retaining the core combat and gameplay systems.

The project is being developed from scratch, with an emphasis on modular gameplay systems, cross-platform input, optimized low-poly visuals, and a scalable camera architecture.

---

## 🎮 Game Overview

| Category | Details |
|---|---|
| Game Title | AZ: Frontier Zero |
| Genre | Third-Person Shooter (TPS) |
| Perspective | Third-person initially; first-person planned |
| Engine | Unity |
| Programming Language | C# |
| Art Style | Stylized low-poly 3D |
| Gameplay | Single-player, mission-based |
| Combat | Ranged combat and weapon handling |
| Camera | Over-the-shoulder, with future perspective switching |
| Target Platforms | Windows, macOS, Linux, Android, iOS |
| Project Status | In development |

---

## 🔁 Core Gameplay Loop

1. **Deploy:** Enter a mission with the player character.
2. **Explore:** Navigate the environment using third-person movement.
3. **Engage:** Aim, shoot, and fight hostile enemies.
4. **Manage:** Monitor health, ammunition, and available supplies.
5. **Complete objectives:** Eliminate targets, activate devices, or reach mission locations.
6. **Extract:** Complete the final mission objective.
7. **Progress:** Unlock additional missions, weapons, and equipment as the game expands.

---

## ⚙️ Gameplay Mechanics

### 1. Third-Person Character Controller

- Third-person movement with a visible player character.
- Over-the-shoulder camera.
- Camera rotation using mouse or touchscreen input.
- Walking, running, and jumping.
- Camera-relative movement.
- Character rotation toward the movement or aiming direction.
- Collision handling and ground detection.
- Optional aiming mode with tighter camera positioning.
- Animation integration for idle, movement, running, aiming, shooting, and reloading.

### 2. Future First-Person Mode

A first-person camera mode is planned for a future update.

Planned capabilities:

- Switch between third-person and first-person perspectives.
- First-person aiming and camera controls.
- Perspective-appropriate weapon positioning.
- First-person firing and aiming animations where needed.
- Shared health, ammunition, weapon, and damage systems.
- Consistent player controls across both perspectives.
- Platform-specific camera-switching controls.

The camera system will be designed to support both perspectives without duplicating the entire gameplay architecture.

### 3. Shooting and Weapon Handling

- Third-person aiming and shooting.
- Crosshair-based targeting.
- Hitscan shooting for initial weapons.
- Fire-rate and reload management.
- Magazine and reserve ammunition.
- Weapon switching.
- Hit detection and damage calculation.
- Muzzle flashes, impact effects, and sound feedback.
- Camera and weapon recoil.

### 4. Health and Damage

- Player health system.
- Enemy damage and hit reactions.
- Health display in the HUD.
- Player death and game-over state.
- Restart and mission retry options.

### 5. Mission Objectives

- Eliminate hostile targets.
- Reach designated locations.
- Activate mission-related objects.
- Collect ammunition and supplies.
- Track objectives through the HUD.
- Display mission success and failure states.

---

## 📷 Camera System

### Initial Camera: Third-Person

The initial release will use an over-the-shoulder camera that keeps the player character visible during exploration and combat.

Planned features:

- Smooth camera follow.
- Mouse and touch camera rotation.
- Adjustable camera sensitivity.
- Camera collision handling to reduce clipping through walls.
- Optional aiming shoulder offset.
- Character orientation aligned with movement or aim.
- Zoom or camera-distance adjustment where appropriate.

### Future Camera: First-Person

The future first-person mode will provide a closer, immersive perspective.

Planned features:

- First-person camera placement.
- Perspective-specific aiming and weapon positioning.
- Camera transition or toggle behaviour.
- Appropriate camera clipping and collision handling.
- Separate animation presentation where required.

### Perspective Switching

The intended camera system will support a future player-controlled toggle between third-person and first-person modes.

**Technical design principle:** The camera should be independent of the core combat systems. Both perspectives should reuse the same player health, weapon inventory, ammunition, enemy AI, damage handling, and mission logic wherever practical.

---

## 🎯 Aiming and Combat

The third-person combat system will prioritize clear targeting and responsive shooting.

- Over-the-shoulder aiming.
- Screen-centre crosshair.
- Camera-based target selection.
- Weapon muzzle alignment with the intended target.
- Recoil and firing feedback.
- Enemy hit reactions.
- Optional aim-down-sights mode.

A robust implementation can use a raycast from the camera to identify the intended target, then calculate the firing direction from the weapon muzzle toward that target. This helps avoid shots that visibly travel away from the crosshair.

The future first-person mode can reuse the targeting and damage logic while adapting the camera and weapon presentation.

---

## 🖥️ User Interface and HUD

The interface will support third-person gameplay initially and accommodate first-person gameplay later.

### In-Game HUD

| Element | Purpose |
|---|---|
| Crosshair | Indicates the aiming point |
| Health Bar | Displays remaining player health |
| Ammo Counter | Shows magazine and reserve ammunition |
| Weapon Indicator | Identifies the equipped weapon |
| Objective Tracker | Displays the current mission objective |
| Interaction Prompt | Shows nearby usable objects |
| Hit Feedback | Communicates successful hits |
| Camera Mode Indicator | Identifies the active perspective when useful |
| Pause Button | Opens the pause menu |

### Main Menu

- Game title and branding.
- Play.
- Settings.
- Controls.
- Quit or exit where supported.

### Settings Menu

- Camera sensitivity.
- Camera distance and shoulder offset where supported.
- Graphics quality.
- Audio volume.
- Desktop display options where supported.
- Touch-control configuration.

---

## 🎮 Controls

### Desktop Controls

| Action | Default Input |
|---|---|
| Move | W, A, S, D |
| Rotate Camera | Mouse |
| Aim | Right Mouse Button |
| Fire | Left Mouse Button |
| Jump | Space |
| Sprint | Left Shift |
| Reload | R |
| Switch Weapon | Mouse Wheel |
| Interact | E |
| Switch Camera | Planned future key, such as V |
| Pause | Escape |

### Mobile Controls

- Virtual joystick for movement.
- Touch-drag camera control.
- Dedicated fire button.
- Aim and reload buttons.
- Jump and sprint buttons.
- Weapon switching controls.
- Pause button.
- A future camera-switch button.

Desktop key bindings and mobile button layouts may be configurable.

---

## ✨ Planned Features

- [ ] Third-person character controller.
- [ ] Over-the-shoulder camera.
- [ ] Camera-relative movement.
- [ ] Character aiming and rotation.
- [ ] Character animations.
- [ ] Shooting and hit detection.
- [ ] Health and damage systems.
- [ ] Weapon and ammunition management.
- [ ] Enemy AI and combat behaviours.
- [ ] Low-poly environment and level design.
- [ ] Mission and objective system.
- [ ] HUD and menus.
- [ ] Mobile touchscreen controls.
- [ ] Windows, macOS, and Linux builds.
- [ ] Android and iOS builds.
- [ ] Future first-person camera mode.
- [ ] Future perspective-switching system.
- [ ] Cross-perspective weapon and animation support.
- [ ] Performance optimization.

---

## 🗺️ Updated Development Roadmap

### Phase 1 — Project Foundation

- [x] Create the Unity project.
- [x] Configure URP and project settings.
- [x] Set up Git and `.gitignore`.
- [ ] Organize scenes, scripts, assets, and prefabs.
- [ ] Create a low-poly test environment.

**Goal:** Establish a clean and scalable foundation.

### Phase 2 — Third-Person Character Controller

- [ ] Implement player movement.
- [ ] Add an over-the-shoulder camera.
- [ ] Implement camera-relative movement.
- [ ] Add camera rotation and sensitivity.
- [ ] Implement character rotation.
- [ ] Add jumping and ground detection.
- [ ] Handle camera and player collision.

**Goal:** Create a responsive third-person controller.

### Phase 3 — Character Animation

- [ ] Integrate the player model.
- [ ] Set up idle and movement animations.
- [ ] Add running and jumping animations.
- [ ] Implement aiming and shooting animations.
- [ ] Add reloading and weapon-switch animations.

**Goal:** Make the character visually responsive to player input.

### Phase 4 — Combat Systems

- [ ] Implement camera-based targeting.
- [ ] Add weapon firing and hit detection.
- [ ] Implement health and damage.
- [ ] Add ammunition and reloading.
- [ ] Add enemy hit reactions and death.
- [ ] Integrate combat audio and effects.

**Goal:** Complete the core third-person combat loop.

### Phase 5 — Enemy AI and Level Design

- [ ] Create enemy prefabs.
- [ ] Implement patrol, detection, pursuit, and attack.
- [ ] Create a low-poly test level.
- [ ] Add cover and combat areas.
- [ ] Implement mission objectives.
- [ ] Test gameplay difficulty and navigation.

**Goal:** Create a complete playable mission.

### Phase 6 — UI and Game Flow

- [ ] Create the main menu.
- [ ] Implement the gameplay HUD.
- [ ] Add pause and game-over menus.
- [ ] Display health and ammunition.
- [ ] Implement mission success and failure.
- [ ] Add restart and return-to-menu options.

**Goal:** Make the game playable from launch to mission completion.

### Phase 7 — Mobile and Desktop Controls

- [ ] Integrate the Unity Input System.
- [ ] Add touchscreen movement and aiming.
- [ ] Implement mobile firing and interaction buttons.
- [ ] Adapt the HUD for different aspect ratios.
- [ ] Configure desktop controls.
- [ ] Test input consistency across devices.

**Goal:** Deliver usable controls across the target platforms.

### Phase 8 — First-Person Mode

- [ ] Add a first-person camera rig.
- [ ] Implement perspective switching.
- [ ] Adjust camera transitions and clipping.
- [ ] Configure first-person aiming.
- [ ] Add first-person weapon presentation.
- [ ] Reuse shared weapon and damage systems.
- [ ] Adapt controls and HUD for both perspectives.
- [ ] Test transitions during movement and combat.

**Goal:** Allow players to switch between third-person and first-person perspectives.

### Phase 9 — Cross-Platform Builds and Optimization

- [ ] Build for Windows.
- [ ] Test macOS compatibility.
- [ ] Test Linux compatibility.
- [ ] Build and test Android.
- [ ] Validate the iOS build workflow.
- [ ] Profile rendering, CPU, and memory usage.
- [ ] Optimize graphics and input responsiveness.
- [ ] Fix platform-specific issues.

**Goal:** Prepare stable builds for supported platforms.

### Phase 10 — Polish and Release

- [ ] Refine animations and effects.
- [ ] Improve audio and combat feedback.
- [ ] Complete testing and bug fixing.
- [ ] Prepare game documentation.
- [ ] Create release builds.
- [ ] Publish the first release.

**Goal:** Deliver a polished, documented release.

---

## 🏗️ Recommended Camera Architecture

The project should use a modular camera system instead of embedding camera-switching logic directly into the player movement script.

Suggested components:

- `PlayerController` — movement and character control.
- `CameraController` — camera movement, rotation, and collision.
- `CameraModeManager` — selects the active perspective.
- `WeaponController` — firing, reloading, and weapon behaviour.
- `HealthSystem` — player and enemy health.
- `EnemyAI` — enemy perception and behaviour.
- `GameManager` — mission and game state.

This separation will make the future first-person update easier to implement without rewriting the entire game.

---

## 📊 Current Development Status

**Project stage: Initial development**

The first playable milestone is a third-person prototype with a visible character, responsive camera, basic movement, one weapon, one enemy, and a test environment.

First-person mode and perspective switching are planned future features, not part of the initial playable milestone.

---

## 🔮 Future Improvements

- First-person and third-person camera switching.
- Additional weapons and equipment.
- More enemy types and behaviours.
- Additional maps and mission types.
- Character customization.
- Advanced animations and weapon handling.
- Improved graphics and accessibility options.
- Additional control schemes.
- Further cross-platform optimization.

---

## 👨‍💻 Project Vision

AZ: Frontier Zero aims to grow from a small third-person shooter prototype into a modular, cross-platform action game.

The initial focus is a reliable third-person experience. The longer-term goal is to give players the freedom to switch between third-person exploration and first-person combat while preserving a consistent gameplay experience.

**Explore. Engage. Survive.**
