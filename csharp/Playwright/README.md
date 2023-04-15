# Tests web UI avec Playwright et Specflow

## Introduction

Ce repository contient deux projets :

* Cea.Tmma.UiTests.Core : le framework commun aux projets de tests et distribuable sous forme d'un package nuget.
* Cea.Tmma.Application.UiTests : un template de projet de tests spécifique à la TMMA CEA. Ce template de projet est distribuable sour forme de package nuget sous le nom `Cea.Tmma.WebUi.Tests`.

Cette solution technique repose sur les concepts suivants :
1. L'instanciation d'un navigateur web, au moment de l'exécution de tests et son pilotage depuis du code C#.
2. Le [Behavior Driven Development](https://en.wikipedia.org/wiki/Behavior-driven_development) et le langage Gherkin qui, combinés permettent d'organiser et d'exprimer des cas de tests fonctionnels en langage humain et exécutable depuis du code.
3. Le pattern de programmation appelé [page object pattern](https://www.martinfowler.com/bliki/PageObject.html) qui rend les tests pas l'interface plus robustes aux changements et plus maintenables dans le temps. Ce pattern est par ailleur bien supporté par [Playwright](https://playwright.dev/dotnet/docs/pom).

Les frameworks disponibles et choisis pour cette solution technique sont :
1. pour Le pilote de navigateur web : [Playright](https://playwright.dev/), [vers la documentation](https://playwright.dev/dotnet/docs/writing-tests).
2. pour le framework BDD : [Specflow](https://www.specflow.org/), [vers la documentation](https://docs.specflow.org/en/latest/)

## Pré-requis et outillage

Pour le support de Specflow dans Visual Studio (toute version) il est nécessaire d'installer les extensions suivantes:

1. Ajouter l'extension Specflow à Visual studio 2022 : https://marketplace.visualstudio.com/items?itemName=TechTalkSpecFlowTeam.SpecFlowForVisualStudio2022
2. ajouter le package pour eles nouveaux projets de tests (NUnit) : https://www.nuget.org/packages/SpecFlow/


## Démarrer un nouveau projet de tests



## Limites et remarques techniques

### Playwright

> Ne marche bien qu'avec NUnit et MSTest. On ne retient pas Xunit pour ce besoin.

https://playwright.dev/dotnet/docs/writing-tests

### PageObject pattern avec Playwright

Leur recommandation d'implémentation pour le pageobject pattern : https://playwright.dev/dotnet/docs/pom


## Générer un rapport d'exécution

### En local

1. installer le nuget package qui générera automatiquement un fichier json de rapport après chaque exécution : https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html
2. installer le dotnet tool qui génère la "living doc" au format HTML : https://docs.specflow.org/projects/spe
cflow-livingdoc/en/latest/LivingDocGenerator/Using-the-command-line-tool.html
3. Lancer la commande pour générer le rapport : 
``` livingdoc test-assembly bin\Debug\net7.0\PlaywrightTests.dll -t bin\debug\net7.0\TestExecution.json```

### Sur azuredevops 

A tester en suivant les instructions de ce lien : https://docs.specflow.org/projects/specflow-livingdoc/en/latest/Generating/Generating-Documentation.html

## TODOs

* vérifier que l'exécution // fonctionne avec plusieurs feature et plusieurs scénaios par features.
* améliorer le modéle programmatique pour faciliter la navigation entre pages applicatives et nottament suivre les redirections lors de la soumission des formulaires.Prendre exeple sur le projet fait che Ingenico avec Selenium.
* paramétrer le run des tests en fonction d'une configuration dans app.settings.
* extraire un template de projet qui sera réutilisé pour chaque application
* faire une doc des concepts et de comment ajouter des tests de la couche feature é la couche pageObjects.

