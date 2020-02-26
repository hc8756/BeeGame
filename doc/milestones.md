# Milestones
_With each milestone, give a _brief_ (3-4 paragraphs at most) summary of what was accomplished during the milestone, any major lessons learned, and how your experience in that milestone influenced your plans for the next (or how you changed things during this milestone based on last time)._

## Milestone 1
Write Up
The majority of this milestone was getting our idea and framework agreed upon and laid out, as well as establishing each of our roles. Each of us coordinated our major goals and began working on our preliminary tasks that have to be accomplished before we can start the actual work. As of right now, our main directive is to focus on producing our Minimum Viable Product before the next phase of development. We definitely learned that communication and correspondence are pretty important in a group project.
We had to go through and scrap a couple ideas before we agreed upon starting with a barebones space invaders-style fixed top-down shooter that we will gradually add on to and stylize in order to make it feel more like our own game. While it may feel uninspired during the initial phase of development, we are hoping that we will be able to give the game mechanics a unique spin that will make it stand out as more than an arcade cabinet love letter.

Production - Hyunseo (Ashley) Cho
Architecture - Maxwell Hazel
Design - Devon
Interface - Nick
Very Cool Flex Role - Matt Camera

Production

 During this milestone, we found that we all had the common goal of creating a fun but simple game for the time being and then adding more complex stretch goals later on. For now we are planning on creating a space invaders inspired fixed shooter with a bee theme. Our minimum viable product will be a version where the enemies come straight down with placeholder images and no sound. There will have to be a UI as well as the game. Our stretch goals would be to add our own art as well as sound effects and to make the enemies attack randomly or in a fixed pattern (which we would have to read from an external file).
 Our plans for Now to October 18th would “bare bones” version of game, or to implement the basic classes required to get the mvp and UI running. Our plans from then to November 15th would be to fix any bugs, play test it, and make improvements. Finally,from then to December 9th we will implement all the stretch goals that we can.
 The tools we are using are Discord, google slides/docs, a task manager to assign tasks+cross them off once finished, and GitHub. We will be meeting every Thursday afternoon to discuss our progress so far and assign more tasks to members once previous ones are completed. These meetings will be logged. 
 
<b>Architecture:</b>

The game’s objects will be split into 3 classes:  Player, Flower, and Enemy.  The Player class will be able to move horizontally and shoot vertically upward.  Enemy class objects move according to their specific movement patterns, and some can shoot projectiles downwards that can harm the Player class and Flower class objects.  Flowers are guarded by the Player, and can be destroyed by the Enemies' projectiles.

## Milestone 2
Milestone 2 was spent organizing and implementing our code according to the architecture we laid out. Our meeting was largely devoted to the delegation of tasks. All of our classes have been implemented, and a skeleton for our external wave editor has been created. Work has also begun on producing our own assets. As of right now, we have a barebones functioning game that adheres to our original plan. Future plans include making our external tool functional, implementing waves of enemies, implementing our own assets, and refining what we already have.

## Milestone 3
The main things that wer done for Milestone 3 were implementing a new enemy type, the Wasp, finishing the external tool, the Wave Editor, and starting to implement the framework for powerups.  Player and enemy projectiles were split into seperate Lists as well, to improve collisions and make powerups easier to implement in the future.  Art assets were also improved, both for the game and its menus.

## Milestone 4
The main goal for this mileston was to tie up any loose ends, fix any error, and add as much of the stretch goals as we could. We completed the external tool which now moves the wasp and yellow jacket enemy types in designated patterns. Power ups such as time, bullet, health, and damage were implemented. Fonts were fixed to be more visible. The stretch goals we could not implement was making our own art and adding sound effects due to lack of time.
