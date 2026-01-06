# MicroRTS MVP (Option 1)

## Goal
A playable micro-RTS prototype on a single map: the player can select units, move, attack, build units from one building, and defeat an AI opponent.

## Scope (MUST HAVE)
### Game
- One map (single scene) with two bases: Player and AI
- Win/Lose condition: base destroyed

### Units
- 3 unit types max: Worker, Soldier, Tank
- Teams: Player vs AI
- Stats: HP, move speed, attack range, attack damage, attack cooldown

### Player Controls
- Left click selects a unit
- Drag box selects multiple units
- Right click on ground issues move command
- Right click on enemy issues attack command
- No formations required

### Economy
- Resource counter that increases by a fixed amount per second
- Units have a cost
- One production building per team (Base)

### UI
- Resource count
- Selected unit count
- Buttons to build Soldier and Tank
- Win/Lose screen with Restart

### AI Opponent (simple)
- Accumulates resources
- Builds units periodically (within budget)
- Attacks player base after it has N units
- No cheating beyond resource trickle

## Explicitly OUT OF SCOPE (DO NOT IMPLEMENT)
- Multiplayer
- Fog of war
- Worker gathering/mining/returning resources
- Tech tree / upgrades
- More than 1 map
- Advanced pathfinding beyond a simple approach (no navmesh tooling)
- Formations, flanking, squad tactics
- Save/load
- In-game map editor
