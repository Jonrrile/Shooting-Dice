using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always roles one higher than the other player
    public class OneHigherPlayer : Player
    {
        public override int HighRoller()
        {
            return Random().Next(DiceSize) + 100;
        }
    }
}