import turtle

t = turtle.Turtle()
sc = turtle.Screen()

def demicercle(couleur, rayon, angle):
    t.color(couleur)
    t.begin_fill()
    t.down()
    t.circle(rayon, angle)
    t.up()
    t.end_fill()

# Configuration de la fenêtre
sc.setup(width=600, height=600)
sc.bgcolor("light blue")

# Préparation de la tortue
t.hideturtle()
t.speed(0)
t.up()
t.goto(-200, 100)
t.right(90)

# Boucle pour dessiner les demi-cercles
for i in range(5):
    demicercle('red', 40, 180)
    t.goto(t.xcor() - 80, t.ycor())
    demicercle('yellow', -40, 180)
