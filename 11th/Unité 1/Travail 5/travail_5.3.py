import random

def est_nombre_positif(n):
    # Vérifie si l'entrée est un nombre entier positif.
    return n.isdigit() and int(n) >= 0

# Boucle principale du jeu
encore = 'o'
while encore.lower() == 'o' or encore.lower() == 'y':  # Tant que le joueur veut jouer, accepte y aussi
    n = input("Entrez un nombre positif : ")
    
    # Vérification de l'entrée
    while not est_nombre_positif(n):
        n = input("Entrée invalide. Entrez un nombre entier positif : ")

    n = int(n)  # Conversion en entier
    x = random.randint(0, n)  # Sélection du nombre aléatoire
    
    print("Un nombre a été choisi entre 0 et", n)
    
    while True:
        print("Le jeu commence !") 
        devine = input("Devinez le nombre : ")

        # Vérification de l'entrée
        while not est_nombre_positif(devine):
            devine = input("Entrée invalide. Entrez un nombre entier positif : ")

        devine = int(devine)  # Conversion en entier

        if devine < x:
            print("Trop petit")
        elif devine > x:
            print("Trop grand")
        else:
            print("Vous l’avez bien deviné !")
            break  # Sort de la boucle de devinette
    
    encore = input("Voulez-vous rejouer ? (o/n) : ")
    
print("Merci d'avoir joué !")
