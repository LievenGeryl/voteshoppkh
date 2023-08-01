## How rewards get picked

**!!IMPORTANT!!**
This system can be abused if one path is worth more GP on average than the other, as players could choose to max out the "lesser" path first to maximize loot on the better path. Therefor, these rewards aren't very balanced (or fleshed out) yet. It's just a proposal/draft and can be edited.
Amounts are the lower & upper boundary, randomly selected. 

It is possible to get one or multiple extra rolls. This depends on your streak. I was thinking something along the lines of: 
You have a 10% base chance on getting an extra roll. Every day you get another 10% chance, which caps at 9. This means that if you focus on just one path and reach your last crate (before you get the end item), you would have a 100% chance at an extra roll. For every extra roll a player gets, they get 10% less on the next attempt at a reroll. If my explanation isn't the best, I've C#-pseudo-code-ified it a bit [here](https://github.com/LievenGeryl/voteshoppkh/blob/main/roll.cs) so you can get a better idea about what I'm thinking of.


## Limitations
You can not bank or drop a crate. We want to force people to open these crates straight away. Mainly so we avoid crazy bugs like someone getting 16h of 2x construction XP because they got lucky when opening a dozen crates, and because rewards would be scaled to your current progress. This also means that you can not claim another crate before you've opened the one you already have on your account.

## Boosters
These go in effect immediately when you open the crate. Getting a booster while already having a booster of the same type active will **extend** said booster. You will be warned if you open a crate while having a booster active. If you get one, it will tell you in your chatbox in a bold red color. I will try to make this into an item you can consume as well, so these can be given away during events.


# Rewards
I have based these mainly on what I think would be cool & things that Adam has given out during community PvM events.

## Skilling crate

- 5000-10,000 Raw manta ray
- 2500-7500 Raw rocktail
- 1000-5000 Runite bar
- 2500-5000 dragon bolts (unf)
- 100-1000 torstol, extreme attack, extreme ranged, ... (supplies for 100-1K overloads)
- 1-10 100M ticket
- 30min-2h of double fletching XP
- 30min-2h of double woodcutting & firemaking XP
- 30min-1h of double construction XP
- etc.

## PK crate
- 100-500 rocktails, 100-500 super combat potions, 100-250 restore potions, 50-150 saradomin brews, 100-250 Cooked karambwan
- 1-3 abbysal whip, 1-3 dragonfire shield, 1-3 berserker ring, 1-3 amulet of fury, 1-3 barrage runes pouch (not sack!), 1-3 vengeance runes pouch (not sack!)
- 1-2K opal/jade/diamond dragon bolts (e) (All the ones besides ruby, since those are for PVM)
- 3-6h double BH point booster (stacks with events)
- 1-2h double PKP booster (stacks with events)
- 1-10 100M ticket
- 1-5 Dharok's armor set
- 1-5 Ahrim's armor set
- 1-5 Karil's armor set
- etc.

## PVM crate

- 10-100 overloads, 100-250 saradomin brews, 50-150 super prayer potions
- 5-15% damage boost(does not stack with 
- 3-6h of 10-30% droprate increase for rare items
- 1-8h of double Combat XP
- 1-6h of double GWD KC(?)
- 10,000 Ruby Dragon Bolts(e)
- 1-10 100M ticket
- Very rare chance of getting 1 Preserve scroll
- etc.
