class User():
    def __init__(self, username, password, firstname, lastname):
        self.username = username
        self.password = password
        self.firstname = firstname
        self.lastname = lastname

data = [
    {
        "username": "dunglequoc",
        "password": "123",
        "firstname": "Куок Зунг",
        "lastname": "Ле"
    },
    {
        "username": "alexander",
        "password": "321",
        "firstname": "Александр",
        "lastname": "Ивановна"
    }
]

users = [User(d["username"], d["password"], d["firstname"], d["lastname"]) for d in data]