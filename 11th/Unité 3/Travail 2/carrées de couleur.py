import turtle

sc = turtle.Screen()
sc.setup(width=640, height=480)
sc.bgcolor("white")

def carre(taille, couleur, position):
    x, y = position
    t.goto(x, y)
    t.color(couleur)
    t.begin_fill()
    
    t.goto(x + taille, y)
    t.goto(x + taille, y + taille)
    t.goto(x, y + taille)
    t.goto(x, y)
    
    t.end_fill()

# Initialisation de la tortue
t = turtle.Turtle()
t.speed(0)
t.up()
t.hideturtle()

# Paramètres
taille = 80
couleurs = ['yellow', 'green']

# Dessin des carreaux
for ligne in range(2):
    for col in range(3):
        x = col * taille - taille * 1.5
        y = -ligne * taille
        couleur = couleurs[(col + ligne) % 2]  # Alterner les couleurs
        carre(taille, couleur, (x, y))

# Affichage
turtle.done()
