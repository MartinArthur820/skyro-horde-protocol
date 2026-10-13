ADR : 001 Hranice Modulov

Status :

    Proposed

Context :

    Na hodine sme dostali zadané spraviť jednoduchý ADR kvôli budúcnosti štruktúry komunikácii tochto projektu. Projekt budeme robiť celý polrok takže je potrebné aby sme mali dobrú štruktúru kódu rovno od začiatku. Potrebné je rozhodnúť ako hra bude rozdelená a ktoré časti budu medzi sebou komunikovať.

Decision :

Časti hry sú rozdelené na 

Data (Backend hry)
    Obsahuje iba samotné dáta hráča, enemákov, wavok, atď. Nepotrebuje komunikovať s ostatnými častami lebo má pozíciu data holdera.

Gameplay (Ovládanie)
    Rieši všetko čo sa týka fungovania hlavného gameloopu čiže napr. Wave systém, ovládanie hráča, AI enemákov. Komunikovať potrebuje iba s Dátmi aby ich mohol využívať rovno v hre.

Presentation (Grafika hry)
    Potrebuje riešiť aj samotné sprity aj herné rozhranie a stavy v ktorých sú. Komunikovať potrebuje aj s Gameplay časťou a s Dátovou časťou skriptov.

\\ Zbytok není v Builde hry \\

Editor (Unity Editor veci)
    Rieši iba tooly v editore na zjednodušenie práce ale ajtak pri tom potrebuje komunikovať s Gameplay časťou a Dátovou časťou.

Tests (Časti hry v testovacej forme)
    Majú za úlohu najefektívnejšie otestovavť mechaniky/dynamiky v hre. Odkazujú na Gameplay a Dáta aby sme ich mohli otestovať počas vývoja. 

Concequences :
    V Editore sa bude jednoduchšie pracovať pri zakomponovaní tochto rozdelenia.
    Väčší prehľad vo funkcií skriptoch.
    Jednoduchšie menenie dát pre game dizajnerov za pomoci Data časti a Editor nástrojov.