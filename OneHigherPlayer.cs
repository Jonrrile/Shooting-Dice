using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always roles one higher than the other player
    public class OneHigherPlayer : Player
    {
        public override void Play(Player other)
        {
            int opponentRoll = other.Roll();
            int highRoll = opponentRoll = 100;

            Console.WriteLine($"{Name} rolls a {highRoll}");
            Console.WriteLine($"{other.Name} rolls a {opponentRoll}");
            Console.WriteLine($"{Name} Wins, Some would call it luck...");
        }
    }
}