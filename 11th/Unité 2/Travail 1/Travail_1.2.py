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

def compter_voyelles(chaine):
    voyelles = set("aeiouyéèêëôöîïàâùûüAEIOUYÉÈÊËÔÖÎÏÀÂÙÛÜ")
    return sum(1 for char in chaine if char in voyelles)

# Demander une chaîne valide
mot = input("Entrez une chaîne de caractères : ")

while not myisalpha(mot):
    print("Erreur : La chaîne doit contenir uniquement des lettres (sans espaces).")
    mot = input("Entrez une chaîne de caractères valide : ")

# Compter les voyelles
nombre_voyelles = compter_voyelles(mot)
print(f"La chaîne '{mot}' possède {nombre_voyelles} voyelles.")
