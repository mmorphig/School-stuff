def myisalpha(chaine):
    # Vérifie si la chaîne contient uniquement des lettres (sans utiliser isalpha()). 
    alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
    
    # Vérifier si la chaîne est vide ou contient uniquement des espaces
    if chaine.strip() == "":
        return False  

    # Vérifier chaque caractère
    for char in chaine:
        if char not in alphabet:  
            return False  

    return True  

def cherche(lettre, mot):
    """ Renvoie une liste des positions de la lettre dans le mot. """
    positions = [i for i, char in enumerate(mot) if char == lettre]
    return positions

# Demande de la chaîne
mot = input("Entrez une chaîne de caractères : ")

while not myisalpha(mot):
    print("Erreur : La chaîne doit contenir uniquement des lettres (sans espaces).")
    mot = input("Entrez une chaîne de caractères valide : ")

# Recherche des lettres
reponse = "o"
while reponse.lower() == "o" or reponse.lower() == "y":
    lettre = input("Tapez la lettre recherchée : ")

    if len(lettre) != 1 or not lettre.isalpha():
        print("Veuillez entrer une seule lettre.")
        continue

    positions = cherche(lettre, mot)
    if positions:
        print(f"La lettre '{lettre}' se trouve aux positions :", *positions)
    else:
        print(f"La lettre '{lettre}' ne se trouve pas dans le mot.")

    reponse = input("Voulez-vous chercher une autre lettre ? (o/n) : ").lower()
