# Mediatonic Candidate Exercise

# Technical Art

The original document detailing the exercise is included [here](./MediatonicTAExercise).

## Essential Information
● In an alternate dimension, Mediatonic Ltd. are working on a super awesome game called Tanks2! It has been adapted from a game (not by Mediatonic) originally presented as part of a tutorial at Unity Boston 2015.

● Tanks is a 2 player shooter game in which you must control your tank and vanquish your
opponent (also a tank). In this alternate dimension, we want to release Tanks 2, incorporating some fantastic new features and improvements and need your help to get the game over the finish line!

## Instructions
Import the original Tanks project from the Unity Asset Store into a blank project in Unity, the link is here .
We would like you to code up the request below and add it to the project. The end result will be an
amended project which we can run ourselves. The evaluation and submission criteria are on the last
page.
Request
Create a HUD (head up display) in UGUI to be overlaid on the game. Feel free to use premade image assets
downloaded from the public domain. The HUD should contain a set of information on each player, with player
1’s information on the left hand side and player 2’s information on the right hand side, with the layout
mirrored. The HUD should adjust automatically to suit different screen sizes. Please include the following
elements in the HUD:
- Player tank icon matching the colour of the player’s tank, anchored to the top and side by 20px. Use a
flat texture for the icon.
- Health bar which anchors to the side by 20px and 60px from top and bottom. The health bar has a
green fill from top (highest) to bottom (lowest) depending on the health of the player.
- A scrollable area across the bottom of the screen, scrolling from side to side. This will act as a colour
picker. The scroller contains a dozen tank icons, these are similar in appearance to the player tank
icon, except they will each be a different colour. Tapping or pressing one of the icons will change the
colour of the current player’s tank which also updates the player tank icon. The current player’s tank
is determined based on the last player tank icon to be tapped or pressed. The scroller anchors to the
bottom and both sides by 20px.

The UI should be optimised for low end mobile devices. This means as few draw calls as possible and as few
canvas updates as possible. We are looking for a screen which has been laid out with an eye for design. Feel
free to add any animation polish you see fit.

## Evaluation

● We’ll only evaluate the changes to the original Tanks project.

● Here’s a top level view of our evaluation criteria:

    ○ Technical integrity,
    ○ Script tidiness,
    ○ Quality of layout and polish,
    ○ How well the layout works at different screen sizes
● Please send us a zip file with the full project, so we can build and run it

● Please state what Unity version, platform and other public software or assets (if any, including version numbers) you used during the work

● Be sure to include whatever is needed to run the code without any extra steps on our part.
