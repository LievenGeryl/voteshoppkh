## Important to consider

I'm building the system rework on the shop rework I had drafted, so there could be some items in the shop rework that are irrelevant now.

## **Voting system rework**

I could've sworn we have/had vote "streaks", with RL being the one that rewards players the most, I figured that'd be the main incentive to keep voting daily. I reconsidered it and realized that even if we have or had streaks its actually not that good of an incentive, hell, I don't even vote.

Moving on to the WarThunder system. It actually looks quite neat and refreshing, and I got some additional ideas to cater it to PKHonor while also having an actual shop. I'll wireframe a bit to give some visual aid, don't mind the shitty photoshopping & things not being to scale. 


### The system itself.
We take the best of both worlds (shop & war thunder/battlepass-ish/warframe system).

One of the first considerations is how we would require the players to get progress. If RL is the most important one, then a registered vote for RL is all we really need. If we want them to vote for every single site, then that's the requirement.

There are 3 "paths" you can take & max out every month. It also resets every month. I was thinking 10-10-10, although that is an issue for february. For an outlier like that, I suggest something like a voting event during february, where one vote counts as two for the progress. 
These paths I spoke of would be, as you probably guessed by now, the path of the PVMer, PKer & Skiller.

How to access these "paths" and see your progress? Well, we change the functionality of the ::vote command to display the interface. When they press the "vote" button for their chosen path, they get redirected to the vote page, but this way we know **what** path they're voting for. I don't think I can access anything that goes beyond opening a URL, so I'm guessing this is where you (Rapsey) will have to alter some of the code behind voting page to acommodate for this.

![alt text](https://github.com/LievenGeryl/voteshoppkh/blob/main/voteprogress.png)
*Forgot to add a timer until next reset & a streak counter, which is useful for players.

As you can see on the wireframe, it's a bunch of crates and then ends at an item. If a player maxes out one path, they can still continue to vote for this path and receive crates. Losing your streak means losing your additional rolls (see link on next paragraph), but it does not lose your progress towards getting the item.

### Crates
While they may look the same, they're not. They're dependent on the path you got them from, so it'd be Skilling Crates, PVM Crates & PK Crates.

They are guaranteed to give between 10-50 vote points & the rest of their contents are randomized, but appropriate for the path they come from. [Click here](https://github.com/LievenGeryl/voteshoppkh/blob/main/crates.md) to see the rewards these crates would offer & how these crates would work.

### Items
At the end of your path, you will receive an item that can be extremely helpful but have a limited "lifespan". **These will remain on your account until the next reset, which keeps you constantly voting if you want access to these items.** I just took a few random items to illustrate it while wireframing, but obviously an AGS or once-a-day death touched dart wont cut it. I'm trying to make these items worth voting for, but not too OP. I noted some ideas for these items down [here](https://github.com/LievenGeryl/voteshoppkh/blob/main/items.md).

## **Keep in shop**

`Item name\description - ID - Required items - Notes`

1M Coins - 995 - 1 pts - Fine for ironman. Far better alternatives to get them are ingame. It's only a few M per day.

PkHonor points - 4067 - 1 pts - Fine for ironman. Far better alternatives to get them than are ingame. It's only a few PKP per day.

Ex-ex-parrot - 42210 - 500 pts - Fine for ironman. They would still be able to get them from clues. Getting a parrot shouldn't be pure RNG though.

Dark bow (blue) - 43006 - 200 pts + dark bow (11235) - Fine for ironman. No reason why they shouldn't have it in vote shop. Yeah they can get it from clues too. Remove them from clues or leave as is.

Dark bow (green) - 43008 - 200 pts + dark bow (11235) - See above

Dark bow (yellow) - 43010 - 200 pts + dark bow (11235) - See above

Dark bow (white) - 43012 - 200 pts + dark bow (11235) - See above

Brown afro - 43004 - 500pts + Powdered wig (10392) - Fine for ironman. Remove them from clues or leave as is. No reason why there shouldn't be a less RNG-dependent way to obtain them. Still takes a while to save up regardless & for this, and the next few items, you still need to do a ton of clues to get the 'ingredients' for them.

Rainbow afro - 12430 - 250pts + Brown afro (43004) - See above.

Black partyhat - 11862 - 1500pts + Red partyhat + Yellow partyhat + Blue partyhat + Green partyhat + Purple partyhat + White partyhat -  See above.

Rainbow partyhat - 11863 - 750pts + Black partyhat (11862) + Rainbow afro (12430) - See above.

Partyhat & specs - 12399 - 1500pts + Black partyhat (11862) + Gnome goggles (9472) - See above.

Black h'ween mask - 11847 - 700 pts + Green halloween mask + Blue halloween mask + Red halloween mask - See above.


## **Add to shop** 

`Item name\description - ID - Required items - Notes`

### Items that should require minimal/no effort to get working

Golden Chef's Hat - 20205 - 1000 pts - Equips in weapon slot. Looks fine. Disappears when teleporting. Reappears when teleport animation finishes. - Suggested initial price: 750M-1500M

Silly jester hat - 10836 - 250 - Nice fashionscape set. Looks fine on both male & female models. Item model in inventory\bank looks a bit weird. Destroy option needs to become drop option, and also drop the item. Suggested initial price: 200M-300M *

Silly jester top - 10837 - 250pts - See above *

Silly jester tights - 10838 - 250pts - See above *

Silly jester boots - 10839 - 250pts - See above *

* These items could be obtained with a holiday event, so I understand if you would choose not to add these.

Cow mask - 11919 - 100pts - Equips in weapon slot. Looks fine. Fun little fashionscape item. Suggested initial price: 75M-125M

Desert disguise - 4611 - 150pts - Fun little item.

Banana cape - 25502 - 2500pts - Equips in weapon slot. Destroy option needs to become drop option. Item already gets dropped when "destroying". New big ticket item. Looks awesome. Looks fine on both male & female models. Suggested initial price: 2250-2750M

Banana hat - 25840 - 2500pts - Equips in weapon slot. Destroy option needs to become drop option.  Item already gets dropped when "destroying". New big ticket item. Looks awesome. Looks fine on both male & female models. Suggested initial price: 2250-2750M

'24-Carat' sword - 24539 - 1500pts - New big ticket item. Looks kinda cool. Looks fine on both male & female models. Suggested initial price: 1250M-1750M

Prop sword - 22316 - 1000pts - Looks fine on both male & female characters. Suggested initial price: 750M-1250M

3rd age pickaxe - 20014 - 5000pts - Flex item. Looks fine on both character models. Would have same functionality as a sacred clay pickaxe. Untradeable.

3rd age axe - 20011 - 5000pts - Flex item. Looks fine on both character models. Would have same functionality as a dragon axe. Untradeable.

### Items that need some major fixing

Pharaoh's sceptre - 26950 - 500pts - There's so many variants and IDs of the pharaohs sceptre, but at least this one has a wield option. Doesn't work so I can't tell whether or not the model itself is bugged.

Birthday balloons - 21209 - 500pts - The balloons face forward like a sword. They need to face up. 

## **Remove from shop**

`Item name\description - ID - Reasoning`

Advanced mystery box - 290 - No one buys this anyways. Very expensive for what it is as well. Also prevents irons from getting godswords, statuses, spiritshields & third age druidic by only voting.



## Some sources & additional notes
https://forums.pkhonor.net/viewtopic.php?f=134&t=81790 - Iron Man Vote Shop by Church

https://forums.pkhonor.net/viewtopic.php?f=73&t=83703 - Vote Rewards for Ironmen by Thearlygamer

I didn't go with skilling sets. They can be introduced with another update which implements all of them. Having these in the voting store would give players another incentive to vote.
I didn't include the anger items suggested by Thearlygamer. Many of those custom servers with Pokemons and ak47s have these as over-the-top OP weapons and it doesn't feel right to have them on PKH. 
