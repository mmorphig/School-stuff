def chercheSymbole(liste, symbole):
    # Remplace chaque élément de la liste en supprimant le symbole donné
    return [mot.replace(symbole, "") for mot in liste]

# Liste fournie
liste_mots = ["#Super", "Certain#", "Der#nier", "Somb#re", "Couleur", "Do#uble"]
symbole = "#"

# Application de la fonction
liste_modifiee = chercheSymbole(liste_mots, symbole)
print("Liste modifiée :", liste_modifiee)
