# Hunt-The-Wumpus
---

## About The Project
This project is done as part of a MSSA team competition between different cohorts. The objective is to create a [Hunt The Wumpus](https://en.wikipedia.org/wiki/Hunt_the_Wumpus) game as a team to see whose program is the best. The following team from **Quantico Cohort #7** is working on this project:
- [Dmitry Landy](https://github.com/DmitryLandy/)
- [Jae Yi](https://github.com/jaehyi)
- [Phillip Tham](https://github.com/Phillip-M-Tham)
- [Alex Sanchez](https://github.com/AlexSanchez7x)
- [Douglas Doniel](https://github.com/Douglas-Doniel)
- [Dakin Werneburg](https://github.com/dakinwerneburg)
- [Scott Revillar](https://github.com/smrev88)
- [Jim Simon](https://github.com/jimsimon9)


## Rules

The following are the [rules](https://www.pdp8.net/games/wumpus.shtml) for the game:

# New Rules

/*****************************************************
* RULE CHANGES:
* 
* 1. One player, armed with an M4 Carbine with ONE (1) bullet
* 2. Firearm range is one cavern only, but hits are guaranteed
* 3. One Wumpus, who does not move, with stench only in the adjacent caverns
* 4. As many caverns as desired, possibly player configurable, with any number of tunnels (i.e., does not have to be 3)
* 5. As many bats as desired, with chirps only in the adjacent caverns, possibly player configurable
* 6. As many pits as desired, with drafts only in the adjacent caverns, possibly player configurable
* 7. Winning: shooting the Wumpus
* 8. Losing: falling into a pit, shooting into the wrong cavern, entering the Wumpus cavern without shooting 
*****************************************************/


   WUMPUS.BA     -    A "HUNT THE WUMPUS" GAME

Note: This is a basic game, see BASIC instructions.

YOU ARE A FAMOUS HUNTER DESCENDING DOWN INTO THE CAVES OF DARKNESS,
LAIR OF THE INFAMOUS MAN-EATING WUMPUS.  YOU ARE EQUIPPED WITH FIVE
BENT ARROWS, AND ALL YOUR SENSES.  THERE ARE TWENTY CAVES CONNECTED
BY TUNNELS, AND THERE ARE TWO OTHER KINDS OF HAZARDS:

        A) PITS, WHICH ARE BOTTOMLESS, AND USUALLY FATAL TO FALL
        INTO.  THERE ARE THREE SUCH PITS IN THE NETWORK.

        B) SUPER-BATS, WHICH IF YOU STUMBLE INTO THEIR ROOM WILL
        PICK YOU UP AND DROP YOU IN SOME RANDOM ROOM IN THE NETWORK.
        YOU MAY SHOOT SUPER-BATS, THERE IS ONE IN EACH OF THREE OR
        FOUR ROOMS WITHIN THE NETWORK.  THE SUPER-BATS GENERALLY STAY
        IN THEIR OWN ROOMS, EXCEPT WHEN DISPOSING OF INTRUDERS OR
        SCAVENGING FOR FOOD IN THE PITS.

IF YOU BLUNDER INTO THE SAME ROOM AS THE WUMPUS, YOU LOSE....
THE NORMALLY SLEEPING WUMPUS DOES NOT MOVE (HAVING GORGED HIMSELF UPON
A PREVIOUS HUNTER).  HOWEVER SEVERAL THINGS CAN WAKE HIM UP:

        1) WALKING INTO HIS ROOM,
        2) SHOOTING AN ARROW ANYWHERE IN THE NETWORK,
        3) TRIPPING OVER DEBRIS (CLUMSINESS),
        4) TURNING ON THE LIGHTS, IN ORDER TO SEE WHERE YOU ARE
        HEADED.

IF HE WAKES UP THERE'S A POSSIBILITY HE WILL MOVE, HOWEVER, HE'S TOO
LAZY TO MOVE MORE THAN ONE ROOM BETWEEN SNOOZES.  THE WUMPUS IS TOO
BIG TO BE PICKED UP BY SUPER-BATS AND HAS SUCKER FEET, SO HE DOESN'T
FALL INTO THE PITS.

YOU CAN SMELL THE WUMPUS FROM ONE OR TWO ROOMS AWAY.  YOU WILL
TREMBLE WITH FEAR WHEN HE MOVES ABOUT.  YOU CAN HEAR SUPER-BATS FROM
ONE ROOM AWAY, AND FEEL DRAFTS (FROM BOTTOMLESS PITS) FROM ONE ROOM
AWAY (AND TASTE THE FEAR...).

TO SHOOT AN ARROW TYPE "SHOOT" INSTEAD OF A MOVE, AND THEN
SPECIFY WHICH ROOMS THE ARROW SHOULD PASS THROUGH.  YOU ARE STRONG
ENOUGH TO SHOOT IT THROUGH AS MANY AS FIVE ROOMS.  BENT ARROWS HAVE
NO PROBLEM ROUNDING CORNERS OF LESS THAN 98.6 DEGREES.  IF YOU
SPECIFY AN IMPOSSIBLE PATH THE ARROW WILL RICOCHET OFF THE WALLS OF
THE ROOM, LOSING SPEED, AND WILL EVENTUALLY COME TO REST IN ONE OF
THE ADJOINING ROOMS.  THE PATH MAY BE TERMINATED BY SPECIFYING ROOM 0.

EACH ROOM IS CONNECTED TO THREE OTHER ROOMS BY THREE TUNNELS A, B
AND C.  YOU MUST ALWAYS MOVE BETWEEN ROOMS BY SPECIFYING WHICH
TUNNEL YOU WISH TO EXPLORE.  YOU CAN ALWAYS RETRACE YOUR FOOT STEPS
BY MOVING BACK USING THE SAME TUNNEL DESIGNATOR.

IF YOU WISH TO SEE WHICH ROOMS ARE AT THE ENDS OF THE TUNNELS YOU
MAY TYPE "LIGHTS ON" INSTEAD OF A MOVE.  THIS MAY BE AN UNHEALTHY
LUXURY HOWEVER BECAUSE THE LIGHT GIVES THE WUMPUS INSOMNIA.  TO
EXTINGUISH THE LIGHTS SIMPLY TYPE "LIGHTS OFF".

                GOOD LUCK HUNTING!!
