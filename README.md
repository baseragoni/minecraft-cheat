# minecraft-cheat

> Minecraft · cheat · esp · aimbot · wallhack · triggerbot

[![.NET 10](https://img.shields.io/badge/.NET-10.0-512BD4)](https://dot.net)
[![Cheat](https://img.shields.io/badge/type-cheat-red)]()
[![Game](https://img.shields.io/badge/game-Minecraft-orange)]()
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

**minecraft-cheat** is an external Minecraft cheat: ESP, aim assist, triggerbot, recoil, bhop, radar and misc.

tested on latest patch. for research and educational purposes only.

## features

- **ESP** — box, health bar, distance, name tags, skeleton, snaplines
- **Aim Assist** — configurable FOV circle, smooth factor, bone select, recoil compensation
- **TriggerBot** — reaction delay with jitter, burst mode, team check
- **Bunny Hop** — auto-jump on ground flag detect
- **Radar** — force enemy spotted on minimap
- **No Flash** — override flash duration to zero
- **Config** — JSON profiles under %APPDATA%, import/export, hotkeys

## build

requires .NET 10 SDK.

```
dotnet build
```

run:

```
.\build\bin\minecraft-cheat.Loader\net10.0\mccheat.exe
```

Minecraft must be running before you start the loader.

## config

profiles auto-save to `%APPDATA%\minecraft-cheat\profiles\default.json`.

```json
{
  "aim": {
    "enabled": true,
    "fov": 5.0,
    "smooth": 3.5,
    "bone": "Head",
    "rcs": true
  },
  "esp": {
    "enabled": true,
    "box": true,
    "health": true,
    "skeleton": false,
    "distance": true
  },
  "trigger": {
    "enabled": false,
    "delayMs": 50,
    "jitter": 15,
    "burstCount": 1
  },
  "misc": {
    "bhop": false,
    "noFlash": false,
    "radar": false
  }
}
```

## keybinds

| key | action |
|---|---|
| INSERT | toggle menu |
| F1 | aim assist |
| F2 | esp |
| F3 | triggerbot |
| F4 | bhop |
| MOUSE5 | aim key (hold) |
| HOME | reload config |
| END | panic — clean exit |

## anti-cheat

targets **server-side only**. no bypass included.
detection is expected without additional evasion layers.

## disclaimer

educational / research project for game hacking concepts.
not affiliated with the developers of Minecraft.
don't use in online matchmaking — you **will** get banned.


---

## Topics

![minecraft](https://img.shields.io/badge/minecraft-111827?style=flat-square) ![minecraft-cheat](https://img.shields.io/badge/minecraft%20cheat-111827?style=flat-square) ![minecraft-hack](https://img.shields.io/badge/minecraft%20hack-111827?style=flat-square) ![cheat](https://img.shields.io/badge/cheat-111827?style=flat-square) ![hack](https://img.shields.io/badge/hack-111827?style=flat-square) ![ghost-client](https://img.shields.io/badge/ghost%20client-111827?style=flat-square) ![killaura](https://img.shields.io/badge/killaura-111827?style=flat-square) ![pvp](https://img.shields.io/badge/pvp-111827?style=flat-square)

`minecraft` `minecraft-cheat` `minecraft-hack` `cheat` `hack` `ghost-client` `killaura` `pvp` `reach` `velocity` `hypixel` `game-hacking` `free` `csharp`

Search: minecraft-cheat · minecraft · cheat · pvp · killaura · Minecraft cheat client — killaura, reach, velocity, scaffold, fly, speed. Ghost client for Hypixel/MMC.

---

<sub>Minecraft cheat client — killaura, reach, velocity, scaffold, fly, speed. Ghost client for Hypixel/MMC.</sub>
