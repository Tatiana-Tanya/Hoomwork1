# class House():
   
#    def __init__(self,name,surname,street,number):
      
#     self.name = name
#     self.surname = surname 
#     self.street = street
#     self.number = number
                     
#    def peoplehouse(self):
#         print("Имя" + str(self.name) + "Фамилия" + str(self.surname) + "Живет на улице" + str(self.street) + "Номер" + str(self.number))


# House1 = House("Иван","Иванов","Московская", 20) 
# House2 = House("Ирина","Иванова","Серебряная", 30)

# class PeopleHouse(House):
#    # люди в доме
#    def __init__(self,people,number):
#       super().__init__(self,number)
#       self.people = people
# childHouse = PeopleHouse("Иванов Иван Иванович", 1)
# House1.age_of_house(10)
# print(childHouse.people)
# House1.peoplehouse()
class Address:
    def __init__(self,
                 area: str,
                 city: str,
                 street: str,
                 number: int,
                 kvartira: int):
        self.area = area
        self.city = city
        self.street = street
        self.number = number
        self.kvartira = kvartira
        self.allAddr = f"кр./обл.: {self.area}, г.: {self.city}, ул.: {self.street}, строение: {self.number}, кв.:{self.kvartira}"

    def __str__(self):
        return self.allAddr

    def __repr__(self):
        return self.allAddr


class People:
    def __init__(self,
                 familia: str,
                 name: str,
                 otchestvo: str,
                 birthDate: str):
        self.familia = familia
        self.name = name
        self.otchestvo = otchestvo
        self.birthDate = birthDate
        self.allName = f"{self.familia} {self.name} {self.otchestvo} {self.birthDate} г.р."

    def __str__(self):
        return self.allName

    def __repr__(self):
        return self.allName


class House:
    def __init__(self, address: Address, peoples: list = []):
        self.address = address
        self.peoples = peoples
        for (count, people) in enumerate(peoples, start=1):
            self.__set_propiska_to_people(people=people, kvartira=count)
        self.lastKvartira = count

    def add_people_to_house(self, people: People):
        self.lastKvartira += 1
        self.peoples.append(people)
        self.__set_propiska_to_people(people, self.lastKvartira)

    def __set_propiska_to_people(self, people: People, kvartira: int):
        tmpAddr: Address = self.address
        tmpAddr.kvartira = kvartira
        people.addressPropiski = tmpAddr

    def showPeoples(self):
        print(f"в доме {self.address} проживают:")
        for people in self.peoples:
            print(people)

    def __str__(self):
        return f"Дом по адресу {self.address}"

    def __repr__(self):
        return f"Дом по адресу {self.address}"


addr1 = Address("Московская", "Москва", "Ленина", "12", None)

people1 = People("Иванов", "Иван", "Иваныч", "09.05.1945")

house1 = House(addr1, [people1])

house1.add_people_to_house(People("Петров", "Петр", "Петрович", "10.05.1945"))

print(addr1)
print(people1)
print(house1)
house1.showPeoples()