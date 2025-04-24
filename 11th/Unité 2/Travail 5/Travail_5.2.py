def myisalpha(lettre):
    # Vérifie si la lettre est alphabétique et non vide
    return len(lettre) == 1 and lettre.isalpha()

def mots_contenant_lettre(liste_mots, lettre):
    # Affiche les mots contenant la lettre recherchée
    if not myisalpha(lettre):  # Vérification de l'entrée
        print("Veuillez entrer une lettre alphabétique valide.")
        return []

    lettre = lettre.lower()  # Normaliser en minuscule
    mots_trouves = [mot for mot in liste_mots if lettre in mot.lower()]

    return mots_trouves

# Liste fournie
liste_mots = ["Super", "Certain", "Dernier", "Sombre", "Couleur", "Double"]

# Boucle principale
while True:
    lettre_recherchee = input("Donner la lettre à rechercher dans la liste donnée : ").strip()
    
    mots = mots_contenant_lettre(liste_mots, lettre_recherchee)
    
    for mot in mots:
        print(f"Le mot {mot} contient {lettre_recherchee}")

    reponse = input("\nVoulez-vous recommencer o/O ? ").strip().lower()
    
    if reponse != "o" or reponse != "O":
        break
