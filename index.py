from flask import Flask, render_template, request, redirect, url_for
from News import news
from Book import books

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