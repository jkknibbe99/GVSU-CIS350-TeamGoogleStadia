# Overview

This document is the software requirements specification for Team Google Stadia.
It lists the various features and requirements that will be acheived in our project.

# Functional Requirements

1. Character Controls
	1. The character shall attack when the user presses the attack key
	1. The character shall move when the appropriate movement key is pressed
	1. The character shall change its attack style when acquiring a new item
	1. The character shall lose health when hit by an enemy attack
1. Gameplay
	1. The menu shall appear on game startup
	1. The game shall end when the player's health is 0
	1. The level shall change when the player advances to the end of the current level
	1. The player's health shall recover when they acquire a health item
1. Enemies
	1. An enemy shall be killed and be removed from the game-screen when the player fully depletes the enemy's health
	1. The enemies shall lose health when attacked. 
	1. The enemies shall attack the user when in range. 
	1. The enemies shall move around the level. 
	1. The enemies shall spawn randomly throughout the level. 
# Non-Functional Requirements

1. Design/Artwork
	1. The backgrounds and characters shall be easily discernable form each other
	1. The level design shall not be visibly cluttered
	1. The enemies shall be easy to see and not blend in the surroundings
	1. The items shall be easy to distinguish between
	1. The game shall display 8-bit style pixel art
1. Game setup
	1. The player character shall remain within the set boundaries of the game
	1. The game shall run smoothly and not crash in any instance
	1. The player character's movement shall be smooth/fluid and easy to control
	1. The game scheme shall be hardcore where the player loses all progres when they die
	1. The game shall quit/start when the user starts/exits the game
	1. The player shall lose all items when health reaches 0
	1. The player shall be able to buy items from the store if they have a sufficient amount of money

