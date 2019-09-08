﻿using HREngine.Bots;

namespace SilverFish.cards._01Basic.Druid
{
    class Sim_NEW1_007a : SimTemplate //starfall choice left
    {

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
            p.allMinionOfASideGetDamage(!ownplay, dmg);
        }

    }
}