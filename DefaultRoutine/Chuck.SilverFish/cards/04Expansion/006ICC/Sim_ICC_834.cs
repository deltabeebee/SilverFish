using Chuck.SilverFish;
using SilverFish.Enums;

namespace SilverFish.cards._04Expansion._006ICC
{
    class Sim_ICC_834: SimTemplate //* Scourgelord Garrosh
    {
        // Battlecry: Equip a 4/3 Shadowmourne that also damages adjacent minions.

        CardDB.Card w = CardDB.Instance.getCardDataFromID(CardIdEnum.ICC_834w); //Shadowmourne

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.setNewHeroPower(CardIdEnum.ICC_834h, ownplay); // Bladestorm
            if (ownplay) p.ownHero.armor += 5;
            else p.enemyHero.armor += 5;

            p.equipWeapon(w, ownplay);
        }
    }
}