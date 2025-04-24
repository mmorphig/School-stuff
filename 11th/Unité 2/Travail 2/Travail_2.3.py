# Définition de la liste des ponctuations
ponctuation = [',', '.', '!', '?', ':', ';', ' ']

# Demande à l'utilisateur une phrase
phrase = input("Entrez une phrase : ")

# Extraction du premier mot
premier_mot = ""
for lettre in phrase:
    if lettre in ponctuation:
        break
    premier_mot += lettre

# Affichage du premier mot
print("\nLe premier mot est :", premier_mot)
