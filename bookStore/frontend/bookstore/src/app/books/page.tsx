'use client'; 
import Button from "antd/es/button/button";
import { useEffect, useState } from "react";
import { Books } from "../components/Books";
import { getAllBooks } from "../services/books";
import Title from "antd/es/typography/Title";

export default function BooksPage()
{
    const [books, setBooks] = useState<Book[]>([]);
    const [loading, setLoading] = useState(true);

    useEffect(() => {
        const getBooks = async () => {
            const books = await getAllBooks();
            setLoading(false);
            setBooks(books);
        }
    })
    return (
        <div>
            <Button>Добавить книгу</Button>
            {loading ? <Title>Загружаемь...</Title> : <Books books={books}></Books>}
        </div>
    )
}