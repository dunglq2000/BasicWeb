class Book():
    def __init__(self, name, author, category, free=0):
        self.name = name
        self.author = author
        self.category = category
        self.free = free

data = [
    {
        "name": 'Linear Algebra',
        "author": 'Кто-то',
        "category": 'Что-то',
        "free": 3
    },
    {
        "name": "Linear Algebra",
        "author": "Ле Куок Зунг",
        "category": "Математика",
        "free": 4
    }
]

books = [Book(d["name"], d["author"], d["category"], d["free"]) for d in data]