using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmUpBot.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("warmup")]
        public async Task GenerateQuestion()
        {
            Random random = new Random();

            List<string> questions = new List<string>();
            questions.Add("What should every adventurer have?");
            questions.Add("What would you say with your dying breath?");
            questions.Add("What is the best meal you have ever eaten?");
            questions.Add("What is the best gift you have ever received?");
            questions.Add("What is one title you have earned that makes you proud?");
            questions.Add("Any retirement plan?");
            questions.Add("What is your favorite thing about adventuring?");
            questions.Add("In exchange of what would you sell your soul?");
            questions.Add("What did you last dream about?");
            questions.Add("What is one thing you prefer to do alone?");
            questions.Add("What is one thing you have changed your mind about?");
            questions.Add("When is the last time you were cold to someone else?");
            questions.Add("When is the last time you failed?");
            questions.Add("What do you do on your day off?");
            questions.Add("Describe the other party members in one word.");
            questions.Add("What song would you sing around the campfire?");
            questions.Add("What is your pet peeve?");
            questions.Add("If you were a warning label, what would it say?");
            questions.Add("What is your fondest memory?");
            questions.Add("What is one rule you never break?");
            questions.Add("A new adventurer approaches you, asking for wisdom. What lesson would you impart to the young one?");
            questions.Add("Describe a childhood friend.");
            questions.Add("If you could ask an all-knowing entity one question, what would it be?");
            questions.Add("If you were an animal, what would you be?");
            questions.Add("Where did you receive your education?");
            questions.Add("When is the last time you said \"I love you\" if ever?");
            questions.Add("What is your catch phrase?");
            questions.Add("What deity do you worship? How do you show your devotion?");
            questions.Add("Tell me about a trinket you possess.");
            questions.Add("What is one thing you admire about someone else in the party?");
            questions.Add("What do you do to relax after a hard day's work?");
            questions.Add("What do you see when you look in the mirror?");
            questions.Add("If your life was a book, what would its title be?");
            questions.Add("What is something that always makes you smile?");
            questions.Add("What is one way someone can earn your trust?");
            questions.Add("What is one thing you've seen or done that no one would ever believe?");
            questions.Add("What is one goal you hope to accomplish in the next year?");
            questions.Add("What is something you do every morning?");
            questions.Add("What is one sacrifice your character has made?");
            questions.Add("If you could use a magic hourglass and change one decision you've made this past year, what would it be?");
            questions.Add("What is one way you show you care about someone else?");
            questions.Add("What is something you don't have enough of?");
            questions.Add("If you were a drink, what would you be?");
            questions.Add("If you were to paint something, what would it be?");
            questions.Add("If you could be anywhere right now, where would you be?");
            questions.Add("");

            await ReplyAsync(questions[random.Next(questions.Count)]);
        }
    }
}
