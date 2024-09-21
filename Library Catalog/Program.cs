using Library_Catalog;

Book[] LibraryCatalog =
[
    new FictionBook("The Great Gatsby", "F. Scott Fitzgerald", 180, "Classic"),
    new FictionBook("Dune", "Frank Herbert", 412, "Science Fiction"),
    new NonFictionBook("Sapiens", "Yuval Noah Harari", 512, "History"),
    new NonFictionBook("Atomic Habits", "James Clear", 320, "Self-Help"),
    new ArtBook("Art book", "any", 120, "vintage")
];

Library.DisplayBooks(LibraryCatalog);

