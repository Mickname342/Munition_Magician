# Munition Magician
 ![Title_Screen](https://github.com/Mickname342/Munition_Magician/blob/main/Images/Title%20screen.PNG)

 Munition Magician is a wave based top-down shooter with roguelike lements. The Player has to complete 12 waves of enemies, but to help them they will be able to get an upgrade to their combat abilities every 3 waves.

All of the code was made by Mickname342. [Link to the itch.io page](https://mickname.itch.io/munition-macigian)

 ## Player Abilities 
 The player will be able to move with WASD, shoot with left click and place bombs with right click. For more information on player movement check the [PlayerMovement script](https://github.com/Mickname342/Munition_Magician/blob/main/Roguelike-GameDesig/Assets/Scripts/PlayerMovement.cs) annd the [Shooting script](https://github.com/Mickname342/Munition_Magician/blob/main/Roguelike-GameDesig/Assets/Scripts/Shooting.cs)
 
 The bullets the player shoots can have different elements:

 Fire: Will deal damage overtime to the enemies and burn shields

 ![Fire](https://github.com/Mickname342/Munition_Magician/blob/main/Images/Fire%20effect.PNG)

 Wind: Will knock back the enemies

 Electricity: Will create a hitbox around the enemy that hits other enemies

 ![Electricity](https://github.com/Mickname342/Munition_Magician/blob/main/Images/Electricity.PNG)

 Water: Will slow down the enemies

 For more information on the elements check the [Enemy script](https://github.com/Mickname342/Munition_Magician/blob/main/Roguelike-GameDesig/Assets/Scripts/Bear.cs) and the respective scripts for the elements ([ApplyFire](https://github.com/Mickname342/Munition_Magician/blob/main/Roguelike-GameDesig/Assets/Scripts/ApplyFire.cs), [ApplyElectricity](https://github.com/Mickname342/Munition_Magician/blob/main/Roguelike-GameDesig/Assets/Scripts/ApplyElectricity.cs), [ApplyWater](https://github.com/Mickname342/Munition_Magician/blob/main/Roguelike-GameDesig/Assets/Scripts/ApplyWater.cs) and [ApplyWind](https://github.com/Mickname342/Munition_Magician/blob/main/Roguelike-GameDesig/Assets/Scripts/ApplyWind.cs)

 The bomb will explode when the player hits it with a bullet. For more information on the bomb check the [Bomb script](https://github.com/Mickname342/Munition_Magician/blob/main/Roguelike-GameDesig/Assets/Scripts/ApplyWind.cs)

 ![Bomb1](https://github.com/Mickname342/Munition_Magician/blob/main/Images/Bomb.PNG) [Bomb2](https://github.com/Mickname342/Munition_Magician/blob/main/Images/Explosion.PNG)

 ## Waves
 At the beggining of the game the player will be able to choose between the four elements for their bullets and an upgarde for the playable character. The elements will not be randomised, but the upgrades will This is done by randomising 3 integers and then using a switch statement. For more information on the upgrade randomisation check the [ScoreManager script](https://github.com/Mickname342/Munition_Magician/blob/main/Roguelike-GameDesig/Assets/Scripts/ScoreManager.cs)

 ![Elements](https://github.com/Mickname342/Munition_Magician/blob/main/Images/Elements.PNG) ![Upgrades](https://github.com/Mickname342/Munition_Magician/blob/main/Images/Upgrade.PNG)

 The upgardes have a whide range and can go from a simple +1 damage to the bullets to an increasing spread shot or even damaging orbs rotating around the player.

 ![Spread_Shot](https://github.com/Mickname342/Munition_Magician/blob/main/Images/Spread%20shot.PNG)

 ![Final_Wave](https://github.com/Mickname342/Munition_Magician/blob/main/Images/Final%20Wave.PNG)

 The enemies will also change depending on the wave. There are four tipes: a small goblin, a crossbow goblin, a shielded goblin and a big goblin. All of them (except the crossbow goblin) use an A* pathfinding algorithm to know where the player is. For more information check the [Enemy script](https://github.com/Mickname342/Munition_Magician/blob/main/Roguelike-GameDesig/Assets/Scripts/Bear.cs)
