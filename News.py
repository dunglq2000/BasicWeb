class News():
    def __init__(self, title, date):
        self.title = title
        self.date = date

data = [
    {
        "title": "Библиотека открыто",
        "date": "10/11/2020",
    },
    {
        "title": 'Купить новые книги', 
        "date": '11/11/2020'
    },
    {
        "title": 'Фестивал ноября', 
        "date": '12/11/2020'
    },
    {
        "title": 'Фестивал декабря',
        "date": '12/12/2020'
    }
]
news = [News(d["title"], d["date"]) for d in data]