# Production

## Meeting Minutes
_Keep the [Meeting Log](mtgLog.md) log up to date to track when your team meets and the main topic(s) of discussion._
_Make sure to also keep the weekly meeting time on the main [README](../README.md) up to date._

October 3rd (all members present): game idea, implementation, designation of roles
We decided to make space invaders inspired game and discussed the classes we would need and how they would work
So far the rough roles we have for ourselves are: Production - Hyunseo (Ashley) Cho Architecture - Maxwell Hazel Design - Devon Grant Interface - Nicolas Jensen General - Matthew Camera
We will meet every Thursday to discuss problems and to assign more tasks once previous ones have been completed.

October 14th (all members present):discuss classes and assign people with specific programming roles for mvp. 
player class: Max
fields: rectangle, placeholder texture, lives
functions: movement, collision, shooting

enemy class: Matt
fields: rectangle, placeholder textures, lives
functions: movement, collision, shooting
needs intricate constructor that can handle many different kidns of enemies

hive class: Hyunseo 
fields: rectangle, placeholder texture, lives
method: upate- decrease health

projectile class: Devon (working closely with Max)
fields: rectangle, placeholder texture

User interface: Nick
implement fsm and implement different states

external tool (wave editor): Matt and Max

October 30th (all members present): discussing what we've done so far, dividing remaining tasks
Game now has player that shoots bullets at enemy, enemy that shoots bullet at hive
Player can wrap around screen
Remaining tasks: 
Splitting up player and enemy projectiles- Max 
Comlete external tool- Matthew 
Art, implement pause state - Nick 
Implement powerups- Ashley 
Fixed bugs - Devon

December 1st (# team members present): distributed the few remaining tasks we had left which was basically adding the stretch goals, completing the wave editor, and fixing any bugs. Tasks:
Matt is fixing external tool
Devon is working on time slowing power up
Ashley is working on health bar and bullet power up
Max is adding enemies, implementing damage power up
Nick is working on fixing font and buttons
Due to time constraints, we were not about to add our own art for bees and hive or add sound effects. However, we did manage to finish our stretch goal of adding power ups.

## Scope

### Minumum Viable Product (MVP)
For now we are planning on creating a space invaders inspired fixed shooter with a bee theme. Our minimum viable product will be a version where the enemies come straight down with placeholder images and no sound. There will have to be a UI as well as the game.

### Extra Features
Our stretch goals would be to add our own art as well as sound effects and to make the enemies attack randomly or in a fixed pattern (which we would have to read from an external file).

## Task Management
creating a google doc with the list of thngs that must be done, who has done it, as well as if it has been completed.
https://docs.google.com/spreadsheets/d/1Me7J2kAnSCDyePDyjWc2E-S6mxc_e3_K97WlK2JaLps/edit?usp=sharing

### Task Breakdowns
player class: Max
enemy class: Matt
hive class: Hyunseo 
projectile class: Devon (working closely with Max)
User interface: Nick
external tool (wave editor): Matt and Max
(Tasks have been increased and distributed evenly over course of project, look at meeting log/task manager for more details)

## Testing
Playable game- a few issues with hive taking damage, hopefully will be fixed soon.
