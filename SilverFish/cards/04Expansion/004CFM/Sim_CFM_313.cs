using HREngine.Bots;

namespace SilverFish.cards._04Expansion._004CFM
{
	class Sim_CFM_313 : SimTemplate //* Finders Keepers
	{
		// Discover a card with Overload. Overload: (1)

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardName.lightningbolt, ownplay);
            if (ownplay) p.ueberladung++;
        }
    }
}