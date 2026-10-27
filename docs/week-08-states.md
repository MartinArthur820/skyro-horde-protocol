StateManager
Teraz       Udalosť     Potom
[Run        Pause       Pause]
[Pause      Pause       Run]
[Run        Collision   GameOver]
[Pause      Collision   Pause]
[GameOver   Pause       GameOver]
[GameOver   Retry       Run, od zaciatku hry]
[Run/Pause  Retry       Run/Pause (stav sa nezmeni)]

Submit
Prikaz      Run             Pause           GameOver
[Move       vykona sa       zahodi sa       zahodi sa]
[Fire       vykona sa       zahodi sa       zahodi sa]
[Pause      prejde do Pause prejde do Run   zahodi sa]
[Retry      zahodi sa       zahodi sa       nacita Arenu znova]

1. Na mieste a nebudu sa hybat.
2. Pause pricom colizia nema ziadny efekt na hru.
3. Zahodi command.
4. State hry a bude kontrolovany roznymi skriptami a commandmi.