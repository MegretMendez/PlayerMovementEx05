
#PlayerMovementEx05
Using Unity's Input System we will add additional basic movements do 3D characters, such as Jump, Double Jump and FastMovement

Part 1A. Download Input System


<img width="721" alt="Part1A_1" src="https://github.com/MegretMendez/PlayerMovementEx05/assets/142510070/29c60318-c75a-4f5a-970c-a84b94447a37">
<img width="797" alt="Part1A_2" src="https://github.com/MegretMendez/PlayerMovementEx05/assets/142510070/9e80c2d3-56b4-440e-9ab9-1989c42b3719">

Description: First let's download Unity's Input System by heading on to Window->Package Manager->Input System. Be sure that you are searching for the package in Unity's Registry. 

Part 1B. Configurate Input System

<img width="1439" alt="Part1B_1" src="https://github.com/MegretMendez/PlayerMovementEx05/assets/142510070/c526d4aa-4b83-427a-8977-8560f34f730e">
<img width="642" alt="Part1B_2" src="https://github.com/MegretMendez/PlayerMovementEx05/assets/142510070/605163b3-b140-4d70-a480-f0f5ab5a290c">
<img width="952" alt="Part1B_3" src="https://github.com/MegretMendez/PlayerMovementEx05/assets/142510070/adaa02dd-928b-4391-860e-bab2b0486e47">
<img width="952" alt="Part1B_4" src="https://github.com/MegretMendez/PlayerMovementEx05/assets/142510070/0ff02230-8ac2-4e6d-9204-9ab78133f0fd">

Description: Once we download the Input System we must configurate so we can implement it in our code. Go to File->Build Settings->Player Settings->Other Settings->Active Input Handling and select Both. Now we can implement the Input System in our Project.


Part 2. Creating Input Map

<img width="1436" alt="Part2_1" src="https://github.com/MegretMendez/PlayerMovementEx05/assets/142510070/3a36a6f0-4cce-41eb-8d8a-c37ac52caf30">
<img width="420" alt="Part2_2" src="https://github.com/MegretMendez/PlayerMovementEx05/assets/142510070/63f9f611-da9b-48d2-939f-bbf53b8f7578">

Description: To create an Input Map, go to your "Shooter/Player" prefab's Inspector panel. In this panel select Add Component->Player Input->Create Actions. Then name your new Input Map as you wish and save it in the Scripts Folder inside the Assets Folder. 

A basic Input comes with three default actions(Move,Fire,Look).Later we will add Jumping, Double Jumping and Fast Movements and implement it with code. This is how your Input Map should look like:

<img width="841" alt="Part2_3" src="https://github.com/MegretMendez/PlayerMovementEx05/assets/142510070/b6aacc0e-d83c-464b-a086-a85d741eccf7">

Part 3A. Adding Jump Action to Input Map


Description: We only need to add FastMove and Jump. Adding a Jump Action is simple, press the "+" in Actions and rename it as Jump, set the action as a Button type. Then in the Biding of your Action, set the path to the "Space[Keyboard]. Lastly, in the Binding Properties check the "Keyboard&Mouse" box.

<img width="841" alt="Part3_1" src="https://github.com/MegretMendez/PlayerMovementEx05/assets/142510070/26bbe02b-5839-4b0f-8c54-213f72266d28">
<img width="841" alt="Part3_2" src="https://github.com/MegretMendez/PlayerMovementEx05/assets/142510070/4b34fc55-6a05-4439-a954-d62a5dfc040e">
<img width="940" alt="Part3_3" src="https://github.com/MegretMendez/PlayerMovementEx05/assets/142510070/8cfee01d-3a2d-42fe-97f0-13eec687b8a4">
<img width="842" alt="Part3_4" src="https://github.com/MegretMendez/PlayerMovementEx05/assets/142510070/b5d74b26-a3fc-447b-8894-02f51c091497">

Part 3B. Adding FastMove Action to InputMap

Since the FastMove Action requires two buttons,("Shift" and A/D/W/S/Left Arrow,Right Arrow,Up Arrow,Down Arrow) these actions require two Bindings. 

<img width="842" alt="Part3B_1" src="https://github.com/MegretMendez/PlayerMovementEx05/assets/142510070/6e1c3fa5-0d7f-4f62-b054-b0fa07fadb2f">

Description: First Create a new Action as shown in Part 3A. Then besides the new action, hit the "+" and select "Add Binding with One Modifier". Remember to set your action as "Button".

<img width="844" alt="Part3B_2" src="https://github.com/MegretMendez/PlayerMovementEx05/assets/142510070/d1e37fb7-0250-4a93-b75d-05146e139513">


Now that we have created an Action, set the path of the first modifier as the "Shift" button and check the "Keyboard&Mouse" box.

<img width="841" alt="Part3B_3" src="https://github.com/MegretMendez/PlayerMovementEx05/assets/142510070/f37daf64-18c9-44d0-8dbf-1f8080a3d4f7">

Lastly, in the second Binding, set the path to "A[Keyboard]" and check the "Keyboard&Mouse" box. As a result we have created an action for moving left fast. Repeat Part3A and Part3B until you have covered all cases for movement.

<img width="848" alt="Part3B_4" src="https://github.com/MegretMendez/PlayerMovementEx05/assets/142510070/d667135e-a04c-4040-86a2-5d05a2820378">

To see how we implemented the Input Map with code, see the files we uploaded in this Repository. The code is explained through comments for a more intuitive experience.

