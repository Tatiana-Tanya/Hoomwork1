class House():
   
   def __init__(self,name,surname,street,number):
      
    self.name = name
    self.surname = surname 
    self.street = street
    self.number = number
                     
   def peoplehouse(self):
        print("Имя" + str(self.name) + "Фамилия" + str(self.surname) + "Живет на улице" + str(self.street) + "Номер" + str(self.number))


House1 = House("Иван","Иванов","Московская", 20) 
House2 = House("Ирина","Иванова","Серебряная", 30)

# class PeopleHouse(House):
#    # люди в доме
#    def __init__(self,people,number):
#       super().__init__(self,number)
#       self.people = people
# childHouse = PeopleHouse("Иванов Иван Иванович", 1)
# House1.age_of_house(10)
# print(childHouse.people)
House1.peoplehouse()