Link to original functioning repository: https://rijeka.sdsu.edu/jnguyen1941/cs583_s22_nguyen_jasmine_project1a

Project #1A:  User Interface - Character Generator


A DnD style character generator made with Unity with a user interface that will be used to select a character for a player of your future games. 

Requirements:

-Use the Unity Canvas system to create a user interface.  
-The UI should be a scene named Scene_Roll_Character, When your game starts up this scene will load. 
-The UI should implement a D&D 5th edition character generator which saves the following game properties (in a data structure) to a JSON formatted string (must pass validation) displayed in a selectable (input) text box. All the following elements should be in the output (saved data structure):
-Character Name - String
-Abilities - floats  Ability_Strenght, Ability_Dexterity, Ability_Constitution, Ability_Intelligence, Ability_Wisdon, Ability_Charisma 
-Race - String
-Class  - String 
-Alignment - String
-Experience Points ( Current and Max) - XP - Integer
-Hit Points ( Current and Max) - HP - Integer
-Armor Class - Integer
-Speeds ( Walking, Running, and Jump Height ) - Integer
-Item List - List<String> (Leave list empty for this Assignment)
-The Abilities portion of your UI  should implement a dice simulator. Players must roll (5d8 +6d3) and add the three highest rolls to compute each of the six Abilities (one at a time). Note make all modifiers default to +2. See below for list of Abilities. One Button per ability.
-The Race and Class elements should be implemented as a Drop Down menu UI element. 
-The speeds should be implemented as a slider UI element between 2 and 56.
-The armor class element should only accept user input that is a positive integer between 1 and 100. 
-Once all abilities have been calculated, the json output shall be displayed in the output section (Hint this should be a Text Input field used for output only, yes a UI element).
-The project should implement an Exit Button that will exit the game in both Editor Mode and Run Mode. 
-You must build and code this UI all by yourself. No additional assets (Free or paid for (Especially the Unity Tutorials)) may be used. 
-You may not use external APIs to generate your character.
-Must be coded in C# using Unity3d 2020.4.# (LTS) 
