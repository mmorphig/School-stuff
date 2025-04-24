def compter_maj_min(chaine):
    # Compte le nombre de lettres majuscules et minuscules dans une chaîne.
    nb_majuscules = sum(1 for c in chaine if c.isupper())
    nb_minuscules = sum(1 for c in chaine if c.islower())
    
    print(f"Le nombre de lettres majuscules dans '{chaine}' est {nb_majuscules}")
    print(f"Le nombre de lettres minuscules dans '{chaine}' est {nb_minuscules}")

# Demander un mot ou une phrase à l'utilisateur
mot = input("Entrez un mot contenant des lettres majuscules et minuscules : ")
compter_maj_min(mot)
