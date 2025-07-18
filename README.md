
# 🧟 Undead Remains

**Undead Remains** is a 3D zombie survival game developed in **Unity** using **C#**, inspired by the atmosphere and gameplay of *Left 4 Dead*. Players must survive waves of the undead while managing limited resources and their own sanity.

![Undead Remains Banner](./assets/banner.png) <!-- optional image -->

---

## 🎮 Features

- 🔫 First-person shooter (FPS) gameplay
- 🧠 **Sanity system**: the lower your sanity, the more unstable the world becomes
- 🧟 Dynamic zombie spawns and enemy AI
- 🧭 Atmospheric environments with low light, sound cues, and fog
- 🎧 Immersive sound design and jump-scare potential
- 🧑‍🤝‍🧑 Designed for co-op support

---

## 🕹️ Controls

| Action         | Key / Button        |
|----------------|---------------------|
| Move           | `WASD`              |
| Look Around    | `Mouse Movement`    |
| Shoot          | `Left Mouse Button` |
| Aim / Scope    | `Right Mouse Button`|
| Reload         | `R`                 |
| Interact       | `E`                 |
| Flashlight     | `F`                 |
| Pause / Menu   | `ESC`               |

---

## 🛠️ Built With

- **Unity**
- **C#**
- [Unity Input System](https://docs.unity3d.com/Packages/com.unity.inputsystem@1.0/manual/index.html)
- [Cinemachine](https://unity.com/unity/features/editor/art-and-design/cinemachine)
- Unity's **First-Person Controller**
- Optional packages: **Cinemachine**, **Post-processing**, **Input System**

---

## 📂 Project Structure

Assets/
├── Animations/ # Animation clip, controller cho nhân vật, zombie
├── Audio/ # Âm thanh: tiếng súng, tiếng zombie, nhạc nền
├── Materials/ # Vật liệu dùng cho nhân vật, vũ khí, bản đồ
├── Models/ # Mô hình 3D: nhân vật, zombie, súng
├── Prefabs/ # Prefab hóa các object: player, zombie, đạn, UI
│ ├── Player/
│ ├── Zombie/
│ ├── Weapons/
│ └── Environment/
├── Scenes/ # Các scene của game (menu, gameplay, loading...)
├── Scripts/ # Toàn bộ mã nguồn C#
│ ├── Player/ # Movement, animation, health của người chơi
│ ├── Zombie/ # AI, navmesh, attack của zombie
│ ├── UI/ # HUD, healthbar, ammo display
│ ├── Weapons/ # Behavior của vũ khí, đạn, reload
│ ├── Managers/ # GameManager, AudioManager, UIManager (singleton)
│ └── Game/ # Luồng chính, spawn logic, round, win/lose
├── Settings/ # Cài đặt game, InputActions, ScriptableObject config
├── UI/ # Prefab các UI canvas (menu, gameover, HUD)
└── TutorialInfo/ # Unity tạo sẵn (có thể xóa nếu không dùng)

## 🚀 How to Play

