using Chuck.SilverFish;

namespace SilverFish.cards._02Classic
{
	class Sim_EX1_080 : SimTemplate //* Secretkeeper
	{
		// Whenever a Secret: is played, gain +1/+1.

        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Minion m)
        {
            if (hc.card.Secret) p.minionGetBuffed(m, 1, 1);
        }

	}
}