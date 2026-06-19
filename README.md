# 🎮 EVO Guns - FPS Shooting Game

A thrilling first-person shooter game built with **Unity** where you can unlock all weapons, skins, and bundles instantly!

## 📋 About

This is a complete FPS (First-Person Shooter) game featuring:
- **Unlimited Customization**: All guns, vehicles, and bundles unlocked from the start
- **Dynamic Weapon System**: Multiple Evo guns and weapon varieties
- **Combat Mechanics**: Headshot detection for double damage
- **Player Progression**: Diamond and gold currency system
- **Skin Unlocking**: All skins available immediately

## 🎯 Features

### 🔫 Weapon System
- **Evo Guns**: Unlimited access to all evolution guns
- **Bundles**: Cobra and Booyah bundles fully unlocked
- **Vehicles**: All vehicle options available
- **Headshot Detection**: Double damage multiplier for precision shots

### 💰 Inventory System
- **Diamonds**: 9,999,999 (unlimited currency)
- **Gold**: 9,999,999 (unlimited currency)
- **All Skins Unlocked**: Every cosmetic available from start
- **Custom Loadouts**: Create your perfect weapon combination

### 🎮 Gameplay Mechanics
- **Player Movement**: WASD keys for smooth navigation
- **Shooting System**: Mouse click to fire
- **Damage System**: Different damage values for headshots vs body shots
- **Enemy Detection**: Raycast-based hit detection
- **Health System**: Enemy health tracking and elimination

## 🚀 Getting Started

### Requirements
- Unity 2020.3 LTS or later
- Visual Studio or any C# IDE
- Git

### Installation

1. **Clone the repository**:
```bash
git clone https://github.com/devijoyti1851-commits/Satyam-.git
cd Satyam-
```

2. **Open in Unity**:
   - Open Unity Hub
   - Click "Open Project"
   - Select the cloned folder
   - Wait for assets to import

3. **Setup Scenes**:
   - Create a new scene or open existing scene
   - Add Player GameObject with Camera
   - Add Enemy GameObjects with colliders and tags

4. **Configure Tags**:
   - Go to Tags Manager
   - Add tags: `Head`, `EnemyBody`
   - Tag your enemy parts accordingly

5. **Play**:
   - Press Play in Unity Editor
   - Use WASD to move
   - Click to shoot
   - Get headshots for double damage!

## 🎮 Controls

| Action | Control |
|--------|---------|
| Move Forward | W |
| Move Backward | S |
| Move Left | A |
| Move Right | D |
| Shoot | Left Mouse Click |
| Look Around | Mouse Movement |

## 📁 Project Structure

```
Assets/
├── Scripts/
│   ├── PlayerInventory.cs      # Currency and unlock system
│   ├── PlayerController.cs     # Movement and shooting
│   └── EnemyHealth.cs          # Enemy damage and death
├── Scenes/
│   └── GameScene.unity
├── Prefabs/
│   ├── Player.prefab
│   ├── Enemy.prefab
│   └── Weapons/
└── UI/
    └── HUD Canvas
```

## 🎯 Game Mechanics Explained

### PlayerInventory System
```csharp
diamonds = 9999999;      // Unlimited premium currency
gold = 9999999;          // Unlimited standard currency
allSkinsUnlocked = true; // All cosmetics available
```

### Shooting Mechanic
- **Raycast Detection**: Uses invisible rays from camera
- **Headshot**: 2x damage multiplier (50 damage)
- **Body Shot**: Normal damage (25 damage)
- **Enemy Elimination**: Enemy destroyed when health reaches 0

### Damage System
```
Headshot: 25 * 2 = 50 damage
Body Shot: 25 damage
Max Enemy Health: 100
```

## 🛠️ Customization

### Adjust Player Stats
```csharp
public float speed = 5.0f;      // Movement speed
public float damage = 25f;      // Base damage per shot
```

### Modify Enemy Health
```csharp
public float maxHealth = 100f;  // Enemy starting health
```

### Change Currency Values
```csharp
diamonds = 9999999;  // Change to any amount
gold = 9999999;      // Change to any amount
```

## 📈 Development Roadmap

- [ ] Add weapon shop system
- [ ] Implement multiplayer mode
- [ ] Create campaign missions
- [ ] Add sound effects and music
- [ ] Develop weapon progression system
- [ ] Create boss fights
- [ ] Add leaderboards
- [ ] Implement daily challenges

## 🤝 Contributing

Feel free to fork this project and submit pull requests for improvements!

### Contribution Ideas
- Add new weapon types
- Create new maps/levels
- Implement voice chat
- Design new skins
- Create tutorials
- Add achievements system

## 📄 License

This project is open source and available under the MIT License.

## 👨‍💻 Author

Created by devijoyti1851-commits

---

**Download Unity and start shooting! 🎮🔫**

## 📞 Support

For issues or questions:
- Open an Issue on GitHub
- Check the Wiki for tutorials
- Join our community discussions

**Happy Gaming! 🎉**
