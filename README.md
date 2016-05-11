# Projet_Final_POA
par Ken Moussat et Paul Puech

Notre programme converti des fichiers CSV en SVG. Le but étant de de convertir des valeurs en modèle svg web pour réaliser des dessins.

Lors du lancement du programme, nous savons déjà quels fichiers sont à convertir et ces derniers sont stockés dans 
le répertoire /bin/debug/ de notre projet. 
Le programme crée une instance "dessins" qui possède des méthodes pour lire un fichier csv, et pour écrire un fichier SVG. 
Pour ce faire, nous utilisons les classes StreamReader et StreamWriter qui créent des flux pour manipuler des fichiers.

Dans un premier temps, le programme crée un dessin.
Le dessin va ensuite lire le fichier choisi et traduire chaque ligne en une forme géométrique et les enregistrer dans une liste.
La liste est ensuite triée avec sa méthode ".Sort" pour que les dessins soit enregistrsés dans l'ordre pour le StreamWriter.
Un fichier .svg est ensuite créé et chaque element de la liste prédcédemment créée est retranscrit.

Projet_Final_C#
