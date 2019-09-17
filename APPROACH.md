# APPROACH

## Session 01

**Mon Sep 16 16:43:07 - Mon Sep 16 17:21:35**

**To Do**
- Enter spec in readme
- Install asset project
- Assess current UI
- Assess what I need to do that I don't know how to

**Done**
- Copied original document into readme, with link to file
- Installed dependencies and downloaded assets in new project file
- Saved the finished version of the game as a new scene
- The current UI is just messages for the start and finish.
    - All capital letter text in BowlbyOne-Regular
    - White for messages
    - Respective player colour for names
    - Slight brown shadow under all text
- Touched a .gitignore

## Session 02

**Mon Sep 16 17:31:52 - Mon Sep 16 18:19:10**

**To do**
- Create a canvas in camera overlay and find out how to mirror it's elements

**Done**
- Googled UGUI to make sure it the default UI system in Unity, I think it is.
- Had a look for existing solutions, not fruitfull
- Looking through current files, cannot find TankManager use in scene
- Taking the file out breaks the game, so it is used somehow.
- Added a HUD canvas set to resize with screen
- Added flat images anchored in each corner, 20px away
- Thinking of ways to change HUD colours based on tanks. Add a HUDManager?

## Session 03

**Tue Sep 17 11:55:29 - 

**To do**
- Create a HUDManager that
    - finds the tanks
    - copies their colours to the HUD
    - makes HUD icons selectable
    - turn off HUD unless both tanks present

**Done**
- Read through existing files, trying to figure out where to connect new files
- Making a TankColour script and moving the colour setup logic over from the tank manager

