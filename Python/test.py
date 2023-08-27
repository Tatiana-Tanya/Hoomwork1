x = float(input("Введите кг"))
y = float(input('Введите см'))
z = x/(y*y)
if z < 18.5:
 print('Underweight')
elif z >= 18.5 and z < 25:
     print('Normal')
elif z >=25 and z < 30:
        print('Overweight')
else:
        z = 30 and z > 30
        print('Obesity')
