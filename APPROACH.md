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

**Tue Sep 17 11:55:29 - Tue Sep 17 12:48:51**

**To do**
- Create a HUDManager that
    - finds the tanks
    - copies their colours to the HUD
    - makes HUD icons selectable
    - turn off HUD unless both tanks present

**Done**
- Read through existing files, trying to figure out where to connect new files
- Making a TankColour script and moving the colour setup logic over from the tank manager

##  Session 04

**Tue Sep 17 12:57:10 - Tue Sep 17 13:24:34**

**To do**
- Make each tank find it's UI
- Change the UI when state changes
    - Icon colour
    - Health bar

**Done**
- Pass the HUD icon image from gamemanager
- Change the icon colour when setting the tank material colour

## Session 05

**Tue Sep 17 13:30:09 - Tue Sep 17 14:04:35**

**To do**
- Redirect the health UI logic to update the HUD
    - Pass the HUD to TankHealth
    - Make new sliders in the HUD

**Done**
- Split the HUD into one each per player
- Added health sliders to each HUD

## Session 06

**Tue Sep 17 14:12:44 - Tue Sep 17 14:40:51**

**To Do**
- Pass the HUD to tankHealth
- Pass health value to slider

**Done**
- Pass the HUD to tankHealth
- Pass health value to slider
- Adjusted the slider to be closer to instructions
- Tested different colours

## Session 07

**Tue Sep 17 15:39:57 -Tue Sep 17 16:29:10**

**To do**
- Add a scrollbar with colour icons

**Done**
- Add a scrollbar with colour icons

## Session 08

**Tue Sep 17 17:39:59 - Tue Sep 17 18:36:57**

**To do**
- Plan the control flow from buttons to tanks

**Done**
- Stuck on a bug, any new script cannot have other script components dragged onto it.
    - Tried making new scripts, assigning gameobjects then getting their script components
    - Had to add:

    ```
    namespace Complete {...}
    ```

    around the class.

## Session 09

**Fri Sep 20 12:25:41 - Fri Sep 20 12:50:28**

**To do**
- Make a selected player using their icon

**Done**
- Added button and animator components to the icons so they can be selected, and grow when they are
- Accidentally scaled the colour icons and had to undo
- Scaled content down

## Session 10

**Fri Sep 20 13:13:49 BST - Fri Sep 20 13:55:49**

**To do**
- Have icon/tank colours set by colour buttons

**Done**
- HUDManager has references to tanks
- HUDManager has method to set which tank is active
- Colour buttons couldn't find the set colour method, can't pass a colour
    - Passing button object and then getting it's colour to pass instead
    - Nothing happening
    - Had forgotten to set OnClick
- Colours changing but have to be set manually (long) for each button

## Session 11

**Fri Sep 20 15:18:19 - Fri Sep 20 15:43:45**

**To do**
- Refactor
    - Tank selection
    - Tank colour change
    - Button colours setting

**Done**
- Refactored tank selection and colour change to work off an array instead of individuals and conditionals
- Changed resizing settings to be constant
- Changed animator controller flow

## Session 12

**Fri Sep 20 15:54:51 - Fri Sep 20 16:28:14**

**To do**
- Change message colours to match tanks
- Test changing a white tank icon colour

**Done**
- Message colours changed with tank colours
- Converted the tank fbx model for photographing in Blender
- A white icon with the colour changed in Unity could work, just need a visually legible icon

## Session 13

**Wed Sep 25 14:48:10 - Wed Sep 25 15:13:55**

**To do**
- Make/find a small tank icon

**Done**
- Edited a small tank icon. It's a bit crunchy, I don't know if it would look better on other screens.

## Session 14

**Wed Sep 25 15:23:32 - Wed Sep 25 16:28:13**

**To Do**
- Edit icon animation sizes
- Health bar shake animation
- Colour picker instancer

**Done**
- Added a ColourIcon script, made it serializable, and made a list of them in the HUDManager
- Removed the Monobehaviour parent class to make it actually serializable
- Made a prefab of a colour button and added it to the script as a gameobject to instantiate
- HUDManager iterates through list of icons, instantiates them as children of HUD, and calls their Setup method
- Added image to change the colour of, but because it is a prefab the onclick is no longer set
    - Added an onclick listener to the script that calls the HUDManager SetTankColour method

## Session 15

**Wed Sep 25 16:46:35 - Wed Sep 25 17:50:52**

**To do**
- Slight refactor
- Edit icon animations
- Health bar shake animation

**Done**
- Assigned HUDM in ColourIcon at instantiation instead of finding component in parent
- Tried flipping the icon for mirroring but might have to have two images, or a flipped child, or a an animation seperate from the original
- Drew a new icon

## Session 16

**Thu Sep 26 14:57:36 - Thu Sep 26 15:24:18**

**To do**
- Finish icons
- Health shake animation

**Done**
- Signed up to Vectr so I can save the working file
- Remade the icon
- Added numbers
- Exported pngs
- Edited lines in Krita

## Session 17

**Thu Sep 26 15:28:22 - Thu Sep 26 16:12:01**

**To do**
- Add icons into scene
- Health shake animation

**Done**
- Added the icons, resized them
- Resized the scrollbar, arrows and colour icons
- Made the scrollbar transparent
- Added the rest of the icons and right side padding
- Created animation controller
- Created shake animation to be triggered by 'hit' parameter
- Added animator to health bars
- Edited shake animations specific to left and right
- Assigned the animator on each health script
- Triggered the Hit parameter by script
- Edited the animator for nicer triggering

## Session 18

**Thu Sep 26 16:19:53 - Thu Sep 26 17:30:16**

**To do**
- Test icons  without borders
- Mockup with alt icon

**Done**
- Tried without borders, no more legible
- Tried with thicker borders, better but not perfect

![wip001](wip/wip001.png)

- Returned to using the shaded icons

![wip002](wip/wip002.png)

- Edited animators to be individual per icon
- Edited animation controllers to trigger manually
- Adding gifs to readme