# POC tests end to end format Behavior Driven Development avec Playwright et Cucumber

## Introduction

Playwright est l'outil de manipulation du navigateur, exuteur de tests et librairie d'assertions. Il est écrit et maintenu par Microsoft. (contre attaque envers Cypress)
Cucumber est l'outil qui permet d'écrire les cas de tests en Gerkin (BDD) et qui devient le moteur d'éxecution des tests.

Cypress vs Playwright : https://mtlynch.io/notes/cypress-vs-playwright/#what-i-miss-about-cypress

Supporte tous les navigateurs modernes : Edge, Crhome, Firefox, Safaris (cf confs cucumber.conf.js, playwright.config.ts)


## Launch tests

Pour avoir le report en HTML
```npm run test:e2e-ci acceptance/features/todo.feature > report.html```

Pour avoir le rport dans la console
```npm run test:e2e-dev acceptance/features/todo.feature ```

## Pre-requis

Voir les pages webs des packages.

Playwright : https://playwright.dev/docs/intro#installing-playwright
Cucumber : https://cucumber.io/docs/cucumber/api/?lang=javascript

Le seul pré-requis système est 'npm' qui est installé lors de l'installation de 'nodejs' sur Windows.

## Notes en vrac

Features : "localizable"
StepDefinitions

PageObject implementation : 

* https://dev.to/jankaritech/behavior-driven-development-bdd-using-playwright-n1o
* https://www.cuketest.com/playwright/docs/test-pom/

Rapports HTML et rapports Pretty

packages.json : 

* script e2e-ci => rapport HTML
* script e2e-dev => rapport pretty dans terminal

## pistes futures

Utiliser TypeScript plutot que js pour éviter les erreurs de syntaxes du langage et se faire aider par un compilateur : https://www.elliotdenolf.com/blog/cucumberjs-with-typescript

Comparer les runners cucumber et playright pour ne pas passer à coter des trucs puissants de playright (workers, tests en // et autres que je n'ai pas encore identifiés)

## browser headless

dans cucumber.conf.js : `... headless: false,`
