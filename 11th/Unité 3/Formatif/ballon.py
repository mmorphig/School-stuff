import turtle

t = turtle.Turtle()
sc = turtle.Screen()

sc.addshape("ballon.png")

def demicercle(couleur, rayon, angle):
    t.color(couleur)
    t.circle(-rayon, angle)

# Configuration de la fenêtre
sc.setup(width=600, height=600)
sc.bgcolor("white")

# Préparation de la tortue
t.shape("ballon.png")
t.speed(10)
t.up()
t.goto(-200, 100)
t.left(90)

# Boucle pour dessiner les demi-cercles
while True:
    demicercle('black', 40, 180)
    t.right(180)
    if t.xcor() > 300:
      # augmente la vitesse du ballon, pour qu'il vas plis vite
      t.speed(20)
      t.goto(-200, 100)
      t.speed(10)
