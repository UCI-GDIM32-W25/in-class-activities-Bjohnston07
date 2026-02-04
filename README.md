# GDIM32 In Class Activities
## Instructions
Put each week's activities under new headers like the one shown above. Headers are created with the # symbol. More # symbols = smaller header.

## Week 1

### Activity 1

- Try to understand syntax and every part of lines as much as possible
- Ask peers for help
- Read all comments, instructions, etc. carefully before committing to any work
- Add detailed comments to work especially when working with others

### Activity 2

1. 10
2. 2
3. Every frame, prints "hello world" to the console
4. Monobehaviour
5. Prints "x = 10" to the console
6. 10 is the argument and is used to call the method with specific entries
7. Cannot call translate directly with Transform
8. use the _playerTransform member variable to call Translate

### Activity 3

[MG1 breakdown Google doc](https://docs.google.com/document/d/1l_v-lUJcDy0AyYdrUiEx2mTIQQP50WEgMH6YhFn23zE/edit?usp=sharing)

## Week 2

### Activity 1

<img width="2013" height="1268" alt="image" src="https://github.com/user-attachments/assets/8ba68433-3e57-49cb-9340-565a282c8add" />

### Activity 2

[Activity 2 Link](https://github.com/UCI-GDIM32-W25/mg2-Bjohnston07/commit/acc33bef362df660978941d961fa7b74c80dd844)

All required features have been implemented. I tried to add a trigger box that destroys the coins when they leave the screen but couldn't get it to work.

## Week 3

### Activity 1

Nolan Burns

### Activity 2

<img width="1280" height="720" alt="week3 32 activity 2 " src="https://github.com/user-attachments/assets/9e99108d-fd98-46f6-ae28-93cf2b0291aa" />

## Week 4

### Activity 0

- Audrey
- Nolan

### Activity 1

The objects lose the Locator component only, the last object in the hierarchy kept the script. Through the instance variable and the if statement, it checks and deletes other instances
of the locator script

### Activity 2


<img width="1822" height="1262" alt="w4 inclass breakdown" src="https://github.com/user-attachments/assets/253d037e-d9cc-488c-97e7-3961639d0511" />

### Activity 3

[MG4 Start Link](https://github.com/Bjohnston07/HW4/commit/ddffc9a872ac00e82c262752f9cd83d9798137bc)

In this commit I created the project file, the added all of the sprites. Then sliced them, added a ground object, a player object with one of the bird sprites, the started on
the jumping functionality within a player script.

## Week 5

### Activity 1

How the abstract and interface classes are used such as overridable methods that are already named, and simply have to be customized for each class is very efficient. The only
flaw that I can tell from the design of this system is having numbers like durability being hard coded within the script. It would be nice to know some way to simplify that 
specific process further. Not having to override a method like Break() for every single object if the only thing changing is one word.

### Activity 2

Classes within the demo that represent the model or data would be EnemyStats and Item W5 Demo 2 class. View classes would be the DialogueBubble and InventoryUI classes. Controller
classes would be PlayerW5Demo2 and EnemyW5Demo2.

### Activity 3

Scenario 1: The beats could be scriptable objects to easily create different types of beats.

Scenario 2: Inheritance are useful to create parent classes for things like characters and the child classes can specify character traits/abilities. State machines are helpful for the
different movement and animation types. Events are most likely firing every all the time. Every kill, every round start or game end would invoke events that update things like
the kill feed, scoreboard or activate certain character abilities that are subscribed to those events. 

Scenario 3: State machines could be used the stage of plant growth as well as the state of action the player is in.