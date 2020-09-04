using System.Collections.Generic;

namespace ShootingDice
{

    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        List<string> insults = new List<string>()
        {
            "You stink",
            "You rolled a nat 1",
            "Get good"
        };
    }
}