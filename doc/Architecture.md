# Architecture

## Overview

The game’s objects will be split into 4 main classes: Player, Hive, Projectile, and Enemy. The Player class will be able to move horizontally and shoot Projectile class objects vertically upward. Enemy class objects move according to their specific movement patterns, and some can shoot Projectile class objects downwards that can harm the Player class and Hive class objects. The Enemy class may end up being a parent to various Enemy types, if they are too varied for a single class.  Hive objects are guarded by the Player, and can be destroyed by the Enemies' projectiles.  Projectile class objects move and cause damage to objects they collide with, depending on whether the Player or Enemies fired them.  The Projectile class with be built so it can be used both as its own class and as a parent to other types of projectiles, if they are added in later.

Regions have been implemented in multiple areas for code readability
## General Approach

## State Machine(s)
<img src="State Diagram.PNG"
     alt="State Machine"/>

## OO Design
Projectiles, Enemies, the Player, and the Hive(s) will interact when they collide with each other, usually by damaging each other.


## External Tool
The external tool will be a mod tool that allows players to create custom waves of enemies, as well as possibly the ability to create custom enemy types.
