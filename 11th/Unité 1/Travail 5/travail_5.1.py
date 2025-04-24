import random

def rouler_de():
    return random.randint(1, 6)

def jouer():
    faces_6 = 0
    tours_6 = []
    
    for tour in range(1, 11):  # 10 tours
        resultat = rouler_de()
        print(f"Tour {tour}, résultat : {resultat}")
        
        if resultat == 6:
            faces_6 += 1
            tours_6.append(tour)
        
        if resultat == 1:
            print(f"Tu as été éliminé car tu as eu la face 1 au tour {tour}, au revoir !")
            return
        
    if faces_6 >= 4:
        print(f"Tu as eu une face 6 aux tours : {', '.join(map(str, tours_6))}")
        print("Félicitations, tu as gagné !")
    else:
        print(f"Tu as eu une face 6 aux tours : {', '.join(map(str, tours_6))}")
        print("Tu n'as pas réussi à avoir 4 fois la face 6.")

jouer()
