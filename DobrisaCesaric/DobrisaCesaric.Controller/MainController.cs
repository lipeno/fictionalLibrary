using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DobrisaCesaric.DomainModel.Factories;
using DobrisaCesaric.DomainModel.Repositories;
using DobrisaCesaric.DomainModel;
using DobrisaCesaric.Utility;

namespace DobrisaCesaric.Controller
{
    public class MainController
    {
        public void addNewBook(IAddBook inForm)
        {
            if (inForm.ShowForm() == true)
            {
                string book = inForm.getBookName();
                string author = inForm.getAuthorName();
                string isbn = inForm.getIsbn();

                Book newBook = BookFactory.CreateBook(isbn, book, author);

                BookRepository.GetInstance().AddBook(newBook);
            }
        }
        public void viewBooks(IViewBooks inForm)
        {
            inForm.ShowForm();
        }

        public void addNewAuthor(IAddAuthor inForm)
        {
            if (inForm.ShowForm() == true)
            {
                string authorName = inForm.getAuthorName();
                string desc = inForm.getAuthorDescription();
                DateTime dob = inForm.getAuthorDob();


                Author author = new Author(authorName, desc, dob);
                AuthorRepository.GetInstance().AddAuthor(author);
            }
        }

        public void addLender(IAddLender inForm)
        {
            if (inForm.ShowForm() == true)
            {
                string firstName = inForm.getFirstName();
                string lastName = inForm.getLastName();
                DateTime memberSince = inForm.getMemberSince();
                string telephone = inForm.getTelephone();
                string email = inForm.getEmail();

                
                BookLender lender = new BookLender(firstName, lastName, telephone, email);
                UserRepository.GetInstance().Adduser(lender);
            }
        }
        
        public void addNewLibrarian(IAddLibrarian inForm)
        {
            if (inForm.ShowForm() == true)
            {
                string firstName = inForm.getFirstName();
                string lastName = inForm.getLastName();
                DateTime startOfContract = inForm.getStartOfContract();
                string telephone = inForm.getTelephone();
                string email = inForm.getEmail();
                string department = inForm.getDepartment();

                Librarian librarian = new Librarian(firstName,lastName,telephone,email,department,startOfContract);
                UserRepository.GetInstance().Adduser(librarian);
            }
        }

        public void viewLendings(ILend inForm)
        {
            inForm.ShowForm();
        }

        public void lend(ILend inForm)
        {
                int bookIndex = inForm.getBook();
                string lenderName = inForm.getLender();
                DateTime date = DateTime.Now;
                string librarianName = inForm.getLibrarian();

                Book book = BookRepository.GetInstance().GetBookByIndex(bookIndex);
                BookLender lender = UserRepository.GetInstance().GetLenderByFullName(lenderName);
                Librarian librarian = UserRepository.GetInstance().GetLibrarianByFullName(librarianName);

                Lending lending = new Lending(book, lender, librarian, date);
                LendingRepository.GetInstance().AddLending(lending);
        }

        public void returnbook(ILend inForm)
        {
            int lendingIndex = inForm.getLending();
            LendingRepository.GetInstance().RemoveLending(lendingIndex);
        }

        public void viewAuthors(IViewAuthors inForm)
        {
            inForm.ShowForm();
        }

        public void fillDummy()
        {
            BookRepository bookRepo = BookRepository.GetInstance();
            Author author = new Author("Lao Tsu");

            AuthorRepository.GetInstance().AddAuthor(author);

            Book book = BookFactory.CreateBook("2534534534535353", "Tao Te Ching", author.Name);
            BookRepository.GetInstance().AddBook(book);

            Author author2 = new Author("Dan Brown");

            AuthorRepository.GetInstance().AddAuthor(author2);

            Book book2 = BookFactory.CreateBook("2534534534535353", "Da Vinci Code", author2.Name);
            BookRepository.GetInstance().AddBook(book2);

            BookLender lender = new BookLender("pero", "peric", "0982837849", "peroperic22@gmail.com");
            UserRepository.GetInstance().Adduser(lender);
            BookLender lender2 = new BookLender("ivan", "ivic", "0986543573", "ivic22@gmail.com");
            UserRepository.GetInstance().Adduser(lender2);

            Librarian librarian = new Librarian("velimir", "jozek", "0982837849", "peroperic22@gmail.com", "knjige za djecu", DateTime.Now);
            UserRepository.GetInstance().Adduser(librarian);
            Librarian librarian2 = new Librarian("branka", "vrtomir", "0986543573", "ivic22@gmail.com", "ekonomija", DateTime.Now);
            UserRepository.GetInstance().Adduser(librarian2);
        }
    }
}
