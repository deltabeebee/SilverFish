using Chuck.SilverFish;
using SilverFish.Enums;

namespace SilverFish.cards._01Basic._04Paladin
{
	class Sim_CS2_091 : SimTemplate //lightsjustice
	{

//
        CardDB.Card w = CardDB.Instance.getCardDataFromID(CardIdEnum.CS2_091);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(w, ownplay);
        }
	}
}