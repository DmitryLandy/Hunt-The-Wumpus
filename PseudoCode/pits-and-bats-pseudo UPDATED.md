# HTW Pseudocode: Bats and Pits
---

**Bats**
- Can pick you up and drop you into random rooms
- Can be shot (they die, decrease count)
- 5 in the map
- Only leave their rooms to dispose of intruder

**Pits**
- Three located in the map
- doesn't move
- Fatal to fall into (You Lose)

---

## Bats Class
```
class Bat
{
	static batCount //keeps track of total number of bat objects
	
	Room number //location of bat	
	
	//constructor that takes room number as parameter
	Bat(Room number)
	{
		this bat's Room number = number
		batCount ++
	}
	
	//noise bat makes. Sensed up to one room
	if(player in adjacent room)
		print "bat flying nearby"
	
	if(bat is hit by arrow)
	{
		BatCount --		
		this bat remove from room //maybe a method		
	}
	
	//teleport player if in same room as bat
	teleportPlayer()
	{
		//generate a new valid room to put player in
		do
		{
			generate a room number
		}while( room number = current room and room number doesnt have hazard); //Do we want to check for hazard? Or just make it a risk?
			
		
		//generate a new valid room for itself
			//check for hazard or player
		do
		{
			generate a room number
		}while(room number doesnt have hazard or player); //Do we want to check for hazard? Or just make it a risk?		
	}
}
```
## Pits Class
```
class Pit
{
	Room number //location of the pit
	
	//constructor that takes room number as parameter
	Pit(Room number)
	{
		Pit's Room number = number		
	}
	
	if(player in adjacent room)
		print "You feel a Cold Breeze"
		
	if (player location == room Number) //same room
	{
		print "You fell into the pit"
		gameOver();
	}
}
```