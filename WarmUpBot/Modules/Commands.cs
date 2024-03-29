﻿using Discord.Commands;
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
            List<string> characters= new List<string>();

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
            questions.Add("Qu'elle est votre idée d'un bon divertissement?");
            questions.Add("Qu'est-ce qui vous fait rire?");
            questions.Add("Comment gérez-vous le stress?");
            questions.Add("Qu'est-ce qui vous choque ou vous offense?");
            questions.Add("Quel était votre routine d'un jour normal avant?");
            questions.Add("Nommez trois choses auxquelles vous excellez.");
            questions.Add("Nommez trois choses auxquelles vous êtes mauvais.");
            questions.Add("La dernière fois que vous avez pleuré?");
            questions.Add("Comment préférez-vous résoudre les conflits?");

            characters.Add("Régis");
            characters.Add("Ruben");
            characters.Add("Michaël");
            characters.Add("Ben");

            Random rand = new Random();
            var shuffled = characters.OrderBy(_ => rand.Next()).ToList();

            Console.WriteLine(String.Join(", ", shuffled));

            await ReplyAsync(questions[random.Next(questions.Count)]);
            await ReplyAsync($"{shuffled[0]}, tu commences, puis {shuffled[1]}, ensuite {shuffled[2]}, et enfin {shuffled[3]}.");
        }
    }
}
