# End to end tests avec Playwright et Specflow

Temps passé sur R&D : 4h.

## Playwright

> Ne marche bien qu'avec NUnit et MSTest. On ne retient pas Xunit pour ce besoin.

https://playwright.dev/dotnet/docs/writing-tests

### PageObject pattern avec Playwright

Leur recommandation d'implémentation pour le pageobject pattern : https://playwright.dev/dotnet/docs/pom

## Specflow

1. Ajouter l'extension Specflow à Visual studio 2022 : https://marketplace.visualstudio.com/items?itemName=TechTalkSpecFlowTeam.SpecFlowForVisualStudio2022
2. ajouter le package pour eles nouveaux projets de tests (NUnit) : https://www.nuget.org/packages/SpecFlow/

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

