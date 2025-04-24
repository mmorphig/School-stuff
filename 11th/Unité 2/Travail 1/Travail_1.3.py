def myisalpha(chaine):
    # Vérifie si la chaîne contient uniquement des lettres (sans utiliser isalpha())
    alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
    
    # Vérifier si la chaîne est vide ou contient uniquement des espaces
    if chaine.strip() == "":
        return False  

    # Vérifier chaque caractère
    for char in chaine:
        if char not in alphabet:  
            return False  

    return True  

def inverser_chaine(chaine):
    inverse = ""
    for char in chaine:
        inverse = char + inverse  # Ajouter chaque lettre au début
    return inverse

# Demander un mot
mot = input("Entrez un mot à inverser : ")

while not myisalpha(mot):
    print("Erreur : La chaîne doit contenir uniquement des lettres (sans espaces).")
    mot = input("Entrez une chaîne de caractères valide : ")

# Inverser le mot
mot_inverse = inverser_chaine(mot)
print(f"L'inverse de '{mot}' est '{mot_inverse}'.")
