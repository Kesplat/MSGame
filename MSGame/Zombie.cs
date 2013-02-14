using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Zombie : GameObject
{
    enum ZombieType {normal, crazy, freak};
    enum Direction {north, south, east, west, northEast, northWest, southEast, southWest}

    protected int health;
    protected int walkingSpeed;
    protected ZombieType zombieType;
    protected Direction facing;
    protected Character currentTarget;
    protected boolean alive;
    protected int followTime;
    protected int attactRate;

    //Might not need this? var[0] = x, var[1] = y coordinate
    protected int[] currentPosition;

    public Zombie(ZombieType typeIn)
	{
        zombieType = typeIn;
        updateZombieAttribute(); //Will this work? or the instance has to be created first?
        followTime = 0;
        currentTarget = null;
        
        //Might not need this
        currentPosition = new int[2];
	}//constructor

    //might not need this if going to have array of GameObject location
    public void walk()
    {

        //
        if (currentTarget == null)
        {
            facing = randomDirection();
            walk(facing);
        }//if
        else
        {
            int[] targePosition = currentTarget.getPosition();
            facing = findTargetDirection(targetPosition);
            walk(facing);
        }
    }//walk

    public void walk(Direction directionIn)
    {
        currentDirection = directionIn;
        
        //speed determind how many slot to move
        switch (currentDirection)
        {
            case north:
                currentPosition[1] += walkingSpeed; 
                break;
            case south:
                currentPosition[1] -= walkingSpeed;
                break;
            case east:
                currentPosition[0] -= walkingSpeed;
                break;
            case west:
                currentPosition[0] += walkingSpeed;
                break;
            case northEast:
                currentPosition[0] -= walkingSpeed;
                currentPosition[1] += walkingSpeed;
                break;
            case northWest:
                currentPosition[0] += walkingSpeed;
                currentPosition[1] += walkingSpeed;
                break;
            case southEast:
                currentPosition[0] -= walkingSpeed;
                currentPosition[1] -= walkingSpeed;
                break;
            case southWest:
                currentPosition[0] += walkingSpeed;
                currentPosition[1] -= walkingSpeed;
                break;
        }//switch

    }//else

    private Direction randomDirection()
    {
        Random random = new Random();
        return random.Next(0, 4);
    }//randomDirection

    private Direction findTargetDirection(int[] positionIn)
    {
        Direction productDirection = north;
        //need to know how grid is numbered
        //Do some x - x and y - y then should know where to face. (positive/negative value)
        return productDirection;
    }//findTargetDirection

    //evolve to the next zombie
    public void evolve()
    {
        if(zombieType != freak)
            zombieType += 1;
        updateZombieAttribute();
    }//evolve

    private void updateZombieAttribute()
    {
        switch (zombieType)
        {
            case normal:
                walkingSpeed = ;
                health = ;
                attactRate = ;
                break;
            case crazy:
                walkingSpeed = ;
                health = ;
                attactRate = ;
                break;
            case freak:
                walkingSpeed = ;
                health = ;
                attactRate = ;
                break;
        }//switch
    }//updateZombieAttribute

    public void decreaseHealth(int damageIn)
    {
        if(health > 0)
        {
            health -= damageIn;
            alive = false;
        }//if
    }//decreaseHealth

    public int getHealth()
    {
        return health;
    }//getHealth

    public ZombieType getType()
    {
        return zombieType;
    }//getType

    public int getAttactRate()
    {
        return attactRate;
    }//getAttactRate

    public void setWalkingSpeed(int speedIn)
    {
        walkingSpeed = speedIn;
    }//setSpeed

    public void follow(Character targetIn)
    {
        currentTarget = targetIn;
    }//follow
}//class
