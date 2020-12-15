# Overview
This document is the software requirements specification for Team Google Stadia.
It lists the various features and requirements that have be acheived in our project.
# Software Requirements
This section lists the functional and non-functional requirements for our project, as well as the test cases associated with them.
## Functional Requirements
### Character Controls
| ID | Requirement | Test Cases |
| :-: | :-: | :-: |
| FR1 | The character shall attack when the user presses the attack key | TC6 |
| FR2 | The character shall move when the appropriate movement key is pressed | TC2, TC3, TC14 |
| FR3 | The character shall lose one health when hit by an enemy attack | TC15, TC16 |
| FR4 | The character shall gain five health when the user presses the heal key | TC1 |
| FR5 | The character shall switch to a new weapon when the user presses the switch weapon key | TC10, TC11 |
### Gameplay
| ID | Requirement | Test Cases |
| :-: | :-: | :-: |
| FR6 | The game shall restart at level 1 when the player's health is 0 | TC16 |
| FR7 | The level shall change when the player advances to the end of the current level | TC12, TC13 |
| FR8 | The camera shall follow the player throughout the level | TC14 |
| FR9 | Upon completion of level 6 the player shall be sent back to level 1 | N/A |
| FR10 | The player shall remain with the bounds of the levels | TC18 |
### Enemies
| ID | Requirement | Test Cases |
| :-: | :-: | :-: |
| FR11 | Enemy 1 shall spawn randomly throughout each level | TC20 |
| FR12 | The enemies shall lose 20 health when hit with a ranged weapon | N/A |
| FR13 | The enemies shall lose 25 health when hit with a melee weapon | TC5 |
| FR14 | The enemies shall be removed from the level when their health reaches zero | TC9 |
| FR15 | Enemy 2 and Enemy 3 shall fire projectiles  | TC8 |

## Non-Functional Requirements
### Player Design
| ID | Requirement | Test Cases |
| :-: | :-: | :-: |
| NFR1 | The player sprite shall display 8-bit pixel art | N/A |
| NFR2 | The player shall have different art for each time period(Jurassic, Medieval, Cyberpunk) | N/A |
| NFR3 | The player shall have a different animation for each weapon | TC6 |
| NFR4 | The weapons shall be easy to distinguish between | N/A |
| NFR5 | The player shall be easy to see and not blend into surroundings | N/A |
### Level Design 
| ID | Requirement | Test Cases |
| :-: | :-: | :-: |
| NFR6 | The game shall have original music for each stage within the game | TC7 |
| NFR7 | The artwork will change throughout the stages of the game (Jurassic, medieval, cyberpunk). | TC13 |
| NFR8 | The screen shall not be cluttered when progressing through the ages | N/A |
| NFR9 | The platforms shall be distinguishable from the background of the game | N/A |
| NFR10 | The enemies shall be distinguishable from the background and the level    | N/A |
### Game Setup
| ID | Requirement | Test Cases |
| :-: | :-: | :-: |
| NFR11 | The game shall run smoothly and not crash in any instance | N/A |
| NFR12 | The game scheme shall be hardcore where the player loses all progress on death | TC13, TC19 |
| NFR13 | The player’s movement shall be smooth/fluid and easy to control | TC16 |
| NFR14 | The game shall start when the game launches | TC19 |
| NFR15 | The player shall have access to all weapons (based on time period) at the start of the level | TC17, TC20 |
# Test Specification
This section lists and describes unit tests, integration tests, and system tests performed on our project.
## Unit tests
| ID | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| TC1 | Test the function that changes the health of the player.  | To heal the player call this function with a negative number, should return update health | -5 | 15 | 15 | Pass | FR4 |
| TC2 | Tests if the player can move to the right | Player presses the ‘D’ key | ‘D’ key press | Player moves to the right | Player moved to the right | Pass | FR2 |
| TC3 | Tests if the player can move to the left | Player presses the ‘A’ key | ‘A’ key press | Player moves to the left | Player moved to the left | Pass | FR2 |
| TC4 | Tests if the player can jump | Player presses the “Space” key | “Space” key press | Player jumps upward | Player jumps upward | Pass | FR2 |
| TC5 | Tests an enemy losing 25 health | Enemy gets hit by the players melee weapon | 25 | 75 | 75 | Pass | FR13 |
| TC6 | Tests if the player plays an attack animation | Player presses “Mouse0” | “Mouse0” pressed | Player plays the attack animation | Player played the attack animation | Pass | FR1, NFR3 |
| TC7 | Tests if the player plays a heal animation | Player presses the ‘E’ key | ‘E’ key press | Player plays the heal animation | Player played the heal animation | Pass | NFR6 |
| TC8 | Tests Enemy 2 and 3 launching projectile | Set timer to 0 to call the launch function | Timer equals 0 | Launch() function called | Launch() function called | Pass | FR15 |
| TC9 | Enemies are removed when health is 0 | Set health to zero and check if destroy is called | Health equals 0 | Destroy called | Destroy called | Pass | FR14 |
| TC10 | The player switches weapons when pressing “MouseWheel1” | Player presses “MouseWheel1” | MouseWheel > 0f | selectedWeapon == 1 | selectedWeapon == 1 | Pass | FR5 |
| TC11 | The player switches weapons when pressing “MouseWheel0” | Player presses “MouseWheel0” | MouseWheel < 0f | selectedWeapon == 3 | selectedWeapon == 3 | Pass | FR5 |
## Integration Tests
| ID | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| TC12 | Tests if the player can move from level to level | Load the game, walk through the level and touch the rock at the end of the level | Both ‘D’ and ‘space’ to move over enemies and to reach the end of the level | The player shall be moved to the next level | The player does move to the next level | Pass | FR7 |
| TC13 | Does the music change on each level  | Progress to the next level | Player uses movement controls to move to next level  | The music changes | The music does change | Pass | NFR7, FR7 |
| TC14 | The camera follows the player as he moves through the level | Start the game, move the character  | ‘A or D, ’ key to move | Camera follows the player | Camera eats the player | Pass | FR8, FR2 |
| TC15 | Tests if the player loses health when colliding with an enemy | Move the character into an enemy | Use movement keys until colliding with an enemy | currentHealth == 14 | currentHealth == 14 | Pass | FR3 |
| TC16 | Tests if the player returns to the first level when their health reaches 0 | Collide with an enemy or enemy projectile until currentHealth == 0 | Use movement keys to collide with an enemy 15 times | currentHealth == 0
Player returns to the start of the first scene
 | currentHealth == 0
Player returns to the start of the first scene 
 | Pass | FR3, FR6, NFR13 |
## System Tests
| ID | Description | Steps | Input Values | Expected Output | Actual Output | Pass/Fail | Requirement Link |
| :-: | :-: | :-: | :-: | :-: | :-: | :-: | :-: |
| TC17 | Game starts on startup (no crashing) | Download executable and begin startup  | Double click on .exe | Game starts and doesn’t crash | The game starts up | Pass | NFR15 |
| TC18 | The player should remain within the bounds of the levels | Launch the game and see if the player can jump out of levels | Move around levels and attempt to leave bounds | Player cannot leave bounds | Player can leave bounds | Fail | FR10 |
| TC19 | Game runs smoothly without frame drops | Launch the game and begin progressing | ‘A, D, Space’ and attack to progress to the end | Game runs smoothly | Game runs smoothly (except for zoom streams) | Pass | NFR12, NFR14 |
| TC20 | The player, enemies, and level all load when the game starts | Start the game and check to see if all assets are present | Start game and move around levels | The player, enemies, and level are all present | The player, enemies, and level are all present | Pass | FR11, NFR15 |
| TC21 | The player respawns at the start of the first level upon completion of the game | Start the game and play it through until completion | Move the player through all the levels until reaching the end | The player respawns at the start of the first level | The player spawns at the start of the first level including a duplicate of the player | Fail | FR9 |
# Software Artifacts
This section contains the various software artifacts of our project.
* [Controls Use Case Diagram](https://github.com/jkknibbe99/GVSU-CIS350-TeamGoogleStadia/blob/master/artifacts/use_case_diagrams/Controls-use-case-diagram.pdf) 
* [Enemies Use Case Diagram](https://github.com/jkknibbe99/GVSU-CIS350-TeamGoogleStadia/blob/master/artifacts/use_case_diagrams/Enemies-usecase-diagram.pdf)
* [Weapons Use Case Diagram](https://github.com/jkknibbe99/GVSU-CIS350-TeamGoogleStadia/blob/master/artifacts/use_case_diagrams/ItemInteractionUCD.pdf)
* [Extended Description](https://github.com/jkknibbe99/GVSU-CIS350-TeamGoogleStadia/blob/master/artifacts/Extended-description.md)