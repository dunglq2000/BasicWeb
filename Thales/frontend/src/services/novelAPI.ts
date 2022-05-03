export interface Novel {
    novelId: number,
    title: string
    authorId: number
}

export interface Author {
    authorId: number,
    firstMidName: string,
    lastName: string,
    novels: Novel[]
}

export const getNovels = async () : Promise<Novel[]> => {
    return await fetch('/api/novels')
    .then(val => val.json()) as Novel[];
}

export const postNovel = async (title: string, authorId: number) : Promise<Novel> => {
    var form = new FormData();
    form.append('title', title);
    form.append('authorId', authorId.toString());
    return await fetch('/api/novels', {
        method: 'POST',
        body: form
    }).then(val => val.json()) as Novel;
}

export const getAuthors = async () : Promise<Author[]> => {
    return await fetch('/api/authors')
    .then(val => val.json()) as Author[];
}

export const getAuthor = async (authorId: number) : Promise<Author> => {
    return await fetch('/api/authors/' + authorId)
    .then(val => val.json()) as Author;
}