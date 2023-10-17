<img width="1436" alt="Part2_1" src="https://github.com/MegretMendez/PlayerMovementEx05/assets/142510070/1f79ffaf-c773-4f56-84a7-88a62aa41914"># PlayerMovementEx05
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

A basic Input comes with three default actions(Move,Fire,Look).Later we will add Jumping, Double Jumping and Fast Movements and implement it with code. This is how your Input Map should like:

<img width="841" alt="Part2_3" src="https://github.com/MegretMendez/PlayerMovementEx05/assets/142510070/b6aacc0e-d83c-464b-a086-a85d741eccf7">

