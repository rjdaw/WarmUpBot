using Discord.Commands;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarmUpBot.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("rp")]
        public async Task GenerateQuestion()
        {
            Random random = new Random();

            List<string> questions = new List<string>();
            List<string> characters = new List<string>
            {
                "Finn",
                "Kythvol",
                "Malcer"
            };

            questions.Add("Quelle est une chose que nous devrions tous avoir?");
            questions.Add("Que diriez-vous avec dernier soupir?");
            questions.Add("Quel est le meilleur repas que vous ayez mangé?");
            questions.Add("Quel est le plus beau cadeau que vous ayez reçu?");
            questions.Add("Quel est un titre que vous avez reçu et qui vous rend fier?");
            questions.Add("Quel est votre plan de retraite?");
            questions.Add("Quel est la chose que vous préférez dans l'aventure?");
            questions.Add("En échange de quoi vendriez-vous votre âme?");
            questions.Add("La dernière chose dont vous avez rêvé?");
            questions.Add("Une chose que vous préférez faire seul?");
            questions.Add("Une chose dont vous avez changé d'avis?");
            questions.Add("La dernière fois que vous avez été froid avec quelqu'un?");
            questions.Add("La dernière fois que vous avez échoué?");
            questions.Add("Que feriez-vous si vous pouviez vous permettre un jour de congé?");
            questions.Add("Décrivez les autres membres du groupe en un seul mot.");
            questions.Add("Quel chanson chanteriez-vous au coin du feu?");
            questions.Add("Quel est votre bouton qui fait \"bims\"?");
            questions.Add("Si vous étiez une étiquette d'avertissement, que diriez-vous?");
            questions.Add("Quel est votre plus beau souvenir?");
            questions.Add("Une règle que vous ne brisez jamais?");
            questions.Add("Un jeune homme s'approche pour vous demander conseil. Quelle leçon lui donneriez-vous?");
            questions.Add("Décrivez un ami d'enfance.");
            questions.Add("Si vous pouviez posez une question à une entité omnisciente, quelle serait la question?");
            questions.Add("Si vous étiez un animal, lequel serait-ce?");
            questions.Add("Où avez-vous reçu votre éducation?");
            questions.Add("Quand est la dernière fois que vous avez dit \"Je t'aime\"?");
            questions.Add("Quel est votre maxime?");
            questions.Add("Racontez l'histoire d'un objet que vous possédez.");
            questions.Add("Une chose que vous admirez chez un membre du groupe?");
            questions.Add("Que faites-vous pour vous relaxer après une longue et dure journée de travail?");
            questions.Add("Que voyez-vous quand vous regardez dans le miroir?");
            questions.Add("Si votre vie était un livre, quel en serait le titre?");
            questions.Add("Quelque chose qui vous fait toujours sourire?");
            questions.Add("Une façon dont quelqu'un peut gagner votre confiance?");
            questions.Add("Une chose que vous avez vue ou faite que personne ne croirait?");
            questions.Add("Un objectif que vous aimeriez accomplir durant l'année qui arrive?");
            questions.Add("Une chose que vous faites chaque matin?");
            questions.Add("Un sacrifice que vous avez fait?");
            questions.Add("Si vous possédiez un sablier magique, vous reviendriez dans le passé pour changer quelle décision?");
            questions.Add("Une manière dont vous montrez que vous tenez à quelqu'un?");
            questions.Add("Quelque chose dont vous n'avez pas assez?");
            questions.Add("Si vous étiez une boisson, laquelle seriez-vous?");
            questions.Add("Si vous pouviez peindre quelque chose, que peindriez-vous?");
            questions.Add("Si vous pouviez vous trouver n'importe où maintenant, où seriez-vous?");
            questions.Add("Si tout était comme avant, quelle vie meneriez-vous?");
            questions.Add("Quelle est votre plus grande conviction morale?");
            questions.Add("Quelle relation avez-vous avec vos parents?");
            questions.Add("Quelle relation avez-vous avec vos frères et sœurs?");
            questions.Add("Avez-vous des préjugés en faveur ou défaveur d'autres races?");
            questions.Add("Quel est votre opinion sur la noblesse et l'autorité?");
            questions.Add("Décrivez votre apparence physique en détails.");
            questions.Add("Racontez l'histoire d'une de vos cicatrices.");
            questions.Add("Si vous pouviez développer un art, lequel serait-ce?");
            questions.Add("Décrivez votre relation avec la personne à votre droite.");
            questions.Add("Votre objectif principal en une seule phrase?");
            questions.Add("Est-ce que vous aimeriez un jour vous posez, avoir une femme, des enfants, une maison, etc.");
            questions.Add("Etes-vous déjà tombé amoureux?");
            questions.Add("Quelle fut votre combat préférée?");
            questions.Add("Quelle est votre saison préférée?");
            questions.Add("Quelle partie du monde voudriez-vous visiter?");
            questions.Add("Quelle est la plus grosse erreur que vous ayez commise");
            questions.Add("Avec quel membre du groupe avez-vous le plus de points communs?");
            questions.Add("Est-ce que vous regrettez une décision que le groupe a prise? Laquelle?");
            questions.Add("Quelle est votre plus grande qualité?");
            questions.Add("Quelle est votre plus grande peur?");
            questions.Add("Qu'est-ce que les gens pensent quand ils vous voient?");
            questions.Add("Qu'est-ce qui vous rend anxieux?");
            questions.Add("Une personne que vous admirez en dehors du groupe?");
            questions.Add("Une chose que vous n'aimez pas à propos de la personne à votre gauche?");
            questions.Add("Où vous sentez-vous le plus à la maison?");
            questions.Add("Est-il important pour vous comment les autres vous perçoivent?");
            questions.Add("Décrivez votre odeur.");
            questions.Add("Quel est votre cauchemar le plus récent/fréquent?");
            questions.Add("Quelle est votre opinion sur la Bannière Incolore?");
            questions.Add("A quoi ressemblait votre enfance?");
            questions.Add("Si vous pouviez savoir une chose sur le futur, que serait-ce?");
            questions.Add("Quelles couleurs vous sont associées?");
            questions.Add("Si un génie vous offrait un souhait, quel serait-il?");
            questions.Add("Que pensez-vous du fait de garder des choses secrètes au reste du groupe?");
            questions.Add("Quelle créature trouvez-vous la plus intrigante?");
            questions.Add("Quand vous étiez enfant, que vouliez-vous devenir?");
            questions.Add("Si quelqu'un de votre passé en qui vous confiez vous demandait de faire quelque chose qui va contre le groupe, quel camp choisiriez-vous?");
            questions.Add("Quel décision prise par le groupe vous ferait quitter le groupe?");
            questions.Add("Comment pensez-vous que vous mourrez?");
            questions.Add("Comment aimeriez-vous mourir?");
            questions.Add("Quelle est la plus grande chose que vous avez accomplie?");
            questions.Add("Quel est votre opinion sur le fait de tuer?");
            questions.Add("Quel est l'ampleur de votre générosité, spécialement envers les étrangers?");
            questions.Add("La personne à votre gauche et celle à votre droite vous donnent deux versions différentes de la vérité. Qui croyez-vous?");
            questions.Add("Si vous saviez que vous alliez mourir dans un mois, que feriez-vous de ces derniers moments?");
            questions.Add("Qu'est-ce qui vous fait vous sentir en sécurité?");
            questions.Add("Si vous deviez donner un nom au groupe, que serait-il?");
            questions.Add("Un souvenir dont vous aimeriez vous débarasser?");
            questions.Add("Quel talent insolite/inhabituel possédez-vous?");
            questions.Add("Comment vous sentez-vous par rapport au fait de recevoir/donner des ordres?");
            questions.Add("Que représente votre nom pour vous?");
            questions.Add("Si le peuple vous donnait un titre, ce serait? Ex: Le Hardi, Le Preu, etc.");
            questions.Add("Si vous pouviez choisir, pour quelle raison se rappellerait-on de vous?");
            questions.Add("Si vous deviez étudier un sujet en profondeur, que serait-ce?");
            questions.Add("Quelle carte de tarot seriez-vous?");
            questions.Add("Comment vous voyez-vous dans 10 ans?");
            questions.Add("Quelle est votre relation avec la magie?");
            questions.Add("Qui est votre plus grand rival?");
            questions.Add("Quel est votre plus grand défaut?");
            questions.Add("Qu'est-ce qui est le plus important? La santé, la richesse ou l'amour?");
            questions.Add("Quel conseil donneriez-vous à la version plus jeune de vous-même?");
            questions.Add("Quel est la chose dont vous êtes le plus curieux pour l'instant?");
            questions.Add("Quel est votre plus vieux souvenir?");
            questions.Add("Où avez-vous appris le plus (connaissance, compétences, etc.)");
            questions.Add("Racontez votre premier baiser.");
            questions.Add("Comment êtes-vous mort?");
            questions.Add("Qui a le plus d'influence sur vous?");
            questions.Add("Quelle est la chose la plus mauvaise que vous ayez faite?");
            questions.Add("Quelle est la chose la plus embarrassante qui vous est arrivée?");
            questions.Add("Quel est votre idéal politique?");
            questions.Add("Quelle est selon vous la pire chose qu'un être humain puisse faire?");
            questions.Add("Pour qui ou quoi seriez-vous prêt à mourir?");
            questions.Add("Vers qui vous tourneriez-vous si vous aviez besoin d'aide de manière déserpérée?");
            questions.Add("Quelle est la personne que vous détestez le plus?");
            questions.Add("Quels sont vos hobbies?");
            questions.Add("Qu'aimez-vous lire?");
            questions.Add("Quelle est votre idée d'un bon divertissement?");
            questions.Add("Qu'est-ce qui vous fait rire?");
            questions.Add("Comment gérez-vous le stress?");
            questions.Add("Qu'est-ce qui vous choque ou vous offense?");
            questions.Add("Quel était votre routine d'un jour normal avant?");
            questions.Add("Nommez trois choses auxquelles vous excellez.");
            questions.Add("Nommez trois choses auxquelles vous êtes mauvais.");
            questions.Add("La dernière fois que vous avez pleuré?");
            questions.Add("Comment préférez-vous résoudre les conflits?");
            questions.Add("Quelle est votre meilleur souvenir depuis votre renaissance?");
            questions.Add("Quelle est votre pire souvenir depuis votre renaissance?");

            foreach (string character in characters)
            {
                questions.Add($"Si vous pouviez poser une question au futur {character}, quelle serait-elle?");
            }

            Random rand = new Random();
            var shuffled = characters.OrderBy(_ => rand.Next()).ToList();

            Console.WriteLine(String.Join(", ", shuffled));

            await ReplyAsync(questions[random.Next(questions.Count)]);
            //await ReplyAsync("Que ressentez-vous depuis votre arrivée à Rugrive et désirez-vous le partager?");
            await ReplyAsync($"{shuffled[0]}, tu commences, puis {shuffled[1]}, et enfin {shuffled[2]}.");
        }

        [Command("r")]
        public async Task RollDiceAsync(int numDice)
        {
            // Roll the dice
            var rolls = new Dictionary<int, int>();
            var random = new Random();
            for (int i = 0; i < numDice; i++)
            {
                rolls[i] = random.Next(1, 11);
            }

            // Tally rolls and prepare success list
            var successList = new Dictionary<int, int>();
            foreach (var roll in rolls)
            {
                if (roll.Value >= 6 && roll.Value < 10)
                {
                    successList[roll.Key] = roll.Value; // Add the actual number of the success
                }
                else if (roll.Value == 10)
                {
                    successList[roll.Key] = 10;
                }
            }

            // Sort the list in descending order
            var sortedSuccessList = successList.OrderByDescending(x => x.Value).ToList();

            // Cancel the highest successes by the number of ones
            int ones = rolls.Values.Count(roll => roll == 1);
            int canceledSuccesses = 0;
            var canceledRolls = new HashSet<int>();
            var cancelingOnes = new HashSet<int>();

            for (int i = 0; i < sortedSuccessList.Count && canceledSuccesses < ones; i++)
            {
                if (sortedSuccessList[i].Value > 0)
                {
                    int key = sortedSuccessList[i].Key;
                    sortedSuccessList[i] = new KeyValuePair<int, int>(key, -sortedSuccessList[i].Value); // Mark as canceled by setting to negative
                    canceledRolls.Add(key);
                    canceledSuccesses++;
                }
            }

            // Identify the ones that canceled successes
            foreach (var roll in rolls)
            {
                if (roll.Value == 1 && cancelingOnes.Count < canceledSuccesses)
                {
                    cancelingOnes.Add(roll.Key);
                }
            }

            // Calculate the final number of uncanceled successes and uncanceled tens
            int uncanceledTens = sortedSuccessList.Count(x => x.Value == 10);
            int uncanceledPairsOfTens = uncanceledTens / 2;
            int remainingTens = uncanceledTens % 2;
            int finalSuccesses = sortedSuccessList.Count(x => x.Value > 0) - uncanceledTens + (uncanceledPairsOfTens * 4) + remainingTens;

            // Determine the result message
            string result;
            if (finalSuccesses == 0 && canceledSuccesses < ones)
            {
                var criticalFailureMessages = new List<string>
        {
            "Échec critique! Comme ta mère!",
            "Ça ou trébucher sur une feuille morte c'est pareil!",
            "T'aurais dû rester au lit aujourd'hui!",
            "Dis au MJ que le 1 est cassé.",
            "Ᏽዐ𐌋ፏꝊፕ𐋅"
        };
                result = criticalFailureMessages[random.Next(criticalFailureMessages.Count)];
            }
            else if (finalSuccesses == 0)
            {
                var failureMessages = new List<string>
        {
            "Même Régis aurait fait mieux!",
            "C'est pas la fin du monde, mais presque.",
            "C'est pas grave, on t'aime quand même.",
            "C'est pas un échec, c'est une réussite manquée.",
            "T'es juste nul. C'est tout.",
        };
                result = failureMessages[random.Next(failureMessages.Count)];
            }
            else if (uncanceledTens >= 2)
            {
                var criticalSuccessMessages = new List<string>
        {
            "Succès critique! Il semblerait que le Voyageur te guide!",
            "Succès éclatant! On dirait que les Gardiens te protègent!",
            "Magnifique! Telle est la volonté des Prodromes!"
        };
                result = criticalSuccessMessages[random.Next(criticalSuccessMessages.Count)];
            }
            else if (finalSuccesses >= 6)
            {
                var highSuccessMessages = new List<string>
        {
            "Ça, ma couille, c'est du lancer de dés!",
            "Incroyable! Du pur talent!",
            "Époustouflant, ni plus, ni moins.",
            "Bravo! Juste bravo."
        };
                result = highSuccessMessages[random.Next(highSuccessMessages.Count)];
            }
            else if (finalSuccesses == 3 || finalSuccesses == 4 || finalSuccesses == 5)
            {
                var midSuccessMessages = new List<string>
        {
            "Bien joué! Bien joué!",
            "Pas mal du tout, chef!",
            "Belle performance! La foule applaudit!"
        };
                result = midSuccessMessages[random.Next(midSuccessMessages.Count)];
            }
            else if (finalSuccesses == 1 || finalSuccesses == 2)
            {
                var lowSuccessMessages = new List<string>
        {
            "Pas mal...mais pas génial non plus...",
            "C'est un début...",
            "Pas de quoi crever un œil à un Banuah.",
            "Un p'tit jet calme, comme Rugrive.",
            "C'est mieux que rien, je suppose."
        };
                result = lowSuccessMessages[random.Next(lowSuccessMessages.Count)];
            }
            else
            {
                result = $"Nombre total de succès: {finalSuccesses}";
            }

            result = $"{finalSuccesses} succès.\n*{result}*";

            // Format the response
            var response = new StringBuilder();
            response.AppendLine("Tu as roulé:");

            // Add formatted rolls to the response
            foreach (var roll in rolls)
            {
                if (canceledRolls.Contains(roll.Key) || cancelingOnes.Contains(roll.Key))
                {
                    response.Append($"~~{roll.Value}~~  "); // Strikethrough for canceled rolls and canceling ones
                }
                else if (roll.Value == 1)
                {
                    response.Append($"**{roll.Value}**  "); // Bold for 1
                }
                else if (roll.Value >= 6 && roll.Value < 10)
                {
                    response.Append($"**{roll.Value}**  "); // Bold for successes
                }
                else if (roll.Value == 10)
                {
                    response.Append($"__**{roll.Value}**__  "); // Bold and underline for critical success
                }
                else
                {
                    response.Append($"{roll.Value}  ");
                }
            }

            response.AppendLine("\n");
            response.AppendLine(result);

            await ReplyAsync(response.ToString());
        }
    }
}