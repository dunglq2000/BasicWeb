class News():
    def __init__(self, title, date):
        self.title = title
        self.date = date

data = [
    {
        "title": "Welcome to my library",
        "date": "12/11/2020",
    },
    {
        "title": "Welcome to my library again",
        "date": "13/11/2020"
    },
    {
        "title": "Welcome to my library again again",
        "date": "14/11/2020"
    },
    {
        "title": "Welcome to my library again again again",
        "date": "15/11/2020"
    },
    {
        "title": 'Hello World', 
        "date": '10/11/2020'
    },
    {
        "title": 'Фестивал ноября', 
        "date": '11/11/2020'
    },
    {
        "title": 'Фестивал декабря',
        "date": '12/11/2020'
    }
]
news = [News(d["title"], d["date"]) for d in data]