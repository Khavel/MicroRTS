# Architecture Rules (AI Contract)

## Principles
- Minimal diff: smallest change to satisfy the request.
- No refactors unless explicitly asked.
- One feature per PR.

## Unity Structure
- Scene: `Assets/Scenes/Game.unity` (main) and `Assets/Scenes/Smoke.unity` (CI smoke)
- Code: `Assets/Scripts/...` only
- Data: ScriptableObjects in `Assets/Data/...`

## Code Rules
- No game logic inside UI scripts beyond calling public APIs.
- No hidden singletons unless explicitly introduced; prefer explicit references via serialized fields.
- Keep classes small and single-responsibility.
- Prefer composition over inheritance for unit behaviors.

## Suggested Modules
- `Core/` (bootstrap, game state, time, win/lose)
- `Input/` (selection + command issuing)
- `Units/` (unit model + movement + combat)
- `AI/` (simple build/attack loop)
- `UI/` (HUD + build buttons)

## Testing
- Maintain a `Smoke` scene that loads without errors.
- Add PlayMode tests for regressions when feasible.

## Naming
- Public APIs: clear nouns/verbs (`Unit`, `SelectionController`, `CommandIssuer`)
- No abbreviations unless domain-standard (HP, AI).
