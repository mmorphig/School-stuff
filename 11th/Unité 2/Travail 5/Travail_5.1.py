valide = 0  # Variable globale pour suivre la validation

def myisalpha(lettre):
    # Vérifie si le caractère est une lettre alphabétique
    return lettre in "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"

def recherche(texte, lettre):
    # Trouve les positions de la lettre (minuscule ou majuscule) dans un texte donné
    global valide  # Permet de modifier la variable globale valide
    
    if not myisalpha(lettre):  # Vérifie si c'est bien une lettre
        valide = 0
        return "Veuillez entrer une lettre alphabétique valide."

    lettre = lettre.lower()  # Normaliser en minuscule
    texte = texte.lower()  # Normaliser en minuscule
    positions = [i for i, char in enumerate(texte) if char == lettre]  # Liste des positions

    valide = 1
    return positions if positions else "La lettre n'est pas dans le texte."

# Textes fournis
texte1 = "Maigret avait alerté les patrouilles cyclistes, ainsi que la police municipale. Dans les cinémas s'enfoncent les passagers. Ils ne s’apercevaient de rien. Sur tous les imperméables beiges s'arrêtèrent des centaines de yeux."
texte2 = "Il me sembla que la conversation sous le figuier marchait bon train. J’ouvris tout doucement la fenêtre, et j’écoutais : mais ils parlaient à voix basse, et je ne pus saisir au passage que des lambeaux de phrase."

# Boucle pour demander une lettre valide
while valide != 1:
    lettre_recherchee = input("Entrez une lettre à rechercher : ").strip()
    resultat1 = recherche(texte1, lettre_recherchee)
    resultat2 = recherche(texte2, lettre_recherchee)
    
    print("\nPositions dans texte1 :", resultat1)
    print("Positions dans texte2 :", resultat2)
