from flask import Flask, render_template, request, redirect, url_for
from News import news
from Book import books
from User import users

app = Flask(__name__)

@app.route('/', methods=['GET', 'POST'])
def hello():
    if request.method == 'POST':
        book_name = request.form["book"]
        my_books = []
        for book in list(books):
            if book.name == book_name:
                my_books.append(book)
        return render_template('book.html', books=my_books)
    if request.method == 'GET':
        return render_template('index.html', news=news)

@app.route('/activities')
def activity():
    return render_template('activities.html', news=news)

@app.route('/intro')
def introduction():
    return render_template('intro.html')

@app.route('/rules')
def rules():
    return render_template('rules.html')

@app.route('/login', methods=['GET', 'POST'])
def login():
    if request.method == 'GET':
        return render_template('login_page.html')
    if request.method == 'POST':
        username = request.form.get("username")
        password = request.form.get("password")
        for user in users:
            if user.username == username and user.password == password:
                return render_template('profile.html', user=user, book=[])
        return render_template('login_page.html')

@app.route('/register', methods=['GET', 'POST'])
def register():
    if request.method == 'GET':
        return render_template('register.html')
    if request.method == 'POST':
        return "Wrong"