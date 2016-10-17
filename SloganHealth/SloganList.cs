using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SloganHealth
{
    public static class SloganList
    {
        //------Creating list of tips/Slogans------
        private static List<string> m_sloganList = new List<string> {
        "Drink More Water",

        "Focus on Nutrients, Not Calories",

        "Limit your alcohol intake.",

        "Walk at least 3 times a week for 20 to 30 minutes",

        "Sleep More to Slim Down",

        "Make Breakfast Mandatory",

        "Get Your Daily Dose of D",

        "Make your home clean and clear",

        "Sleep 7 to 9 hours in a pitch dark bedroom",

        "Make sure you're vaccinated.  ",

        "They say the best things in life are free, and coneys(which are almost free) aside, they’re pretty much right.",

        "Go to the MBAD Museum (African Bead Museum - Detroit) -Visit the home, shop, and outdoor exhibit of visual artist Olayami Dabls, who created the space to honor the cultures and art of Mother Africa within the city.",

        "Go to the DIA - Admission to this incredible museum is miraculously free of charge for Oakland, Wayne, and Macomb county residents. Make sure you check out the free entertainment and films on Friday nights.",

        "Go to the Detroit Historical Museum - Learn about this city’s never-boring past -- be it French fur trappers, Civil War forts, rum running, or sports heroes.",

        "Wave “HI” to Canada - No really, they love it!",

        "Walk or bike the Dequindre Cut - Or skate, or jog, or line dance.Just get out and enjoy this beautiful 1.35-mile path of green space in the city!",

        "Browse volumes at John K.King Used & Rare Books - Stories upon stories within stories upon stories.",

        "Do a group bike ride - Join dozens, hundreds, or even thousands of other city boosters on bike rides through the city’s wide and open streets.Check out Slow Roll, Critical Mass, and Fender Bender collective -- just to name a few -- for upcoming rides.",

        "Sit on the beach in Campus Martius - Someone had the brilliant idea of creating a giant adult sandbox in the middle of Downtown, complete with adult beverages and smooth jazz.",

        "Watch a movie at New Center Park - This green oasis in New Center is a great place to catch a film and admire the lights of the towering Fisher Building.",

        "Visit Old Tiger Stadium - Run the bases on this legendary corner in Detroit with the spirits of Mark Fidrych and Sparky Anderson cheering you on.",

        "Go to Eastern Market - There’s always something going on, either within the market or in the bustling shops and restaurants that surround it.",

        "Go to a free festival - From the Detroit Jazz Festival to Dally in the Alley to Meridian Winter Blast and a wildly high number more, there’s always free entertainment options in the city.",

        "Visit a cider mill - As the nation’s third-most prolific apple-growing state, Michigan has this awesome combo that not every state gets to enjoy.Cider and donuts in Florida? Yeah right.",

        "Visit the Anna Scripps Whitcomb Conservatory - Wander around the cacti, palms, and all manner of exotics housed within this historic greenhouse.",

        "Ride the elevator at the Renaissance Center - Climbing the up 72 stories and watching the view of Windsor and the Detroit River through the glass also provides a you with a sweet chance for the aforementioned wave at Canada.",

        "Walk or bike the Riverfront - Detroit’s riviera is just as beautiful as that of any other town.Err...any other Midwestern town.",

        "Get a museum adventure pass - Visit your local library to pick up a Detroit Museum Adventure Pass, which can help you get in free to museums that charge pesky old admission fees.",

        "Visit Pewabic Pottery - Rearrange the house number tiles they sell there so they spell “boobs” (80085!) and giggle to yourself as you peruse this historic ceramics studio.",

        "Go see live music! Absolutely available, all the time, almost all over the city, and often for free. Just make sure to tip the bands.",

        "Walk or bike to Belle Isle - If you don’t have the $10 yearly fee to enter the island, get on for free on two feet or two wheels.",

        "Once you’re at Belle Isle: go swimming - Many a great city lies on the bank of some body of water, but would you ever swim in New Orleans’ Mississippi River ? How about the San Francisco Bay ? The Detroit River may not win any cleanliness awards, but by all counts, it’s safe to baptize yourself in the river of rock.",

        "Play disc golf on Belle Isle ? -While you’re out adventuring on Belle Isle, you may as well toss a disc around.Just don’t forget your mosquito repellant.",

        "Sing karaoke - One of Detroit’s favorite sports is karaoke.Granted, the bartenders would appreciate you purchase a drink, but the actual singing is free.",

        "Wander around in antique stores - Lose yourself for an afternoon as you browse through rows and rows of useless junk.Just kidding!There are always some gems and lots of Detroit memorabilia at Detroit Antique Mall, The Detroit Mercantile Co., and Eastern Market Antiques, among others.And hey, just because you aren’t looking for a cardboard cutout of Chuck Berry to put in your bathroom doesn’t mean someone else isn’t.",

        "Visit the Detroit Public Library - All libraries are great(books are good, mmmkay), but the main branch on Woodward is particularly exquisite.Peruse through the historic building and imagine the city in its heyday.",

        "Wander around Greektown - One of the liveliest parts of town, always bouncing with odd and delicious smells and behavior.",

        "Hang out at Hart Plaza - Let your freak flag fly in the city’s waterfront central park.",

        "Visit art galleries - See what your creative sistren and brethren are up to and maybe even get inspired.",

        "Visit Cranbrook’s gardens - Explore forests, gardens, and even a lake or two within this art academy’s 319 - acre campus.",

        "Go to Marvin’s Marvelous Mechanical Museum - Let your inner child run free(literally, there’s no admission fee) at this arcade that doubles as a historical museum.Bring some spare change or return bottles if you want to play some vintage games.",

        "Take a garden tour at Meadow Brook Hall -A beautiful spot north of the city.",

        "Wander around Hamtramck - The most diverse city in Michigan-- representing humanity across the seven seas.",

        "Cruise Jefferson Ave along the water -See many sides of the city by bike, by car, by... um, pony?",

        "Take a self-guided architectural tour -By car, by bike, or by foot --don’t buy the ticket, take the ride.",

        "Cruise Woodward Ave - Watch the Motor City and Suburbs come together.",

        "Take a selfie at the Train Station - And while you’re at it...",

        "Sleep under a tree at Roosevelt Park -Seriously, posting up in the green space outside the aforementioned foresaken landmark is a pretty romantic idea for many Detroiters --and wayyy better than it would have been before the parks revival.",

        "Track down famous graves - Son House, Rob Tyner, Fred “Sonic” Smith, Hiram Walker, etc., are all buried around our fair city.Go pay your respects to these important figures in Detroit history.",

        "Visit the Heidelberg Project - Stroll around this outdoor art exhibit and marvel at the combination of visual art, community, and the beautifully weird that makes this place uniquely Detroit.",

        "Go fishing at William G.Milliken State Park - One of the best views of the city!",

        "Take a tour of the Masonic Temple - Go get creeped out and simultaneously informed as you wander through the freakishly high number of rooms in this, the largest of all Free Mason buildings in the world.",

        "Visit Power House Productions - Visit a neighborhood in Hamtramck that’s been transformed house by house into art spaces and even a skate park.",

        "Ride bikes along Hamilton Ave - One of Detroit’s straightest shots and a nearly deserted strip, take it up to Palmer Park and enjoy the city’s peace and quiet.",

        "Visit Hamtramck Disneyland - It could be considered the most bizarre place in Detroit, if Detroit didn’t have so many bizarre places.",

        "Volunteer with a local organization - Lord knows the city needs help, and there is a multitude of organizations that will help you help others.Donate your free time to a worthy cause, and have fun doing it.",

        "Go wildlife watching - Pheasants, coyote, deer, bald eagles, peregrine falcons...who knows what else?!Our urban prairie is home to many unexpected animals.",

        "Bust a move - And now for something completely different: learn how to salsa dance on Fridays and Saturdays at Vicente’s Cuban Cuisine or even make the trek out to Diamondback Saloon to learn how to line dance.",

        "Run around with your pooch at a dog park - Or, go by yourself and run around with someone else’s pooch, since most owners will let you pet their dogs for free.",    };

        
        public static string GetRandomSlogan()
        {
            //-----Picks a random item out of the list-----
            int upperbound = m_sloganList.Count;
            Random random = new Random();
            int randomValue = random.Next(0,upperbound-1);
            //------Returns that random Item------
            return m_sloganList[randomValue];
           }
    }
   
}
