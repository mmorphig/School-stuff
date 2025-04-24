import turtle
import random
import time

# Initialiser la fenêtre
sc = turtle.Screen()
sc.setup(width=1000, height=600)
sc.bgcolor("white")
sc.tracer(2)

# Charger les images de la balle
images = []
for i in range(1, 7):
    sc.addshape("b" + str(i) + ".png")
    images.append("b" + str(i) + ".png")

# Définition des listes et variables
carres_points = [-450, -200]
taille = 60
positions = []
couleurs = []
score = 0

# Déclaration des tortues
crayon = turtle.Turtle()
crayon.hideturtle()
crayon.penup()

carre_turtle = turtle.Turtle()
carre_turtle.hideturtle()

circle = turtle.Turtle()
circle.penup()
circle.shape(images[0])
circle.goto(0, 100)

def dessiner_carres():
    carre_turtle.penup()
    carre_turtle.speed(0)  # Vitesse maximale
    carre_turtle.hideturtle()

    for i in range(10):
        pos = [carres_points[0] + i * (taille + 20), carres_points[1]]
        positions.append(pos)

        # Choix rapide de la couleur sans random.choices()
        couleur = "green" if random.random() < 0.5 else "red"
        couleurs.append(couleur)

        carre_rapide(taille, couleur, pos)

# Si on ne dessine pas les bordures avec le pen, c'est beacoups plus vite
def carre_rapide(taille, couleur, position):
    x, y = position
    carre_turtle.goto(x, y)
    carre_turtle.color(couleur)
    carre_turtle.begin_fill()

    # Dessin rapide du carré
    carre_turtle.goto(x + taille, y)
    carre_turtle.goto(x + taille, y + taille)
    carre_turtle.goto(x, y + taille)
    carre_turtle.goto(x, y)

    carre_turtle.end_fill()

# Pour Afficher le score
def afficher_score():
    crayon.clear()
    crayon.goto(-450, 250)
    crayon.color("green" if score >= 0 else "red")
    crayon.write("Score: " + str(score), font=("Arial", 16, "bold"))

afficher_score() # Fait ceci maintenant pour prévenir un gros délai quand le premier cible est touché
dessiner_carres()

# Demander le nombre de parties
parties = int(input("Jeu", "Nombre de parties :"))

for _ in range(parties):
    carre_touche = random.randint(0, 9)
    cible = positions[carre_touche]
    x_cible, y_cible = cible[0] + taille / 2, cible[1] + taille / 2
    circle.goto(0, 100)
    k = 0

    # Calculer la direction avec une distance fixe
    dx = x_cible - circle.xcor()
    dy = y_cible - circle.ycor()
    distance = (dx**2 + dy**2) ** 0.5 # Theorem de pythagore pour droiver la distance
    grandeur_pas = 25
    pas = int(distance / grandeur_pas)

    # Déplacer la balle en direction de la cible
    for i in range(pas):
        circle.shape(images[k])  # Changer l'image de la balle
        # Deuxième loop pour faire que la balle bouge sans changer d'image très vite
        for j in range(10):
          circle.goto(
              circle.xcor() + (dx / pas)/10,
              circle.ycor() + (dy / pas)/10
          )
          k = (k + 1) % 6
          turtle.update()  # Mettre à jour l'affichage immédiatement
          time.sleep(0.01)  # Petit délai pour lisser l'animation

    # Ajuster la position finale si elle est légèrement décalée
    circle.goto(x_cible, y_cible)

    # Mise à jour du score
    if couleurs[carre_touche] == "green":
        score += 1
    else:
        score -= 1
    afficher_score()

turtle.done()
