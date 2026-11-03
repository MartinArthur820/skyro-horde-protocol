1. dalsi scriptable object prefab z WaveDefinition ktory bude obsahovat data dalsej vlny.
2. factory skript by mal povedat poolu ze potrebuje poolnut tychto enemakov z enemyPool a dat ich do sceny s GetEnemy.
3. lebo s kanalom dostava priamu variabilnu wavky rovno z dat a nie cez spawner (bez spawnera neni potom referencia)
4. pri niecom ako player je zle vyuzitie v ukladani statov hraca kedze sa scriptableobjekty nemenia mimo sceny a resetnu sa ked sa zmeni scena.