import turtle
import random
import math

# Initialiser la fenêtre
sc = turtle.Screen()
sc.setup(width=100, height=100)
sc.bgcolor("black")

# Initialiser la tortue
t = turtle.Turtle()
t.speed(0)
t.up()
t.hideturtle()

# Générer des positions aléatoires uniques
positions = []
for _ in range(1000): # Plus que 40, mais peut être facilement changer, avec seulement 40, les polygones génèrent en piles sur ces 40
    x = random.randint(-480, 450)
    y = random.randint(-480, 450)
    positions.append([x, y])

def dessiner():  # w et e sont ignorés, utilisés pour le clic
    # Générer des valeurs aléatoires
    cote = random.randint(20, 80)
    cote2 = random.randint(20, 80) # Deuxiѐme coté, pour les rectangles
    angle = random.randint(0, 359)
    

    # Choisir une position unique
    pos = random.sample(positions, 1)[0]
    sc.tracer(0,0)
    for y in range(-50, 50):
        t.up()
        t.goto(-50,y)
        for x in range(-50,50):
            r, g, b = random.randint(0, 255)/255, random.randint(0, 255)/255, random.randint(0, 255)/255
            couleur = [r, g, b]
            t.color(couleur)
            t.down()
            t.goto(x,y)
            
    sc.update()
    
for i in range(100000):
  dessiner()

# Associer le clic à la fonction dessiner
sc.onclick(dessiner())

turtle.done()

