
## organisation

Le premier niveau d'organisation concerne les sous domaines de l'application testée. Voici quelques exemples de sous domaines dans le cas d'une application backoffice de e-commerce :

* Sous domaine Authentification
* Sous domaine administration (gestion des droits, paramétrages des devises...)
* Sous domaine facturation
* Sous domaine paramétrage de la boutique en ligne
* Sous domaine gestion des stocks
* ...

Le deuxième niveau d'organisation est une organisation en terme de responsabilités techniques. On retrouve donc les 3 couches suivantes :

* Features : contient uniquement les fichiers .feature de Specflow.

* StepsDefinitions : contient uniquement des classes csharp implémentant les 'steps' utilisés par les features du sous domaine concerné.

* PageObjects : contient uniquement les classes décrivant et manipulant des pages ou parties de pages des applications.

Dans un sous domaine donnée, on limitera au strict nécessaire l'utilisation de stepsDefinitions des autres sous domaine.

## Best practicies pour chaque couche

### Features

Il existe une 'intellisence' sur les stepsDefinitons existants. Cela vous permet de retrouvé un step existant plus facilement.

> Il est impératif de ne pas dupliquer des steps definitions.

### StepsDefinitions

### PageObjects

## Entretien du patrimoine de tests

Il existe le risque d'avoir des stepsDefinitions non utilisés et de conserver du code mort, ce qui constituerait de la dette technique. On cherche à éviter la dette technique.
Specflow nous aide à gérer ceci en affichant dans son rapport appelé 'livingDocumentation.html' dans la section 'Analytics', tous les steps inutilisés.

> Il est impératif de ne pas dupliquer des steps definitions. Vous êtes les garants de la maintenabilité.
