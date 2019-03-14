using System;
using CID.BL.Domain;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CID.DAL.EF
{
    class CityOfIdeasDbInitializer
    {
        private static bool hasRunDuringAppExecution = false;

        public static void Initialize(CityOfIdeasDbContext context, bool dropCreateDatabase = false)
        {
            if (!hasRunDuringAppExecution)
            {
                // Delete database if requesed
                if (dropCreateDatabase)
                    context.Database.EnsureDeleted();

                // Create database and seed dummy-data if needed 
                // Create database and seed dummy-data if needed 
                if (context.Database.EnsureCreated())
                    Seed(context);

                // 'false' if database already exists
                // Seed initial (dummy-)data into newly created database
                //Seed(context);

                hasRunDuringAppExecution = true;

            }



        }

        private static void Seed(CityOfIdeasDbContext context)
        {

            

            Project project1 = new Project()
            {
                Title = "Ontwerpteam voor nieuwe Krugerbrug in Hoboken gekend.",
                Preface = "De stad Antwerpen heeft het ontwerpteam Ney & Partners BXL en Omgeving cvba gekozen voor de bouw van een nieuwe Krugerbrug voor fietsers en voetgangers in Hoboken. ",
                Text =
                "Met deze nieuwe brug maakt de stad een comfortabele en veilige verbinding tussen twee belangrijke fietsroutes: de fietsostrade F13 tussen Antwerpen en Hemiksem / Boom en de Districtenroute." +
                "Het ontwerp bestaat uit 3 bruggen die telkens op een groene aanloophelling liggen. Met een projectdefinitie, die de doelstellingen en de uitgangspunten voor het ontwerp vastlegde, zijn de " +
                "stad Antwerpen en spoorwegbeheerder Infrabel in de loop van 2018 op zoek gegaan naar een ontwerpteam om de nieuwe brug te ontwerpen. Eind oktober konden de buurtbewoners en de gebruikers van" +
                " de twee fietsroutes, de vijf ingediende voorstellen inkijken en hun opmerkingen doorgeven. Eind januari heeft de stad het ontwerpteam, een samenwerking tussen de bureaus Ney &Partners BXL " +
                "en Omgeving cvba, gekozen voor het verder ontwerpen en bouwen van de nieuwe fiets-en voetgangersbrug.Het ontwerp bestaat uit 3 bruggen die telkens op een groene aanloophelling liggen." +
                " Hierdoor ontstaan er rond de bruggen grote groene ruimtes, zijn de bruggen snel en eenvoudig te plaatsen en kan elke brug afzonderlijk worden aangepast bij een verdere ontwikkeling van het" +
                " industrieterrein Blue Gate Antwerp of het project Lageweg.",
                Ideations = new List<Ideation>()
            };

            Ideation ideation1 = new Ideation()
            {
                Project = project1,
                Title = "Voetgangers en fietsers gescheiden",
                Text = "Ik zou het enorm goed vinden moest er een onderscheid kunnen gemaakt worden tussen de fietsers en de voetgangers waardoor geen van de 2 last heeft van elkaar.",
                Tags = new List<Tag>()

            };
            //Gebruik maken van tags!!
            Tag tag1 = new Tag()
            {
                tag = TagEnum.Natuur
            };
            Tag tag2 = new Tag()
            {
                tag = TagEnum.Verkeer
            };
            ideation1.Tags.Add(tag1);
            ideation1.Tags.Add(tag2);

            Ideation ideation2 = new Ideation()
            {
                Project = project1,

                Title = "Maak de brug minder steil!",
                Text = "De brug moet minder steil, zo kan iedereen gebruik maken van dit fantastisch idee ook oudere mensen!",
                Tags = new List<Tag>()

            };
            ideation2.Tags.Add(tag1);
            ideation2.Tags.Add(tag2);
            project1.Ideations.Add(ideation1);
            project1.Ideations.Add(ideation2);

            Project project2 = new Project()
            {
                Title = "Hakhoutbeheer langs de gewestwegen en autosnelwegen.",
                Preface = "De komende maanden voert het Agentschap Wegen en Verkeer hakhoutbeheer uit langs de gewestwegen en autosnelwegen." +
                " De bomen en struiken worden afgezaagd op een tiental centimeter boven de grond. In de volgende seizoenen schieten ze opnieuw uit.",
                Text = 
                "Hakhoutbeheer is een eeuwenoude en alternatieve vorm van beheren van bomen en struiken.De bomen worden daarbij afgezaagd op een tiental centimeter boven de grond." +
                "In de volgende seizoenen schieten ze opnieuw uit.Hakhoutbeheer lijkt op het eerste gezicht drastisch, maar na enkele maanden komen alweer nieuwe scheuten uit de stompen tevoorschijn." +
                "Hakhoutbeheer zorgt zo voor een verjonging van de beplanting in de berm en voor een verrijking van het ecosysteem.Dankzij het hakhoutbeheer komt er immers opnieuw veel licht op de bodem." +
                "Hierdoor kunnen voorjaarsbloeiers en andere planten beter groeien.De wegbermen vormen zo interessante verbindingsassen tussen verschillende natuur - en leefgebieden van fauna en flora." +
                "Dieren gebruiken ze om zich te verplaatsen en nieuwe gebieden te koloniseren.Naast de verrijking van het ecosysteem zorgt hakhoutbeheer ook voor een grotere verkeersveiligheid." +
                "Oudere bomen hebben de neiging om overhangende takken te ontwikkelen die de zichtbaarheid op de weg kunnen beperken.Bovendien krijgen ze gemakkelijk dood hout in hun kruin," +
                "dat bij sterke wind op het wegdek kan belanden.Oude en grote bomen kunnen omvallen of ontworteld raken bij felle windstoten." +
                "Ze kunnen dan op de weg terechtkomen en een gevaar vormen voor de weggebruikers.Hakhoutbeheer helpt dit voorkomen.Het hakhoutseizoen loopt van 1 november tot 15 maart het volgende jaar." +
                "Hakhoutbeheer wordt in de winterperiode uitgevoerd omdat bomen niet in het blad staan, de sapstroom langzamer verloopt(en de bomen dus minder kwetsbaar zijn) en de vogels niet broeden.",
                Ideations = new List<Ideation>()

            };
            Project project3 = new Project()
            {
                Title = "Plantin en Moretuslei.",
                Preface = "Veiligere fiets- en voetpaden voor de Plantin en Moretuslei.",
                Text = "De Plantin en Moretuslei is een belangrijke invalsweg voor fietsers en automobilisten. De fietspaden zijn echter sterk verouderd en niet voorzien op het aantal fietsers dat " +
                "vandaag via deze weg de stad in en uit fietst. Om de veiligheid en het comfort voor zowel de fietsers als de voetgangers te verbeteren, plannen het Agentschap Wegen en Verkeer " +
                "(dat de weg beheert) en de stad Antwerpen een grondige herinrichting.   ",
                Ideations = new List<Ideation>()

            };
            Project project4 = new Project()
            {
                Title = "Rode loper Spoor Noord & Turnhoutsebaan.",
                Preface = "In de loop van 2018 kan u vanop de nieuwe fietsbrug aan de IJzerlaan via de ‘Rode loper Park Spoor Noord’ vlot en veilig doorrijden naar het centrum van de stad. ",
                Text = "Vandaag is de aanleg van de Rode Loper Spoor Noord volop aan de gang.  Hieronder vindt u een overzicht van de lopende en geplande werken op deze route.Via de Samberstraat en het " +
                "Damplein kan u doorrijden tot in Park Spoor Noord.  Aan de andere kant van het park kan u via de Lange Dijkstraat en de Rotterdamstraat naar de Van Stralenstraat om via de Pijlstraat " +
                "en de Van Arteveldestraat het centrum te bereiken.",
                Ideations = new List<Ideation>()

            };
            Project project5 = new Project()
            {
                Title = "Met z’n allen naar een mooie, groene buurt in Mariaburg.",
                Preface = "In de wijken Mariaburg en Ekeren Donk in Ekeren wordt veel belang gehecht aan groen en erfgoed. Om deze twee belangrijke kenmerken van Mariaburg te bewaren en versterken, " +
                "heeft de stad een plan opgemaakt dat een aantal richtlijnen juridisch verankert.",
                Text = "Plan voor bescherming van groen en historisch karakterDe laatste decennia ondergaat het historische karakter van de buurt rond Sint - Mariabrug veranderingen.Door verbouwingen en " +
                "vermenging van bouwstijlen wordt het architec­turaal samenhangende beeld op bepaalde plaatsen onderbroken.Door de bebouwingsdruk wordt het bovendien steeds moeilijker om het vele groen in" +
                " stand te houden.Om ervoor te zorgen dat de omgeving in en rond Sint - Mariaburg mooi groen en architecturaal kwalita­tief blijft, heeft de stad een ruimtelijk uitvoeringsplan(RUP) " +
                "opgemaakt.De ambitie is om er het cul­tuurhistorisch erfgoed,de architectuurkenmerken en het groene karakter te bewaren.Een ruimtelijk uitvoeringsplan(afgekort een RUP) is een juridisch " +
                "afdwingbaar document dat in concrete richtlijnen zegt wat er wel en niet kan in een afgebakend gebied.Het bepaalt waar en hoe er in uw buurt in de toekomst gebouwd en verbouwd mag worden." +
                "Op welke plaatsen kunnen er bijvoorbeeld woningen,bedrijven,winkels,openbare ruimte of recreatie komen ? Alle toekomstige ontwikkelingen worden aan dit plan getoetst.",
                Ideations = new List<Ideation>()

            };
            Project project6 = new Project()
            {
                Title = "Groenplan zorgt voor 187 hectaren extra groen in de stad.",
                Preface= "Ongeveer de helft van Antwerpen bestaat uit groen of water. De stad wil deze groenzones beschermen, verbinden en zowel kwantitatief als kwalitatief versterken. Om dat te verwezenlijken, is er nu het Groenplan ‘Levendig landschap’. De komende jaren worden er ook Groenplannen uitgewerkt voor de districten en dit in overleg met de betrokken districtsbesturen.",
                Text = "Met de realisatie van het Groenplan zal het groenareaal van de stad – op dit moment zo’n 6200 hectaren – met 3% of 187 hectaren groeien. Maar liefst 6% of 358 hectaren groen zal extra juridisch beschermd worden als groengebied en nog eens 15% of 819 hectaren zal kwalitatiever worden dankzij een nieuwe inrichting of beter beheer. Het einddoel is een systeem van grootschalige groengebieden die de stad verlevendigen en de bewoners overal in de stad toegang geven tot aangename groene landschappen. Zo wil de stad een duurzame leefomgeving creëren voor mens, plant en dier, nu en in de toekomst. ",
                Ideations = new List<Ideation>(),
            };

            context.Projects.Add(project1);
            context.Projects.Add(project2);
            context.Projects.Add(project3);
            context.Projects.Add(project4);
            context.Projects.Add(project5);
            context.Projects.Add(project6);

            context.SaveChanges();
            foreach (EntityEntry entry in context.ChangeTracker.Entries().ToList())
            {
                entry.State = EntityState.Detached;
            }
        }

    }
}

            

